using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WCFService
{
    class BasketImp : IBasket
    {
        public bool Insert(int userId, int productId)
        {
            bool completed = false;
            using (var context = Config.context)
            {
                try
                {
                    var user = context.C_User.Single(i => i.id == userId);
                    var product = context.C_Product.Single(i => i.id == productId);
                    C_Basket basket = new C_Basket();
                    basket.userId = user.id;
                    basket.productId = product.id;
                    var data = context.C_Basket.Add(basket);
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

        public bool Remove(int id)
        {
            bool completed = false;
            using (var context = Config.context)
            {
                try
                {
                    var item = context.C_Basket.Single(i => i.id == id);
                    var data = context.C_Basket.Remove(item);
                    completed = true;
                }
                catch (Exception ex)
                {
                    // log here
                }
            }
            return completed;
        }

        public List<Product> FindProductsByUser(int id)
        {
            List<Product> products = new List<Product>();
            using (var context = Config.context)
            {
                try
                {
                    var data =
                     context.C_Basket
                        .Where(c => c.userId == id)
                        .Select(c => new { c.C_Product });
                    
                    foreach (var item in data)
                    {
                        products.Add(Convert(item.C_Product));
                    }
                }
                catch (Exception ex)
                {
                    // log here
                }
            }
            return products;
        }

        

        public C_Product Convert(Product product)
        {
            C_Product cProduct = new C_Product();
            cProduct.id = product.Id;
            cProduct.name = product.Name;
            cProduct.description = product.Description;
            cProduct.price = product.Price;
            cProduct.timestamp = product.Timestamp;
            return cProduct;
        }

        public Product Convert(C_Product cProduct)
        {
            Product product = new Product();
            product.Id = cProduct.id;
            product.Name = cProduct.name;
            product.Description = cProduct.description;
            product.Price = cProduct.price;
            product.Timestamp = cProduct.timestamp;
            return product;
        }
    }
}
