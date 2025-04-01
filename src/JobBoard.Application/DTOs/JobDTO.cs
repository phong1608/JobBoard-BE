using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoard.Application.DTOs
{
    public class JobDTO
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public Guid EmployerId { get; set; }
        public string? EmployerName { get; set; }
        public JobDTO(Guid id, string? title, Guid employerId, string? employerName)
        {
            Id = id;
            Title = title;
            EmployerId = employerId;
            EmployerName = employerName;
        }
    }
}
