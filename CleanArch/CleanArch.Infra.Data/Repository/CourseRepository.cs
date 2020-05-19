using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDbContext _dbContext;
        public CourseRepository(UniversityDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Course> GetCourses()
        {
            return _dbContext.Courses;
        }
    }
}
