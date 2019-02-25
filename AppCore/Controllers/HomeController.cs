using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppCore.Models;

namespace AppCore.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-model?view=aspnetcore-2.2&tabs=visual-studio
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            ViewData["MachineName"] = string.Format("{0} - ({1}) -  {2} - ({3}) - {4}",
                                                Environment.MachineName,
                                                Environment.OSVersion,
                                                Environment.UserName,
                                                Environment.UserDomainName,
                                                Environment.CurrentDirectory);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
