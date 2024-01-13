namespace Template.DDDSQRS.Application.Features.Product.Commands.Update;

public record UpdateProductCommand(UpdateProductDto Dto) : ICommand<Unit>;
