﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string EmailField;
        
        private int IdField;
        
        private string PasswordField;
        
        private System.Nullable<System.DateTime> TimestampField;
        
        private string UsernameField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password
        {
            get
            {
                return this.PasswordField;
            }
            set
            {
                this.PasswordField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> Timestamp
        {
            get
            {
                return this.TimestampField;
            }
            set
            {
                this.TimestampField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username
        {
            get
            {
                return this.UsernameField;
            }
            set
            {
                this.UsernameField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IUser")]
public interface IUser
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/Insert", ReplyAction="http://tempuri.org/IUser/InsertResponse")]
    bool Insert(WCFService.User user);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/Insert", ReplyAction="http://tempuri.org/IUser/InsertResponse")]
    System.Threading.Tasks.Task<bool> InsertAsync(WCFService.User user);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/Remove", ReplyAction="http://tempuri.org/IUser/RemoveResponse")]
    bool Remove(WCFService.User user);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/Remove", ReplyAction="http://tempuri.org/IUser/RemoveResponse")]
    System.Threading.Tasks.Task<bool> RemoveAsync(WCFService.User user);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/Edit", ReplyAction="http://tempuri.org/IUser/EditResponse")]
    bool Edit(WCFService.User user);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/Edit", ReplyAction="http://tempuri.org/IUser/EditResponse")]
    System.Threading.Tasks.Task<bool> EditAsync(WCFService.User user);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/FindUserById", ReplyAction="http://tempuri.org/IUser/FindUserByIdResponse")]
    WCFService.User FindUserById(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/FindUserById", ReplyAction="http://tempuri.org/IUser/FindUserByIdResponse")]
    System.Threading.Tasks.Task<WCFService.User> FindUserByIdAsync(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/FindUserByCredentials", ReplyAction="http://tempuri.org/IUser/FindUserByCredentialsResponse")]
    WCFService.User FindUserByCredentials(string username, string password);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/FindUserByCredentials", ReplyAction="http://tempuri.org/IUser/FindUserByCredentialsResponse")]
    System.Threading.Tasks.Task<WCFService.User> FindUserByCredentialsAsync(string username, string password);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IUserChannel : IUser, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class UserClient : System.ServiceModel.ClientBase<IUser>, IUser
{
    
    public UserClient()
    {
    }
    
    public UserClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public UserClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public UserClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public UserClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public bool Insert(WCFService.User user)
    {
        return base.Channel.Insert(user);
    }
    
    public System.Threading.Tasks.Task<bool> InsertAsync(WCFService.User user)
    {
        return base.Channel.InsertAsync(user);
    }
    
    public bool Remove(WCFService.User user)
    {
        return base.Channel.Remove(user);
    }
    
    public System.Threading.Tasks.Task<bool> RemoveAsync(WCFService.User user)
    {
        return base.Channel.RemoveAsync(user);
    }
    
    public bool Edit(WCFService.User user)
    {
        return base.Channel.Edit(user);
    }
    
    public System.Threading.Tasks.Task<bool> EditAsync(WCFService.User user)
    {
        return base.Channel.EditAsync(user);
    }
    
    public WCFService.User FindUserById(int id)
    {
        return base.Channel.FindUserById(id);
    }
    
    public System.Threading.Tasks.Task<WCFService.User> FindUserByIdAsync(int id)
    {
        return base.Channel.FindUserByIdAsync(id);
    }
    
    public WCFService.User FindUserByCredentials(string username, string password)
    {
        return base.Channel.FindUserByCredentials(username, password);
    }
    
    public System.Threading.Tasks.Task<WCFService.User> FindUserByCredentialsAsync(string username, string password)
    {
        return base.Channel.FindUserByCredentialsAsync(username, password);
    }
}
