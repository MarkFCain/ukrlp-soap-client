using System;
using System.Collections.Generic;
using Ukrlp.SoapApi.Client.Exceptions;
using Ukrlp.SoapApi.Client.ProviderQueryServiceV4;
using Ukrlp.SoapApi.Types;

namespace Ukrlp.SoapApi.Client
{
    /// <summary>
    /// Query UKRLP for provider information
    /// </summary>
    public interface IProviderQueryApiClient
    {
        /// <summary>
        /// An action run before each query to allow it to be logged
        /// </summary>
        Action<SelectionCriteriaStructure> PreRequest { get; set; }

        /// <summary>
        /// An action run after a response has been received
        /// </summary>
        Action<SelectionCriteriaStructure, ProviderQueryResponse> PostRequest { get; set; }

        /// <summary>
        /// Search for a list of providers
        /// </summary>
        /// <param name="criteria">search criteria</param>
        /// <param name="queryId">query identifier (default : 2)</param>
        /// <param name="batchSize">the number of providers to appear in each request</param>
        /// <returns>Collection of providers</returns>
        /// <exception cref="ProviderQueryException">an exception querying the UKRLP service</exception>
        ProviderResponse ProviderQuery(SelectionCriteriaStructure criteria, string queryId = "2", int batchSize = 35);
    }
}