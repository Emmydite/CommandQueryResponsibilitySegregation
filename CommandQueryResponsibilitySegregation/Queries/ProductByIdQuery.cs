
using CommandQueryResponsibilitySegregation.Models;
using MediatR;

namespace CommandQueryResponsibilitySegregation.Queries
{
    public class ProductByIdQuery : IRequest<Product>
    {
        public int Id { get; set; }
    }
}
