namespace Ukrlp.SoapApi.Client.ProviderQueryServiceV4
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.govtalk.gov.uk/people/PersonDescriptives")]
    public partial class PersonBirthDateStructure : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.DateTime personBirthDateField;
        
        private VerificationLevelType verificationLevelField;
        
        private bool verificationLevelFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=0)]
        public System.DateTime PersonBirthDate {
            get {
                return this.personBirthDateField;
            }
            set {
                this.personBirthDateField = value;
                this.RaisePropertyChanged("PersonBirthDate");
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