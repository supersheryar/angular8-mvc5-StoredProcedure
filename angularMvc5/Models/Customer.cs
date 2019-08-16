using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace angularMvc5.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }

        public Customer(DataRow row)
        {
            this.Id = Convert.ToInt32(row["Id"]);
            this.FirstName = row["FirstName"].ToString();
            this.LastName = row["LastName"].ToString();
            this.City = row["City"].ToString();
            this.Country = row["Country"].ToString();
            this.Phone = row["Phone"].ToString();
        }
    }
}