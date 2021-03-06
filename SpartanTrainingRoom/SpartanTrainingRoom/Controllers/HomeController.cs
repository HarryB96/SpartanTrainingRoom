﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpartanTrainingRoom.Models;
using SpartanTrainingRoom.ViewModels;

namespace SpartanTrainingRoom.Controllers
{
    public class HomeController : Controller
    {
        private readonly TrainingDbModel _context;
        public HomeController(TrainingDbModel context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Questions1()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Questions2()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Questions3()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Questions4()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Questions5()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Questions6()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Questions7()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Questions8()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Questions9()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Questions10()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Complete()
        {
            ViewData["Message"] = "Your contact page.";

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

        public IActionResult AdminDashboard()
        {
            AdminViewModel adminViewModel = new AdminViewModel(_context.Users, _context.Course);
            return View(adminViewModel);
        }
    }
}
