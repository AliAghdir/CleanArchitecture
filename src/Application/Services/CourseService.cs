using System;
using Application.Contracts;
using Domain.Contracts;
using Domain.Entities;
using Application.ViewModels;

namespace Application.Services
{
    public class CourseService:ICourseService
    {
        private readonly IRepository<Course> _repository;
        public CourseService(IRepository<Course> repository)
        {
            _repository =repository;
        }

        public CoursesViewModel GetAll()
        {
            return new CoursesViewModel{
                Courses=_repository.GetAll()
            };
        }

        public CourseViewModel GetById(int courseId)
        {
            return new CourseViewModel{
                Course=_repository.GetById(courseId)
            };
        }
    }
}