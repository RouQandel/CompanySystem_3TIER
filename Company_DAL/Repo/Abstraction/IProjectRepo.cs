using Company.DAL.Entities;

namespace Company.DAL.Repo.Abstraction
{
    public interface IProjectRepo
    {
        List<Project> GetAll();
    }
}