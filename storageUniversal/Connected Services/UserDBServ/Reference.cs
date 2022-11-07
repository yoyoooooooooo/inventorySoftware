﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 15.0.28307.1000
// 
namespace storageUniversal.UserDBServ {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserDBServ.UserDBServSoap")]
    public interface UserDBServSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/reg", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<bool> regAsync(storageUniversal.UserDBServ.User usr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsUserPermitted", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<bool> IsUserPermittedAsync(storageUniversal.UserDBServ.User usr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetFullUser", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<storageUniversal.UserDBServ.User> GetFullUserAsync(storageUniversal.UserDBServ.User usr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/updateUser", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<bool> updateUserAsync(storageUniversal.UserDBServ.User OldUsr, storageUniversal.UserDBServ.User NewUsr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteUser", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<bool> DeleteUserAsync(storageUniversal.UserDBServ.User usr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsAdmin", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<bool> IsAdminAsync(storageUniversal.UserDBServ.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAdminUserTbl", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<storageUniversal.UserDBServ.GetAdminUserTblResponseGetAdminUserTblResult> GetAdminUserTblAsync(storageUniversal.UserDBServ.User user);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4161.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class User : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idField;
        
        private string fnameField;
        
        private string lnameField;
        
        private System.DateTime bDateField;
        
        private string compenyField;
        
        private string emailField;
        
        private string passwordField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Fname {
            get {
                return this.fnameField;
            }
            set {
                this.fnameField = value;
                this.RaisePropertyChanged("Fname");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Lname {
            get {
                return this.lnameField;
            }
            set {
                this.lnameField = value;
                this.RaisePropertyChanged("Lname");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public System.DateTime BDate {
            get {
                return this.bDateField;
            }
            set {
                this.bDateField = value;
                this.RaisePropertyChanged("BDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Compeny {
            get {
                return this.compenyField;
            }
            set {
                this.compenyField = value;
                this.RaisePropertyChanged("Compeny");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string Email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
                this.RaisePropertyChanged("Email");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
                this.RaisePropertyChanged("Password");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4161.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/")]
    public partial class GetAdminUserTblResponseGetAdminUserTblResult : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Xml.Linq.XElement[] anyField;
        
        private System.Xml.Linq.XElement any1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="http://www.w3.org/2001/XMLSchema", Order=0)]
        public System.Xml.Linq.XElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
                this.RaisePropertyChanged("Any");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="urn:schemas-microsoft-com:xml-diffgram-v1", Order=1)]
        public System.Xml.Linq.XElement Any1 {
            get {
                return this.any1Field;
            }
            set {
                this.any1Field = value;
                this.RaisePropertyChanged("Any1");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface UserDBServSoapChannel : storageUniversal.UserDBServ.UserDBServSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserDBServSoapClient : System.ServiceModel.ClientBase<storageUniversal.UserDBServ.UserDBServSoap>, storageUniversal.UserDBServ.UserDBServSoap {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public UserDBServSoapClient() : 
                base(UserDBServSoapClient.GetDefaultBinding(), UserDBServSoapClient.GetDefaultEndpointAddress()) {
            this.Endpoint.Name = EndpointConfiguration.UserDBServSoap.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserDBServSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(UserDBServSoapClient.GetBindingForEndpoint(endpointConfiguration), UserDBServSoapClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserDBServSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(UserDBServSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserDBServSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(UserDBServSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserDBServSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync() {
            return base.Channel.HelloWorldAsync();
        }
        
        public System.Threading.Tasks.Task<bool> regAsync(storageUniversal.UserDBServ.User usr) {
            return base.Channel.regAsync(usr);
        }
        
        public System.Threading.Tasks.Task<bool> IsUserPermittedAsync(storageUniversal.UserDBServ.User usr) {
            return base.Channel.IsUserPermittedAsync(usr);
        }
        
        public System.Threading.Tasks.Task<storageUniversal.UserDBServ.User> GetFullUserAsync(storageUniversal.UserDBServ.User usr) {
            return base.Channel.GetFullUserAsync(usr);
        }
        
        public System.Threading.Tasks.Task<bool> updateUserAsync(storageUniversal.UserDBServ.User OldUsr, storageUniversal.UserDBServ.User NewUsr) {
            return base.Channel.updateUserAsync(OldUsr, NewUsr);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteUserAsync(storageUniversal.UserDBServ.User usr) {
            return base.Channel.DeleteUserAsync(usr);
        }
        
        public System.Threading.Tasks.Task<bool> IsAdminAsync(storageUniversal.UserDBServ.User user) {
            return base.Channel.IsAdminAsync(user);
        }
        
        public System.Threading.Tasks.Task<storageUniversal.UserDBServ.GetAdminUserTblResponseGetAdminUserTblResult> GetAdminUserTblAsync(storageUniversal.UserDBServ.User user) {
            return base.Channel.GetAdminUserTblAsync(user);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.UserDBServSoap)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.UserDBServSoap)) {
                return new System.ServiceModel.EndpointAddress("http://localhost:57628/UserDBServ.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return UserDBServSoapClient.GetBindingForEndpoint(EndpointConfiguration.UserDBServSoap);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return UserDBServSoapClient.GetEndpointAddress(EndpointConfiguration.UserDBServSoap);
        }
        
        public enum EndpointConfiguration {
            
            UserDBServSoap,
        }
    }
}
