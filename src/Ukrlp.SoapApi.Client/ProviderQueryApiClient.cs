using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Ukrlp.SoapApi.Client.Exceptions;
using Ukrlp.SoapApi.Client.ProviderQueryServiceV4;
using Ukrlp.SoapApi.Types;

namespace Ukrlp.SoapApi.Client
{
    /// <summary>
    /// Query UKRLP for provider information
    /// </summary>
    public class ProviderQueryApiClient : IProviderQueryApiClient
    {
        private readonly string _serviceEndpointUri;
        private static readonly Regex UkprnPattern = new Regex(@"^\d{8}");
        private const string  BadUkprnMessage = "the ukprn wasn't 8 digits long";

        /// <summary>
        /// UKRLP SOAP API client
        /// </summary>
        /// <param name="serviceEndpointUri">url to the UKRLP service</param>
        public ProviderQueryApiClient(string serviceEndpointUri)
        {
            _serviceEndpointUri = serviceEndpointUri;
        }

        /// <summary>
        /// Search for a list of providers
        /// </summary>
        /// <param name="criteria">search criteria</param>
        /// <param name="queryId">query identifier (default : 2)</param>
        /// <param name="batchSize">the number of providers to appear in each request</param>
        /// <returns>Collection of providers</returns>
        /// <exception cref="ProviderQueryException">an exception querying the UKRLP service</exception>
        public ProviderResponse ProviderQuery(SelectionCriteriaStructure criteria, string queryId = "2", int batchSize = 35)
        {
            var invalid = criteria.UnitedKingdomProviderReferenceNumberList.Where(x => !UkprnPattern.IsMatch(x)).ToList();
            criteria.UnitedKingdomProviderReferenceNumberList = criteria.UnitedKingdomProviderReferenceNumberList.Except(invalid).ToArray();

            return new ProviderResponse
            {
                Providers = GetProviderQueryResponse(criteria, queryId, batchSize),
                Warnings = invalid.ToDictionary(ukprn => ukprn, ukprn => BadUkprnMessage)
            };
        }

        private IEnumerable<Provider> GetProviderQueryResponse(SelectionCriteriaStructure criteria, string queryId, int batchSize)
        {
            var noOfUkprnsProcessed = 0;

            var providerUkprns = criteria.UnitedKingdomProviderReferenceNumberList.ToList();
            var ukprnsListSize = providerUkprns.Count;

            do
            {
                var numberOfUkprnsUnprocessed = ukprnsListSize - noOfUkprnsProcessed;
                var numberOfUkprnsToSend = numberOfUkprnsUnprocessed > batchSize
                    ? batchSize
                    : numberOfUkprnsUnprocessed;

                criteria.UnitedKingdomProviderReferenceNumberList = providerUkprns.Skip(noOfUkprnsProcessed).Take(numberOfUkprnsToSend).ToArray();

                var providerQueryStructure = new ProviderQueryStructure
                {
                    QueryId = queryId,
                    SchemaVersion = "?",
                    SelectionCriteria = criteria
                };

                using (var client = new ProviderQueryPortTypeClient("ProviderQueryPort", _serviceEndpointUri))
                {
                    ProviderQueryResponse response = null;
                    try
                    {
                        response = client.retrieveAllProviders(providerQueryStructure);
                    }
                    catch (Exception ex)
                    {
                        throw new ProviderQueryException(ex.Message, criteria, ex);
                    }

                    foreach (var provider in response?.MatchingProviderRecords?.Select(MapFromUkrlpProviderRecord) ?? new List<Provider>())
                    {
                        yield return provider;
                    }
                }

                noOfUkprnsProcessed += numberOfUkprnsToSend;
            } while (noOfUkprnsProcessed < ukprnsListSize);
        }

        private Provider MapFromUkrlpProviderRecord(ProviderRecordStructure record)
        {
            var aliases = record.ProviderAliases?.Where(pa => !string.IsNullOrEmpty(pa.ProviderAlias)).Select(pa => pa.ProviderAlias).ToList() ?? new List<string>();

            var provider = new Provider
            {
                UnitedKingdomProviderReferenceNumber = record.UnitedKingdomProviderReferenceNumber,
                ProviderName = record.ProviderName,
                ProviderAliases = aliases.Any() ? aliases : null,
                ProviderContact = record.ProviderContact?.Select(MapFromContact)
            };

            return provider;
        }

        private Contact MapFromContact(ProviderContactStructure contact)
        {
            return new Contact
            {
                ContactType = contact?.ContactType,
                Address = MapFromContactAddress(contact?.ContactAddress),
                ContactEmail = contact?.ContactEmail,
                ContactWebsiteAddress = contact?.ContactWebsiteAddress,
                ContactTelephone1 = contact?.ContactTelephone1
            };
        }

        private Address MapFromContactAddress(BSaddressStructure contactAddress)
        {
            return new Address
            {
                PostCode = contactAddress?.PostCode,
                PAON = contactAddress?.PAON?.Description,
                SAON = contactAddress?.SAON?.Description,
                StreetDescription = contactAddress?.StreetDescription,
                PostTown = contactAddress?.PostTown,
                Town = GetItem(contactAddress, ItemsChoiceType.Town),
                AdministrativeArea = GetItem(contactAddress, ItemsChoiceType.AdministrativeArea),
                Locality = contactAddress?.Locality,
                UniquePropertyReferenceNumber = contactAddress?.UniquePropertyReferenceNumber,
                UniqueStreetReferenceNumber = contactAddress?.UniqueStreetReferenceNumber
            };
        }

        private static string GetItem(BSaddressStructure contactAddress, ItemsChoiceType choice)
        {
            if (contactAddress.ItemsElementName != null && contactAddress.ItemsElementName.Any(x => x == choice))
            {
                return contactAddress?.Items[System.Array.IndexOf(contactAddress?.ItemsElementName, choice)];
            }

            return null;
        }
    }
}
