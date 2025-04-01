using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoard.Application.DTOs
{
    public record UserDTO(Guid Id, string UserName, string Email, string Phone);
    
}
