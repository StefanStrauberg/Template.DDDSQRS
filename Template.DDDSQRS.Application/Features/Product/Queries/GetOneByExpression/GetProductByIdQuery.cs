namespace Template.DDDSQRS.Application.Features.Product.Queries.GetOneByExpression;

public record GetOneProductByExpressionQuery(Expression<Func<Domain.Product, bool>> Expression) 
    : IQuery<ProductDetailDto>;
