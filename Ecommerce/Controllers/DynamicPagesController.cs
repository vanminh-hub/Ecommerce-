using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    public class DynamicPagesController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
        public IActionResult Blog()
        {
            return View("Blog");
        }
        public IActionResult About()
        {
            return View("About");
        }
        public IActionResult Shop()
        {
            return View("Shop");
        }
        public IActionResult ShopSingle()
        {
            return View("ShopSingle");
        }
    }
}