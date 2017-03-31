using System.Collections.Generic;
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
        /// Search for a list of providers
        /// </summary>
        /// <param name="criteria">search criteria</param>
        /// <param name="queryId">query identifier (default : 2)</param>
        /// <param name="batchSize">the number of providers to appear in each request</param>
        /// <returns>Collection of providers</returns>
        IEnumerable<Provider> ProviderQuery(SelectionCriteriaStructure criteria, string queryId = "2", int batchSize = 35);
    }
}