using System.Collections.Concurrent;

namespace IZ.DockerDashboard.Application.Common.Interfaces.Identity;

public interface IUsersStateContainer
{
    ConcurrentDictionary<string, string> UsersByConnectionId { get; }
    event Action? OnChange;
    void AddOrUpdate(string connectionId, string? userId);
    void Remove(string connectionId);
    void Clear(string userId);
}