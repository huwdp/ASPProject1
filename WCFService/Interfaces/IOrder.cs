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
        bool InsertOrderFromUser(int userId, Address address, Visa visa);
        [OperationContract]
        bool Remove(Order order);
        [OperationContract]
        bool Edit(Order order);
        [OperationContract]
        Order FindOrderById(int id);
        [OperationContract]
        List<Order> FindOrdersByUser(int id);
        

        C_Order Convert(Order order);
        Order Convert(C_Order corder);
        C_Visa Convert(Visa visa);
        Visa Convert(C_Visa cVisa);
    }

    [DataContract]
    public class Order
    {
        private int id;
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
    public class Address
    {
        private int houseNumber;
        private string houseName;
        private string address1;
        private string address2;
        private string postcode;
        private string county;
        private string country;
        
        [DataMember]
        public int HouseNumber
        {
            get { return houseNumber; }
            set { houseNumber = value; }
        }

        [DataMember]
        public string HouseName
        {
            get { return houseName; }
            set { houseName = value; }
        }

        [DataMember]
        public string Address1
        {
            get { return address1; }
            set { address1 = value; }
        }

        [DataMember]
        public string Address2
        {
            get { return address2; }
            set { address2 = value; }
        }

        [DataMember]
        public string Postcode
        {
            get { return postcode; }
            set { postcode = value; }
        }

        [DataMember]
        public string County
        {
            get { return county; }
            set { county = value; }
        }

        [DataMember]
        public string Country
        {
            get { return county; }
            set { country = value; }
        }
    }

    [DataContract]
    public class Visa
    {
        private DateTime? validDate;
        private DateTime? expiryDate;
        private int? cardSecurityCode;
        private int? cardNumber;

        [DataMember]
        public DateTime? ValidDate
        {
            get { return validDate; }
            set { validDate = value; }
        }

        [DataMember]
        public DateTime? ExpiryDate
        {
            get { return expiryDate; }
            set { expiryDate = value; }
        }

        [DataMember]
        public int? CardSecurityCode
        {
            get { return cardSecurityCode; }
            set { cardSecurityCode = value; }
        }

        [DataMember]
        public int? CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }
    }
}
