using Microsoft.AspNetCore.Mvc;
using System;

namespace InAndOut.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
            //string todaysDate = DateTime.Now.ToShortDateString();
            //return Ok(todaysDate);
        }

        public IActionResult Details(int id)
        {
            return Ok("You have entered id = " + id);
        }

        public IActionResult GetSomeData([FromQuery]string values)
        {
            return Ok("The value : " + values + " is from Query string");
        }
    }
}
