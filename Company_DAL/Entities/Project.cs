using Company.DAL.ComplexType;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.DAL.Entities
{
    public class Project
    {
        public Project()
        {
        }

        public Project(long id, string name, string description, DateTime startDate, DateTime endDate)
        {
            Id = id;
            Name = name;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
        }

        [Key]
        public long Id { get; set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }

        [ForeignKey("Department")]
        public long? DepartmentId { get; private set; }
        public virtual Department? Department { get; private set; } = new();
    }
}