using Microsoft.Net.Http.Headers;

namespace OnlineCourses.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ThumbnailUrl { get; set; }
        public int Progress { get; set; } 
        public string ImageUrl { get; set; } 
    }
}   