using Microsoft.AspNetCore.Mvc;

namespace TaskManagment.web.Controllers
{
    public class ErrorController : BaseController
    {
        public ErrorController()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public async Task<IActionResult> Unknown()
        {
            return View("Error");
        }
    }
}
