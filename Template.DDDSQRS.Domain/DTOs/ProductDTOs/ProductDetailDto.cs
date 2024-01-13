namespace Template.DDDSQRS.Domain.DTOs.ProductDTOs;

public sealed class ProductDetailDto
{
    public Guid Id { get; set; }
    public DateTime DateCreateed { get; set; }
    public DateTime DateUpdated { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public List<Guid>? Categories { get; set; }
}
