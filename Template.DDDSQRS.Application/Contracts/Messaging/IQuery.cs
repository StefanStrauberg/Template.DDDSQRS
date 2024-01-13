namespace Template.DDDSQRS.Application.Contracts.Messaging;

internal interface IQuery<out TResponse>
    : IRequest<TResponse>
{
}