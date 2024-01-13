namespace Template.DDDSQRS.Application.Features.Category.Commands.Update;

public record UpdateCategoryCommand(UpdateCategoryDto Dto) : ICommand<Unit>;
