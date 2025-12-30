//using Microsoft.AspNetCore.Mvc;

//namespace All_In_One_Fitness_App.Controllers
//{
//    public class ExpertController : Controller
//    {
//        public IActionResult Index()
//        {
//            return View();
//        }
//    }
//}



//using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace All_In_One_Fitness_App.Controllers
{
    //[Authorize(Roles = "Expert")]
    public class ExpertController : Controller
    {
        // Expert Dashboard
        public IActionResult Dashboard()
        {
            return View();
        }

        // Interact with users
        public IActionResult Interactions()
        {
            return View();
        }

        // Health tips
        public IActionResult HealthTips()
        {
            return View();
        }

        // Complaints
        public IActionResult Complaints()
        {
            return View();
        }
        
        
    }
}
