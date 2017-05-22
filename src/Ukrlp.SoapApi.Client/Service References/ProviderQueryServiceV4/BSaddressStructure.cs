namespace Ukrlp.SoapApi.Client.ProviderQueryServiceV4
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.govtalk.gov.uk/people/bs7666")]
    public partial class BSaddressStructure : object, System.ComponentModel.INotifyPropertyChanged {
        
        private AONstructure sAONField;
        
        private AONstructure pAONField;
        
        private string streetDescriptionField;
        
        private string uniqueStreetReferenceNumberField;
        
        private string localityField;
        
        private string[] itemsField;
        
        private ItemsChoiceType[] itemsElementNameField;
        
        private string postTownField;
        
        private string postCodeField;
        
        private string uniquePropertyReferenceNumberField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public AONstructure SAON {
            get {
                return this.sAONField;
            }
            set {
                this.sAONField = value;
                this.RaisePropertyChanged("SAON");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public AONstructure PAON {
            get {
                return this.pAONField;
            }
            set {
                this.pAONField = value;
                this.RaisePropertyChanged("PAON");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string StreetDescription {
            get {
                return this.streetDescriptionField;
            }
            set {
                this.streetDescriptionField = value;
                this.RaisePropertyChanged("StreetDescription");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=3)]
        public string UniqueStreetReferenceNumber {
            get {
                return this.uniqueStreetReferenceNumberField;
            }
            set {
                this.uniqueStreetReferenceNumberField = value;
                this.RaisePropertyChanged("UniqueStreetReferenceNumber");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Locality {
            get {
                return this.localityField;
            }
            set {
                this.localityField = value;
                this.RaisePropertyChanged("Locality");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdministrativeArea", typeof(string), Order=5)]
        [System.Xml.Serialization.XmlElementAttribute("Town", typeof(string), Order=5)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
                this.RaisePropertyChanged("Items");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName", Order=6)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
                this.RaisePropertyChanged("ItemsElementName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string PostTown {
            get {
                return this.postTownField;
            }
            set {
                this.postTownField = value;
                this.RaisePropertyChanged("PostTown");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string PostCode {
            get {
                return this.postCodeField;
            }
            set {
                this.postCodeField = value;
                this.RaisePropertyChanged("PostCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=9)]
        public string UniquePropertyReferenceNumber {
            get {
                return this.uniquePropertyReferenceNumberField;
            }
            set {
                this.uniquePropertyReferenceNumberField = value;
                this.RaisePropertyChanged("UniquePropertyReferenceNumber");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
}