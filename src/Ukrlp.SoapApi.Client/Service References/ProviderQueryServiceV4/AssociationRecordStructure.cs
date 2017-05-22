namespace Ukrlp.SoapApi.Client.ProviderQueryServiceV4
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ukrlp.co.uk.server.ws.v3")]
    public partial class AssociationRecordStructure : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string typeOfAssociationField;
        
        private string associationIdField;
        
        private string associationDescriptionField;
        
        private string associationStatusField;
        
        private System.DateTime associationCreatedDateField;
        
        private string associationMembershipStatusField;
        
        private System.DateTime associationMemberSinceDateField;
        
        private System.DateTime associationMembershipEndDateField;
        
        private bool associationMembershipEndDateFieldSpecified;
        
        private YesNoType leadProviderFlagField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string TypeOfAssociation {
            get {
                return this.typeOfAssociationField;
            }
            set {
                this.typeOfAssociationField = value;
                this.RaisePropertyChanged("TypeOfAssociation");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="positiveInteger", Order=1)]
        public string AssociationId {
            get {
                return this.associationIdField;
            }
            set {
                this.associationIdField = value;
                this.RaisePropertyChanged("AssociationId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string AssociationDescription {
            get {
                return this.associationDescriptionField;
            }
            set {
                this.associationDescriptionField = value;
                this.RaisePropertyChanged("AssociationDescription");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string AssociationStatus {
            get {
                return this.associationStatusField;
            }
            set {
                this.associationStatusField = value;
                this.RaisePropertyChanged("AssociationStatus");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public System.DateTime AssociationCreatedDate {
            get {
                return this.associationCreatedDateField;
            }
            set {
                this.associationCreatedDateField = value;
                this.RaisePropertyChanged("AssociationCreatedDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string AssociationMembershipStatus {
            get {
                return this.associationMembershipStatusField;
            }
            set {
                this.associationMembershipStatusField = value;
                this.RaisePropertyChanged("AssociationMembershipStatus");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public System.DateTime AssociationMemberSinceDate {
            get {
                return this.associationMemberSinceDateField;
            }
            set {
                this.associationMemberSinceDateField = value;
                this.RaisePropertyChanged("AssociationMemberSinceDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public System.DateTime AssociationMembershipEndDate {
            get {
                return this.associationMembershipEndDateField;
            }
            set {
                this.associationMembershipEndDateField = value;
                this.RaisePropertyChanged("AssociationMembershipEndDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AssociationMembershipEndDateSpecified {
            get {
                return this.associationMembershipEndDateFieldSpecified;
            }
            set {
                this.associationMembershipEndDateFieldSpecified = value;
                this.RaisePropertyChanged("AssociationMembershipEndDateSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public YesNoType LeadProviderFlag {
            get {
                return this.leadProviderFlagField;
            }
            set {
                this.leadProviderFlagField = value;
                this.RaisePropertyChanged("LeadProviderFlag");
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