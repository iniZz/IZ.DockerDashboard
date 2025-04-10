namespace IZ.DockerDashboard.Application.Common.Interfaces.Caching;

public interface ICacheInvalidatorRequest<TResponse> : IRequest<TResponse>
{
    string CacheKey => string.Empty;
    IEnumerable<string>? Tags { get; }
}