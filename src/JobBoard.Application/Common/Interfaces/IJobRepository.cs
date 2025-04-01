
using JobBoard.Application.DTOs;
using JobBoard.Domain.Models;
namespace JobBoard.Application.Common.Interfaces
{
    public interface IJobRepository
    {
        Task<Job> AddAsync(string title, string empoyerId, string description, string location, float salary);
        Task<Job> GetByIdAsync(Guid id);
        Task<IEnumerable<JobDTO>> GetAllAsync();
        Task<IEnumerable<JobDTO>> GetByUserId(Guid UserId);
        Task<Job> DeleteByIdAsync(Guid id);
        Task<bool> UpdateAsync(string title, string empoyerId, string description, string location, float salary);

    }
}
