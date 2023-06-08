using Microsoft.AspNetCore.Mvc;
using Task_PurpleBuzz.Models;
using Task_PurpleBuzz.ViewModels.Home;

namespace Task_PurpleBuzz.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
