using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductImp" in both code and config file together.
    public class ProductImp : IProduct
    {

        public bool Insert(Product product)
        {
            bool completed = false;
            using (var context = Config.context)
            {
                try
                {
                    var data = context.C_Product.Add(Convert(product));
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

        public bool Remove(Product product)
        {
            bool completed = false;
            using (var context = Config.context)
            {
                try
                {
                    var item = context.C_Product.Single(i => i.id == product.Id);
                    var data = context.C_Product.Remove(item);
                    completed = true;
                }
                catch (Exception ex)
                {
                    // log here
                }
            }
            return completed;
        }

        public bool Edit(Product product)
        {
            /*
            bool completed = false;
            using (var context = Config.context)
            {
                try
                {
                    var item = context.C_Product.Single(i => i.id == product.Id);
                    var data = Convert(product);
                    context.SaveChanges();
                    completed = true;
                }
                catch (Exception ex)
                {
                    // log here
                }
            }
            return completed;
            */
            return false;
        }

        public Product FindProductById(int id)
        {
            Product product = new Product();
            using (var context = Config.context)
            {
                try
                {
                    var data = context.C_Product.Single(i => i.id == id);
                    return Convert(data);                    
                }
                catch (Exception ex)
                {
                    // log here
                }
            }
            return product;
        }

        public List<Product> GetProductList()
        {
            List<Product> products = new List<Product>();

            using (var context = Config.context)
            {
                try
                {
                    
                    var data = context.C_Product.Select(i => i);
                    foreach (C_Product item in data)
                    {
                        products.Add(Convert(item));
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
