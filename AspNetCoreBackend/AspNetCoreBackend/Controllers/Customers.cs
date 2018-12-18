using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreBackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace AspNetCoreBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        public List<Customers> GetAll()
        {
            NorthwindContext context = new NorthwindContext();
            List<Customers> asiakkaat = context.Customers.ToList();
            return asiakkaat;
        }
        [Route("{key}")]
      
            public Customers GetSingle(string key)
            {
                NorthwindContext context = new NorthwindContext();
            Customers asiakas = context.Customers.Find(key);
                return asiakas;
            }
        }
    }
