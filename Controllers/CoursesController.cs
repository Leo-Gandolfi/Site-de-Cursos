using Microsoft.AspNetCore.Mvc;
using OnlineCourses.Models;
using System.Collections.Generic;
using System.Linq;

namespace OnlineCourses.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index(string searchQuery = "")
        {
            var courses = new List<Course>
            {
                new Course { Id = 1, Title = "Curso de HTML e CSS", Description = "Aprenda os fundamentos da web.", ThumbnailUrl = "https://via.placeholder.com/300", Progress = 70 },
                new Course { Id = 2, Title = "Curso de JavaScript", Description = "Domine a linguagem do navegador.", ThumbnailUrl = "https://via.placeholder.com/300", Progress = 50 },
                new Course { Id = 3, Title = "Curso de C#", Description = "Aprenda programação com C#.", ThumbnailUrl = "https://via.placeholder.com/300", Progress = 30 }
            };

            if (!string.IsNullOrWhiteSpace(searchQuery))
            {
                courses = courses.Where(c => c.Title.Contains(searchQuery, StringComparison.OrdinalIgnoreCase)
                                           || c.Description.Contains(searchQuery, StringComparison.OrdinalIgnoreCase))
                                 .ToList();
            }

            return View(courses);
        }
    }
}
