using JobBoard.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoard.Application.Common.Interfaces
{
    public interface IAuthService
    {
        Task<string> Login(string Email,string Password);
        Task<bool> AssignRole(Guid userId, Guid roleId);

    }
}
