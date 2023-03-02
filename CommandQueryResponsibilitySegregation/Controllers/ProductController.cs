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

        public IActionResult Index()
        {
            return View();
        }
    }
}
