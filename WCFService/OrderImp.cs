using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFService
{

    public class OrderImp : IOrder
    {

        public bool Insert(Order order)
        {
            bool completed = false;
            
            return completed;
        }

        public bool Remove(Order order)
        {
            bool completed = false;
            using (var context = Config.context)
            {
                try
                {
                    var item = context.C_Order.Single(i => i.id == order.Id);
                    var data = context.C_Order.Remove(item);
                    completed = true;
                }
                catch (Exception ex)
                {
                    // log here
                }
            }
            return completed;
        }

        public bool Edit(Order order)
        {
            bool completed = false;
            
            return completed;
        }

        public Order FindOrderById(int id)
        {
            using (var context = Config.context)
            {
                try
                {
                    var data = context.C_Product.Single(i => i.id == id);
                    Order order = new Order();
                    
                    return order;
                }
                catch (Exception ex)
                {
                    // log here
                }
            }
            return null;
        }

        public List<Order> FindOrdersByUser(User user)
        {
            using (var context = Config.context)
            {
                try
                {
                    var data = context.C_Order.Select(i => i.C_User.id == user.Id);
                    List<Order> orders = new List<Order>();
                    
                    return orders;
                    
                }
                catch (Exception ex)
                {
                    // log here
                }
            }
            return null;
        }

        public C_Order Convert(Order order)
        {
            C_Order cOrder = new C_Order();
            cOrder.id = order.Id;
            //cOrder.userId = order.User.Id;
            //cOrder.C_OrderItems
            cOrder.money = order.Money;
            cOrder.timestamp = order.Timestamp;
            return cOrder;
        }

        public Order Convert(C_Order cOrder)
        {
            Order order = new Order();
            order.Id = cOrder.id;
            //order.User = 
            //order.Items = cOrder.C_OrderItems.ToList();
            order.Money = (decimal)cOrder.money;
            order.Timestamp = cOrder.timestamp;
            return order;
        }

    }
}
