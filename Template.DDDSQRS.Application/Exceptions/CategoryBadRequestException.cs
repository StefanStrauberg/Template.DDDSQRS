namespace Template.DDDSQRS.Application.Exceptions;

public sealed class CategoryBadRequestException(string id) 
    : BadRequestException($"Category with ID: {id} was not found")
{
}
