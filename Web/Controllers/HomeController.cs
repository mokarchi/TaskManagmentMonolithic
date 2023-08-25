using Microsoft.AspNetCore.Mvc;

namespace TaskManagment.web.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController()
        {

        }

        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
