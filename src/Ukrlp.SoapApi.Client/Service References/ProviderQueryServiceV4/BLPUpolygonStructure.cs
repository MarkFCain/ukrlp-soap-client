namespace Ukrlp.SoapApi.Client.ProviderQueryServiceV4
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.govtalk.gov.uk/people/bs7666")]
    public partial class BLPUpolygonStructure : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string polygonIDField;
        
        private BLPUpolygonStructurePolygonType polygonTypeField;
        
        private bool polygonTypeFieldSpecified;
        
        private object[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger", Order=0)]
        public string PolygonID {
            get {
                return this.polygonIDField;
            }
            set {
                this.polygonIDField = value;
                this.RaisePropertyChanged("PolygonID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public BLPUpolygonStructurePolygonType PolygonType {
            get {
                return this.polygonTypeField;
            }
            set {
                this.polygonTypeField = value;
                this.RaisePropertyChanged("PolygonType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PolygonTypeSpecified {
            get {
                return this.polygonTypeFieldSpecified;
            }
            set {
                this.polygonTypeFieldSpecified = value;
                this.RaisePropertyChanged("PolygonTypeSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExternalRef", typeof(ulong), Order=2)]
        [System.Xml.Serialization.XmlElementAttribute("Vertices", typeof(CoordinateStructure), Order=2)]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
                this.RaisePropertyChanged("Items");
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