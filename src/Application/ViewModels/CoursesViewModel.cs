using Domain.Entities;

namespace Application.ViewModels;

public class CoursesViewModel
{
    public IEnumerable<Course> Courses { get; set; }
}