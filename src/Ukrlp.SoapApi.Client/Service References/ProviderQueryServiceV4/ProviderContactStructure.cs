namespace Ukrlp.SoapApi.Client.ProviderQueryServiceV4
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ukrlp.co.uk.server.ws.v3")]
    public partial class ProviderContactStructure : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string contactTypeField;
        
        private BSaddressStructure contactAddressField;
        
        private PersonNameStructure contactPersonalDetailsField;
        
        private string contactRoleField;
        
        private string contactTelephone1Field;
        
        private string contactTelephone2Field;
        
        private string contactFaxField;
        
        private string contactWebsiteAddressField;
        
        private string contactEmailField;
        
        private System.DateTime lastUpdatedField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string ContactType {
            get {
                return this.contactTypeField;
            }
            set {
                this.contactTypeField = value;
                this.RaisePropertyChanged("ContactType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public BSaddressStructure ContactAddress {
            get {
                return this.contactAddressField;
            }
            set {
                this.contactAddressField = value;
                this.RaisePropertyChanged("ContactAddress");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public PersonNameStructure ContactPersonalDetails {
            get {
                return this.contactPersonalDetailsField;
            }
            set {
                this.contactPersonalDetailsField = value;
                this.RaisePropertyChanged("ContactPersonalDetails");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string ContactRole {
            get {
                return this.contactRoleField;
            }
            set {
                this.contactRoleField = value;
                this.RaisePropertyChanged("ContactRole");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string ContactTelephone1 {
            get {
                return this.contactTelephone1Field;
            }
            set {
                this.contactTelephone1Field = value;
                this.RaisePropertyChanged("ContactTelephone1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string ContactTelephone2 {
            get {
                return this.contactTelephone2Field;
            }
            set {
                this.contactTelephone2Field = value;
                this.RaisePropertyChanged("ContactTelephone2");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string ContactFax {
            get {
                return this.contactFaxField;
            }
            set {
                this.contactFaxField = value;
                this.RaisePropertyChanged("ContactFax");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string ContactWebsiteAddress {
            get {
                return this.contactWebsiteAddressField;
            }
            set {
                this.contactWebsiteAddressField = value;
                this.RaisePropertyChanged("ContactWebsiteAddress");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string ContactEmail {
            get {
                return this.contactEmailField;
            }
            set {
                this.contactEmailField = value;
                this.RaisePropertyChanged("ContactEmail");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public System.DateTime LastUpdated {
            get {
                return this.lastUpdatedField;
            }
            set {
                this.lastUpdatedField = value;
                this.RaisePropertyChanged("LastUpdated");
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