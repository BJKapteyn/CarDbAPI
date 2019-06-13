using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CarDealership.Models;
using Newtonsoft.Json.Linq;

namespace CarDealership.Controllers
{
    public class ValuesController : ApiController
    {
        List<string> dbase = new List<string>() { "Jimmy", "Sally", "Corporal Dan" };
        // GET api/values
        CarDealershipDBEntities db = new CarDealershipDBEntities();
        public IEnumerable<Car> Get()
        {
            return db.Cars;
        }

        // GET api/values/5
        public Car Get(int id)
        {
            if(id >= 0 && id < db.Cars.ToArray().Length)
            {
                return db.Cars.Find(id);
            }
            else
            {
                Car c = new Car();
                c.Make = "Ya Blew It";
                return c;
            }
        }

        // POST creating new
        public void Post([FromBody]Car car)
        {

        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Car car)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
