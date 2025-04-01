using JobBoard.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoard.Domain.Models
{
    public class Application
    {
        public int Id { get; set; }
        public string? JobId { get; set; }
        public string? CandidateId { get; set; }
        public ApplicationStatus Status { get; set; }
        public string? CoverLetter { get; set; }
        public Application(int id, string? jobId, string? candidateId, string? coverLetter)
        {
            Id = id;
            JobId = jobId;
            CandidateId = candidateId;
            Status = ApplicationStatus.Pending;
            CoverLetter = coverLetter;
        }
    }
}
