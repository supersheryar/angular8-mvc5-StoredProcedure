using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using angularMvc5.Models;

namespace angularMvc5.Controllers.Core
{
    public class SystemController
    {
        internal DataLayerController DataLayerController { get; set; }
        internal List<OrderProducts> OrderProducts { get; set; }
        internal List<Order> Orders { get; set; }
        internal List<Product> Products { get; set; }
        internal List<Supplier> Suppliers { get; set; }
        internal List<Customer> Customers { get; set; }

        #region Singleton
        private static SystemController instance;

        private SystemController()
        {
            DataLayerController = new DataLayerController();
            Orders = new List<Order>();
            Products = new List<Product>();
            Suppliers = new List<Supplier>();
            Customers = new List<Customer>();
            OrderProducts = new List<OrderProducts>();
        }

        public static SystemController Instance
        {
            get
            {
                if (instance == null)
                    instance = new SystemController();
                return instance;
            }
        }
        #endregion

        public void LoadData()
        {
            var temProducts = new List<Product>();
            var temOrders = new List<Order>();
            var temOrderProducts = new List<OrderProducts>();

            temProducts = SystemController.Instance.DataLayerController.ExcuteObject<Product>("[dbo].[usp_GetProducts]", true).ToList();
            temOrders = SystemController.Instance.DataLayerController.ExcuteObject<Order>("[dbo].[usp_GetOrders]", true).ToList();
            this.Suppliers = SystemController.Instance.DataLayerController.ExcuteObject<Supplier>("[dbo].[usp_GetSuppliers]", true).ToList();
            this.Customers = SystemController.Instance.DataLayerController.ExcuteObject<Customer>("[dbo].[usp_GetCustomers]", true).ToList();
            temOrderProducts = SystemController.Instance.DataLayerController.ExcuteObject<OrderProducts>("[dbo].[usp_GetOrderProducts]", true).ToList();

            //assign supplier to products

            foreach (var item in temProducts)
            {
                var product = item;
                product.Supplier = this.Suppliers.Where(i => i.Id == item.SupplierId).FirstOrDefault();
                this.Products.Add(product);
            }
            //assign customers to orders
            foreach (var item in temOrders)
            {
                var order = item;
                order.Customer = this.Customers.Where(i => i.Id == item.CustomerId).FirstOrDefault();
                this.Orders.Add(order);
            }
            //assign data to orderproducts

            foreach (var item in temOrderProducts)
            {
                var orderPorducts = item;

                orderPorducts.Product = this.Products.Where(i => i.Id == item.ProductId).FirstOrDefault();
                orderPorducts.Order = this.Orders.Where(i => i.Id == item.OrderId).FirstOrDefault();

                this.OrderProducts.Add(orderPorducts);
            }

        }

    }
}