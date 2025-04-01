using JobBoard.Application.DTOs;
using JobBoard.Domain.Enum;
using JobBoard.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace JobBoard.Application.Common.Interfaces
{
    public interface IApplicationRepository
    {
        Task<Guid> AddAsync(Guid jobId, Guid candidateId,string coverLetter);
        Task<ApplicationDTO> GetById(Guid id);
        Task<bool> UpdateApplicationStatus(Guid id, ApplicationStatus status);
        Task<IEnumerable<ApplicationDTO>> GetApplicationsByJobId(Guid jobId);
        Task<IEnumerable<ApplicationDTO>> GetApplicationsByUserId(Guid userId);
    }
}
 