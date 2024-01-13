namespace Template.DDDSQRS.Application.Features.Product.Queries.GetAll;

internal class GetAllProductsQueryHandler(IProductRepository repository,
                                          IMapper mapper) 
    : IQueryHandler<GetAllProducts, IReadOnlyList<ProductDto>>
{
    readonly IProductRepository _repository = repository;
    readonly IMapper _mapper = mapper;

    async Task<IReadOnlyList<ProductDto>> IRequestHandler<GetAllProducts, IReadOnlyList<ProductDto>>.Handle(GetAllProducts request,
                                                                                                            CancellationToken cancellationToken)
    {
        var produtcs = await _repository.GetAllItemsAsync(cancellationToken);
        return _mapper.Map<IReadOnlyList<ProductDto>>(produtcs);
    }
}