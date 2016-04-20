using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        public ActionResult Index()
        {
            //return "This is my <b>default</b> action...";
            return View();
        }

        public ActionResult Test()
        {
            ViewBag.Name = "Robert Robbins";
            return View();
        }

        public ActionResult Example()
        {
            ViewBag.Name = "Robert Robbins";
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}