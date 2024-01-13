namespace Template.DDDSQRS.Application.Features.Product.Queries.GetById;

public record GetProductByIdQuery(Expression<Func<Domain.Product, bool>> Expression) 
    : IQuery<ProductDetailDto>;
