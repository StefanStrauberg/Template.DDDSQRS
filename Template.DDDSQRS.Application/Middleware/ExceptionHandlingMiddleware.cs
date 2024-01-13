namespace Template.DDDSQRS.Application.Middleware;

public sealed class ExceptionHandlingMiddleware(IAppLogger<ExceptionHandlingMiddleware> logger) 
    : IMiddleware
{
    readonly IAppLogger<ExceptionHandlingMiddleware> _logger = logger
        ?? throw new ArgumentNullException(nameof(logger));

    async Task IMiddleware.InvokeAsync(HttpContext context,
                                       RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.ToString());
            await HandleExceptionAsync(context, ex);
        }
    }

    static async Task HandleExceptionAsync(HttpContext context,
                                           Exception ex)
    {
        var statusCode = GetStatusCode(ex);
        var title = GetTitle(ex);

        var response = new ErrorResponse
        {
            Title = title,
            Details = ex.Message,
            Errors = null
        };

        context.Response
               .ContentType = "application/json";
        context.Response
               .StatusCode = statusCode;
               
        await context.Response
                     .WriteAsync(JsonSerializer.Serialize(response));
    }

    static string GetTitle(Exception ex) =>
        ex switch
        {
            ApplicationException applicationException => applicationException.Title,
            _ => "Server Error"
        };

    static int GetStatusCode(Exception ex) =>
        ex switch
        {
            BadRequestException => StatusCodes.Status400BadRequest,
            NotFoundException => StatusCodes.Status404NotFound,
            _ => StatusCodes.Status500InternalServerError
        };
}
