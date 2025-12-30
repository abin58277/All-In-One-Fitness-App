


//////using Microsoft.AspNetCore.Mvc;

//////namespace All_In_One_Fitness_App.Controllers
//////{

//////    public class AdminController : Controller
//////    {
//////        // Admin Dashboard
//////        public IActionResult Dashboard()
//////        {
//////            return View();
//////        }

//////        // View all users (placeholder)
//////        public IActionResult Users()
//////        {
//////            return View();
//////        }

//////        // Membership management (placeholder)
//////        public IActionResult Memberships()
//////        {
//////            return View();
//////        }

//////        // Trainers management (placeholder)
//////        public IActionResult Trainers()
//////        {
//////            return View();
//////        }

//////        // Experts management (placeholder)
//////        public IActionResult Experts()
//////        {
//////            return View();
//////        }

//////        // Events management (placeholder)
//////        public IActionResult Event()
//////        {
//////            return View();
//////        }

//////        // Reports
//////        public IActionResult Reports()
//////        {
//////            return View();
//////        }
//////    }
//////}



////using Microsoft.AspNetCore.Mvc;
////using All_In_One_Fitness_App.Models;
////using System;
////using System.Collections.Generic;
////using System.Linq;

////namespace All_In_One_Fitness_App.Controllers
////{
////    public class AdminController : Controller
////    {
////        // --------------------------------------------------
////        // IN-MEMORY USER DATA (DEMO PURPOSE)
////        // --------------------------------------------------
////        private static List<Users> users = new List<Users>
////        {
////            new Users
////            {
////                Id = 1,
////                FullName = "Rahul Sharma",
////                Email = "rahul@gmail.com",
////                Membership = "Gold",
////                MembershipId = 1,
////                MembershipStartDate = DateTime.Now.AddMonths(-2),
////                MembershipEndDate = DateTime.Now.AddMonths(10),
////                IsMembershipFrozen = false
////            },
////            new Users
////            {
////                Id = 2,
////                FullName = "Ananya Patel",
////                Email = "ananya@gmail.com",
////                Membership = "Silver",
////                MembershipId = 2,
////                MembershipStartDate = DateTime.Now.AddMonths(-1),
////                MembershipEndDate = DateTime.Now.AddMonths(5),
////                IsMembershipFrozen = true
////            }
////        };

////        // --------------------------------------------------
////        // ADMIN DASHBOARD
////        // --------------------------------------------------
////        public IActionResult Dashboard()
////        {
////            return View();
////        }

////        // --------------------------------------------------
////        // USER MANAGEMENT
////        // --------------------------------------------------
////        public IActionResult Users()
////        {
////            return View(users);
////        }

////        // Freeze Membership
////        public IActionResult FreezeUser(int id)
////        {
////            var user = users.FirstOrDefault(u => u.Id == id);
////            if (user != null)
////            {
////                user.IsMembershipFrozen = true;
////            }
////            return RedirectToAction("Users");
////        }

////        // Resume Membership
////        public IActionResult ResumeUser(int id)
////        {
////            var user = users.FirstOrDefault(u => u.Id == id);
////            if (user != null)
////            {
////                user.IsMembershipFrozen = false;
////            }
////            return RedirectToAction("Users");
////        }

////        // --------------------------------------------------
////        // MEMBERSHIP MANAGEMENT
////        // --------------------------------------------------
////        public IActionResult Memberships()
////        {
////            return View();
////        }

////        // --------------------------------------------------
////        // TRAINER MANAGEMENT
////        // --------------------------------------------------
////        public IActionResult Trainers()
////        {
////            return View();
////        }

////        // --------------------------------------------------
////        // EXPERT MANAGEMENT
////        // --------------------------------------------------
////        public IActionResult Experts()
////        {
////            return View();
////        }

////        // --------------------------------------------------
////        // EVENT MANAGEMENT
////        // --------------------------------------------------
////        public IActionResult Events()
////        {
////            return View();
////        }

////        // --------------------------------------------------
////        // REPORTS
////        // --------------------------------------------------
////        public IActionResult Reports()
////        {
////            return View();
////        }
////    }
////}


//using Microsoft.AspNetCore.Mvc;
//using All_In_One_Fitness_App.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace All_In_One_Fitness_App.Controllers
//{
//    public class AdminController : Controller
//    {
//        // --------------------------------------------------
//        // IN-MEMORY USER DATA (DEMO)
//        // --------------------------------------------------
//        private static List<Users> users = new List<Users>
//        {
//            new Users
//            {
//                Id = 1,
//                FullName = "Rahul Sharma",
//                Email = "rahul@gmail.com",
//                Membership = "Gold",
//                MembershipId = 1,
//                MembershipStartDate = DateTime.Now.AddMonths(-2),
//                MembershipEndDate = DateTime.Now.AddMonths(10),
//                IsMembershipFrozen = false
//            },
//            new Users
//            {
//                Id = 2,
//                FullName = "Ananya Patel",
//                Email = "ananya@gmail.com",
//                Membership = "Silver",
//                MembershipId = 2,
//                MembershipStartDate = DateTime.Now.AddMonths(-1),
//                MembershipEndDate = DateTime.Now.AddMonths(5),
//                IsMembershipFrozen = true
//            }
//        };

//        // --------------------------------------------------
//        // IN-MEMORY MEMBERSHIP DATA (DEMO)
//        // --------------------------------------------------
//        private static List<Membership> memberships = new List<Membership>
//        {
//            new Membership
//            {
//                Id = 1,
//                Name = "Basic",
//                Fee = 999,
//                DurationInMonths = 3,
//                IsActive = true
//            },
//            new Membership
//            {
//                Id = 2,
//                Name = "Silver",
//                Fee = 2499,
//                DurationInMonths = 6,
//                IsActive = true
//            },
//            new Membership
//            {
//                Id = 3,
//                Name = "Gold",
//                Fee = 4499,
//                DurationInMonths = 12,
//                IsActive = false
//            }
//        };

//        // --------------------------------------------------
//        // ADMIN DASHBOARD
//        // --------------------------------------------------
//        public IActionResult Dashboard()
//        {
//            return View();
//        }

//        // --------------------------------------------------
//        // USER MANAGEMENT
//        // --------------------------------------------------
//        public IActionResult Users()
//        {
//            return View(users);
//        }

//        // Freeze Membership
//        public IActionResult FreezeUser(int id)
//        {
//            var user = users.FirstOrDefault(u => u.Id == id);
//            if (user != null)
//            {
//                user.IsMembershipFrozen = true;
//                TempData["Success"] = $"{user.FullName}'s membership has been frozen.";
//            }
//            return RedirectToAction("Users");
//        }

//        // Resume Membership
//        public IActionResult ResumeUser(int id)
//        {
//            var user = users.FirstOrDefault(u => u.Id == id);
//            if (user != null)
//            {
//                user.IsMembershipFrozen = false;
//                TempData["Success"] = $"{user.FullName}'s membership has been resumed.";
//            }
//            return RedirectToAction("Users");
//        }

//        // --------------------------------------------------
//        // MEMBERSHIP MANAGEMENT
//        // --------------------------------------------------
//        public IActionResult Memberships()
//        {
//            return View(memberships);
//        }

//        [HttpPost]
//        public IActionResult ActivateMembership(int id)
//        {
//            var membership = memberships.FirstOrDefault(m => m.Id == id);
//            if (membership != null)
//            {
//                membership.IsActive = true;
//                TempData["Success"] = $"{membership.Name} membership activated.";
//            }
//            return RedirectToAction("Memberships");
//        }

//        [HttpPost]
//        public IActionResult DeactivateMembership(int id)
//        {
//            var membership = memberships.FirstOrDefault(m => m.Id == id);
//            if (membership != null)
//            {
//                membership.IsActive = false;
//                TempData["Success"] = $"{membership.Name} membership deactivated.";
//            }
//            return RedirectToAction("Memberships");
//        }

//        // --------------------------------------------------
//        // TRAINER MANAGEMENT
//        // --------------------------------------------------
//        public IActionResult Trainers()
//        {
//            return View();
//        }

//        // --------------------------------------------------
//        // EXPERT MANAGEMENT
//        // --------------------------------------------------
//        public IActionResult Experts()
//        {
//            return View();
//        }

//        // --------------------------------------------------
//        // EVENT MANAGEMENT
//        // --------------------------------------------------
//        public IActionResult Events()
//        {
//            return View();
//        }

//        // --------------------------------------------------
//        // REPORTS
//        // --------------------------------------------------
//        public IActionResult Reports()
//        {
//            return View();
//        }
//    }
//}




using Microsoft.AspNetCore.Mvc;
using All_In_One_Fitness_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace All_In_One_Fitness_App.Controllers
{
    public class AdminController : Controller
    {
        // --------------------------------------------------
        // IN-MEMORY USER DATA (DEMO)
        // --------------------------------------------------
        private static List<Users> users = new List<Users>
        {
            new Users
            {
                Id = 1,
                FullName = "Rahul Sharma",
                Email = "rahul@gmail.com",
                Membership = "Gold",
                MembershipId = 1,
                MembershipStartDate = DateTime.Now.AddMonths(-2),
                MembershipEndDate = DateTime.Now.AddMonths(10),
                IsMembershipFrozen = false
            },
            new Users
            {
                Id = 2,
                FullName = "Ananya Patel",
                Email = "ananya@gmail.com",
                Membership = "Silver",
                MembershipId = 2,
                MembershipStartDate = DateTime.Now.AddMonths(-1),
                MembershipEndDate = DateTime.Now.AddMonths(5),
                IsMembershipFrozen = true
            }
        };

        // --------------------------------------------------
        // IN-MEMORY MEMBERSHIP DATA (DEMO)
        // --------------------------------------------------
        private static List<Membership> memberships = new List<Membership>
        {
            new Membership
            {
                Id = 1,
                Name = "Basic",
                Fee = 999,
                DurationInMonths = 3,
                IsActive = true
            },
            new Membership
            {
                Id = 2,
                Name = "Silver",
                Fee = 2499,
                DurationInMonths = 6,
                IsActive = true
            },
            new Membership
            {
                Id = 3,
                Name = "Gold",
                Fee = 4499,
                DurationInMonths = 12,
                IsActive = false
            }
        };

        // --------------------------------------------------
        // IN-MEMORY TRAINER DATA (DEMO)  ✅ ADDED
        // --------------------------------------------------
        private static List<Trainer> trainers = new List<Trainer>
        {
            new Trainer
            {
                Id = 1,
                FullName = "Arjun Mehta",
                Email = "arjun.trainer@gmail.com",
                Specialization = "Strength Training",
                IsActive = true
            },
            new Trainer
            {
                Id = 2,
                FullName = "Priya Nair",
                Email = "priya.trainer@gmail.com",
                Specialization = "Yoga & Flexibility",
                IsActive = true
            },
            new Trainer
            {
                Id = 3,
                FullName = "Karan Singh",
                Email = "karan.trainer@gmail.com",
                Specialization = "Cardio & HIIT",
                IsActive = false
            }
        };

        // --------------------------------------------------
        // ADMIN DASHBOARD
        // --------------------------------------------------
        public IActionResult Dashboard()
        {
            return View();
        }

        // --------------------------------------------------
        // USER MANAGEMENT
        // --------------------------------------------------
        public IActionResult Users()
        {
            return View(users);
        }

        public IActionResult FreezeUser(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                user.IsMembershipFrozen = true;
                TempData["Success"] = $"{user.FullName}'s membership has been frozen.";
            }
            return RedirectToAction("Users");
        }

        public IActionResult ResumeUser(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                user.IsMembershipFrozen = false;
                TempData["Success"] = $"{user.FullName}'s membership has been resumed.";
            }
            return RedirectToAction("Users");
        }

        // --------------------------------------------------
        // MEMBERSHIP MANAGEMENT
        // --------------------------------------------------
        public IActionResult Memberships()
        {
            return View(memberships);
        }

        [HttpPost]
        public IActionResult ActivateMembership(int id)
        {
            var membership = memberships.FirstOrDefault(m => m.Id == id);
            if (membership != null)
            {
                membership.IsActive = true;
                TempData["Success"] = $"{membership.Name} membership activated.";
            }
            return RedirectToAction("Memberships");
        }

        [HttpPost]
        public IActionResult DeactivateMembership(int id)
        {
            var membership = memberships.FirstOrDefault(m => m.Id == id);
            if (membership != null)
            {
                membership.IsActive = false;
                TempData["Success"] = $"{membership.Name} membership deactivated.";
            }
            return RedirectToAction("Memberships");
        }

        // --------------------------------------------------
        // TRAINER MANAGEMENT  ✅ FIXED
        // --------------------------------------------------
        public IActionResult Trainers()
        {
            return View(trainers);
        }

        [HttpPost]
        public IActionResult ActivateTrainer(int id)
        {
            var trainer = trainers.FirstOrDefault(t => t.Id == id);
            if (trainer != null)
            {
                trainer.IsActive = true;
                TempData["Success"] = $"{trainer.FullName} activated.";
            }
            return RedirectToAction("Trainers");
        }

        [HttpPost]
        public IActionResult DeactivateTrainer(int id)
        {
            var trainer = trainers.FirstOrDefault(t => t.Id == id);
            if (trainer != null)
            {
                trainer.IsActive = false;
                TempData["Success"] = $"{trainer.FullName} deactivated.";
            }
            return RedirectToAction("Trainers");
        }

        // --------------------------------------------------
        // EXPERT MANAGEMENT
        // --------------------------------------------------
        public IActionResult Experts()
        {
            return View();
        }

        // --------------------------------------------------
        // EVENT MANAGEMENT
        // --------------------------------------------------
        public IActionResult Events()
        {
            return View();
        }

        // --------------------------------------------------
        // REPORTS
        // --------------------------------------------------
        public IActionResult Reports()
        {
            return View();
        }
    }
}
