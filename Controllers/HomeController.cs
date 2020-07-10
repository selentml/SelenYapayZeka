using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SelenYapayZekaGit.Classes.String;
using SelenYapayZekaGit.Models;


namespace SelenYapayZekaGit.Controllers
{
    public class HomeController : Controller
    {
    
        
        
        public IActionResult Index()
        {
            ViewBag.Title = "Anasayfa".AsTitle();
            return View();
        }


    }
}
