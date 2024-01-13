namespace Template.DDDSQRS.Application.Contracts.Messaging;

internal interface ICommandHandler<in TCommand, TResponse> 
    : IRequestHandler<TCommand, TResponse> 
    where TCommand : ICommand<TResponse>
{
}
