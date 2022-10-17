using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;

namespace TravelCup.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/

        /* public string Index()
         {
             return "This is my default action...";
         }*/

        // 
        // GET: /HelloWorld/Welcome/ 

        /*public string Welcome()
        {
            return "This is the Welcome action method...";
        }*/
        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
 /*       public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }*/

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
