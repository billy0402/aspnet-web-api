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
        public int Post([FromBody] tCustomer data)
        {
            int num = 0;
            try
            {
                tCustomer customer = new tCustomer();
                customer.fName = data.fName;
                customer.fPhone = data.fPhone;
                customer.fEmail = data.fEmail;
                customer.fAddress = data.fAddress;
                db.tCustomer.Add(customer);
                num = db.SaveChanges();
            }
            catch (Exception e)
            {
                num = 0;
            }


            return num;
        }

        // PUT: api/Customer/5
        public int Put(int fId, [FromBody] tCustomer data)
        {
            int num = 0;
            try
            {
                tCustomer customer = db.tCustomer.Where(m => m.fId == fId).FirstOrDefault();
                customer.fName = data.fName;
                customer.fPhone = data.fPhone;
                customer.fEmail = data.fEmail;
                customer.fAddress = data.fAddress;
                num = db.SaveChanges();
            }
            catch (Exception e)
            {
                num = 0;
            }


            return num;
        }

        // DELETE: api/Customer/5
        public int Delete(int fId)
        {
            int num = 0;
            try
            {
                tCustomer customer = db.tCustomer.Where(m => m.fId == fId).FirstOrDefault();
                db.tCustomer.Remove(customer);
                num = db.SaveChanges();
            }
            catch (Exception e)
            {
                num = 0;
            }


            return num;
        }
    }
}
