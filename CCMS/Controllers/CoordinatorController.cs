using Microsoft.AspNetCore.Mvc;

namespace CCMS.Controllers
{
    public class CoordinatorController : Controller
    {
        // Load the review claims page for coordinators
        public IActionResult ReviewClaims()
        {
            return View();
        }
    }
}
