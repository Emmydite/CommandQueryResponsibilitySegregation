using MediatR;

namespace CommandQueryResponsibilitySegregation.Commands
{
    public class DeleteProductCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
