namespace Template.DDDSQRS.Application.Features.Category.Queries.GetAllByExpression;

internal class GetAllCategoriesByExpressionQueryHandler(ICategoryRepository repository,
                                                        IMapper mapper) 
    : IQueryHandler<GetAllCategoriesByExpressionQuery, IEnumerable<CategoryDto>>
{
    readonly ICategoryRepository _repository = repository
        ?? throw new ArgumentNullException(nameof(repository));
    readonly IMapper _mapper = mapper
        ?? throw new ArgumentNullException(nameof(mapper));

    async Task<IEnumerable<CategoryDto>> IRequestHandler<GetAllCategoriesByExpressionQuery, IEnumerable<CategoryDto>>.Handle(GetAllCategoriesByExpressionQuery request,
                                                                                                                             CancellationToken cancellationToken)
    {
        var categries = await _repository.GetAllItemsByExpressionAsync(request.Expression,
                                                                       cancellationToken);
        return _mapper.Map<IEnumerable<CategoryDto>>(categries);
    }
}
