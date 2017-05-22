namespace Ukrlp.SoapApi.Client.ProviderQueryServiceV4
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.govtalk.gov.uk/people/PersonDescriptives")]
    public partial class PersonNameStructure : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string[] personNameTitleField;
        
        private string[] personGivenNameField;
        
        private string personFamilyNameField;
        
        private string[] personNameSuffixField;
        
        private string personRequestedNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonNameTitle", Order=0)]
        public string[] PersonNameTitle {
            get {
                return this.personNameTitleField;
            }
            set {
                this.personNameTitleField = value;
                this.RaisePropertyChanged("PersonNameTitle");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonGivenName", Order=1)]
        public string[] PersonGivenName {
            get {
                return this.personGivenNameField;
            }
            set {
                this.personGivenNameField = value;
                this.RaisePropertyChanged("PersonGivenName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string PersonFamilyName {
            get {
                return this.personFamilyNameField;
            }
            set {
                this.personFamilyNameField = value;
                this.RaisePropertyChanged("PersonFamilyName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonNameSuffix", Order=3)]
        public string[] PersonNameSuffix {
            get {
                return this.personNameSuffixField;
            }
            set {
                this.personNameSuffixField = value;
                this.RaisePropertyChanged("PersonNameSuffix");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string PersonRequestedName {
            get {
                return this.personRequestedNameField;
            }
            set {
                this.personRequestedNameField = value;
                this.RaisePropertyChanged("PersonRequestedName");
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