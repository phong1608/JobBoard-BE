using JobBoard.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoard.Application.Common.Interfaces
{
    public interface IUserRepository
    {
        Task<bool> IsEmailExisted(string email);
        Task<UserDTO> AddAsync(string userName, string email, string password, string phone);
        Task<UserDTO> GetUserById(Guid id);
    }
}
