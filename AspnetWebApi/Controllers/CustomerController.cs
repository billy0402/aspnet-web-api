using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using AspnetWebApi.Models;

namespace AspnetWebApi.Controllers
{
    public class CustomerController : ApiController
    {
        dbCustomerEntities db = new dbCustomerEntities();

        // GET: api/Customer
        public List<tCustomer> Get()
        {
            var customers = db.tCustomer;
            return customers.ToList();
        }

        // GET: api/Customer/5
        public tCustomer Get(int fId)
        {
            var customers = db.tCustomer.Where(m => m.fId == fId).FirstOrDefault();
            return customers;
        }

        // POST: api/Customer
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Customer/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Customer/5
        public void Delete(int id)
        {
        }
    }
}
