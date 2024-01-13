namespace Template.DDDSQRS.Domain.Exceptions;

public abstract class BadRequestException(string message) 
    : ApplicationException("Bad Request", message)
{
}
