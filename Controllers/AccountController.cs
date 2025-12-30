////using Microsoft.AspNetCore.Mvc;

////namespace All_In_One_Fitness_App.Controllers
////{
////    public class AccountController : Controller
////    {
////        public IActionResult Index()
////        {
////            return View();
////        }
////    }
////}


//using Microsoft.AspNetCore.Mvc;

//namespace All_In_One_Fitness_App.Controllers
//{
//    public class AccountController : Controller
//    {
//        // GET: Login Page
//        public IActionResult Login()
//        {
//            return View();
//        }

//        // POST: Login Logic
//        [HttpPost]
//        public IActionResult Login(string username, string password, string role)
//        {
//            // SIMPLE DEMO LOGIN (for now)
//            if (role == "Admin")
//                return RedirectToAction("Dashboard", "Admin");

//            if (role == "Expert")
//                return RedirectToAction("Dashboard", "Expert");

//            if (role == "Trainer")
//                return RedirectToAction("Dashboard", "Trainer");

//            if (role == "User")
//                return RedirectToAction("Dashboard", "Users");

//            ViewBag.Error = "Invalid login details";
//            return View();
//        }

//        public IActionResult Logout()
//        {
//            return RedirectToAction("Index", "Home");
//        }
//    }
//}




using Microsoft.AspNetCore.Mvc;

namespace All_In_One_Fitness_App.Controllers
{
    public class AccountController : Controller
    {
        // GET: Login Page
        public IActionResult Login()
        {
            return View();
        }

        // POST: Login Logic
        [HttpPost]
        public IActionResult Login(string username, string password, string role)
        {
            // 🔑 STORE ROLE IN SESSION
            HttpContext.Session.SetString("UserRole", role);

            // SIMPLE DEMO LOGIN (FLOW CONTROL)
            if (role == "Admin")
                return RedirectToAction("Dashboard", "Admin");

            if (role == "Expert")
                return RedirectToAction("Dashboard", "Expert");

            if (role == "Trainer")
                return RedirectToAction("Dashboard", "Trainer");

            if (role == "User")
                return RedirectToAction("Dashboard", "Users");

           
            return View();
        }

        public IActionResult Logout()
        {
            // CLEAR SESSION ON LOGOUT
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
