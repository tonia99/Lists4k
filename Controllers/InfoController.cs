using Microsoft.AspNetCore.Mvc;

namespace Laba1FP.Controllers
{
    [Route("api/[controller]")]
    public class InfoController : Controller
    {
        // GET
        public IActionResult Get()
        {
            return View("index");
        }
    }
}