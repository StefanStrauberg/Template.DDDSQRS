namespace Template.DDDSQRS.Application.Features.Product.Queries.GetAll;

internal class GetAllProductsQueryHandler(IProductRepository repository,
                                          IMapper mapper) 
    : IQueryHandler<GetAllProductsQuery, IReadOnlyList<ProductDto>>
{
    readonly IProductRepository _repository = repository
        ?? throw new ArgumentNullException(nameof(repository));
    readonly IMapper _mapper = mapper
        ?? throw new ArgumentNullException(nameof(mapper));

    async Task<IReadOnlyList<ProductDto>> IRequestHandler<GetAllProductsQuery, IReadOnlyList<ProductDto>>.Handle(GetAllProductsQuery request,
                                                                                                                 CancellationToken cancellationToken)
    {
        var produtcs = await _repository.GetAllItemsAsync(cancellationToken);
        return _mapper.Map<IReadOnlyList<ProductDto>>(produtcs);
    }
}