namespace Ukrlp.SoapApi.Client.ProviderQueryServiceV4
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.govtalk.gov.uk/people/bs7666")]
    public partial class BLPUextentStructure : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string sourceDescriptionField;
        
        private System.DateTime extentEntryDateField;
        
        private System.DateTime extentSourceDateField;
        
        private System.DateTime extentStartDateField;
        
        private System.DateTime extentEndDateField;
        
        private bool extentEndDateFieldSpecified;
        
        private System.DateTime extentLastUpdateDateField;
        
        private BLPUpolygonStructure[] extentDefinitionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string SourceDescription {
            get {
                return this.sourceDescriptionField;
            }
            set {
                this.sourceDescriptionField = value;
                this.RaisePropertyChanged("SourceDescription");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=1)]
        public System.DateTime ExtentEntryDate {
            get {
                return this.extentEntryDateField;
            }
            set {
                this.extentEntryDateField = value;
                this.RaisePropertyChanged("ExtentEntryDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=2)]
        public System.DateTime ExtentSourceDate {
            get {
                return this.extentSourceDateField;
            }
            set {
                this.extentSourceDateField = value;
                this.RaisePropertyChanged("ExtentSourceDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=3)]
        public System.DateTime ExtentStartDate {
            get {
                return this.extentStartDateField;
            }
            set {
                this.extentStartDateField = value;
                this.RaisePropertyChanged("ExtentStartDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=4)]
        public System.DateTime ExtentEndDate {
            get {
                return this.extentEndDateField;
            }
            set {
                this.extentEndDateField = value;
                this.RaisePropertyChanged("ExtentEndDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExtentEndDateSpecified {
            get {
                return this.extentEndDateFieldSpecified;
            }
            set {
                this.extentEndDateFieldSpecified = value;
                this.RaisePropertyChanged("ExtentEndDateSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=5)]
        public System.DateTime ExtentLastUpdateDate {
            get {
                return this.extentLastUpdateDateField;
            }
            set {
                this.extentLastUpdateDateField = value;
                this.RaisePropertyChanged("ExtentLastUpdateDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExtentDefinition", Order=6)]
        public BLPUpolygonStructure[] ExtentDefinition {
            get {
                return this.extentDefinitionField;
            }
            set {
                this.extentDefinitionField = value;
                this.RaisePropertyChanged("ExtentDefinition");
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