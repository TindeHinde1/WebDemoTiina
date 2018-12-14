using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreBackend.Controllers
{
    public class DEMOController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}