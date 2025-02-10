namespace Company.DAL.Entities
{
    public class Department
    {
        public Department()
        {
        }

        public Department(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public long Id { get; set; }
        public string Name { get; private set; }
        public string Description { get; private set; }

        // Navigation Property
        public virtual List<Project>? Projects { get; private set; } = [];
    }
}