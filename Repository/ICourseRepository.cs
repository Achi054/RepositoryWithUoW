using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using RepositoryPattern.Entities;

namespace RepositoryPattern.Repository
{
    public interface ICourseRepository : IRepository<Course>
    {
        IEnumerable<Course> GetTopSellingCourses();
        IEnumerable<Course> GetCourseWithAuthors(int pageIndex, int pageSize);
    }
}