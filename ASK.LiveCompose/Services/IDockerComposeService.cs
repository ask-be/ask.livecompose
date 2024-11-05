using System.Collections;

namespace ASK.LiveCompose.Services;

public interface IDockerComposeService
{
    Task UpdateProjectAsync(
        string projectName,
        string? service,
        IReadOnlyDictionary<string,string> environmentVariables,
        Action<string> writeLogLine,
        CancellationToken cancellationToken);

    Task GetProjectServiceLogs(
        string projectName,
        string? serviceName,
        bool includeTimeStamp,
        string? tail,
        string? since,
        Action<string> writeLogLine,
        CancellationToken cancellationToken);

    Task<string> GetProjectAsync(string projectName, CancellationToken cancellationToken);

    void PrintProjectTokens();

    string? GetProjectToken(string projectName);
}