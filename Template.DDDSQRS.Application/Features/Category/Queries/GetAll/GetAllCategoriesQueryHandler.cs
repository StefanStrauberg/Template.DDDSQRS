namespace Template.DDDSQRS.Application.Features.Category.Queries.GetAll;

internal class GetAllCategoriesQueryHandler(ICategoryRepository repository,
                                            IMapper mapper) 
    : IQueryHandler<GetAllCategoriesQuery, IEnumerable<CategoryDto>>
{
    readonly ICategoryRepository _repository = repository
        ?? throw new ArgumentNullException(nameof(repository));
    readonly IMapper _mapper = mapper
        ?? throw new ArgumentNullException(nameof(mapper));

    async Task<IEnumerable<CategoryDto>> IRequestHandler<GetAllCategoriesQuery, IEnumerable<CategoryDto>>.Handle(GetAllCategoriesQuery request,
                                                                                                                 CancellationToken cancellationToken)
    {
        var categries = await _repository.GetAllItemsAsync(cancellationToken);
        return _mapper.Map<IEnumerable<CategoryDto>>(categries);
    }
}
