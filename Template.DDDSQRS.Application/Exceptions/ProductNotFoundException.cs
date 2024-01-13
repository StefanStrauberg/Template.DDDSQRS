namespace Template.DDDSQRS.Application.Exceptions;

public sealed class ProductNotFoundException(string message)
    : NotFoundException(message)
{
}
