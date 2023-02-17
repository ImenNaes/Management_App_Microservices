using AutoMapper;
using Management.BLL.Contracts.CQRS.Queries;
using Management.BLL.Contracts.DTO;
using Management.BLL.Contracts.Persistence;
using MediatR;

namespace Management.BLL.Application.Features.Product.Queries
{
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, List<ProductDto>>
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepo;
        public GetProductsQueryHandler(IMapper mapper, IProductRepository productRepo)
        {
            _mapper = mapper;
            _productRepo = productRepo;

        }
        public async Task<List<ProductDto>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            //Query the database 
            var listProducts = await _productRepo.GetAllAsync();
            //convert list of dto objects
            var data = _mapper.Map<List<ProductDto>>(listProducts);
            //return list of Dto object
            return data;
        }
    }
}
