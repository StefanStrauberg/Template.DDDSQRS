namespace Template.DDDSQRS.Application.Features.Product.Commands.Update;

internal class UpdateProductCommandHandler(IProductRepository repository,
                                           IMapper mapper) 
    : ICommandHandler<UpdateProductCommand, Unit>
{
    readonly IProductRepository _repository = repository
        ?? throw new ArgumentNullException(nameof(repository));
    readonly IMapper _mapper = mapper
        ?? throw new ArgumentNullException(nameof(mapper));

    async Task<Unit> IRequestHandler<UpdateProductCommand, Unit>.Handle(UpdateProductCommand request,
                                                                        CancellationToken cancellationToken)
    {
        var productToCreate = _mapper.Map<Domain.Product>(request.Dto);
        await _repository.InsertOneItemAsync(productToCreate,
                                             cancellationToken);
        return Unit.Value;
    }
}
