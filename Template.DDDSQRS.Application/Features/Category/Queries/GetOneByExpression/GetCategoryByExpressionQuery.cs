namespace Template.DDDSQRS.Application.Features.Category.Queries.GetOneByExpression;

public record GetCategoryByExpressionQuery(Expression<Func<Domain.Category, bool>> Expression) 
    : IQuery<CategoryDetailDto>;
