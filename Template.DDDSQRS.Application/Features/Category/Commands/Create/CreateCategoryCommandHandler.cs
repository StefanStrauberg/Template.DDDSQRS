namespace Template.DDDSQRS.Application.Features.Category.Commands.Create;

internal class CreateCategoryCommandHandler(ICategoryRepository repository,
                                            IMapper mapper) 
    : ICommandHandler<CreateCategoryCommand, Unit>
{
    readonly ICategoryRepository _repository = repository
        ?? throw new ArgumentNullException(nameof(repository));
    readonly IMapper _mapper = mapper
        ?? throw new ArgumentNullException(nameof(mapper));

    async Task<Unit> IRequestHandler<CreateCategoryCommand, Unit>.Handle(CreateCategoryCommand request,
                                                                         CancellationToken cancellationToken)
    {
        var categoryToCreate = _mapper.Map<Domain.Category>(request.Dto);
        await _repository.InsertOneItemAsync(categoryToCreate,
                                             cancellationToken);
        return Unit.Value;
    }
}