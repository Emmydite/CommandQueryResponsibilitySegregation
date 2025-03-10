﻿using CommandQueryResponsibilitySegregation.Models;
using MediatR;

namespace CommandQueryResponsibilitySegregation.Commands
{
    public class CreateProductCommand : IRequest<Product>
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
