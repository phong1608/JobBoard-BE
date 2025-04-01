using JobBoard.Application.Common.CQRS;
using JobBoard.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoard.Application.Entity.User.Queries.GetUserById
{
    public record GetUSerByIdResult(UserDTO User);
    public record GetUserByIdQuery(Guid Id):IQuery<GetUSerByIdResult>;
    
}
