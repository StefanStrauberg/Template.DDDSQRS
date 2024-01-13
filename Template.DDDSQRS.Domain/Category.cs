using Template.DDDSQRS.Domain.Common;

namespace Template.DDDSQRS.Domain;

public class Category : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public List<Guid>? Products { get; set; }
}