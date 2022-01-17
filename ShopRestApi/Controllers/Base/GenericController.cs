using Microsoft.AspNetCore.Mvc;

namespace ShopRestApi.Controllers.Base
{
    public class GenericController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
