using AutoMapper;
using Management.BLL.Contracts.CQRS.Commands;
using Management.BLL.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.BLL.Application.Features.Product.Comands
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Unit>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public UpdateProductCommandHandler(IProductRepository productRepository,
            IMapper mapper)
        {
            _productRepository = productRepository; 
            _mapper = mapper;   
        }
      
        public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var productToUpdate = _mapper.Map<Domain.Product>(request);

            await _productRepository.UpdateAsync(productToUpdate);

            return Unit.Value;
        }
    }
}
