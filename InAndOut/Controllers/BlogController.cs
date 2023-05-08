using Microsoft.AspNetCore.Mvc;

namespace InAndOut.Controllers
{
    public class BlogController : Controller
    {
        
        public IActionResult Article()
        {
            //return View();
            return Ok("Action of Blog controller is called");
        }

        //Step-2
        [Route("Blog")]
        [Route("Blog/Index")]
        [Route("Blog/Index/{id?}")]

        public IActionResult AnyActionName(int id)
        {
            return Ok("Index called");
        }
    }
}
