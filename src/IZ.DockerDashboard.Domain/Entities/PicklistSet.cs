
using System.ComponentModel;
using IZ.DockerDashboard.Domain.Common.Entities;
namespace IZ.DockerDashboard.Domain.Entities;

public class PicklistSet : BaseAuditableEntity, IAuditTrial
{
    public Picklist Name { get; set; } = Picklist.Brand;
    public string? Value { get; set; }
    public string? Text { get; set; }
    public string? Description { get; set; }
}

public enum Picklist
{
    [Description("Status")] Status,
    [Description("Unit")] Unit,
    [Description("Brand")] Brand
}