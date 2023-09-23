using Example01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;

namespace Example01.Controllers
{
    public class PartialController : Controller
    {
        // GET: Partial
        public ActionResult Products()
        {
            var product = new Product
            {
                Name = "Samsung S21 5g",
                Price = 15000
            };
            return View(product);
        }
    }
}