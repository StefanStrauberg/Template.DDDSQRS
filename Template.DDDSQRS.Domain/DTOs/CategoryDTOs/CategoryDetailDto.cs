namespace Template.DDDSQRS.Domain.DTOs.CategoryDTOs;

public sealed class CategoryDetailDto
{
    public Guid Id { get; set; }
    public DateTime DateCreateed { get; set; }
    public DateTime DateUpdated { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public List<Guid>? Products { get; set; }
}
