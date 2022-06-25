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

        public CourseViewModel GetAll()
        {
            return new CourseViewModel{
                Courses=_repository.GetAll()
            };
        }
    }
}