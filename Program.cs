using System;
using RepositoryPattern;
using RepositoryPattern.UnitOfWork;

namespace RepositoryWithUoW
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var UnitOfWork = new UnitOfWork(new SchoolContext("connection")))
            {
                var courses = UnitOfWork.Courses.GetAll();
            }
        }
    }
}
