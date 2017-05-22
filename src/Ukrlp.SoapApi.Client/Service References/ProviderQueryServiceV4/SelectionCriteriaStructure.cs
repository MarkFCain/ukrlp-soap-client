namespace Ukrlp.SoapApi.Client.ProviderQueryServiceV4
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ukrlp.co.uk.server.ws.v3")]
    public partial class SelectionCriteriaStructure : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string[] unitedKingdomProviderReferenceNumberListField;
        
        private string[] providerNameListField;
        
        private string[] postcodeListField;
        
        private string searchTermField;
        
        private string basePostcodeField;
        
        private int maxDistanceFromBasePostcodeField;
        
        private bool maxDistanceFromBasePostcodeFieldSpecified;
        
        private System.DateTime providerUpdatedSinceField;
        
        private bool providerUpdatedSinceFieldSpecified;
        
        private System.DateTime providerVerifiedAfterField;
        
        private bool providerVerifiedAfterFieldSpecified;
        
        private System.DateTime providerVerifiedBeforeField;
        
        private bool providerVerifiedBeforeFieldSpecified;
        
        private QueryCriteriaConditionType criteriaConditionField;
        
        private bool criteriaConditionFieldSpecified;
        
        private string stakeholderIdField;
        
        private YesNoType approvedProvidersOnlyField;
        
        private bool approvedProvidersOnlyFieldSpecified;
        
        private string providerStatusField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("UnitedKingdomProviderReferenceNumber", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="positiveInteger", IsNullable=false)]
        public string[] UnitedKingdomProviderReferenceNumberList {
            get {
                return this.unitedKingdomProviderReferenceNumberListField;
            }
            set {
                this.unitedKingdomProviderReferenceNumberListField = value;
                this.RaisePropertyChanged("UnitedKingdomProviderReferenceNumberList");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ProviderName", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public string[] ProviderNameList {
            get {
                return this.providerNameListField;
            }
            set {
                this.providerNameListField = value;
                this.RaisePropertyChanged("ProviderNameList");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Postcode", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public string[] PostcodeList {
            get {
                return this.postcodeListField;
            }
            set {
                this.postcodeListField = value;
                this.RaisePropertyChanged("PostcodeList");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string SearchTerm {
            get {
                return this.searchTermField;
            }
            set {
                this.searchTermField = value;
                this.RaisePropertyChanged("SearchTerm");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string BasePostcode {
            get {
                return this.basePostcodeField;
            }
            set {
                this.basePostcodeField = value;
                this.RaisePropertyChanged("BasePostcode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public int MaxDistanceFromBasePostcode {
            get {
                return this.maxDistanceFromBasePostcodeField;
            }
            set {
                this.maxDistanceFromBasePostcodeField = value;
                this.RaisePropertyChanged("MaxDistanceFromBasePostcode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxDistanceFromBasePostcodeSpecified {
            get {
                return this.maxDistanceFromBasePostcodeFieldSpecified;
            }
            set {
                this.maxDistanceFromBasePostcodeFieldSpecified = value;
                this.RaisePropertyChanged("MaxDistanceFromBasePostcodeSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public System.DateTime ProviderUpdatedSince {
            get {
                return this.providerUpdatedSinceField;
            }
            set {
                this.providerUpdatedSinceField = value;
                this.RaisePropertyChanged("ProviderUpdatedSince");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProviderUpdatedSinceSpecified {
            get {
                return this.providerUpdatedSinceFieldSpecified;
            }
            set {
                this.providerUpdatedSinceFieldSpecified = value;
                this.RaisePropertyChanged("ProviderUpdatedSinceSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public System.DateTime ProviderVerifiedAfter {
            get {
                return this.providerVerifiedAfterField;
            }
            set {
                this.providerVerifiedAfterField = value;
                this.RaisePropertyChanged("ProviderVerifiedAfter");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProviderVerifiedAfterSpecified {
            get {
                return this.providerVerifiedAfterFieldSpecified;
            }
            set {
                this.providerVerifiedAfterFieldSpecified = value;
                this.RaisePropertyChanged("ProviderVerifiedAfterSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public System.DateTime ProviderVerifiedBefore {
            get {
                return this.providerVerifiedBeforeField;
            }
            set {
                this.providerVerifiedBeforeField = value;
                this.RaisePropertyChanged("ProviderVerifiedBefore");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProviderVerifiedBeforeSpecified {
            get {
                return this.providerVerifiedBeforeFieldSpecified;
            }
            set {
                this.providerVerifiedBeforeFieldSpecified = value;
                this.RaisePropertyChanged("ProviderVerifiedBeforeSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public QueryCriteriaConditionType CriteriaCondition {
            get {
                return this.criteriaConditionField;
            }
            set {
                this.criteriaConditionField = value;
                this.RaisePropertyChanged("CriteriaCondition");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CriteriaConditionSpecified {
            get {
                return this.criteriaConditionFieldSpecified;
            }
            set {
                this.criteriaConditionFieldSpecified = value;
                this.RaisePropertyChanged("CriteriaConditionSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer", Order=10)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public YesNoType ApprovedProvidersOnly {
            get {
                return this.approvedProvidersOnlyField;
            }
            set {
                this.approvedProvidersOnlyField = value;
                this.RaisePropertyChanged("ApprovedProvidersOnly");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ApprovedProvidersOnlySpecified {
            get {
                return this.approvedProvidersOnlyFieldSpecified;
            }
            set {
                this.approvedProvidersOnlyFieldSpecified = value;
                this.RaisePropertyChanged("ApprovedProvidersOnlySpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public string ProviderStatus {
            get {
                return this.providerStatusField;
            }
            set {
                this.providerStatusField = value;
                this.RaisePropertyChanged("ProviderStatus");
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