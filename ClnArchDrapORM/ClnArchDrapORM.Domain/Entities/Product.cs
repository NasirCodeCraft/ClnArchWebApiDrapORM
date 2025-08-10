using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnArchDrapORM.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int quantity { get; set; }
        public string Description { get; set; } = string.Empty;

        public Product() { }

        public Product(int id, string name, decimal price, int quantity, string description)
        {
            Id = id;
            Name = name;
            Price = price;
            this.quantity = quantity;
            Description = description;
        }
        public bool IsInStock()
        {
            return quantity > 0;
        }
    }
}
