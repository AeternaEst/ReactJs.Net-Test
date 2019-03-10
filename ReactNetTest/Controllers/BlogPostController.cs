using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using ReactNetTest.Models.BlogPost;

namespace ReactNetTest.Controllers
{
    public class BlogPostController : Controller
    {
        private BlogPost BlogPost = new BlogPost
        {
            Title = "Amazing Title",
            Subject = "Amazing Subject",
            Date = DateTime.Now.ToShortDateString(),
            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua"
        };

        private IEnumerable<Comment> Comments = new List<Comment>
        {
            new Comment
            {
                name = "Nicholas",
                date = DateTime.Now.ToShortDateString(),
                text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit"
            },
            new Comment
            {
                name = "Nicholas",
                date = DateTime.Now.ToShortDateString(),
                text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit"
            },
            new Comment
            {
                name = "Nicholas",
                date = DateTime.Now.ToShortDateString(),
                text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit"
            }
        };

        public ActionResult Index()
        {
            return View(BlogPost);
        }

        public ActionResult GetComments()
        {
            Thread.Sleep(3000);
            return Json(Comments, JsonRequestBehavior.AllowGet);
        }
    }
}