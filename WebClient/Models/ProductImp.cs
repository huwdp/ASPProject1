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
    
    /*
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string DescriptionField;
        
        private int IdField;
        
        private string NameField;
        
        private System.Nullable<decimal> PriceField;
        
        private System.Nullable<System.DateTime> TimestampField;
        
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
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
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
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> Price
        {
            get
            {
                return this.PriceField;
            }
            set
            {
                this.PriceField = value;
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
    }
    */
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IProduct")]
public interface IProduct
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/Insert", ReplyAction="http://tempuri.org/IProduct/InsertResponse")]
    bool Insert(WCFService.Product product);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/Insert", ReplyAction="http://tempuri.org/IProduct/InsertResponse")]
    System.Threading.Tasks.Task<bool> InsertAsync(WCFService.Product product);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/Remove", ReplyAction="http://tempuri.org/IProduct/RemoveResponse")]
    bool Remove(WCFService.Product product);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/Remove", ReplyAction="http://tempuri.org/IProduct/RemoveResponse")]
    System.Threading.Tasks.Task<bool> RemoveAsync(WCFService.Product product);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/Edit", ReplyAction="http://tempuri.org/IProduct/EditResponse")]
    bool Edit(WCFService.Product product);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/Edit", ReplyAction="http://tempuri.org/IProduct/EditResponse")]
    System.Threading.Tasks.Task<bool> EditAsync(WCFService.Product product);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/FindProductById", ReplyAction="http://tempuri.org/IProduct/FindProductByIdResponse")]
    WCFService.Product FindProductById(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/FindProductById", ReplyAction="http://tempuri.org/IProduct/FindProductByIdResponse")]
    System.Threading.Tasks.Task<WCFService.Product> FindProductByIdAsync(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/GetProductList", ReplyAction="http://tempuri.org/IProduct/GetProductListResponse")]
    WCFService.Product[] GetProductList();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/GetProductList", ReplyAction="http://tempuri.org/IProduct/GetProductListResponse")]
    System.Threading.Tasks.Task<WCFService.Product[]> GetProductListAsync();
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IProductChannel : IProduct, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class ProductClient : System.ServiceModel.ClientBase<IProduct>, IProduct
{
    
    public ProductClient()
    {
    }
    
    public ProductClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public ProductClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ProductClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ProductClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public bool Insert(WCFService.Product product)
    {
        return base.Channel.Insert(product);
    }
    
    public System.Threading.Tasks.Task<bool> InsertAsync(WCFService.Product product)
    {
        return base.Channel.InsertAsync(product);
    }
    
    public bool Remove(WCFService.Product product)
    {
        return base.Channel.Remove(product);
    }
    
    public System.Threading.Tasks.Task<bool> RemoveAsync(WCFService.Product product)
    {
        return base.Channel.RemoveAsync(product);
    }
    
    public bool Edit(WCFService.Product product)
    {
        return base.Channel.Edit(product);
    }
    
    public System.Threading.Tasks.Task<bool> EditAsync(WCFService.Product product)
    {
        return base.Channel.EditAsync(product);
    }
    
    public WCFService.Product FindProductById(int id)
    {
        return base.Channel.FindProductById(id);
    }
    
    public System.Threading.Tasks.Task<WCFService.Product> FindProductByIdAsync(int id)
    {
        return base.Channel.FindProductByIdAsync(id);
    }
    
    public WCFService.Product[] GetProductList()
    {
        return base.Channel.GetProductList();
    }
    
    public System.Threading.Tasks.Task<WCFService.Product[]> GetProductListAsync()
    {
        return base.Channel.GetProductListAsync();
    }
}
