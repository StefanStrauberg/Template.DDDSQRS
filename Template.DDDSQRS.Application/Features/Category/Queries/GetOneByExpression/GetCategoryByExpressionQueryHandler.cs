namespace Template.DDDSQRS.Application.Features.Category.Queries.GetOneByExpression;

internal class GetCategoryByExpressionQueryHandler(ICategoryRepository repository,
                                                        IMapper mapper) 
    : IQueryHandler<GetCategoryByExpressionQuery, CategoryDetailDto>
{
    readonly ICategoryRepository _repository = repository
        ?? throw new ArgumentNullException(nameof(repository));
    readonly IMapper _mapper = mapper
        ?? throw new ArgumentNullException(nameof(mapper));

    async Task<CategoryDetailDto> IRequestHandler<GetCategoryByExpressionQuery, CategoryDetailDto>.Handle(GetCategoryByExpressionQuery request,
                                                                                                          CancellationToken cancellationToken)
    {
        var categries = await _repository.GetAllItemsByExpressionAsync(request.Expression,
                                                                       cancellationToken);
        return _mapper.Map<CategoryDetailDto>(categries);
    }
}