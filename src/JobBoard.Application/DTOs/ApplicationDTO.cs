using JobBoard.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoard.Application.DTOs
{
    public class ApplicationDTO
    {
        public Guid Id { get; set; }
        public Guid JobId { get; set; }
        public string? JobTitle { get; set; }
        public Guid UserId { get; set; }
        public UserDTO? User { get; set; }
        public string? CoverLetter { get; set; }
        public ApplicationStatus Status { get; set; }
        
        
    }
}
