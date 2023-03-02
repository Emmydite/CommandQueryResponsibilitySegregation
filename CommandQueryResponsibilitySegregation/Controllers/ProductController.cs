using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CommandQueryResponsibilitySegregation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;
        public ProductController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
