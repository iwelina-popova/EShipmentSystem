using Microsoft.AspNetCore.Mvc;

namespace EShipmentSystem.Web.Controllers
{
    [Route("api/[controller]")]
    public class ShipmentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}