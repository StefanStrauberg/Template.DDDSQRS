namespace Template.DDDSQRS.Application.Features.Product.Commands.Create;

internal class CreateProductCommandHandler(IProductRepository repository,
                                           IMapper mapper) 
    : ICommandHandler<CreateProductCommand, Unit>
{
    readonly IProductRepository _repository = repository
        ?? throw new ArgumentNullException(nameof(repository));
    readonly IMapper _mapper = mapper
        ?? throw new ArgumentNullException(nameof(mapper));

    async Task<Unit> IRequestHandler<CreateProductCommand, Unit>.Handle(CreateProductCommand request,
                                                                        CancellationToken cancellationToken)
    {
        var productToCreate = _mapper.Map<Domain.Product>(request.Dto);
        await _repository.InsertOneItemAsync(productToCreate,
                                             cancellationToken);
        return Unit.Value;
    }
}
