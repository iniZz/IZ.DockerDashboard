using AutoMapper;
using AutoMapper.QueryableExtensions;
using IZ.DockerDashboard.Application.Features.Identity.DTOs;
using IZ.DockerDashboard.Domain.Identity;
using ZiggyCreatures.Caching.Fusion;

namespace IZ.DockerDashboard.Infrastructure.Services.Identity;

public class UserService : IUserService
{
    private const string CACHEKEY = "ALL-ApplicationUserDto";
    private readonly IMapper _mapper;
    private readonly IFusionCache _fusionCache;
    private readonly UserManager<ApplicationUser> _userManager;

    public UserService(
        IMapper mapper,
        IFusionCache fusionCache,
        IServiceScopeFactory scopeFactory)
    {
        _mapper = mapper;
        _fusionCache = fusionCache;
        var scope = scopeFactory.CreateScope();
        _userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
        DataSource = new List<ApplicationUserDto>();
    }

    public List<ApplicationUserDto> DataSource { get; private set; }

    public event Func<Task>? OnChange;

    public void Initialize()
    {
        DataSource = _fusionCache.GetOrSet(CACHEKEY,
                         _ => _userManager.Users.Include(x => x.UserRoles).ThenInclude(x => x.Role)
                             .ProjectTo<ApplicationUserDto>(_mapper.ConfigurationProvider).OrderBy(x => x.UserName)
                             .ToList())
                     ?? new List<ApplicationUserDto>();
        OnChange?.Invoke();
    }


    public void Refresh()
    {
        _fusionCache.Remove(CACHEKEY);
        DataSource = _fusionCache.GetOrSet(CACHEKEY,
                         _ => _userManager.Users.Include(x => x.UserRoles).ThenInclude(x => x.Role)
                             .ProjectTo<ApplicationUserDto>(_mapper.ConfigurationProvider).OrderBy(x => x.UserName)
                             .ToList())
                     ?? new List<ApplicationUserDto>();
        OnChange?.Invoke();
    }
}