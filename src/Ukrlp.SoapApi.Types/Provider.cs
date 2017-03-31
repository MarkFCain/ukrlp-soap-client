using System.Collections.Generic;

namespace Ukrlp.SoapApi.Types
{
    public class Provider
    {
        public string UnitedKingdomProviderReferenceNumber { get; set; }
        public string ProviderName { get; set; }
        public IEnumerable<Contact> ProviderContact { get; set; }
        public IEnumerable<string> ProviderAliases { get; set; }
    }
}