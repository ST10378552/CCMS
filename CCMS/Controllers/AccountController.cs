using Microsoft.AspNetCore.Mvc;

namespace CCMS.Controllers
{
    public class AccountController : Controller
    {
        // GET: /Account/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            // Simulate a login process. In reality, you'd verify credentials here.
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                // Set a session variable or use TempData to simulate login
                HttpContext.Session.SetString("User", username);

                // Redirect to home page or dashboard
                return RedirectToAction("Index", "Home");
            }

            // If login fails, show the login page again
            ViewBag.Error = "Invalid credentials";
            return View();
        }

        // GET: /Account/Logout
        public IActionResult Logout()
        {
            // Clear session or simulated login state
            HttpContext.Session.Remove("User");

            return RedirectToAction("Index", "Home");
        }
    
}
}
