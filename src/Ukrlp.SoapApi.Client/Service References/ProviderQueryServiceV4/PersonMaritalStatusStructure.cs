namespace Ukrlp.SoapApi.Client.ProviderQueryServiceV4
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.govtalk.gov.uk/people/PersonDescriptives")]
    public partial class PersonMaritalStatusStructure : object, System.ComponentModel.INotifyPropertyChanged {
        
        private MaritalStatusType maritalStatusField;
        
        private VerificationLevelType verificationLevelField;
        
        private bool verificationLevelFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public MaritalStatusType MaritalStatus {
            get {
                return this.maritalStatusField;
            }
            set {
                this.maritalStatusField = value;
                this.RaisePropertyChanged("MaritalStatus");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public VerificationLevelType VerificationLevel {
            get {
                return this.verificationLevelField;
            }
            set {
                this.verificationLevelField = value;
                this.RaisePropertyChanged("VerificationLevel");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VerificationLevelSpecified {
            get {
                return this.verificationLevelFieldSpecified;
            }
            set {
                this.verificationLevelFieldSpecified = value;
                this.RaisePropertyChanged("VerificationLevelSpecified");
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