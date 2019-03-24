using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ReactNetTest.Models.Person;

namespace ReactNetTest.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult Overview()
        {
            var model = new PersonOverview
            {
                OverviewTitle = "Title From Server",
                OverviewManchet =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua"
            };
            return View(model);
        }
    }
}