using Application.ViewModels;

namespace Application.Contracts;

public interface ICourseService
{
    CourseViewModel GetAll();
}