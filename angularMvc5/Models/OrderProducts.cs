using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace angularMvc5.Models
{
    public class OrderProducts
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public double UnitPrice { get; set; }
        public double Quantity { get; set; }

        public Product Product { get; set; }
        public Order Order { get; set; }

        public OrderProducts(DataRow row)
        {
            this.OrderId = Convert.ToInt32(row["OrderId"]);
            this.ProductId = Convert.ToInt32(row["ProductId"]);
            this.UnitPrice = Convert.ToDouble(row["UnitPrice"]);
            this.Quantity = Convert.ToDouble(row["Quantity"]);
        }
    }
}