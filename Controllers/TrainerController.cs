//using Microsoft.AspNetCore.Mvc;

//namespace All_In_One_Fitness_App.Controllers
//{
//    public class TrainerController : Controller
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
    //[Authorize(Roles = "Trainer")]
    public class TrainerController : Controller
    {
        // Trainer Dashboard
        public IActionResult Dashboard()
        {
            return View();
        }

        // View schedules
        public IActionResult Schedules()
        {
            return View();
        }

        // Attendance view
        public IActionResult Attendance()
        {
            return View();
        }

        // Upload training videos
        public IActionResult Videos()
        {
            return View();
        }
    }
}
