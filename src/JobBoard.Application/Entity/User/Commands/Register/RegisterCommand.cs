using JobBoard.Application.Common.CQRS;
using JobBoard.Application.DTOs;
using JobBoard.Domain.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace JobBoard.Application.Entity
{
    public record RegisterResult(Guid Id,string Token);
    public record RegisterCommand(string UserName, string Password, string Email, string Phone) :ICommand<RegisterResult>;
    
}
