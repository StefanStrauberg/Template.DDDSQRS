namespace Template.DDDSQRS.Application.Features.Category.Commands.Delete;

internal class DeleteCategoryCommandHandler(ICategoryRepository repository) 
    : ICommandHandler<DeleteCategoryCommand, Unit>
{
    readonly ICategoryRepository _repository = repository
        ?? throw new ArgumentNullException(nameof(repository));

    async Task<Unit> IRequestHandler<DeleteCategoryCommand, Unit>.Handle(DeleteCategoryCommand request,
                                                                         CancellationToken cancellationToken)
    {
        var categoryExist = await _repository.ExistsItemAsync(q => q.Id == request.Id,
                                                              cancellationToken);
        if (!categoryExist)
            throw new CategoryNotFoundException(request.Id.ToString());

        await _repository.DeleteItemsAsync(q => q.Id == request.Id,
                                           cancellationToken);
        return Unit.Value;
    }
}