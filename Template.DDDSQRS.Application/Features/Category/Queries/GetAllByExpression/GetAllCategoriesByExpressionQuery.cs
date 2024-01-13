namespace Template.DDDSQRS.Application.Features.Category.Queries.GetAllByExpression;

public record GetAllCategoriesByExpressionQuery(Expression<Func<Domain.Category, bool>> Expression) 
    : IQuery<IEnumerable<CategoryDto>>;
