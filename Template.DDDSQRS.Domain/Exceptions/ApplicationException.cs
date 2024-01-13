namespace Template.DDDSQRS.Domain.Exceptions;

public abstract class ApplicationException(string title,
                                           string message) : Exception(message)
{
    public string Title { get; set; } = title;
}

public abstract class BadRequestException(string message) 
    : ApplicationException("Bad Request", message)
{
}

public abstract class NotFoundException(string message)
    : ApplicationException("Not Found", message)
{
}