﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EPiServer.Business.Commerce.Payment.PayEx.PxVerification {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://external.payex.com/PxVerification/", ConfigurationName="PxVerification.PxVerificationSoap")]
    public interface PxVerificationSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://external.payex.com/PxVerification/CreditCheckPrivate", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string CreditCheckPrivate(long accountNumber, string countryCode, string socialSecurityNumber, string firstName, string lastName, int amount, string clientIPAddress, string hash);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://external.payex.com/PxVerification/CreditCheckPrivate", ReplyAction="*")]
        System.Threading.Tasks.Task<string> CreditCheckPrivateAsync(long accountNumber, string countryCode, string socialSecurityNumber, string firstName, string lastName, int amount, string clientIPAddress, string hash);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://external.payex.com/PxVerification/CreditCheckPrivate2", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string CreditCheckPrivate2(long accountNumber, string countryCode, string socialSecurityNumber, string firstName, string lastName, int amount, string clientIPAddress, string hash);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://external.payex.com/PxVerification/CreditCheckPrivate2", ReplyAction="*")]
        System.Threading.Tasks.Task<string> CreditCheckPrivate2Async(long accountNumber, string countryCode, string socialSecurityNumber, string firstName, string lastName, int amount, string clientIPAddress, string hash);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://external.payex.com/PxVerification/CreditCheckCorporate", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string CreditCheckCorporate(long accountNumber, string countryCode, string organizationNumber, int amount, string hash);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://external.payex.com/PxVerification/CreditCheckCorporate", ReplyAction="*")]
        System.Threading.Tasks.Task<string> CreditCheckCorporateAsync(long accountNumber, string countryCode, string organizationNumber, int amount, string hash);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://external.payex.com/PxVerification/CreditCheckCorporate2", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string CreditCheckCorporate2(long accountNumber, string countryCode, string organizationNumber, int amount, string hash);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://external.payex.com/PxVerification/CreditCheckCorporate2", ReplyAction="*")]
        System.Threading.Tasks.Task<string> CreditCheckCorporate2Async(long accountNumber, string countryCode, string organizationNumber, int amount, string hash);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://external.payex.com/PxVerification/NameCheckPrivate", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string NameCheckPrivate(long accountNumber, string socialSecurityNumber, string firstName, string lastName, string countryCode, string hash);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://external.payex.com/PxVerification/NameCheckPrivate", ReplyAction="*")]
        System.Threading.Tasks.Task<string> NameCheckPrivateAsync(long accountNumber, string socialSecurityNumber, string firstName, string lastName, string countryCode, string hash);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://external.payex.com/PxVerification/RequestAuthentication", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseResp))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseReq))]
        EPiServer.Business.Commerce.Payment.PayEx.PxVerification.PxRequestAuthenticationResp RequestAuthentication(EPiServer.Business.Commerce.Payment.PayEx.PxVerification.PxRequestAuthenticationReq req);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://external.payex.com/PxVerification/RequestAuthentication", ReplyAction="*")]
        System.Threading.Tasks.Task<EPiServer.Business.Commerce.Payment.PayEx.PxVerification.PxRequestAuthenticationResp> RequestAuthenticationAsync(EPiServer.Business.Commerce.Payment.PayEx.PxVerification.PxRequestAuthenticationReq req);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://external.payex.com/PxVerification/GetConsumerLegalAddress", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseResp))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseReq))]
        string GetConsumerLegalAddress(long accountNumber, string socialSecurityNumber, string countryCode, string hash);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://external.payex.com/PxVerification/GetConsumerLegalAddress", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GetConsumerLegalAddressAsync(long accountNumber, string socialSecurityNumber, string countryCode, string hash);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://external.payex.com/PxVerification/")]
    public partial class PxRequestAuthenticationReq : PxBaseReq {
        
        private string[] authenticatorsField;
        
        private string returnUrlField;
        
        private Signable signableField;
        
        private string extraDataField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        public string[] Authenticators {
            get {
                return this.authenticatorsField;
            }
            set {
                this.authenticatorsField = value;
                this.RaisePropertyChanged("Authenticators");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ReturnUrl {
            get {
                return this.returnUrlField;
            }
            set {
                this.returnUrlField = value;
                this.RaisePropertyChanged("ReturnUrl");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public Signable Signable {
            get {
                return this.signableField;
            }
            set {
                this.signableField = value;
                this.RaisePropertyChanged("Signable");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string ExtraData {
            get {
                return this.extraDataField;
            }
            set {
                this.extraDataField = value;
                this.RaisePropertyChanged("ExtraData");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://external.payex.com/PxVerification/")]
    public partial class Signable : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string idField;
        
        private string typeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
                this.RaisePropertyChanged("Type");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://external.payex.com/PxVerification/")]
    public partial class Status : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string descriptionField;
        
        private string errorCodeField;
        
        private string errorCodeSimpleField;
        
        private string paramNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
                this.RaisePropertyChanged("Description");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ErrorCode {
            get {
                return this.errorCodeField;
            }
            set {
                this.errorCodeField = value;
                this.RaisePropertyChanged("ErrorCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string ErrorCodeSimple {
            get {
                return this.errorCodeSimpleField;
            }
            set {
                this.errorCodeSimpleField = value;
                this.RaisePropertyChanged("ErrorCodeSimple");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string ParamName {
            get {
                return this.paramNameField;
            }
            set {
                this.paramNameField = value;
                this.RaisePropertyChanged("ParamName");
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PxBaseResp))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PxRequestAuthenticationResp))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://external.payex.com/PxVerification/")]
    public partial class BaseResp : object, System.ComponentModel.INotifyPropertyChanged {
        
        private Status statusField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public Status Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
                this.RaisePropertyChanged("Status");
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PxRequestAuthenticationResp))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://external.payex.com/PxVerification/")]
    public abstract partial class PxBaseResp : BaseResp {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://external.payex.com/PxVerification/")]
    public partial class PxRequestAuthenticationResp : PxBaseResp {
        
        private string returnUrlField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ReturnUrl {
            get {
                return this.returnUrlField;
            }
            set {
                this.returnUrlField = value;
                this.RaisePropertyChanged("ReturnUrl");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://external.payex.com/PxVerification/")]
    public partial class Authentication : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string hashField;
        
        private long accountNumberField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Hash {
            get {
                return this.hashField;
            }
            set {
                this.hashField = value;
                this.RaisePropertyChanged("Hash");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public long AccountNumber {
            get {
                return this.accountNumberField;
            }
            set {
                this.accountNumberField = value;
                this.RaisePropertyChanged("AccountNumber");
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PxBaseReq))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PxRequestAuthenticationReq))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://external.payex.com/PxVerification/")]
    public partial class BaseReq : object, System.ComponentModel.INotifyPropertyChanged {
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PxRequestAuthenticationReq))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://external.payex.com/PxVerification/")]
    public abstract partial class PxBaseReq : BaseReq {
        
        private Authentication authenticationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public Authentication Authentication {
            get {
                return this.authenticationField;
            }
            set {
                this.authenticationField = value;
                this.RaisePropertyChanged("Authentication");
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface PxVerificationSoapChannel : EPiServer.Business.Commerce.Payment.PayEx.PxVerification.PxVerificationSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PxVerificationSoapClient : System.ServiceModel.ClientBase<EPiServer.Business.Commerce.Payment.PayEx.PxVerification.PxVerificationSoap>, EPiServer.Business.Commerce.Payment.PayEx.PxVerification.PxVerificationSoap {
        
        public PxVerificationSoapClient() {
        }
        
        public PxVerificationSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PxVerificationSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PxVerificationSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PxVerificationSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string CreditCheckPrivate(long accountNumber, string countryCode, string socialSecurityNumber, string firstName, string lastName, int amount, string clientIPAddress, string hash) {
            return base.Channel.CreditCheckPrivate(accountNumber, countryCode, socialSecurityNumber, firstName, lastName, amount, clientIPAddress, hash);
        }
        
        public System.Threading.Tasks.Task<string> CreditCheckPrivateAsync(long accountNumber, string countryCode, string socialSecurityNumber, string firstName, string lastName, int amount, string clientIPAddress, string hash) {
            return base.Channel.CreditCheckPrivateAsync(accountNumber, countryCode, socialSecurityNumber, firstName, lastName, amount, clientIPAddress, hash);
        }
        
        public string CreditCheckPrivate2(long accountNumber, string countryCode, string socialSecurityNumber, string firstName, string lastName, int amount, string clientIPAddress, string hash) {
            return base.Channel.CreditCheckPrivate2(accountNumber, countryCode, socialSecurityNumber, firstName, lastName, amount, clientIPAddress, hash);
        }
        
        public System.Threading.Tasks.Task<string> CreditCheckPrivate2Async(long accountNumber, string countryCode, string socialSecurityNumber, string firstName, string lastName, int amount, string clientIPAddress, string hash) {
            return base.Channel.CreditCheckPrivate2Async(accountNumber, countryCode, socialSecurityNumber, firstName, lastName, amount, clientIPAddress, hash);
        }
        
        public string CreditCheckCorporate(long accountNumber, string countryCode, string organizationNumber, int amount, string hash) {
            return base.Channel.CreditCheckCorporate(accountNumber, countryCode, organizationNumber, amount, hash);
        }
        
        public System.Threading.Tasks.Task<string> CreditCheckCorporateAsync(long accountNumber, string countryCode, string organizationNumber, int amount, string hash) {
            return base.Channel.CreditCheckCorporateAsync(accountNumber, countryCode, organizationNumber, amount, hash);
        }
        
        public string CreditCheckCorporate2(long accountNumber, string countryCode, string organizationNumber, int amount, string hash) {
            return base.Channel.CreditCheckCorporate2(accountNumber, countryCode, organizationNumber, amount, hash);
        }
        
        public System.Threading.Tasks.Task<string> CreditCheckCorporate2Async(long accountNumber, string countryCode, string organizationNumber, int amount, string hash) {
            return base.Channel.CreditCheckCorporate2Async(accountNumber, countryCode, organizationNumber, amount, hash);
        }
        
        public string NameCheckPrivate(long accountNumber, string socialSecurityNumber, string firstName, string lastName, string countryCode, string hash) {
            return base.Channel.NameCheckPrivate(accountNumber, socialSecurityNumber, firstName, lastName, countryCode, hash);
        }
        
        public System.Threading.Tasks.Task<string> NameCheckPrivateAsync(long accountNumber, string socialSecurityNumber, string firstName, string lastName, string countryCode, string hash) {
            return base.Channel.NameCheckPrivateAsync(accountNumber, socialSecurityNumber, firstName, lastName, countryCode, hash);
        }
        
        public EPiServer.Business.Commerce.Payment.PayEx.PxVerification.PxRequestAuthenticationResp RequestAuthentication(EPiServer.Business.Commerce.Payment.PayEx.PxVerification.PxRequestAuthenticationReq req) {
            return base.Channel.RequestAuthentication(req);
        }
        
        public System.Threading.Tasks.Task<EPiServer.Business.Commerce.Payment.PayEx.PxVerification.PxRequestAuthenticationResp> RequestAuthenticationAsync(EPiServer.Business.Commerce.Payment.PayEx.PxVerification.PxRequestAuthenticationReq req) {
            return base.Channel.RequestAuthenticationAsync(req);
        }
        
        public string GetConsumerLegalAddress(long accountNumber, string socialSecurityNumber, string countryCode, string hash) {
            return base.Channel.GetConsumerLegalAddress(accountNumber, socialSecurityNumber, countryCode, hash);
        }
        
        public System.Threading.Tasks.Task<string> GetConsumerLegalAddressAsync(long accountNumber, string socialSecurityNumber, string countryCode, string hash) {
            return base.Channel.GetConsumerLegalAddressAsync(accountNumber, socialSecurityNumber, countryCode, hash);
        }
    }
}
