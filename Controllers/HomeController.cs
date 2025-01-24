using Microsoft.AspNetCore.Mvc;
using OnlineCourses.Models;
using System.Collections.Generic;
using System.Linq;

namespace OnlineCourses.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string searchQuery = "")
        {
            // Cursos em progresso
            var coursesInProgress = new List<Course>
            {
                new Course { Id = 1, Title = "Curso de Programação", Description = "Aprenda os fundamentos.", ThumbnailUrl = "/image/programming.jpg", Progress = 40 },
                new Course { Id = 2, Title = "Curso de Design", Description = "Domine ferramentas gráficas.", ThumbnailUrl = "/image/design.jpg", Progress = 70 },
                new Course { Id = 3, Title = "Curso de Marketing", Description = "Estratégias modernas.", ThumbnailUrl = "/image/marketing.jpg", Progress = 90 }
            };

            // Todos os cursos recomendados
            var allRecommendedCourses = new List<Course>
            {
                new Course { Id = 4, Title = "Curso de Edição de Vídeo", Description = "Aprenda sobre os principais editores do mercado e edite seu primeiro vídeo.", ThumbnailUrl = "/image/video_editing.jpg" },
                new Course { Id = 5, Title = "Curso Avançado de Programação", Description = "Domine habilidades avançadas neste curso e desenvolva uma aplicação robusta.", ThumbnailUrl = "/image/advanced_programming.jpg" },
                new Course { Id = 6, Title = "Curso Básico de Java", Description = "Inicie sua jornada de aprendizado com este curso básico de Java.", ThumbnailUrl = "/image/basic_java.jpg" },
                new Course { Id = 7, Title = "Curso de Fotografia", Description = "Descubra os segredos para tirar fotos incríveis.", ThumbnailUrl = "/image/photography.jpg" },
                new Course { Id = 8, Title = "Curso de Culinária", Description = "Cozinhe pratos incríveis com este curso.", ThumbnailUrl = "/image/culinary.jpg" },
                new Course { Id = 9, Title = "Curso de Desenvolvimento Web", Description = "Construa websites modernos e responsivos.", ThumbnailUrl = "/image/web_development.jpg" },
                new Course { Id = 10, Title = "Curso de Espanhol", Description = "Aprenda o básico do idioma espanhol rapidamente.", ThumbnailUrl = "/image/spanish.jpg" },
                new Course { Id = 11, Title = "Curso de Finanças Pessoais", Description = "Gerencie melhor suas finanças com este curso.", ThumbnailUrl = "/image/finance.jpg" },
                new Course { Id = 12, Title = "Curso de Yoga", Description = "Descubra como melhorar sua saúde com yoga.", ThumbnailUrl = "/image/yoga.png" }
            };


            // Aplicar pesquisa
            var recommendedCourses = string.IsNullOrWhiteSpace(searchQuery)
                ? allRecommendedCourses
                : allRecommendedCourses.Where(c =>
                    c.Title.Contains(searchQuery, System.StringComparison.OrdinalIgnoreCase) ||
                    c.Description.Contains(searchQuery, System.StringComparison.OrdinalIgnoreCase)).ToList();

            // Combinar as listas em um modelo único
            var viewModel = new HomeViewModel
            {
                CoursesInProgress = coursesInProgress,
                RecommendedCourses = recommendedCourses
            };

            return View(viewModel);
        }
    }
}
