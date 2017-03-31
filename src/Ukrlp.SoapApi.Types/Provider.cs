using System.Collections.Generic;

namespace Ukrlp.SoapApi.Types
{
    public class Provider
    {
        /// <summary>
        /// Provider ID : 8 characters long
        /// </summary>
        public string UnitedKingdomProviderReferenceNumber { get; set; }
        public string ProviderName { get; set; }
        public IEnumerable<Contact> ProviderContact { get; set; }
        public IEnumerable<string> ProviderAliases { get; set; }
    }
}