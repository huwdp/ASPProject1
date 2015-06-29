using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFService
{
    public class UserImp : IUser
    {
        public bool Insert(User user)
        {
            bool completed = false;
            using (var context = Config.context)
            {
                try
                {
                    var data = context.C_User.Add(Convert(user));
                    context.SaveChanges();
                    completed =  true;
                }
                catch (Exception ex)
                {
                    // log here
                }
            }
            return completed;
        }

        public bool Remove(User user)
        {
            bool completed = false;
            using (var context = Config.context)
            {
                try
                {
                    var item = context.C_User.Single(i => i.id == user.Id);
                    var data = context.C_User.Remove(item);
                    completed = true;
                }
                catch (Exception ex)
                {
                    // log here
                }
            }
            return completed;
        }

        public bool Edit(User user)
        {
            bool completed = false;

            return completed;
        }

        public User FindUserById(int id)
        {
            using (var context = Config.context)
            {
                try
                {
                    var data = context.C_User.Single(i => i.id == id);
                    User user = new User();
                    user.Id = data.id;
                    user.Username = data.username;
                    user.Password = data.password;
                    user.Email = data.email;
                    user.Timestamp = data.timestamp;
                    return user;
                }
                catch (Exception ex)
                {
                    // log here
                }
            }
            return null;
        }

        public User FindUserByCredentials(string username, string password)
        {
            using (var context = Config.context)
            {
                try
                {
                    var data = context.C_User.Single(i => i.username == username && i.password == password);
                    User user = new User();
                    user.Id = data.id;
                    user.Username = data.username;
                    user.Password = data.password;
                    user.Email = data.email;
                    user.Timestamp = data.timestamp;
                    return user;
                }
                catch (Exception ex)
                {
                    // log here
                }
            }
            return null;
        }

        public C_User Convert(User user)
        {
            C_User cuser = new C_User();
            cuser.id = user.Id;
            cuser.username = user.Username;
            cuser.email = user.Email;
            cuser.password = user.Password;
            cuser.timestamp = cuser.timestamp;
            return cuser;
        }

        public User Convert(C_User cUser)
        {
            User user = new User();
            user.Id = cUser.id;
            user.Username = cUser.username;
            user.Email = cUser.email;
            user.Password = cUser.password;
            user.Timestamp = cUser.timestamp;
            return user;
        }
    }
}
