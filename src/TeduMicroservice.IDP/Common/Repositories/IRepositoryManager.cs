using Microsoft.EntityFrameworkCore.Storage;
using TeduMicroservice.IDP.Entities;

namespace TeduMicroservice.IDP.Common.Repositories;

public interface IRepositoryManager
{
    IPermissionRepository Permission { get; }
    Task<int> SaveAsync();
    Task<IDbContextTransaction> BeginTransaction();
    Task EndTransactionAsync();
    void RollbackTransaction();

}
