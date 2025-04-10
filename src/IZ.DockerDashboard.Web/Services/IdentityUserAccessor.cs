using IZ.DockerDashboard.Domain.Identity;
using Microsoft.AspNetCore.Identity;

namespace IZ.DockerDashboard.Web.Services;

internal sealed class IdentityUserAccessor(
    UserManager<ApplicationUser> userManager,
    IdentityRedirectManager redirectManager)
{
    public async Task<ApplicationUser> GetRequiredUserAsync(HttpContext context)
    {
        var user = await userManager.GetUserAsync(context.User).ConfigureAwait(false);

        if (user is null)
            redirectManager.RedirectToWithStatus("/pages/authentication/InvalidUser",
                $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);

        return user;
    }
}