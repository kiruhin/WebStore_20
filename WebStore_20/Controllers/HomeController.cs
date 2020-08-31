﻿using Microsoft.AspNetCore.Mvc;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            //return StatusCode(500);
            //return new RedirectResult("https://google.com");
            //return RedirectToAction("Blog", "Home");
            //return PartialView("_Partial/_LeftSideBar");
            //return new JsonResult("");
            //return new NotFoundResult();
            //return new FileContentResult();
            //return new EmptyResult();
            //return Content("Hello from controller");
            return View();
        }

        // GET: /<controller>/blog
        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult Shop()
        {
            return View();
        }

        public IActionResult ProductDetails()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult BlogSingle()
        {
            return View();
        }

        public IActionResult NotFound()
        {
            return View();
        }
    }

}
