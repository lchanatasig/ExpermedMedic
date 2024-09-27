using Microsoft.AspNetCore.Mvc;

namespace medic_system.Controllers
{
    public class BillingController : Controller
    {
        public IActionResult Billing()
        {
            return View();
        }
 
        [HttpPost]
        public IActionResult Billing(int id)
        {



            return View();
        }

    }


}
