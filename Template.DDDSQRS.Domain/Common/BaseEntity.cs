namespace Template.DDDSQRS.Domain.Common;

public abstract class BaseEntity
{
    public Guid Id { get; set; }
    public DateTime DateCreateed { get; set; }
    public DateTime DateUpdated { get; set; }
}
