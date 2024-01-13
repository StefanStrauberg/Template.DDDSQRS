namespace Template.DDDSQRS.Application.Features.Category.Queries.GetAll;

public record GetAllCategoriesQuery() : IQuery<IEnumerable<CategoryDto>>;
