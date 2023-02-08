namespace CommandQueryResponsibilitySegregation.Commands
{
    public class CreateProductCommand
    {
        public string ProductName { get; set; }
        public string ProductSKU { get; set; }
        public decimal Price { get; set; }

        public CreateProductCommand(string productName, string productSKU, decimal price)
        {
            ProductName = productName;
            ProductSKU = productSKU;
            Price = price;
        }

    }
}
