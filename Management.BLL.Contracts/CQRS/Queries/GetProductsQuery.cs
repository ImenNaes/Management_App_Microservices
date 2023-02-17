using Management.BLL.Contracts.DTO;
using MediatR;

namespace Management.BLL.Contracts.CQRS.Queries
{
    public class GetProductsQuery : IRequest<List<ProductDto>>
    {
    }
}
