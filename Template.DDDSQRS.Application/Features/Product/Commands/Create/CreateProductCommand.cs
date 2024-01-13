namespace Template.DDDSQRS.Application.Features.Product.Commands.Create;

public record CreateProductCommand(CreateProductDto Dto) : ICommand<Unit>;
