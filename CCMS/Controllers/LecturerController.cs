using Microsoft.AspNetCore.Mvc;

namespace CCMS.Controllers
{
    public class LecturerController : Controller
    {
        // Load the claim submission form
        public IActionResult SubmitClaim()
        {
            return View();
        }

        // Load the claim tracking page
        public IActionResult TrackClaim()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }
    }
}
