namespace Catalog.Dtos
{
    public record CreateitemDto
    {
        public string Name { get; init; }
        public decimal Price { get; init; }
    }
}
