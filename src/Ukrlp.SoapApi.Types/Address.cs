namespace Ukrlp.SoapApi.Types
{
    public class Address
    {
        public string PostCode { get; set; }
        public string StreetDescription { get; set; }
        public string PostTown { get; set; }
        public string PAON { get; set; }
        public string SAON { get; set; }
        public string Town { get; set; }
        public string AdministrativeArea { get; set; }
        public string Locality { get; set; }
        public string UniquePropertyReferenceNumber { get; set; }
        public string UniqueStreetReferenceNumber { get; set; }
    }
}