using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoard.Domain.Models
{
    public class Job
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? EmpoyerId { get; set; }
        public string? Description { get; set; }
        public string? Location { get; set; }
        public float? Salary { get; set; }
        public Job(Guid id, string? title, string? empoyerId, string? description, string? location, float? salary)
        {
            Id = id;
            Title = title;
            EmpoyerId = empoyerId;
            Description = description;
            Location = location;
            Salary = salary;
        }
    }
}
