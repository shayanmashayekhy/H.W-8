using Microsoft.AspNetCore.Mvc;

namespace H.W08.Controllers
{
    public class UserContorolls : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}
