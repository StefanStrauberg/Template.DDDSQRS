namespace Template.DDDSQRS.Application.Exceptions;

public sealed class CategoryNotFoundException(string id)
    : NotFoundException($"Category with ID: {id} was not found")
{
}