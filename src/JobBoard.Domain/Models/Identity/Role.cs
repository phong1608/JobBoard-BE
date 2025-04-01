using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoard.Domain.Models.Identity
{
    public class Role
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
    }
}
