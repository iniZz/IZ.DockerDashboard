using IZ.DockerDashboard.Application.Features.PicklistSets.DTOs;

namespace IZ.DockerDashboard.Application.Common.Interfaces;

public interface IPicklistService
{
    List<PicklistSetDto> DataSource { get; }
    event Func<Task>? OnChange;
    void Initialize();
    void Refresh();
}