using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.ViewModels;

namespace WebStore.Controllers
{
    /// <summary>
    /// Examples of types returned
    /// </summary>
    public class ActionResultsController : Controller
    {
        /// <summary>
        /// Example return View
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Example return any string
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public IActionResult MereContentString(string name)
        {
            return Content($"Hi, {name}. I'm mere string content result");
        }

        /// <summary>
        /// Returns nothing and StatusCode = 200
        /// </summary>
        /// <returns></returns>
        public IActionResult Nothing()
        {
            return new EmptyResult();
        }

        /// <summary>
        /// Returns nothing and StatusCode = 204
        /// </summary>
        /// <returns></returns>
        public IActionResult Nothing204()
        {
            return new NoContentResult();
        }

        /// <summary>
        /// Return json-object
        /// </summary>
        /// <returns></returns>
        public JsonResult JsonObjectSerialized()
        {
            var employee = new EmployeeViewModel
            {
                Id = 1,
                FirstName = "Иван",
                SurName = "Иванов",
                Patronymic = "Иванович",
                Age = 22,
                Position = "Начальник"
            };

            return Json(employee);
        }

        /// <summary>
        /// Return to Google
        /// </summary>
        /// <returns></returns>
        public IActionResult GoGoogle()
        {
            return Redirect("https://google.com");
        }

        /// <summary>
        /// Return Home-page
        /// </summary>
        /// <returns></returns>
        public IActionResult GoToHomePage()
        {
            return LocalRedirect("~/Home/Index");
        }

        /// <summary>
        /// Redirection with parameters
        /// </summary>
        /// <returns></returns>
        public IActionResult RedirectWithParameters()
        {
            return RedirectToAction("MereContentString", "ActionResults", new { name = "Dear user" });
        }

        /// <summary>
        /// Return forbidden resourse
        /// </summary>
        /// <returns></returns>
        public IActionResult ForbiddenResource()
        {
            //return Forbid(); // the same
            return StatusCode(403);
        }

        public IActionResult NotFoundResource()
        {
            //return StatusCode(404, "Nothing found. Sorry.");
            return NotFound("Nothing found. Sorry.");
        }

        public IActionResult AgeCheck(int age)
        {
            if (age < 18)
                return Unauthorized("Sorry. Adults only");

            return Content("You're welcome");
        }

        public IActionResult TellMeItsOk()
        {
            return Ok("Everything is gonna be fine!");
        }

        public IActionResult ReallyBadRequest(string s)
        {
            if (String.IsNullOrEmpty(s))
                return BadRequest("Some parameter was expected");
            
            return View("Index");
        }

        public IActionResult GetFile()
        {
            // Путь к файлу
            string file_path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/blog/man-two.jpg");
            // Тип файла - content-type
            string file_type = "image/jpeg";
            // Имя файла - необязательно
            string file_name = "My awesome ring.jpg";
            return PhysicalFile(file_path, file_type, file_name);
        }

        // Отправка массива байтов
        public FileResult GetBytes()
        {
            string file_path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/15.jpg");
            byte[] mas = System.IO.File.ReadAllBytes(file_path);
            string file_type = "image/jpeg";
            string file_name = "My awesome ring.jpg";
            return File(mas, file_type, file_name);
        }

        // Отправка потока
        public FileResult GetStream()
        {
            string file_path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/15.jpg");
            FileStream fs = new FileStream(file_path, FileMode.Open);
            string file_type = "image/jpeg";
            string file_name = "My awesome ring.jpg";
            return File(fs, file_type, file_name);
        }
    }

}
