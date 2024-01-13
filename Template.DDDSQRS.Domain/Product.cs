using Template.DDDSQRS.Domain.Common;

namespace Template.DDDSQRS.Domain;

public class Product : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public List<Guid>? Categories { get; set; }
}
