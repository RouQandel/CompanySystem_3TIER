using Company.DAL.Entities;
using Company.DAL.Repo.Abstraction;
using Company.DAL.Repo.Implementation;
using Company_BL.Servicse.Abstraction;

namespace Company_BL.Servicse.Impelementation;

        public class ProjectServices : IProjectServices
        {
            private readonly IProjectRepo _projectRepo;

            public ProjectServices()
            {
                _projectRepo = new ProjectRepo();
            }

            public List<Project> GetAll()
            {
                var result = _projectRepo.GetAll();
                return result;
            }
        }
