﻿
namespace IZ.DockerDashboard.Domain.Identity;

public class ApplicationRoleClaim : IdentityRoleClaim<string>
{
    public string? Description { get; set; }
    public string? Group { get; set; }
    public virtual ApplicationRole Role { get; set; } = default!;
}