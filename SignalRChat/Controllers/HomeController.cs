using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using SignalRChat.Hubs;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //var X = from a in ChatHub2019Test.MemebersList select a;
            StringBuilder sb = new StringBuilder();
            String x = "ddd";
            //int e = int.Parse(x) * 2;
            //foreach (var element in X)
            //{
            //    sb.Append(element.memberID + "<br>");
            //}
            //Response.Headers.Add("test", "dd" + sb.ToString());
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
