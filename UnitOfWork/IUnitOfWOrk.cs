using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using RepositoryPattern.Repository;

namespace RepositoryPattern.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ICourseRepository Courses { get; }
        int Complete();
    }
}