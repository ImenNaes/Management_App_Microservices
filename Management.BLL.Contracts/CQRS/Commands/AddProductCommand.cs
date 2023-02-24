using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.BLL.Contracts.CQRS.Commands
{
    public class AddProductCommand : IRequest<int>
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        //public string RequestComments { get; set; } = string.Empty; 
        //public bool concelled { get; set; }
    }
}
