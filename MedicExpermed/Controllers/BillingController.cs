using Microsoft.AspNetCore.Mvc;

namespace medic_system.Controllers
{
    public class BillingController : Controller
    {
        public IActionResult Billing()
        {
            return View();
        }
    }
}
