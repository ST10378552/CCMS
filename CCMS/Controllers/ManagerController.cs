using Microsoft.AspNetCore.Mvc;

namespace CCMS.Controllers
{
    public class ManagerController : Controller
    {
        // Load the approve claims page for academic managers
        public IActionResult ApproveClaims()
        {
            return View();
        }
    }
}
