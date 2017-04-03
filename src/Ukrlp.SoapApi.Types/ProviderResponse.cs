using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukrlp.SoapApi.Types
{
    public class ProviderResponse
    {
        /// <summary>
        /// Collection of matching providers
        /// </summary>
        public IEnumerable<Provider> Providers { get; set; }
        /// <summary>
        /// dictionary of warnings by UKPRN and the reason
        /// </summary>
        public IDictionary<string, string> Warnings { get; set; }
    }
}
