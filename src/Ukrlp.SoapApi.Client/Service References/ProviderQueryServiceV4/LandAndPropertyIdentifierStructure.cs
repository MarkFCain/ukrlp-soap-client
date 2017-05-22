namespace Ukrlp.SoapApi.Client.ProviderQueryServiceV4
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.govtalk.gov.uk/people/bs7666")]
    public partial class LandAndPropertyIdentifierStructure : object, System.ComponentModel.INotifyPropertyChanged {
        
        private AONstructure pAONField;
        
        private AONstructure sAONField;
        
        private string postTownField;
        
        private string postCodeField;
        
        private string levelField;
        
        private LogicalStatusType logicalStatusField;
        
        private bool officialAddressMarkerField;
        
        private bool officialAddressMarkerFieldSpecified;
        
        private System.DateTime lPIstartDateField;
        
        private System.DateTime lPIentryDateField;
        
        private System.DateTime lPIendDateField;
        
        private bool lPIendDateFieldSpecified;
        
        private System.DateTime lPIlastUpdateDateField;
        
        private object itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public AONstructure PAON {
            get {
                return this.pAONField;
            }
            set {
                this.pAONField = value;
                this.RaisePropertyChanged("PAON");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public AONstructure SAON {
            get {
                return this.sAONField;
            }
            set {
                this.sAONField = value;
                this.RaisePropertyChanged("SAON");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string PostTown {
            get {
                return this.postTownField;
            }
            set {
                this.postTownField = value;
                this.RaisePropertyChanged("PostTown");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string PostCode {
            get {
                return this.postCodeField;
            }
            set {
                this.postCodeField = value;
                this.RaisePropertyChanged("PostCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Level {
            get {
                return this.levelField;
            }
            set {
                this.levelField = value;
                this.RaisePropertyChanged("Level");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public bool OfficialAddressMarker {
            get {
                return this.officialAddressMarkerField;
            }
            set {
                this.officialAddressMarkerField = value;
                this.RaisePropertyChanged("OfficialAddressMarker");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OfficialAddressMarkerSpecified {
            get {
                return this.officialAddressMarkerFieldSpecified;
            }
            set {
                this.officialAddressMarkerFieldSpecified = value;
                this.RaisePropertyChanged("OfficialAddressMarkerSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=7)]
        public System.DateTime LPIstartDate {
            get {
                return this.lPIstartDateField;
            }
            set {
                this.lPIstartDateField = value;
                this.RaisePropertyChanged("LPIstartDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=8)]
        public System.DateTime LPIentryDate {
            get {
                return this.lPIentryDateField;
            }
            set {
                this.lPIentryDateField = value;
                this.RaisePropertyChanged("LPIentryDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=9)]
        public System.DateTime LPIendDate {
            get {
                return this.lPIendDateField;
            }
            set {
                this.lPIendDateField = value;
                this.RaisePropertyChanged("LPIendDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LPIendDateSpecified {
            get {
                return this.lPIendDateFieldSpecified;
            }
            set {
                this.lPIendDateFieldSpecified = value;
                this.RaisePropertyChanged("LPIendDateSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=10)]
        public System.DateTime LPIlastUpdateDate {
            get {
                return this.lPIlastUpdateDateField;
            }
            set {
                this.lPIlastUpdateDateField = value;
                this.RaisePropertyChanged("LPIlastUpdateDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Street", typeof(StreetStructure), Order=11)]
        [System.Xml.Serialization.XmlElementAttribute("USRN", typeof(string), DataType="integer", Order=11)]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
                this.RaisePropertyChanged("Item");
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