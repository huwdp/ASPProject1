using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace WebClient
{
    public class Database
    {
        private static Database instance;

        EndpointAddress userEp;
        EndpointAddress productEp;
        EndpointAddress orderEp;
        EndpointAddress basketEp;
        IUser userProxy;
        IProduct productProxy;
        IOrder orderProxy;
        IBasket basketProxy;

        
        private Database()
        {
            userEp =  new EndpointAddress("http://localhost:8733/WCFService/UserImp/");
            userProxy = ChannelFactory<IUser>.CreateChannel(new BasicHttpBinding(), userEp);

            orderEp =  new EndpointAddress("http://localhost:8733/WCFService/OrderImp/");
            orderProxy = ChannelFactory<IOrder>.CreateChannel(new BasicHttpBinding(), orderEp);

            productEp =  new EndpointAddress("http://localhost:8733/WCFService/ProductImp/");
            productProxy = ChannelFactory<IProduct>.CreateChannel(new BasicHttpBinding(), productEp);

            basketEp = new EndpointAddress("http://localhost:8733/WCFService/BasketImp/");
            basketProxy = ChannelFactory<IBasket>.CreateChannel(new BasicHttpBinding(), basketEp);
        }

        public static Database Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Database();
                }
                return instance;
            }
        }

        public IUser UserProxy
        {
            get { return userProxy; }
        }

        public IProduct ProductProxy
        {
            get { return productProxy; }
        }

        public IOrder OrderProxy
        {
            get { return orderProxy; }
        }

        public IBasket BasketProxy
        {
            get { return basketProxy; }
        }
    }
}