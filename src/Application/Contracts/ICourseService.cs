using Application.ViewModels;

namespace Application.Contracts;

public interface ICourseService
{
    CoursesViewModel GetAll();
}