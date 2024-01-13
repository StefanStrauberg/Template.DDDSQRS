namespace Template.DDDSQRS.Application.Features.Product.Queries.GetAllByExpression;

internal class GetAllProductsByExpressionQueryHandler(IProductRepository repository,
                                                      IMapper mapper) 
    : IQueryHandler<GetAllProductsByExpressionQuery, IEnumerable<ProductDto>>
{
    readonly IProductRepository _repository = repository
        ?? throw new ArgumentNullException(nameof(repository));
    readonly IMapper _mapper = mapper
        ?? throw new ArgumentNullException(nameof(mapper));

    async Task<IEnumerable<ProductDto>> IRequestHandler<GetAllProductsByExpressionQuery, IEnumerable<ProductDto>>.Handle(GetAllProductsByExpressionQuery request,
                                                                                                                         CancellationToken cancellationToken)
    {
        var products = await _repository.GetAllItemsByExpressionAsync(request.Expression,
                                                                      cancellationToken);
        return _mapper.Map<IEnumerable<ProductDto>>(products);
    }
}
