using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers;

public class CourseController : Controller
{
    public IActionResult Details(int? id)
    {
        if (id == null)
        {
            return RedirectToAction("List","Course");
        }
        var kurs = Repository.GetById(id);
        return View(kurs);
    }
    public IActionResult List()
    {

        return View("CourseList", Repository.Courses);
    }
}