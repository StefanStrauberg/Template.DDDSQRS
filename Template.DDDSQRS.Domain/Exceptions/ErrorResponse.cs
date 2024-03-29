namespace Template.DDDSQRS.Domain.Exceptions;

public sealed class ErrorResponse
{
    public string Title { get; set; } = string.Empty;
    public string Details { get; set; } = string.Empty;
    public IReadOnlyDictionary<string, string[]>? Errors { get; set; }
}