using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TwitterGate.DAL;

namespace AlaaDamiri.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            cntMongo cnt = new cntMongo();
            List<entTweetView> lst =  cnt.GetTopFiveTweetsOrderedByRetweets();
            return View(lst);
        }
    }
}
