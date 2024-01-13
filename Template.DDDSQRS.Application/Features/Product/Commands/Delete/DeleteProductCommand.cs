namespace Template.DDDSQRS.Application.Features.Product.Commands.Delete;

public record DeleteProductCommand(Guid Id) : ICommand<Unit>;
