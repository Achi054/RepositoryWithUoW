using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using RepositoryPattern.Repository;

namespace RepositoryPattern.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SchoolContext _context;
        public UnitOfWork(SchoolContext context)
        {
            _context = context;
            Courses = new CourseRepository(context);
        }

        public ICourseRepository Courses { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}