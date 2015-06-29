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
        public bool InsertOrderFromUser(int userId, Address address, Visa visa)
        {
            bool completed = false;
            using (var context = Config.context)
            {
                try
                {
                    C_Order order = new C_Order();

                    // Get products in baskets and add them to order
                    var data = context.C_Basket.Where(c => c.userId == userId).Select(c => new { c.C_Product });
                    foreach (var item in data)
                    {
                        C_OrderItem orderItem = new C_OrderItem();
                        orderItem.C_Product = item.C_Product;
                        order.C_OrderItem.Add(new C_OrderItem());
                    }

                    // Remove products in basket
                    var baskets = context.C_Basket.Where(i => i.userId == userId);
                    foreach (var item in baskets)
                        context.C_Basket.Remove(item);

                    // Setup order before adding it to database
                    order.userId = userId;
                    order.timestamp = DateTime.Now;

                    // Setup address



                    // Setup payment



                    context.C_Order.Add(order);

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

        public bool Insert(Order order)
        {
            bool completed = false;
            using (var context = Config.context)
            {
                try
                {
                    var data = context.C_Order.Add(Convert(order));
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
            using (var context = Config.context)
            {
                try
                {
                    var item = context.C_Order.Single(i => i.id == order.Id);

                    // As not everything cannot be implemented in the second layer
                    // Not everything can be changed, and thus cannot use Convert
                    // as it will break data in the database.

                    item.id = order.Id;
                    //item.money = order.Money;
                    //item.C_OrderItem
                    //item.C_User
                    item.timestamp = order.Timestamp;

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

        public List<Order> FindOrdersByUser(int id)
        {
            using (var context = Config.context)
            {
                try
                {
                    var data = context.C_Order.Select(i => i.C_User.id == id);
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
            //cOrder.money = order.Money;
            cOrder.timestamp = order.Timestamp;
            return cOrder;
        }

        public Order Convert(C_Order cOrder)
        {
            Order order = new Order();
            order.Id = cOrder.id;
            //order.User = 
            //order.Items = cOrder.C_OrderItems.ToList();
            //order.Money = (decimal)cOrder.money;
            order.Timestamp = cOrder.timestamp;
            return order;
        }

        public C_Visa Convert(Visa visa)
        {
            C_Visa cVisa = new C_Visa();
            cVisa.ValidDate = visa.ValidDate;
            cVisa.ExpiryDate = visa.ExpiryDate;
            cVisa.CardNumber = visa.CardNumber;
            cVisa.CardSecurityCode = visa.CardSecurityCode;
            return cVisa;
        }

        public Visa Convert(C_Visa cVisa)
        {
            Visa visa = new Visa();
            visa.ValidDate = cVisa.ValidDate;
            visa.ExpiryDate = cVisa.ExpiryDate;
            visa.CardNumber = cVisa.CardNumber;
            visa.CardSecurityCode = cVisa.CardSecurityCode;
            return visa;
        }
    }
}
