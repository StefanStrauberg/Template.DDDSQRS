namespace Template.DDDSQRS.Application.Features.Category.Commands.Create;

public record CreateCategoryCommand(CreateCategoryDto Dto) 
    : ICommand<Unit>;
