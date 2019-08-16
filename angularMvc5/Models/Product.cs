using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace angularMvc5.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int SupplierId { get; set; }
        public double UnitPrice { get; set; }
        public string Package { get; set; }
        public bool IsDiscontinued { get; set; }

        public Supplier Supplier { get; set; }
         
        public Product(DataRow row)
        {
            this.Id = Convert.ToInt32(row["Id"]);
            this.ProductName = row["ProductName"].ToString();
            this.SupplierId = Convert.ToInt32(row["SupplierId"]);
            this.UnitPrice = Convert.ToDouble(row["UnitPrice"]);
            this.Package = row["Package"].ToString();
            this.IsDiscontinued = Convert.ToBoolean(row["IsDiscontinued"]);
        }
    }
}