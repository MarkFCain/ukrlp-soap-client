namespace Ukrlp.SoapApi.Client.ProviderQueryServiceV4
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ukrlp.co.uk.server.ws.v3")]
    public partial class ProviderQueryResultStructure : object, System.ComponentModel.INotifyPropertyChanged {
        
        private ProviderRecordStructure[] matchingProviderRecordsField;
        
        private string queryIdField;
        
        private string stakeholderIdField;
        
        private string schemaVersionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MatchingProviderRecords", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public ProviderRecordStructure[] MatchingProviderRecords {
            get {
                return this.matchingProviderRecordsField;
            }
            set {
                this.matchingProviderRecordsField = value;
                this.RaisePropertyChanged("MatchingProviderRecords");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer", Order=1)]
        public string QueryId {
            get {
                return this.queryIdField;
            }
            set {
                this.queryIdField = value;
                this.RaisePropertyChanged("QueryId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer", Order=2)]
        public string StakeholderId {
            get {
                return this.stakeholderIdField;
            }
            set {
                this.stakeholderIdField = value;
                this.RaisePropertyChanged("StakeholderId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        public string SchemaVersion {
            get {
                return this.schemaVersionField;
            }
            set {
                this.schemaVersionField = value;
                this.RaisePropertyChanged("SchemaVersion");
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