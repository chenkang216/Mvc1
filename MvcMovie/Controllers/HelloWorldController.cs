using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public string Index()
        {
            return "This is index action.";
        }

        public string HelloWorld()
        {
            return "This is hello world action.";
        }

        public string Welcome(string name, int id = 1)
        {
            return HttpUtility.HtmlEncode(string.Format("Hello {0}, numTimes is {1}", name, id));
        }
    }
}