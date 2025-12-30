//namespace All_In_One_Fitness_App.Models
//{
//    public class Expert
//    {
//    }
//}



using System.ComponentModel.DataAnnotations;

namespace All_In_One_Fitness_App.Models
{
    public class Expert
    {
        [Key]
        public int ExpertId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Expertise { get; set; }

        public string ContactInfo { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
