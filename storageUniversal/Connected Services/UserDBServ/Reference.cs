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
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://tempuri.org/")]
    public partial class User : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int IDField;
        
        private string FnameField;
        
        private string LnameField;
        
        private System.DateTime BDateField;
        
        private string CompenyField;
        
        private string EmailField;
        
        private string PasswordField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Fname {
            get {
                return this.FnameField;
            }
            set {
                if ((object.ReferenceEquals(this.FnameField, value) != true)) {
                    this.FnameField = value;
                    this.RaisePropertyChanged("Fname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Lname {
            get {
                return this.LnameField;
            }
            set {
                if ((object.ReferenceEquals(this.LnameField, value) != true)) {
                    this.LnameField = value;
                    this.RaisePropertyChanged("Lname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public System.DateTime BDate {
            get {
                return this.BDateField;
            }
            set {
                if ((this.BDateField.Equals(value) != true)) {
                    this.BDateField = value;
                    this.RaisePropertyChanged("BDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string Compeny {
            get {
                return this.CompenyField;
            }
            set {
                if ((object.ReferenceEquals(this.CompenyField, value) != true)) {
                    this.CompenyField = value;
                    this.RaisePropertyChanged("Compeny");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserDBServ.UserDBServSoap")]
    public interface UserDBServSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<storageUniversal.UserDBServ.HelloWorldResponse> HelloWorldAsync(storageUniversal.UserDBServ.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/reg", ReplyAction="*")]
        System.Threading.Tasks.Task<storageUniversal.UserDBServ.regResponse> regAsync(storageUniversal.UserDBServ.regRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsUserPermitted", ReplyAction="*")]
        System.Threading.Tasks.Task<storageUniversal.UserDBServ.IsUserPermittedResponse> IsUserPermittedAsync(storageUniversal.UserDBServ.IsUserPermittedRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetFullUser", ReplyAction="*")]
        System.Threading.Tasks.Task<storageUniversal.UserDBServ.GetFullUserResponse> GetFullUserAsync(storageUniversal.UserDBServ.GetFullUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/updateUser", ReplyAction="*")]
        System.Threading.Tasks.Task<storageUniversal.UserDBServ.updateUserResponse> updateUserAsync(storageUniversal.UserDBServ.updateUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteUser", ReplyAction="*")]
        System.Threading.Tasks.Task<storageUniversal.UserDBServ.DeleteUserResponse> DeleteUserAsync(storageUniversal.UserDBServ.DeleteUserRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public storageUniversal.UserDBServ.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(storageUniversal.UserDBServ.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public storageUniversal.UserDBServ.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(storageUniversal.UserDBServ.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class regRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="reg", Namespace="http://tempuri.org/", Order=0)]
        public storageUniversal.UserDBServ.regRequestBody Body;
        
        public regRequest() {
        }
        
        public regRequest(storageUniversal.UserDBServ.regRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class regRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public storageUniversal.UserDBServ.User usr;
        
        public regRequestBody() {
        }
        
        public regRequestBody(storageUniversal.UserDBServ.User usr) {
            this.usr = usr;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class regResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="regResponse", Namespace="http://tempuri.org/", Order=0)]
        public storageUniversal.UserDBServ.regResponseBody Body;
        
        public regResponse() {
        }
        
        public regResponse(storageUniversal.UserDBServ.regResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class regResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool regResult;
        
        public regResponseBody() {
        }
        
        public regResponseBody(bool regResult) {
            this.regResult = regResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class IsUserPermittedRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="IsUserPermitted", Namespace="http://tempuri.org/", Order=0)]
        public storageUniversal.UserDBServ.IsUserPermittedRequestBody Body;
        
        public IsUserPermittedRequest() {
        }
        
        public IsUserPermittedRequest(storageUniversal.UserDBServ.IsUserPermittedRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class IsUserPermittedRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public storageUniversal.UserDBServ.User usr;
        
        public IsUserPermittedRequestBody() {
        }
        
        public IsUserPermittedRequestBody(storageUniversal.UserDBServ.User usr) {
            this.usr = usr;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class IsUserPermittedResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="IsUserPermittedResponse", Namespace="http://tempuri.org/", Order=0)]
        public storageUniversal.UserDBServ.IsUserPermittedResponseBody Body;
        
        public IsUserPermittedResponse() {
        }
        
        public IsUserPermittedResponse(storageUniversal.UserDBServ.IsUserPermittedResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class IsUserPermittedResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool IsUserPermittedResult;
        
        public IsUserPermittedResponseBody() {
        }
        
        public IsUserPermittedResponseBody(bool IsUserPermittedResult) {
            this.IsUserPermittedResult = IsUserPermittedResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetFullUserRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetFullUser", Namespace="http://tempuri.org/", Order=0)]
        public storageUniversal.UserDBServ.GetFullUserRequestBody Body;
        
        public GetFullUserRequest() {
        }
        
        public GetFullUserRequest(storageUniversal.UserDBServ.GetFullUserRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetFullUserRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public storageUniversal.UserDBServ.User usr;
        
        public GetFullUserRequestBody() {
        }
        
        public GetFullUserRequestBody(storageUniversal.UserDBServ.User usr) {
            this.usr = usr;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetFullUserResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetFullUserResponse", Namespace="http://tempuri.org/", Order=0)]
        public storageUniversal.UserDBServ.GetFullUserResponseBody Body;
        
        public GetFullUserResponse() {
        }
        
        public GetFullUserResponse(storageUniversal.UserDBServ.GetFullUserResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetFullUserResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public storageUniversal.UserDBServ.User GetFullUserResult;
        
        public GetFullUserResponseBody() {
        }
        
        public GetFullUserResponseBody(storageUniversal.UserDBServ.User GetFullUserResult) {
            this.GetFullUserResult = GetFullUserResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class updateUserRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="updateUser", Namespace="http://tempuri.org/", Order=0)]
        public storageUniversal.UserDBServ.updateUserRequestBody Body;
        
        public updateUserRequest() {
        }
        
        public updateUserRequest(storageUniversal.UserDBServ.updateUserRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class updateUserRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public storageUniversal.UserDBServ.User OldUsr;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public storageUniversal.UserDBServ.User NewUsr;
        
        public updateUserRequestBody() {
        }
        
        public updateUserRequestBody(storageUniversal.UserDBServ.User OldUsr, storageUniversal.UserDBServ.User NewUsr) {
            this.OldUsr = OldUsr;
            this.NewUsr = NewUsr;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class updateUserResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="updateUserResponse", Namespace="http://tempuri.org/", Order=0)]
        public storageUniversal.UserDBServ.updateUserResponseBody Body;
        
        public updateUserResponse() {
        }
        
        public updateUserResponse(storageUniversal.UserDBServ.updateUserResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class updateUserResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool updateUserResult;
        
        public updateUserResponseBody() {
        }
        
        public updateUserResponseBody(bool updateUserResult) {
            this.updateUserResult = updateUserResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteUserRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteUser", Namespace="http://tempuri.org/", Order=0)]
        public storageUniversal.UserDBServ.DeleteUserRequestBody Body;
        
        public DeleteUserRequest() {
        }
        
        public DeleteUserRequest(storageUniversal.UserDBServ.DeleteUserRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DeleteUserRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public storageUniversal.UserDBServ.User usr;
        
        public DeleteUserRequestBody() {
        }
        
        public DeleteUserRequestBody(storageUniversal.UserDBServ.User usr) {
            this.usr = usr;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteUserResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteUserResponse", Namespace="http://tempuri.org/", Order=0)]
        public storageUniversal.UserDBServ.DeleteUserResponseBody Body;
        
        public DeleteUserResponse() {
        }
        
        public DeleteUserResponse(storageUniversal.UserDBServ.DeleteUserResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DeleteUserResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool DeleteUserResult;
        
        public DeleteUserResponseBody() {
        }
        
        public DeleteUserResponseBody(bool DeleteUserResult) {
            this.DeleteUserResult = DeleteUserResult;
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
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<storageUniversal.UserDBServ.HelloWorldResponse> storageUniversal.UserDBServ.UserDBServSoap.HelloWorldAsync(storageUniversal.UserDBServ.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<storageUniversal.UserDBServ.HelloWorldResponse> HelloWorldAsync() {
            storageUniversal.UserDBServ.HelloWorldRequest inValue = new storageUniversal.UserDBServ.HelloWorldRequest();
            inValue.Body = new storageUniversal.UserDBServ.HelloWorldRequestBody();
            return ((storageUniversal.UserDBServ.UserDBServSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<storageUniversal.UserDBServ.regResponse> storageUniversal.UserDBServ.UserDBServSoap.regAsync(storageUniversal.UserDBServ.regRequest request) {
            return base.Channel.regAsync(request);
        }
        
        public System.Threading.Tasks.Task<storageUniversal.UserDBServ.regResponse> regAsync(storageUniversal.UserDBServ.User usr) {
            storageUniversal.UserDBServ.regRequest inValue = new storageUniversal.UserDBServ.regRequest();
            inValue.Body = new storageUniversal.UserDBServ.regRequestBody();
            inValue.Body.usr = usr;
            return ((storageUniversal.UserDBServ.UserDBServSoap)(this)).regAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<storageUniversal.UserDBServ.IsUserPermittedResponse> storageUniversal.UserDBServ.UserDBServSoap.IsUserPermittedAsync(storageUniversal.UserDBServ.IsUserPermittedRequest request) {
            return base.Channel.IsUserPermittedAsync(request);
        }
        
        public System.Threading.Tasks.Task<storageUniversal.UserDBServ.IsUserPermittedResponse> IsUserPermittedAsync(storageUniversal.UserDBServ.User usr) {
            storageUniversal.UserDBServ.IsUserPermittedRequest inValue = new storageUniversal.UserDBServ.IsUserPermittedRequest();
            inValue.Body = new storageUniversal.UserDBServ.IsUserPermittedRequestBody();
            inValue.Body.usr = usr;
            return ((storageUniversal.UserDBServ.UserDBServSoap)(this)).IsUserPermittedAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<storageUniversal.UserDBServ.GetFullUserResponse> storageUniversal.UserDBServ.UserDBServSoap.GetFullUserAsync(storageUniversal.UserDBServ.GetFullUserRequest request) {
            return base.Channel.GetFullUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<storageUniversal.UserDBServ.GetFullUserResponse> GetFullUserAsync(storageUniversal.UserDBServ.User usr) {
            storageUniversal.UserDBServ.GetFullUserRequest inValue = new storageUniversal.UserDBServ.GetFullUserRequest();
            inValue.Body = new storageUniversal.UserDBServ.GetFullUserRequestBody();
            inValue.Body.usr = usr;
            return ((storageUniversal.UserDBServ.UserDBServSoap)(this)).GetFullUserAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<storageUniversal.UserDBServ.updateUserResponse> storageUniversal.UserDBServ.UserDBServSoap.updateUserAsync(storageUniversal.UserDBServ.updateUserRequest request) {
            return base.Channel.updateUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<storageUniversal.UserDBServ.updateUserResponse> updateUserAsync(storageUniversal.UserDBServ.User OldUsr, storageUniversal.UserDBServ.User NewUsr) {
            storageUniversal.UserDBServ.updateUserRequest inValue = new storageUniversal.UserDBServ.updateUserRequest();
            inValue.Body = new storageUniversal.UserDBServ.updateUserRequestBody();
            inValue.Body.OldUsr = OldUsr;
            inValue.Body.NewUsr = NewUsr;
            return ((storageUniversal.UserDBServ.UserDBServSoap)(this)).updateUserAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<storageUniversal.UserDBServ.DeleteUserResponse> storageUniversal.UserDBServ.UserDBServSoap.DeleteUserAsync(storageUniversal.UserDBServ.DeleteUserRequest request) {
            return base.Channel.DeleteUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<storageUniversal.UserDBServ.DeleteUserResponse> DeleteUserAsync(storageUniversal.UserDBServ.User usr) {
            storageUniversal.UserDBServ.DeleteUserRequest inValue = new storageUniversal.UserDBServ.DeleteUserRequest();
            inValue.Body = new storageUniversal.UserDBServ.DeleteUserRequestBody();
            inValue.Body.usr = usr;
            return ((storageUniversal.UserDBServ.UserDBServSoap)(this)).DeleteUserAsync(inValue);
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