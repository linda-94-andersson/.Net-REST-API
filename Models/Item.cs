using System;

namespace Catalog.Models
{
    public record Item
    {
        public Guid Id { get; init; } // Init insted of private set
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset CreatedDate { get; init; }
    }
}
