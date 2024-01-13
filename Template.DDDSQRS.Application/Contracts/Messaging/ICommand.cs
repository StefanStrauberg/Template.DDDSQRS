namespace Template.DDDSQRS.Application.Contracts.Messaging;

internal interface ICommand<out TResponse> 
    : IRequest<TResponse>
{
}
