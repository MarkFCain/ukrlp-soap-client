namespace Ukrlp.SoapApi.Client.ProviderQueryServiceV4
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ukrlp.co.uk.server.ws.v3")]
    public partial class ProviderRecordStructure : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string unitedKingdomProviderReferenceNumberField;
        
        private string providerNameField;
        
        private string providerStatusField;
        
        private ProviderContactStructure[] providerContactField;
        
        private System.DateTime providerVerificationDateField;
        
        private bool providerVerificationDateFieldSpecified;
        
        private System.DateTime expiryDateField;
        
        private bool expiryDateFieldSpecified;
        
        private AssociationRecordStructure[] providerAssociationsField;
        
        private ProviderAliasesStructure[] providerAliasesField;
        
        private VerificationDetailsStructure[] verificationDetailsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="positiveInteger", Order=0)]
        public string UnitedKingdomProviderReferenceNumber {
            get {
                return this.unitedKingdomProviderReferenceNumberField;
            }
            set {
                this.unitedKingdomProviderReferenceNumberField = value;
                this.RaisePropertyChanged("UnitedKingdomProviderReferenceNumber");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string ProviderName {
            get {
                return this.providerNameField;
            }
            set {
                this.providerNameField = value;
                this.RaisePropertyChanged("ProviderName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string ProviderStatus {
            get {
                return this.providerStatusField;
            }
            set {
                this.providerStatusField = value;
                this.RaisePropertyChanged("ProviderStatus");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProviderContact", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public ProviderContactStructure[] ProviderContact {
            get {
                return this.providerContactField;
            }
            set {
                this.providerContactField = value;
                this.RaisePropertyChanged("ProviderContact");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public System.DateTime ProviderVerificationDate {
            get {
                return this.providerVerificationDateField;
            }
            set {
                this.providerVerificationDateField = value;
                this.RaisePropertyChanged("ProviderVerificationDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProviderVerificationDateSpecified {
            get {
                return this.providerVerificationDateFieldSpecified;
            }
            set {
                this.providerVerificationDateFieldSpecified = value;
                this.RaisePropertyChanged("ProviderVerificationDateSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public System.DateTime ExpiryDate {
            get {
                return this.expiryDateField;
            }
            set {
                this.expiryDateField = value;
                this.RaisePropertyChanged("ExpiryDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExpiryDateSpecified {
            get {
                return this.expiryDateFieldSpecified;
            }
            set {
                this.expiryDateFieldSpecified = value;
                this.RaisePropertyChanged("ExpiryDateSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProviderAssociations", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public AssociationRecordStructure[] ProviderAssociations {
            get {
                return this.providerAssociationsField;
            }
            set {
                this.providerAssociationsField = value;
                this.RaisePropertyChanged("ProviderAssociations");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProviderAliases", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public ProviderAliasesStructure[] ProviderAliases {
            get {
                return this.providerAliasesField;
            }
            set {
                this.providerAliasesField = value;
                this.RaisePropertyChanged("ProviderAliases");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VerificationDetails", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public VerificationDetailsStructure[] VerificationDetails {
            get {
                return this.verificationDetailsField;
            }
            set {
                this.verificationDetailsField = value;
                this.RaisePropertyChanged("VerificationDetails");
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