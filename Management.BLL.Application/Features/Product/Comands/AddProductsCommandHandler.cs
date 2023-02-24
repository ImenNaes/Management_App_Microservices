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
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, int>
    {
        private IMapper _mapper { get; }
        private IProductRepository _productRepository { get; set; }
        public AddProductCommandHandler(IMapper mapper, IProductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }


        public async Task<int> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            //Convert to domain entity object 
            var productToCreate = _mapper.Map<Domain.Product>(request);  
            //add to database
            await _productRepository.CreateAsync(productToCreate);
            //return record id 
            return productToCreate.ID;
        }
    }
}
