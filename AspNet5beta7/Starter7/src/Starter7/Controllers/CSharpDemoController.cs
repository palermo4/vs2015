using Microsoft.AspNet.Mvc;
using Starter7.Models;

namespace Starter7.Controllers
{
    public class CSharpDemoController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            // before
            var pb = new Person();
            ViewBag.PersonBefore = 
                pb.GetTestData("personBefore");

            // after
            var p6 = new Person6() {FirstName="Michael", LastName="Palermo" };
            ViewBag.PersonAfter =
                p6.GetTestData(nameof(p6));

            return View();
        }
    }
}
