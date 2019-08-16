using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace angularMvc5.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

        public Supplier(DataRow row)
        {
            this.Id = Convert.ToInt32(row["Id"]);
            this.CompanyName = row["CompanyName"].ToString();
            this.ContactName = row["ContactName"].ToString();
            this.ContactTitle = row["ContactTitle"].ToString();
            this.City = row["City"].ToString();
            this.Country = row["Country"].ToString();
            this.Phone = row["Phone"].ToString();
            this.Fax = row["Fax"].ToString();
        }
    }
}