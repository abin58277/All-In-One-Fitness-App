////namespace All_In_One_Fitness_App.Models
////{
////    public class ApplicationUser
////    {
////    }
////}



//using Microsoft.AspNetCore.Identity;

//namespace All_In_One_Fitness_App.Models
//{
//    public class Users 
//    {
//        public string FullName { get; set; }

//        // Membership relation
//        public int MembershipId { get; set; }
//        public string Membership { get; set; }
//        public string Email { get; set; } = string.Empty;

//        public string MembershipStartDate { get; set; }
//        public string MembershipEndDate { get; set; }

//        public bool IsMembershipFrozen { get; set; }

//    }
//}



namespace All_In_One_Fitness_App.Models
{
    public class Users
    {
        // Primary Identifier
        public int Id { get; set; }

        // Basic User Info
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        // Membership Details
        public int MembershipId { get; set; }
        public string Membership { get; set; } = "Gold";

        public DateTime MembershipStartDate { get; set; }
        public DateTime MembershipEndDate { get; set; }

        // 🔑 IMPORTANT FOR ADMIN FUNCTIONALITY
        public bool IsMembershipFrozen { get; set; }
    }
}
