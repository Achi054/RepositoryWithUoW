using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Entities;

namespace RepositoryPattern.Repository
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        private SchoolContext schoolContext;
        public CourseRepository(SchoolContext context) : base(context)
        {
            schoolContext = context;
        }

        public IEnumerable<Course> GetCourseWithAuthors(int pageIndex, int pageSize)
        {
            return schoolContext.Courses
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize).ToList();
        }

        public IEnumerable<Course> GetTopSellingCourses()
        {
            return schoolContext.Courses.ToList();
        }
    }
}