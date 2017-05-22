namespace Ukrlp.SoapApi.Client.ProviderQueryServiceV4
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.govtalk.gov.uk/people/bs7666")]
    public partial class ElementaryStreetUnitStructure : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string eSUidentityField;
        
        private string eSUversionField;
        
        private System.DateTime eSUentryDateField;
        
        private System.DateTime eSUclosureDateField;
        
        private bool eSUclosureDateFieldSpecified;
        
        private CoordinateStructure startCoordinateField;
        
        private CoordinateStructure endCoordinateField;
        
        private decimal toleranceField;
        
        private CoordinateStructure[] intermediateCoordField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ESUidentity {
            get {
                return this.eSUidentityField;
            }
            set {
                this.eSUidentityField = value;
                this.RaisePropertyChanged("ESUidentity");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger", Order=1)]
        public string ESUversion {
            get {
                return this.eSUversionField;
            }
            set {
                this.eSUversionField = value;
                this.RaisePropertyChanged("ESUversion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=2)]
        public System.DateTime ESUentryDate {
            get {
                return this.eSUentryDateField;
            }
            set {
                this.eSUentryDateField = value;
                this.RaisePropertyChanged("ESUentryDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=3)]
        public System.DateTime ESUclosureDate {
            get {
                return this.eSUclosureDateField;
            }
            set {
                this.eSUclosureDateField = value;
                this.RaisePropertyChanged("ESUclosureDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ESUclosureDateSpecified {
            get {
                return this.eSUclosureDateFieldSpecified;
            }
            set {
                this.eSUclosureDateFieldSpecified = value;
                this.RaisePropertyChanged("ESUclosureDateSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
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
        [System.Xml.Serialization.XmlElementAttribute("IntermediateCoord", Order=7)]
        public CoordinateStructure[] IntermediateCoord {
            get {
                return this.intermediateCoordField;
            }
            set {
                this.intermediateCoordField = value;
                this.RaisePropertyChanged("IntermediateCoord");
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