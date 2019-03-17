using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using ReactNetTest.Models.BlogPost;
using ReactNetTest.Models.React;

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
                Name = "Nicholas",
                Date = DateTime.Now.ToShortDateString(),
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit"
            },
            new Comment
            {
                Name = "Nicholas",
                Date = DateTime.Now.ToShortDateString(),
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit"
            },
            new Comment
            {
                Name = "Nicholas",
                Date = DateTime.Now.ToShortDateString(),
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit"
            }
        };

        public ActionResult Index()
        {
            //This result dosen't make sense on a normal MVC site, since the layout won't be loaded 
            //return new ReactResult<BlogPost>("BlogPost", BlogPost);
            return View(BlogPost);
        }

        public ActionResult GetComments()
        {
            Thread.Sleep(3000);
            return new Models.Json.JsonResult(Comments);
        }
    }
}