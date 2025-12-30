////namespace All_In_One_Fitness_App.Models
////{
////    public class Membership
////    {
////    }
////}


//using System.ComponentModel.DataAnnotations;

//namespace All_In_One_Fitness_App.Models
//{
//    public class Membership
//    {
//        [Key]
//        public int MembershipId { get; set; }

//        [Required]
//        public string Name { get; set; }

//        [Required]
//        public decimal Fee { get; set; }

//        [Required]
//        public int DurationInMonths { get; set; }

//        public bool IsActive { get; set; } = true;
//    }
//}



namespace All_In_One_Fitness_App.Models
{
    public class Membership
    {
        // Primary Key
        public int Id { get; set; }

        // Membership Name (Gold / Silver / Premium)
        public string Name { get; set; } = string.Empty;

        // Fee amount
        public decimal Fee { get; set; }

        // Duration in months
        public int DurationInMonths { get; set; }

        // Active / Inactive
        public bool IsActive { get; set; } = true;
    }
}
