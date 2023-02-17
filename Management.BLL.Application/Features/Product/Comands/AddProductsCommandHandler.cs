using Management.BLL.Contracts.CQRS.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.BLL.Application.Features.Product.Comands
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, int>
    {
        public Task<int> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
