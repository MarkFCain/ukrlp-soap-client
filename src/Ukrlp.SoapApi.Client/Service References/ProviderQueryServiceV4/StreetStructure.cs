namespace Ukrlp.SoapApi.Client.ProviderQueryServiceV4
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.govtalk.gov.uk/people/bs7666")]
    public partial class StreetStructure : object, System.ComponentModel.INotifyPropertyChanged {
        
        private StreetReferenceTypeType streetReferenceTypeField;
        
        private CoordinateStructure startCoordinateField;
        
        private CoordinateStructure endCoordinateField;
        
        private decimal toleranceField;
        
        private string streetVersionNumberField;
        
        private System.DateTime streetEntryDateField;
        
        private System.DateTime streetClosureDateField;
        
        private bool streetClosureDateFieldSpecified;
        
        private string responsibleAuthorityField;
        
        private StreetDescriptiveIdentifierStructure descriptiveIdentifierField;
        
        private StreetDescriptiveIdentifierStructure streetAliasField;
        
        private StreetStructureStreetCrossReferences streetCrossReferencesField;
        
        private string usrnField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public StreetReferenceTypeType StreetReferenceType {
            get {
                return this.streetReferenceTypeField;
            }
            set {
                this.streetReferenceTypeField = value;
                this.RaisePropertyChanged("StreetReferenceType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public CoordinateStructure StartCoordinate {
            get {
                return this.startCoordinateField;
            }
            set {
                this.startCoordinateField = value;
                this.RaisePropertyChanged("StartCoordinate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public CoordinateStructure EndCoordinate {
            get {
                return this.endCoordinateField;
            }
            set {
                this.endCoordinateField = value;
                this.RaisePropertyChanged("EndCoordinate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public decimal Tolerance {
            get {
                return this.toleranceField;
            }
            set {
                this.toleranceField = value;
                this.RaisePropertyChanged("Tolerance");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger", Order=4)]
        public string StreetVersionNumber {
            get {
                return this.streetVersionNumberField;
            }
            set {
                this.streetVersionNumberField = value;
                this.RaisePropertyChanged("StreetVersionNumber");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=5)]
        public System.DateTime StreetEntryDate {
            get {
                return this.streetEntryDateField;
            }
            set {
                this.streetEntryDateField = value;
                this.RaisePropertyChanged("StreetEntryDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=6)]
        public System.DateTime StreetClosureDate {
            get {
                return this.streetClosureDateField;
            }
            set {
                this.streetClosureDateField = value;
                this.RaisePropertyChanged("StreetClosureDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StreetClosureDateSpecified {
            get {
                return this.streetClosureDateFieldSpecified;
            }
            set {
                this.streetClosureDateFieldSpecified = value;
                this.RaisePropertyChanged("StreetClosureDateSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=7)]
        public string ResponsibleAuthority {
            get {
                return this.responsibleAuthorityField;
            }
            set {
                this.responsibleAuthorityField = value;
                this.RaisePropertyChanged("ResponsibleAuthority");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public StreetDescriptiveIdentifierStructure DescriptiveIdentifier {
            get {
                return this.descriptiveIdentifierField;
            }
            set {
                this.descriptiveIdentifierField = value;
                this.RaisePropertyChanged("DescriptiveIdentifier");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public StreetDescriptiveIdentifierStructure StreetAlias {
            get {
                return this.streetAliasField;
            }
            set {
                this.streetAliasField = value;
                this.RaisePropertyChanged("StreetAlias");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public StreetStructureStreetCrossReferences StreetCrossReferences {
            get {
                return this.streetCrossReferencesField;
            }
            set {
                this.streetCrossReferencesField = value;
                this.RaisePropertyChanged("StreetCrossReferences");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string usrn {
            get {
                return this.usrnField;
            }
            set {
                this.usrnField = value;
                this.RaisePropertyChanged("usrn");
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