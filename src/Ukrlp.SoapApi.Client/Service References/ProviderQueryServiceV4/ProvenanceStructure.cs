namespace Ukrlp.SoapApi.Client.ProviderQueryServiceV4
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.govtalk.gov.uk/people/bs7666")]
    public partial class ProvenanceStructure : object, System.ComponentModel.INotifyPropertyChanged {
        
        private ProvenanceCodeType provenanceCodeField;
        
        private string annotationField;
        
        private System.DateTime provEntryDateField;
        
        private System.DateTime provStartDateField;
        
        private System.DateTime provEndDateField;
        
        private bool provEndDateFieldSpecified;
        
        private System.DateTime provLastUpdateDateField;
        
        private BLPUextentStructure bLPUextentField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ProvenanceCodeType ProvenanceCode {
            get {
                return this.provenanceCodeField;
            }
            set {
                this.provenanceCodeField = value;
                this.RaisePropertyChanged("ProvenanceCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Annotation {
            get {
                return this.annotationField;
            }
            set {
                this.annotationField = value;
                this.RaisePropertyChanged("Annotation");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=2)]
        public System.DateTime ProvEntryDate {
            get {
                return this.provEntryDateField;
            }
            set {
                this.provEntryDateField = value;
                this.RaisePropertyChanged("ProvEntryDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=3)]
        public System.DateTime ProvStartDate {
            get {
                return this.provStartDateField;
            }
            set {
                this.provStartDateField = value;
                this.RaisePropertyChanged("ProvStartDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=4)]
        public System.DateTime ProvEndDate {
            get {
                return this.provEndDateField;
            }
            set {
                this.provEndDateField = value;
                this.RaisePropertyChanged("ProvEndDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProvEndDateSpecified {
            get {
                return this.provEndDateFieldSpecified;
            }
            set {
                this.provEndDateFieldSpecified = value;
                this.RaisePropertyChanged("ProvEndDateSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=5)]
        public System.DateTime ProvLastUpdateDate {
            get {
                return this.provLastUpdateDateField;
            }
            set {
                this.provLastUpdateDateField = value;
                this.RaisePropertyChanged("ProvLastUpdateDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public BLPUextentStructure BLPUextent {
            get {
                return this.bLPUextentField;
            }
            set {
                this.bLPUextentField = value;
                this.RaisePropertyChanged("BLPUextent");
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