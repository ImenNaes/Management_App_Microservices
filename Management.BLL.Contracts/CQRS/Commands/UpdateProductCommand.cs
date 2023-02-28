using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.BLL.Contracts.CQRS.Commands
{
    public class UpdateProductCommand:IRequest<Unit>
    {
        public string? Name { get; set;}
        public string? Description { get; set; }
    }
}
