namespace Template.DDDSQRS.Application.Features.Category.Commands.Update;

internal class UpdateCategoryCommandHandler(ICategoryRepository repository,
                                            IMapper mapper) 
    : ICommandHandler<UpdateCategoryCommand, Unit>
{
    readonly ICategoryRepository _repository = repository
        ?? throw new ArgumentNullException(nameof(repository));
    readonly IMapper _mapper = mapper
        ?? throw new ArgumentNullException(nameof(mapper));

    async Task<Unit> IRequestHandler<UpdateCategoryCommand, Unit>.Handle(UpdateCategoryCommand request,
                                                                         CancellationToken cancellationToken)
    {
        var categoryToUpdate = _mapper.Map<Domain.Category>(request.Dto);
        await _repository.UpdateItemAsync(categoryToUpdate,
                                          cancellationToken);
        return Unit.Value;
    }
}