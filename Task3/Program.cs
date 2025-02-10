using Company_BL.Servicse.Abstraction;
using Company_BL.Servicse.Impelementation;

IProjectServices projectServices = new ProjectServices();
var result = projectServices.GetAll();
 foreach (var project in result)
 {
      Console.WriteLine(project.Department.Name);
 }
