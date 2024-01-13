namespace Template.DDDSQRS.Application.Features.Category.Commands.Delete;

public record DeleteCategoryCommand(Guid Id) : ICommand<Unit>;
