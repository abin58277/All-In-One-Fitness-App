//using Microsoft.AspNetCore.Mvc;

//namespace All_In_One_Fitness_App.Controllers
//{
//    public class UserController : Controller
//    {
//        public IActionResult Index()
//        {
//            return View();
//        }
//    }
//}



//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;

//namespace All_In_One_Fitness_App.Controllers
//{
//    //[Authorize(Roles = "User")]
//    public class UsersController : Controller
//    {
//        // User Dashboard
//        public IActionResult Dashboard()
//        {
//            return View();
//        }

//        // View profile
//        public IActionResult Profile()
//        {
//            return View();
//        }

//        // Membership details
//        public IActionResult Membership()
//        {
//            return View();
//        }

//        // Attendance
//        public IActionResult Attendance()
//        {
//            return View();
//        }

//        // Events
//        public IActionResult Events()
//        {
//            return View();
//        }

//        // Health tips
//        public IActionResult HealthTips()
//        {
//            return View();
//        }

//        // Complaints
//        public IActionResult Complaints()
//        {
//            return View();
//        }
//    }
//}


//using Microsoft.AspNetCore.Mvc;
//using System;

//namespace All_In_One_Fitness_App.Controllers
//{
//    //[Authorize(Roles = "User")]
//    public class UsersController : Controller
//    {
//        // -----------------------------------
//        // USER DASHBOARD
//        // -----------------------------------
//        public IActionResult Dashboard()
//        {
//            return View();
//        }

//        // -----------------------------------
//        // USER PROFILE
//        // -----------------------------------
//        public IActionResult Profile()
//        {
//            return View();
//        }

//        // -----------------------------------
//        // MEMBERSHIP DETAILS
//        // -----------------------------------
//        public IActionResult Membership()
//        {
//            return View();
//        }

//        // -----------------------------------
//        // ATTENDANCE
//        // -----------------------------------
//        public IActionResult Attendance()
//        {
//            return View();
//        }

//        // -----------------------------------
//        // EVENTS
//        // -----------------------------------
//        public IActionResult Events()
//        {
//            return View();
//        }

//        // -----------------------------------
//        // HEALTH TIPS
//        // -----------------------------------
//        public IActionResult HealthTips()
//        {
//            return View();
//        }

//        // -----------------------------------
//        // COMPLAINTS
//        // -----------------------------------
//        public IActionResult Complaints()
//        {
//            return View();
//        }

//        // ===================================
//        // BMI CALCULATOR (GET)
//        // ===================================
//        public IActionResult BMICalculator()
//        {
//            return View();
//        }

//        // ===================================
//        // BMI CALCULATOR (POST)
//        // ===================================
//        [HttpPost]
//        public IActionResult BMICalculator(double height, double weight)
//        {
//            if (height <= 0 || weight <= 0)
//            {
//                ViewBag.Error = "Please enter valid height and weight values.";
//                return View();
//            }

//            // Convert height from cm to meters
//            double heightInMeters = height / 100;

//            // BMI formula
//            double bmi = weight / (heightInMeters * heightInMeters);
//            bmi = Math.Round(bmi, 2);

//            ViewBag.BMI = bmi;

//            if (bmi < 18.5)
//            {
//                ViewBag.Status = "Underweight";
//                ViewBag.Message = "You are underweight. Consider a nutritious diet and strength training.";
//                ViewBag.Color = "warning";
//            }
//            else if (bmi >= 18.5 && bmi < 24.9)
//            {
//                ViewBag.Status = "Normal";
//                ViewBag.Message = "Great! You have a healthy body weight. Keep it up!";
//                ViewBag.Color = "success";
//            }
//            else if (bmi >= 25 && bmi < 29.9)
//            {
//                ViewBag.Status = "Overweight";
//                ViewBag.Message = "You are slightly overweight. Regular exercise is recommended.";
//                ViewBag.Color = "warning";
//            }
//            else
//            {
//                ViewBag.Status = "Obese";
//                ViewBag.Message = "High health risk. Please consult a fitness expert or doctor.";
//                ViewBag.Color = "danger";
//            }

//            return View();
//        }
//    }
//}


using Microsoft.AspNetCore.Mvc;
using System;

namespace All_In_One_Fitness_App.Controllers
{
    //[Authorize(Roles = "User")]
    public class UsersController : Controller
    {
        // -----------------------------------
        // USER DASHBOARD
        // -----------------------------------
        public IActionResult Dashboard()
        {
            return View();
        }

        // -----------------------------------
        // USER PROFILE
        // -----------------------------------
        public IActionResult Profile()
        {
            return View();
        }

        // -----------------------------------
        // MEMBERSHIP DETAILS
        // -----------------------------------
        public IActionResult Membership()
        {
            return View();
        }

        // -----------------------------------
        // ATTENDANCE
        // -----------------------------------
        public IActionResult Attendance()
        {
            return View();
        }

        // -----------------------------------
        // EVENTS
        // -----------------------------------
        public IActionResult Events()
        {
            return View();
        }

        // -----------------------------------
        // HEALTH TIPS
        // -----------------------------------
        public IActionResult HealthTips()
        {
            return View();
        }

        // -----------------------------------
        // COMPLAINTS
        // -----------------------------------
        public IActionResult Complaints()
        {
            return View();
        }

        // ===================================
        // BMI CALCULATOR (GET)
        // ===================================
        [HttpGet]
        public IActionResult BMICalculator()
        {
            return View();
        }

        // ===================================
        // BMI CALCULATOR (POST)
        // ===================================
        [HttpPost]
        public IActionResult BMICalculator(double height, double weight)
        {
            if (height <= 0 || weight <= 0)
            {
                ViewBag.Error = "Please enter valid height and weight values.";
                return View();
            }

            // Convert height from cm to meters
            double heightInMeters = height / 100;

            // BMI formula
            double bmi = weight / (heightInMeters * heightInMeters);
            bmi = Math.Round(bmi, 2);

            ViewBag.BMI = bmi;

            if (bmi < 18.5)
            {
                ViewBag.Status = "Underweight";
                ViewBag.Message = "You are underweight. Consider a nutritious diet and strength training.";
                ViewBag.Color = "warning";
            }
            else if (bmi < 24.9)
            {
                ViewBag.Status = "Normal";
                ViewBag.Message = "Great! You have a healthy body weight. Keep it up!";
                ViewBag.Color = "success";
            }
            else if (bmi < 29.9)
            {
                ViewBag.Status = "Overweight";
                ViewBag.Message = "You are slightly overweight. Regular exercise is recommended.";
                ViewBag.Color = "warning";
            }
            else
            {
                ViewBag.Status = "Obese";
                ViewBag.Message = "High health risk. Please consult a fitness expert or doctor.";
                ViewBag.Color = "danger";
            }

            return View();
        }

        // ===================================
        // WATER INTAKE TRACKER (GET)
        // ===================================
        [HttpGet]
        public IActionResult WaterIntake()
        {
            ViewBag.Target = 3.0; // 3 Liters per day
            ViewBag.Consumed = TempData["Consumed"] ?? 0.0;

            return View();
        }

        // ===================================
        // WATER INTAKE TRACKER (POST)
        // ===================================
        [HttpPost]
        public IActionResult WaterIntake(double addWater)
        {
            double target = 3.0;
            double consumed = TempData["Consumed"] != null
                ? Convert.ToDouble(TempData["Consumed"])
                : 0.0;

            consumed += addWater;

            if (consumed > target)
                consumed = target;

            TempData["Consumed"] = consumed;
            TempData.Keep("Consumed");

            ViewBag.Target = target;
            ViewBag.Consumed = consumed;

            return View();
        }
    }
}
