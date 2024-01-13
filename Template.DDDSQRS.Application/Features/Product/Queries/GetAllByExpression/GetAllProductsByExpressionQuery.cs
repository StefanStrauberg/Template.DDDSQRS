namespace Template.DDDSQRS.Application.Features.Product.Queries.GetAllByExpression;

public record GetAllProductsByExpressionQuery(Expression<Func<Domain.Product, bool>> Expression)
    : IQuery<IEnumerable<ProductDto>>;
