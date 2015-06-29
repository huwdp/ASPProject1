using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFService
{
    
    [ServiceContract()]
    public interface IUser
    {
        [OperationContract]
        bool Insert(User user);
        [OperationContract]
        bool Remove(User user);
        [OperationContract]
        bool Edit(User user);
        [OperationContract]
        User FindUserById(int id);
        [OperationContract]
        User FindUserByCredentials(string username, string password);

        C_User Convert(User user);
        User Convert(C_User cUser);
    }

    [DataContract]
    public class User
    {
        private int id;
        private string username;
        private string password;
        private string email;
        private DateTime? timestamp;

        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        [DataMember]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        [DataMember]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        [DataMember]
        public DateTime? Timestamp
        {
            get { return timestamp; }
            set { timestamp = value; }
        }
    }
}
