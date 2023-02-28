using AutoMapper;
using Management.BLL.Contracts.CQRS.Queries;
using Management.BLL.Contracts.DTO;
using Management.BLL.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.BLL.Application.Features.Product.Queries
{
    public class GetProductDetailsQueryHandler : IRequestHandler<GetProductDetailsQuery,
             ProductDto>
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepo;
        public GetProductDetailsQueryHandler(IMapper mapper, IProductRepository productRepo)
        {
            _mapper = mapper;   
            _productRepo = productRepo;

        }
        public async Task<ProductDto> Handle(GetProductDetailsQuery request, CancellationToken cancellationToken)
        {
            var productbyid = await _productRepo.GetByIdAsync(request.id);
            var data = _mapper.Map<ProductDto>(productbyid);
            return data; 
        }
    }
}
