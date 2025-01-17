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
namespace storageUniversal.SubUserServ {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SubUserServ.SubUsersServSoap")]
    public interface SubUsersServSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/createSubUser", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<int> createSubUserAsync(storageUniversal.SubUserServ.SubUser subUser, storageUniversal.SubUserServ.User UpperUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getYourSubUsers", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<System.Data.DataTable> getYourSubUsersAsync(storageUniversal.SubUserServ.User UpperUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/updateSub", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<bool> updateSubAsync(storageUniversal.SubUserServ.SubUser subUser, storageUniversal.SubUserServ.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteSubUser", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<bool> DeleteSubUserAsync(storageUniversal.SubUserServ.User UpUser, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetFullUser", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<storageUniversal.SubUserServ.SubUser> GetFullUserAsync(storageUniversal.SubUserServ.SubUser user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getLimitedSubUserInventoryList", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<System.Data.DataTable> getLimitedSubUserInventoryListAsync(storageUniversal.SubUserServ.SubUser subUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/addOrder", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<int> addOrderAsync(storageUniversal.SubUserServ.Order order, storageUniversal.SubUserServ.SubUser subUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getOrders", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<System.Data.DataTable> getOrdersAsync(storageUniversal.SubUserServ.SubUser user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteOrder", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task DeleteOrderAsync(storageUniversal.SubUserServ.User user, int OrdId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetYourSubUser", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<storageUniversal.SubUserServ.SubUser> GetYourSubUserAsync(storageUniversal.SubUserServ.User user, int SubUserID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateOrderByUpperUser", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<bool> UpdateOrderByUpperUserAsync(storageUniversal.SubUserServ.User user, storageUniversal.SubUserServ.Order order);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class SubUser : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idField;
        
        private int belongsToUpperUserField;
        
        private string fNameField;
        
        private string lNameField;
        
        private string roleField;
        
        private string emailField;
        
        private string passwordField;
        
        private string userNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Id {
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
        public int BelongsToUpperUser {
            get {
                return this.belongsToUpperUserField;
            }
            set {
                this.belongsToUpperUserField = value;
                this.RaisePropertyChanged("BelongsToUpperUser");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string FName {
            get {
                return this.fNameField;
            }
            set {
                this.fNameField = value;
                this.RaisePropertyChanged("FName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string LName {
            get {
                return this.lNameField;
            }
            set {
                this.lNameField = value;
                this.RaisePropertyChanged("LName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Role {
            get {
                return this.roleField;
            }
            set {
                this.roleField = value;
                this.RaisePropertyChanged("Role");
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string UserName {
            get {
                return this.userNameField;
            }
            set {
                this.userNameField = value;
                this.RaisePropertyChanged("UserName");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Order : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idField;
        
        private int bySubUserField;
        
        private int itemIdField;
        
        private float amountField;
        
        private int toUpperUserField;
        
        private bool aprovedField;
        
        private bool rejectedField;
        
        private string remarkesField;
        
        private string itemNameField;
        
        private System.DateTime orderDateField;
        
        private string statusField;
        
        private bool isActiveField;
        
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
        public int BySubUser {
            get {
                return this.bySubUserField;
            }
            set {
                this.bySubUserField = value;
                this.RaisePropertyChanged("BySubUser");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int ItemId {
            get {
                return this.itemIdField;
            }
            set {
                this.itemIdField = value;
                this.RaisePropertyChanged("ItemId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public float Amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
                this.RaisePropertyChanged("Amount");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public int ToUpperUser {
            get {
                return this.toUpperUserField;
            }
            set {
                this.toUpperUserField = value;
                this.RaisePropertyChanged("ToUpperUser");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public bool Aproved {
            get {
                return this.aprovedField;
            }
            set {
                this.aprovedField = value;
                this.RaisePropertyChanged("Aproved");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public bool Rejected {
            get {
                return this.rejectedField;
            }
            set {
                this.rejectedField = value;
                this.RaisePropertyChanged("Rejected");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string Remarkes {
            get {
                return this.remarkesField;
            }
            set {
                this.remarkesField = value;
                this.RaisePropertyChanged("Remarkes");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string ItemName {
            get {
                return this.itemNameField;
            }
            set {
                this.itemNameField = value;
                this.RaisePropertyChanged("ItemName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public System.DateTime OrderDate {
            get {
                return this.orderDateField;
            }
            set {
                this.orderDateField = value;
                this.RaisePropertyChanged("OrderDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
                this.RaisePropertyChanged("Status");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public bool IsActive {
            get {
                return this.isActiveField;
            }
            set {
                this.isActiveField = value;
                this.RaisePropertyChanged("IsActive");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class User : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idField;
        
        private string fnameField;
        
        private string lnameField;
        
        private System.Nullable<System.DateTime> bDateField;
        
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public System.Nullable<System.DateTime> BDate {
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SubUsersServSoapChannel : storageUniversal.SubUserServ.SubUsersServSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SubUsersServSoapClient : System.ServiceModel.ClientBase<storageUniversal.SubUserServ.SubUsersServSoap>, storageUniversal.SubUserServ.SubUsersServSoap {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public SubUsersServSoapClient() : 
                base(SubUsersServSoapClient.GetDefaultBinding(), SubUsersServSoapClient.GetDefaultEndpointAddress()) {
            this.Endpoint.Name = EndpointConfiguration.SubUsersServSoap.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SubUsersServSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(SubUsersServSoapClient.GetBindingForEndpoint(endpointConfiguration), SubUsersServSoapClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SubUsersServSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(SubUsersServSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SubUsersServSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(SubUsersServSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SubUsersServSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Threading.Tasks.Task<int> createSubUserAsync(storageUniversal.SubUserServ.SubUser subUser, storageUniversal.SubUserServ.User UpperUser) {
            return base.Channel.createSubUserAsync(subUser, UpperUser);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> getYourSubUsersAsync(storageUniversal.SubUserServ.User UpperUser) {
            return base.Channel.getYourSubUsersAsync(UpperUser);
        }
        
        public System.Threading.Tasks.Task<bool> updateSubAsync(storageUniversal.SubUserServ.SubUser subUser, storageUniversal.SubUserServ.User user) {
            return base.Channel.updateSubAsync(subUser, user);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteSubUserAsync(storageUniversal.SubUserServ.User UpUser, int id) {
            return base.Channel.DeleteSubUserAsync(UpUser, id);
        }
        
        public System.Threading.Tasks.Task<storageUniversal.SubUserServ.SubUser> GetFullUserAsync(storageUniversal.SubUserServ.SubUser user) {
            return base.Channel.GetFullUserAsync(user);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> getLimitedSubUserInventoryListAsync(storageUniversal.SubUserServ.SubUser subUser) {
            return base.Channel.getLimitedSubUserInventoryListAsync(subUser);
        }
        
        public System.Threading.Tasks.Task<int> addOrderAsync(storageUniversal.SubUserServ.Order order, storageUniversal.SubUserServ.SubUser subUser) {
            return base.Channel.addOrderAsync(order, subUser);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> getOrdersAsync(storageUniversal.SubUserServ.SubUser user) {
            return base.Channel.getOrdersAsync(user);
        }
        
        public System.Threading.Tasks.Task DeleteOrderAsync(storageUniversal.SubUserServ.User user, int OrdId) {
            return base.Channel.DeleteOrderAsync(user, OrdId);
        }
        
        public System.Threading.Tasks.Task<storageUniversal.SubUserServ.SubUser> GetYourSubUserAsync(storageUniversal.SubUserServ.User user, int SubUserID) {
            return base.Channel.GetYourSubUserAsync(user, SubUserID);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateOrderByUpperUserAsync(storageUniversal.SubUserServ.User user, storageUniversal.SubUserServ.Order order) {
            return base.Channel.UpdateOrderByUpperUserAsync(user, order);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.SubUsersServSoap)) {
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
            if ((endpointConfiguration == EndpointConfiguration.SubUsersServSoap)) {
                return new System.ServiceModel.EndpointAddress("http://localhost:57628/SubUsersServ.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return SubUsersServSoapClient.GetBindingForEndpoint(EndpointConfiguration.SubUsersServSoap);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return SubUsersServSoapClient.GetEndpointAddress(EndpointConfiguration.SubUsersServSoap);
        }
        
        public enum EndpointConfiguration {
            
            SubUsersServSoap,
        }
    }
}
