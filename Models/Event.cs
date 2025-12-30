using System;

namespace All_In_One_Fitness_App.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateTime EventDate { get; set; } = DateTime.Now;
        public string? Location { get; set; }
        public bool IsActive { get; set; }
    }
}
