namespace Template.DDDSQRS.Domain.DTOs.ProductDTOs;

public sealed class CreateProductDto
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public List<Guid>? Categories { get; set; }
}
