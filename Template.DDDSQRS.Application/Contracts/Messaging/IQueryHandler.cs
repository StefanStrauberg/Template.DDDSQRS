using Template.DDDSQRS.Application.Features.Product.Queries.GetAll;

namespace Template.DDDSQRS.Application.Contracts.Messaging;

internal interface IQueryHandler<in TQuery, TResponse>
    : IRequestHandler<TQuery, TResponse>

    where TQuery : IQuery<TResponse>
{
}