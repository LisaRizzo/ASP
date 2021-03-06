﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserRegistrationForm.Models;

namespace UserRegistrationForm.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult Registration()
        {
            return View();
        }

        public ActionResult Result(User inputUser)
        {
            //ViewBag.Firstname = inputUser.Firstname;
            //ViewBag.Lastname = inputUser.Lastname;
            //ViewBag.Email = inputUser.Email;
            //ViewBag.Password = inputUser.Password;
            //ViewBag.Phone = inputUser.Phone;

            return View(inputUser);
        }
    }
}