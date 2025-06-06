namespace IZ.DockerDashboard.Web.Models.NavigationMenu;

public class MenuSectionModel
{
    public string Title { get; set; } = string.Empty;
    public string[]? Roles { get; set; }
    public IList<MenuSectionItemModel>? SectionItems { get; set; }
}