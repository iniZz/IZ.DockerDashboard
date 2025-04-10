using IZ.DockerDashboard.Application.Features.Identity.DTOs;

namespace IZ.DockerDashboard.Application.Common.Interfaces.Identity;

public interface IUserService
{
    List<ApplicationUserDto> DataSource { get; }
    event Func<Task>? OnChange;
    void Initialize();
    void Refresh();
}