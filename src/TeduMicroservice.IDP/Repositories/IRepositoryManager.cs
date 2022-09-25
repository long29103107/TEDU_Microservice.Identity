using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Storage;
using TeduMicroservice.IDP.Entities;

namespace TeduMicroservice.IDP.Repositories;

public interface IRepositoryManager
{
    UserManager<User> UserManager { get; }
    RoleManager<User> RoleManager { get; }
    Task<int> SaveAsync();
    Task<IDbContextTransaction> BeginTransaction();
    Task EndTransactionAsync();
    void RollbackTransaction();

}
