using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOrderImp" in both code and config file together.
    [ServiceContract]
    public interface IOrder
    {
        [OperationContract]
        bool Insert(Order order);
        [OperationContract]
        bool Remove(Order order);
        [OperationContract]
        bool Edit(Order order);
        [OperationContract]
        Order FindOrderById(int id);
        [OperationContract]
        List<Order> FindOrdersByUser(User user);

        C_Order Convert(Order order);
        Order Convert(C_Order corder);
    }

    [DataContract]
    public class Order
    {
        private int id;
        private List<OrderItem> items;
        private User user;
        private decimal money;
        private DateTime? timestamp;

        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public List<OrderItem> Items
        {
            get { return items; }
            set { items = value; }
        }

        [DataMember]
        public User User
        {
            get { return user; }
            set { user = value; }
        }

        [DataMember]
        public Decimal Money
        {
            get { return money; }
            set { money = value; }
        }

        [DataMember]
        public DateTime? Timestamp
        {
            get { return timestamp; }
            set { timestamp = value; }
        }
    }

    [DataContract]
    public class OrderItem
    {
        private int id;
        private Product product;
    }
}
