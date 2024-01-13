namespace Template.DDDSQRS.Application.Features.Product.Queries.GetById;

internal class GetProductByExpressionQueryHandler(IProductRepository repository,
                                                  IMapper mapper) 
    : IQueryHandler<GetProductByIdQuery, ProductDetailDto>
{
    readonly IProductRepository _repository = repository;
    readonly IMapper _mapper = mapper;

    async Task<ProductDetailDto> IRequestHandler<GetProductByIdQuery, ProductDetailDto>.Handle(GetProductByIdQuery request,
                                                                                               CancellationToken cancellationToken)
    {
        var product = await _repository.GetItemByExpressionAsync(request.Expression,
                                                                 cancellationToken) 
            ?? throw new ProductNotFoundException(request.Expression.Body.ToString());
        return _mapper.Map<ProductDetailDto>(product);
    }
}
