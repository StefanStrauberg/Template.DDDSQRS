namespace Template.DDDSQRS.Application.Contracts.Logger;

public interface IAppLogger<T>
{
    void LogInformation(string message,
                        params object[] args);
    void LogWarning(string message,
                    params object[] args);
    void LogError(string message,
                  params object[] args);
}
