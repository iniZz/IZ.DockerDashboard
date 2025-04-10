using IZ.DockerDashboard.Web.Models.NavigationMenu;

namespace IZ.DockerDashboard.Web.Services.Navigation;

public interface IMenuService
{
    IEnumerable<MenuSectionModel> Features { get; }
}