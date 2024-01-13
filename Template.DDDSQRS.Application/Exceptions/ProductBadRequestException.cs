namespace Template.DDDSQRS.Application.Exceptions;

public sealed class ProductBadRequestException(string message) 
    : BadRequestException(message)
{
}
