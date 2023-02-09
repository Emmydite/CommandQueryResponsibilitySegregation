namespace CommandQueryResponsibilitySegregation.Commands
{
    public class UpdateProductCommand
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductSKU { get; set; }
        public decimal Price { get; set; }
    }
}
