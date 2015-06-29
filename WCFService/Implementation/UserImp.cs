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
                    user.Password = Config.GeneratePassword(user.Password);
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
            using (var context = Config.context)
            {
                try
                {
                    var item = context.C_User.Single(i => i.id == user.Id);
                    item.id = user.Id;
                    item.username = user.Username;
                    item.email = user.Email;
                    context.SaveChanges();
                    completed = true;
                }
                catch (Exception ex)
                {
                    // log here
                }
            }
            return completed;
        }

        public User FindUserById(int id)
        {
            using (var context = Config.context)
            {
                try
                {
                    var data = context.C_User.Single(i => i.id == id);
                    return Convert(data);  
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
            User user = null;
            using (var context = Config.context)
            {
                try
                {
                    password = Config.GeneratePassword(password);
                    var data = context.C_User.Single(i => i.username == username);
                    if (Config.RemoveSalt(data.password) == Config.RemoveSalt(password))
                    {
                        user = Convert(data);
                    }  
                }
                catch (Exception ex)
                {
                    // log here
                }
            }
            return user;
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
