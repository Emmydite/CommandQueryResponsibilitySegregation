using MediatR;

namespace CommandQueryResponsibilitySegregation.Commands
{
    public class UpdateProductCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductSKU { get; set; }
        public decimal Price { get; set; }

        public UpdateProductCommand(int productId, string productName, string productSKU, decimal price)
        {
            Id = productId;
            ProductName = productName;
            ProductSKU = productSKU;
            Price = price;
        }
    }
}
