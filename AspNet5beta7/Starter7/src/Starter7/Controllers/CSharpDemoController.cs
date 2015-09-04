using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Starter7.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Starter7.Controllers
{
    public class CSharpDemoController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            // before
            var personBefore = new Person();
            ViewBag.PersonBefore = personBefore.GetTestData("personBefore");

            // after
            var personAfter = new Person6() { FirstName = "Michael", LastName = "Palermo" };
            ViewBag.PersonAfter = personAfter.GetTestData(nameof(personAfter));

            return View();
        }
    }
}
