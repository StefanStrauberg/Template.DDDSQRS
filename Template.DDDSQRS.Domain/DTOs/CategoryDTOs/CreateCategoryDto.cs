namespace Template.DDDSQRS.Domain.DTOs.CategoryDTOs;

public sealed class CreateCategoryDto
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public List<Guid>? Products { get; set; }
}
