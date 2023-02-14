using CommandQueryResponsibilitySegregation.Models;
using MediatR;

namespace CommandQueryResponsibilitySegregation.Queries
{
    public class ProductListQuery : IRequest<List<Product>>
    {
    }
}
