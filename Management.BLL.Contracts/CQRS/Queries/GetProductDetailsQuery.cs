using Management.BLL.Contracts.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.BLL.Contracts.CQRS.Queries
{
    public record GetProductDetailsQuery(int id): IRequest<ProductDto>
    {

    }
}
