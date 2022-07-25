using Microsoft.AspNetCore.Mvc;
using Application.Contracts;

namespace CleanArch.Web.Controllers;

public class CourseController : Controller
{
    private ICourseService _courseService;
    public CourseController(ICourseService courseService)
    {
        _courseService = courseService;
    }

    public IActionResult Index()
    {
        var CourseViewModel = _courseService.GetAll();
        return View(CourseViewModel);
    }
}