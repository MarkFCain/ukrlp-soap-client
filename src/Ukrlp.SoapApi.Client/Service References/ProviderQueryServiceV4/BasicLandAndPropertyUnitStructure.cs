namespace Ukrlp.SoapApi.Client.ProviderQueryServiceV4
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.govtalk.gov.uk/people/bs7666")]
    public partial class BasicLandAndPropertyUnitStructure : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string uniquePropertyReferenceNumberField;
        
        private string custodianCodeField;
        
        private RepresentativePointCodeType representativePointCodeField;
        
        private LogicalStatusType logicalStatusField;
        
        private CoordinateStructure gridReferenceField;
        
        private System.DateTime bLPUentryDateField;
        
        private System.DateTime bLPUstartDateField;
        
        private System.DateTime bLPUendDateField;
        
        private bool bLPUendDateFieldSpecified;
        
        private System.DateTime bLPUlastUpdateDateField;
        
        private LandAndPropertyIdentifierStructure[] landAndPropertyIdentifierField;
        
        private ProvenanceStructure[] provenanceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=0)]
        public string UniquePropertyReferenceNumber {
            get {
                return this.uniquePropertyReferenceNumberField;
            }
            set {
                this.uniquePropertyReferenceNumberField = value;
                this.RaisePropertyChanged("UniquePropertyReferenceNumber");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=1)]
        public string CustodianCode {
            get {
                return this.custodianCodeField;
            }
            set {
                this.custodianCodeField = value;
                this.RaisePropertyChanged("CustodianCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public RepresentativePointCodeType RepresentativePointCode {
            get {
                return this.representativePointCodeField;
            }
            set {
                this.representativePointCodeField = value;
                this.RaisePropertyChanged("RepresentativePointCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public LogicalStatusType LogicalStatus {
            get {
                return this.logicalStatusField;
            }
            set {
                this.logicalStatusField = value;
                this.RaisePropertyChanged("LogicalStatus");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public CoordinateStructure GridReference {
            get {
                return this.gridReferenceField;
            }
            set {
                this.gridReferenceField = value;
                this.RaisePropertyChanged("GridReference");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=5)]
        public System.DateTime BLPUentryDate {
            get {
                return this.bLPUentryDateField;
            }
            set {
                this.bLPUentryDateField = value;
                this.RaisePropertyChanged("BLPUentryDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=6)]
        public System.DateTime BLPUstartDate {
            get {
                return this.bLPUstartDateField;
            }
            set {
                this.bLPUstartDateField = value;
                this.RaisePropertyChanged("BLPUstartDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=7)]
        public System.DateTime BLPUendDate {
            get {
                return this.bLPUendDateField;
            }
            set {
                this.bLPUendDateField = value;
                this.RaisePropertyChanged("BLPUendDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BLPUendDateSpecified {
            get {
                return this.bLPUendDateFieldSpecified;
            }
            set {
                this.bLPUendDateFieldSpecified = value;
                this.RaisePropertyChanged("BLPUendDateSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=8)]
        public System.DateTime BLPUlastUpdateDate {
            get {
                return this.bLPUlastUpdateDateField;
            }
            set {
                this.bLPUlastUpdateDateField = value;
                this.RaisePropertyChanged("BLPUlastUpdateDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LandAndPropertyIdentifier", Order=9)]
        public LandAndPropertyIdentifierStructure[] LandAndPropertyIdentifier {
            get {
                return this.landAndPropertyIdentifierField;
            }
            set {
                this.landAndPropertyIdentifierField = value;
                this.RaisePropertyChanged("LandAndPropertyIdentifier");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Provenance", Order=10)]
        public ProvenanceStructure[] Provenance {
            get {
                return this.provenanceField;
            }
            set {
                this.provenanceField = value;
                this.RaisePropertyChanged("Provenance");
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