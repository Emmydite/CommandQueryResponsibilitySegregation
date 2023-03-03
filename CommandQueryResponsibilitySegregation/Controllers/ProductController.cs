using CommandQueryResponsibilitySegregation.Models;
using CommandQueryResponsibilitySegregation.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CommandQueryResponsibilitySegregation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Product>> GetProductList()
        {
            var productList = await _mediator.Send(new ProductListQuery());

            return productList;
        }


    }
}
