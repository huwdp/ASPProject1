using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProductImp" in both code and config file together.
    [ServiceContract]
    public interface IProduct
    {
        [OperationContract]
        bool Insert(Product product);
        [OperationContract]
        bool Remove(Product product);
        [OperationContract]
        bool Edit(Product product);
        [OperationContract]
        Product FindProductById(int id);
        [OperationContract]
        List<Product> GetProductList();

        C_Product Convert(Product product);
        Product Convert(C_Product cproduct);
    }

    [DataContract]
    public class Product
    {
        private int id;
        private string name;
        private string description;
        private decimal? price;
        private DateTime? timestamp;

        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        [DataMember]
        public Decimal? Price
        {
            get { return price; }
            set { price = value; }
        }

        [DataMember]
        public DateTime? Timestamp
        {
            get { return timestamp; }
            set { timestamp = value; }
        }

    }
}
