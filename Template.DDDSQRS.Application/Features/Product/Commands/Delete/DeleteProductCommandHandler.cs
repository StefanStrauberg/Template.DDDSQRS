namespace Template.DDDSQRS.Application.Features.Product.Commands.Delete;

internal class DeleteProductCommandHandler(IProductRepository repository) 
    : ICommandHandler<DeleteProductCommand, Unit>
{
    readonly IProductRepository _repository = repository;

    async Task<Unit> IRequestHandler<DeleteProductCommand, Unit>.Handle(DeleteProductCommand request,
                                                                        CancellationToken cancellationToken)
    {
        var productExists = await _repository.ExistsItemAsync(product => product.Id == request.Id,
                                                              cancellationToken);
        if (!productExists)
            throw new ProductNotFoundException(request.Id.ToString());
            
        await _repository.DeleteItemsAsync(product => product.Id == request.Id,
                                           cancellationToken);
        return Unit.Value;
    }
}