namespace Template.DDDSQRS.Application.Features.Product.Queries.GetOneByExpression;

internal class GetProductByExpressionQueryHandler(IProductRepository repository,
                                                  IMapper mapper) 
    : IQueryHandler<GetOneProductByExpressionQuery, ProductDetailDto>
{
    readonly IProductRepository _repository = repository
        ?? throw new ArgumentNullException(nameof(repository));
    readonly IMapper _mapper = mapper
        ?? throw new ArgumentNullException(nameof(mapper));

    async Task<ProductDetailDto> IRequestHandler<GetOneProductByExpressionQuery, ProductDetailDto>.Handle(GetOneProductByExpressionQuery request,
                                                                                                          CancellationToken cancellationToken)
    {
        var product = await _repository.GetItemByExpressionAsync(request.Expression,
                                                                 cancellationToken) 
            ?? throw new ProductNotFoundException(request.Expression.Body.ToString());
        return _mapper.Map<ProductDetailDto>(product);
    }
}
