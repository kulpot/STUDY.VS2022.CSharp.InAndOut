using Microsoft.AspNetCore.Mvc;

namespace InAndOut.Controllers
{
    //Step-3
    [Route("Admin/[controller]")]

    public class ContactController : Controller //need to define contact page
    {
        //Step-4
        [Route("Main")]

        public IActionResult Index()
        {
            return Ok("Action main called");
        }

        //Step-5
        [Route("Details/{id?}")]

        public IActionResult SomeActionName(int id)
        {
            return Ok("Action main called");
        }
    }
}
