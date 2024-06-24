using EKStore.Areas.Customer.Services.Interfaces;
using EKStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EKStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }


    }
}

