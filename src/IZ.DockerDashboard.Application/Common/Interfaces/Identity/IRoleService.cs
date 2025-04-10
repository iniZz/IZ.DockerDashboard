using IZ.DockerDashboard.Application.Features.Identity.DTOs;

namespace IZ.DockerDashboard.Application.Common.Interfaces.Identity;

public interface IRoleService
{
    List<ApplicationRoleDto> DataSource { get; }
    event Func<Task>? OnChange;
    void Initialize();
    void Refresh();
}