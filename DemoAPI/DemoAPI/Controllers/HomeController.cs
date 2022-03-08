using DemoAPI.Models;
using Lib.Entity;
using Lib.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private TKservice tkService;
        public HomeController(TKservice tkService, ILogger<HomeController> logger)
        {
            _logger = logger;
            this.tkService = tkService;
        }

        public IActionResult Index()
        {
            List<TK> tkList = tkService.GetTKList();
            /*TK tk = new TK();
            tk.taikhoan = "tuyen123";
            tk.matkhau = "1";
            tk.vitri = "a";
            tkService.InsertTK(tk);*/

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