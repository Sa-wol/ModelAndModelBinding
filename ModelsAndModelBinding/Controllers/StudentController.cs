using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelsAndModelBinding.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ModelsAndModelBinding.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet] // When user navigates to URL
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost] // Call this Add method after user posts form data
        public IActionResult Add(IFormCollection form)
        {
            // Need server-side validation for all data

            Student stu = new Student();
            stu.FullName = form["full_name"];
            stu.DateOfBirth = Convert.ToDateTime(form["dob"]);
            stu.PhoneNumber = form["home_phone"];
            stu.EmailAddress = form["email"];

            // Add to database

            ViewData["Added"] = true;

            return View();
        }
    }
}