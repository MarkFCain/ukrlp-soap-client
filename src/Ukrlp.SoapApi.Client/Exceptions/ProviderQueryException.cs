using System;
using Ukrlp.SoapApi.Client.ProviderQueryServiceV4;

namespace Ukrlp.SoapApi.Client.Exceptions
{
    public class ProviderQueryException : Exception
    {
        public string Message { get; set; }
        public SelectionCriteriaStructure Query { get; set; }
        public Exception InnerException { get; set; }

        public ProviderQueryException(string message, SelectionCriteriaStructure query, Exception innerException)
        {
            Message = message;
            Query = query;
            InnerException = innerException;
        }
    }
}