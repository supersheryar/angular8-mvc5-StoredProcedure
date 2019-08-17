using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using angularMvc5.Controllers.Core;
using angularMvc5.Models;

namespace angularMvc5.Controllers.Api
{
    public class OrderProductsController : ApiController
    {
        private List<OrderProducts> OrderProducts { get; set; }

        public OrderProductsController()
        {
            SystemController.Instance.LoadData();
            OrderProducts = SystemController.Instance.OrderProducts;
        }
        // GET: api/OrderProducts
        public IEnumerable<OrderProducts> Get()
        {
            return OrderProducts;
        }

        // GET: api/OrderProducts/5
        public OrderProducts Get(int id)
        {
            return OrderProducts.FirstOrDefault(i => i.OrderId == id);
        }

        // POST: api/OrderProducts
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/OrderProducts/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/OrderProducts/5
        public void Delete(int id)
        {
        }
    }
}
