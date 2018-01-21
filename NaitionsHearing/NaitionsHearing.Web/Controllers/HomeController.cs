using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace NaitionsHearing.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var audienceuri = "http://localhost:49817/";
            HttpClient apiClient = new HttpClient();
            var requestUri = audienceuri + "/members/id/sai";
            var res = apiClient.GetAsync(requestUri).Result;
            var memberid = res.Content.ReadAsStringAsync();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}