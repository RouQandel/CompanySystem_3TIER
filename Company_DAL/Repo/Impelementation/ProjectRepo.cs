using Company.DAL.Database;
using Company.DAL.Entities;
using Company.DAL.Repo.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace Company.DAL.Repo.Implementation
{
    public class ProjectRepo : IProjectRepo
    {
        private ApplicationDbContext Db;

        public ProjectRepo()
        {
            Db = new();
        }

        public List<Project> GetAll()
        {
            using var transaction = Db.Database.BeginTransaction();

            try
            {
                var projects = Db.Projects
                    .Where(p => p.Id > 0)
                    .ToList();

                transaction.CreateSavepoint("T 1");

                var project = Db.Projects.FirstOrDefault();
                Db.Entry(project).Reference(p => p.Department).Load();

                transaction.Commit();

                return projects;
            }
            catch (Exception)
            {
                transaction.RollbackToSavepoint("T 1");
                transaction.Commit();
                throw;
            }
        }
    }
}