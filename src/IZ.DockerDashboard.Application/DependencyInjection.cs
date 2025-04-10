using Microsoft.Extensions.DependencyInjection;
using IZ.DockerDashboard.Application.Common.PublishStrategies;
using IZ.DockerDashboard.Application.Pipeline;
using IZ.DockerDashboard.Application.Pipeline.PreProcessors;
using Microsoft.Extensions.Hosting;

namespace IZ.DockerDashboard.Application;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        services.AddTransient(typeof(IRequestExceptionHandler<,,>), typeof(DbExceptionHandler<,,>));
        services.AddMediatR(config =>
        {
            config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            config.NotificationPublisher = new ParallelNoWaitPublisher();
            config.AddRequestPreProcessor(typeof(IRequestPreProcessor<>), typeof(ValidationPreProcessor<>));
            config.AddOpenBehavior(typeof(PerformanceBehaviour<,>));
            config.AddOpenBehavior(typeof(FusionCacheBehaviour<,>));
            config.AddOpenBehavior(typeof(CacheInvalidationBehaviour<,>));

        });
        services.AddScoped<UserProfileStateService>();
        return services;
    }
    public static void InitializeCacheFactory(this IHost host)
    {
        FusionCacheFactory.Configure(host.Services);
    }
}