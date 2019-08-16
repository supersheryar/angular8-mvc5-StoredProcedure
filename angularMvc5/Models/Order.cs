using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace angularMvc5.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderNumber { get; set; }
        public int CustomerId { get; set; }
        public double TotalAmount { get; set; }

        public Customer Customer { get; set; }

        public Order(DataRow row)
        {
            this.Id = Convert.ToInt32(row["Id"]);
            this.OrderDate = Convert.ToDateTime(row["OrderDate"]);
            this.OrderNumber = Convert.ToInt32(row["OrderNumber"]);
            this.CustomerId = Convert.ToInt32(row["CustomerId"]);
            this.TotalAmount = Convert.ToDouble(row["TotalAmount"]);
        }
    }
}