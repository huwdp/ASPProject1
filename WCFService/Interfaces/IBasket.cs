using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFService
{
    [ServiceContract()]
    public interface IBasket
    {
        [OperationContract]
        bool Insert(int userId, int productId);
        [OperationContract]
        bool Remove(int id);
        [OperationContract]
        List<Product> FindProductsByUser(int id);

        C_Product Convert(Product product);
        Product Convert(C_Product cproduct);
    }

    [DataContract]
    public class Basket
    {
        private int id;
        private C_User user;
        private C_Product product;

        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public C_User User
        {
            get { return user; }
            set { user = value; }
        }

        [DataMember]
        public C_Product Product
        {
            get { return Product; }
            set { Product = value; }
        }
    }
}
