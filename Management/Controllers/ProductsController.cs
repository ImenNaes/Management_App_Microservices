using Management.BLL.Contracts.CQRS.Commands;
using Management.BLL.Contracts.CQRS.Queries;
using Management.BLL.Contracts.DTO;
using Management.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductsController(IMediator mediator)
        {
            this._mediator= mediator;
        }
        // GET: api/<ProductsController>
        [HttpGet]
        public async Task<List<ProductDto>> Get()
        {
            var products = await _mediator.Send(new GetProductsQuery());
            return products;    
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductsController>
        [HttpPost]
        public async Task<ActionResult> Post(AddProductCommand model)
        {
            var response = await _mediator.Send(model);
            return CreatedAtAction(nameof(Get), new { id = response });
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
