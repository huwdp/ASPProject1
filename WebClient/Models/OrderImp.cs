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
    [System.Runtime.Serialization.DataContractAttribute(Name="Order", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
    public partial class Order : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        private decimal MoneyField;
        
        private System.Nullable<System.DateTime> TimestampField;
        
        private WCFService.User UserField;
        
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
        public decimal Money
        {
            get
            {
                return this.MoneyField;
            }
            set
            {
                this.MoneyField = value;
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
        public WCFService.User User
        {
            get
            {
                return this.UserField;
            }
            set
            {
                this.UserField = value;
            }
        }
    }
    
    /*
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
    */
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Address", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
    public partial class Address : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string Address1Field;
        
        private string Address2Field;
        
        private string CountryField;
        
        private string CountyField;
        
        private string HouseNameField;
        
        private int HouseNumberField;
        
        private string PostcodeField;
        
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
        public string Address1
        {
            get
            {
                return this.Address1Field;
            }
            set
            {
                this.Address1Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address2
        {
            get
            {
                return this.Address2Field;
            }
            set
            {
                this.Address2Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Country
        {
            get
            {
                return this.CountryField;
            }
            set
            {
                this.CountryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string County
        {
            get
            {
                return this.CountyField;
            }
            set
            {
                this.CountyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HouseName
        {
            get
            {
                return this.HouseNameField;
            }
            set
            {
                this.HouseNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int HouseNumber
        {
            get
            {
                return this.HouseNumberField;
            }
            set
            {
                this.HouseNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Postcode
        {
            get
            {
                return this.PostcodeField;
            }
            set
            {
                this.PostcodeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Visa", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
    public partial class Visa : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Nullable<int> CardNumberField;
        
        private System.Nullable<int> CardSecurityCodeField;
        
        private System.Nullable<System.DateTime> ExpiryDateField;
        
        private System.Nullable<System.DateTime> ValidDateField;
        
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
        public System.Nullable<int> CardNumber
        {
            get
            {
                return this.CardNumberField;
            }
            set
            {
                this.CardNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> CardSecurityCode
        {
            get
            {
                return this.CardSecurityCodeField;
            }
            set
            {
                this.CardSecurityCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ExpiryDate
        {
            get
            {
                return this.ExpiryDateField;
            }
            set
            {
                this.ExpiryDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ValidDate
        {
            get
            {
                return this.ValidDateField;
            }
            set
            {
                this.ValidDateField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IOrder")]
public interface IOrder
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrder/Insert", ReplyAction="http://tempuri.org/IOrder/InsertResponse")]
    bool Insert(WCFService.Order order);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrder/Insert", ReplyAction="http://tempuri.org/IOrder/InsertResponse")]
    System.Threading.Tasks.Task<bool> InsertAsync(WCFService.Order order);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrder/InsertOrderFromUser", ReplyAction="http://tempuri.org/IOrder/InsertOrderFromUserResponse")]
    bool InsertOrderFromUser(int userId, WCFService.Address address, WCFService.Visa visa);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrder/InsertOrderFromUser", ReplyAction="http://tempuri.org/IOrder/InsertOrderFromUserResponse")]
    System.Threading.Tasks.Task<bool> InsertOrderFromUserAsync(int userId, WCFService.Address address, WCFService.Visa visa);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrder/Remove", ReplyAction="http://tempuri.org/IOrder/RemoveResponse")]
    bool Remove(WCFService.Order order);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrder/Remove", ReplyAction="http://tempuri.org/IOrder/RemoveResponse")]
    System.Threading.Tasks.Task<bool> RemoveAsync(WCFService.Order order);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrder/Edit", ReplyAction="http://tempuri.org/IOrder/EditResponse")]
    bool Edit(WCFService.Order order);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrder/Edit", ReplyAction="http://tempuri.org/IOrder/EditResponse")]
    System.Threading.Tasks.Task<bool> EditAsync(WCFService.Order order);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrder/FindOrderById", ReplyAction="http://tempuri.org/IOrder/FindOrderByIdResponse")]
    WCFService.Order FindOrderById(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrder/FindOrderById", ReplyAction="http://tempuri.org/IOrder/FindOrderByIdResponse")]
    System.Threading.Tasks.Task<WCFService.Order> FindOrderByIdAsync(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrder/FindOrdersByUser", ReplyAction="http://tempuri.org/IOrder/FindOrdersByUserResponse")]
    WCFService.Order[] FindOrdersByUser(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrder/FindOrdersByUser", ReplyAction="http://tempuri.org/IOrder/FindOrdersByUserResponse")]
    System.Threading.Tasks.Task<WCFService.Order[]> FindOrdersByUserAsync(int id);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IOrderChannel : IOrder, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class OrderClient : System.ServiceModel.ClientBase<IOrder>, IOrder
{
    
    public OrderClient()
    {
    }
    
    public OrderClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public OrderClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public OrderClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public OrderClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public bool Insert(WCFService.Order order)
    {
        return base.Channel.Insert(order);
    }
    
    public System.Threading.Tasks.Task<bool> InsertAsync(WCFService.Order order)
    {
        return base.Channel.InsertAsync(order);
    }
    
    public bool InsertOrderFromUser(int userId, WCFService.Address address, WCFService.Visa visa)
    {
        return base.Channel.InsertOrderFromUser(userId, address, visa);
    }
    
    public System.Threading.Tasks.Task<bool> InsertOrderFromUserAsync(int userId, WCFService.Address address, WCFService.Visa visa)
    {
        return base.Channel.InsertOrderFromUserAsync(userId, address, visa);
    }
    
    public bool Remove(WCFService.Order order)
    {
        return base.Channel.Remove(order);
    }
    
    public System.Threading.Tasks.Task<bool> RemoveAsync(WCFService.Order order)
    {
        return base.Channel.RemoveAsync(order);
    }
    
    public bool Edit(WCFService.Order order)
    {
        return base.Channel.Edit(order);
    }
    
    public System.Threading.Tasks.Task<bool> EditAsync(WCFService.Order order)
    {
        return base.Channel.EditAsync(order);
    }
    
    public WCFService.Order FindOrderById(int id)
    {
        return base.Channel.FindOrderById(id);
    }
    
    public System.Threading.Tasks.Task<WCFService.Order> FindOrderByIdAsync(int id)
    {
        return base.Channel.FindOrderByIdAsync(id);
    }
    
    public WCFService.Order[] FindOrdersByUser(int id)
    {
        return base.Channel.FindOrdersByUser(id);
    }
    
    public System.Threading.Tasks.Task<WCFService.Order[]> FindOrdersByUserAsync(int id)
    {
        return base.Channel.FindOrdersByUserAsync(id);
    }
}
