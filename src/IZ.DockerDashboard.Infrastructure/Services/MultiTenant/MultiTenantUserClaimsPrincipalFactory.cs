#nullable disable warnings
using IZ.DockerDashboard.Domain.Identity;
using IZ.DockerDashboard.Infrastructure.Constants.ClaimTypes;

namespace IZ.DockerDashboard.Infrastructure.Services.MultiTenant;
/// <summary>
/// UserClaimsPrincipalFactory implementation for a single-tenant application.
/// </summary>
public class MultiTenantUserClaimsPrincipalFactory : UserClaimsPrincipalFactory<ApplicationUser, ApplicationRole>
{
    public MultiTenantUserClaimsPrincipalFactory(UserManager<ApplicationUser> userManager,
        RoleManager<ApplicationRole> roleManager,
        IOptions<IdentityOptions> optionsAccessor) : base(userManager, roleManager, optionsAccessor)
    {
    }

    /// <summary>
    /// Creates a ClaimsPrincipal for the specified user.
    /// </summary>
    /// <param name="user">The user to create the ClaimsPrincipal for.</param>
    /// <returns>The created ClaimsPrincipal.</returns>
    public override async Task<ClaimsPrincipal> CreateAsync(ApplicationUser user)
    {
        if (user == null) throw new ArgumentNullException(nameof(user));

        var identity = await GenerateClaimsAsync(user).ConfigureAwait(false);

        AddSuperiorClaims(user, identity);  // Only adding superior-related claims
        AddUserClaim(user, identity);       // Add user-specific claims
        await AddAssignedRolesClaim(user, identity);  // Add roles claims

        return new ClaimsPrincipal(identity);
    }

    private void AddSuperiorClaims(ApplicationUser user, ClaimsIdentity identity)
    {
        if (!string.IsNullOrEmpty(user.SuperiorId))
        {
            identity.AddClaim(new Claim(ApplicationClaimTypes.SuperiorId, user.SuperiorId));
        }
    }

    private void AddUserClaim(ApplicationUser user, ClaimsIdentity identity)
    {
        if (!string.IsNullOrEmpty(user.DisplayName))
        {
            identity.AddClaim(new Claim(ClaimTypes.GivenName, user.DisplayName));
        }
        if (!string.IsNullOrEmpty(user.ProfilePictureDataUrl))
        {
            identity.AddClaim(new Claim(ApplicationClaimTypes.ProfilePictureDataUrl, user.ProfilePictureDataUrl));
        }
    }

    private async Task AddAssignedRolesClaim(ApplicationUser user, ClaimsIdentity identity)
    {
        var roles = await UserManager.GetRolesAsync(user).ConfigureAwait(false);
        if (roles != null && roles.Count > 0)
        {
            var rolesStr = string.Join(",", roles);
            identity.AddClaim(new Claim(ApplicationClaimTypes.AssignedRoles, rolesStr));
        }
    }

    /// <summary>
    /// Generates the claims for the specified user.
    /// </summary>
    /// <param name="user">The user to generate the claims for.</param>
    /// <returns>The generated ClaimsIdentity.</returns>
    protected override async Task<ClaimsIdentity> GenerateClaimsAsync(ApplicationUser user)
    {
        var identity = await base.GenerateClaimsAsync(user).ConfigureAwait(false);

        if (UserManager.SupportsUserRole)
        {
            await AddUserRoleClaims(user, identity);
            await AddRoleClaims(user, identity);
        }

        return identity;
    }

    private async Task AddUserRoleClaims(ApplicationUser user, ClaimsIdentity identity)
    {
        var roles = await UserManager.GetRolesAsync(user).ConfigureAwait(false);
        foreach (var roleName in roles)
        {
            identity.AddClaim(new Claim(Options.ClaimsIdentity.RoleClaimType, roleName));
        }
    }

    private async Task AddRoleClaims(ApplicationUser user, ClaimsIdentity identity)
    {
        if (RoleManager.SupportsRoleClaims)
        {
            var roles = (await UserManager.GetRolesAsync(user).ConfigureAwait(false)).ToList();
            var tenantRoles = await RoleManager.Roles.Where(x => roles.Contains(x.Name)).ToListAsync().ConfigureAwait(false);

            foreach (var role in tenantRoles)
            {
                identity.AddClaims(await RoleManager.GetClaimsAsync(role).ConfigureAwait(false));
            }
        }
    }
}
