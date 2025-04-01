using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoard.Application.Common.Interfaces
{
    public interface IJwtGenerator
    {
        string CreateToken(Guid Id,string UserName);
    }
}
