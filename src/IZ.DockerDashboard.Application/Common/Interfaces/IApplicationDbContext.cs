using Microsoft.AspNetCore.DataProtection.EntityFrameworkCore;

namespace IZ.DockerDashboard.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    
    DbSet<PicklistSet> PicklistSets { get; set; }
    DbSet<DataProtectionKey> DataProtectionKeys { get; set; }
    // Asynchroniczna metoda do zapisania zmian w bazie danych
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}