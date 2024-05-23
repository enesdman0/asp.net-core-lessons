using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers;

public class CourseController : Controller
{
    public IActionResult Index()
    {
        var kurs = new Course();
        kurs.Id = 1;
        kurs.Title = "ASP.NET Core kursu";
        kurs.Description = "ASP.NET Core kursu çok güzel mis gibi";
        kurs.Image = "aspnet.jpg";
        return View(kurs);
    }
    public IActionResult List()
    {
        var kurslar = new List<Course>()
        {
            new Course(){ Id=1, Title="ASP", Description="Güzel kurs valla", Image="aspnet.jpg"},
            new Course(){ Id=2, Title="Javascript", Description="Güzel kurs valla", Image="javascript.png"},
            new Course(){ Id=3, Title="NodeJS", Description="Güzel kurs valla", Image="nodejs.jpg"},
        };
        return View("CourseList", kurslar);
    }
}