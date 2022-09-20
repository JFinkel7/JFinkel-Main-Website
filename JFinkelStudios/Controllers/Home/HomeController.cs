using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace JFinkelStudios.Controllers.Home {
    public class HomeController : Controller {


        [HttpGet]
        public IActionResult Index() {
            return View();

        }
        // ADDED 
        [HttpGet]
        public IActionResult About() {
            return View();

        }

        // ADDED 
        [HttpGet]
        public IActionResult MyStory() {
            return View();

        }

        // ADDED 
        [HttpGet]
        public IActionResult Resume() {
            return View();

        }

    }
}
