//namespace All_In_One_Fitness_App.Models
//{
//    public class Trainer
//    {
//    }
//}



//using System.ComponentModel.DataAnnotations;

//namespace All_In_One_Fitness_App.Models
//{
//    public class Trainer
//    {
//        [Key]
//        public int TrainerId { get; set; }

//        [Required]
//        public string Name { get; set; }

//        public string Specialization { get; set; }

//        public string Phone { get; set; }

//        public bool IsActive { get; set; } = true;
//    }
//}



using System.ComponentModel.DataAnnotations;

namespace All_In_One_Fitness_App.Models
{
    public class Trainer
    {
        [Key]
        public int Id { get; set; }   // Used by AdminController

        [Required]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public string Specialization { get; set; } = "General Fitness";

        public string? Phone { get; set; }

        public bool IsActive { get; set; } = true;
    }
}


