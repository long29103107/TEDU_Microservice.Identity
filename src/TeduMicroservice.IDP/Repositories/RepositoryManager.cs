using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Storage;
using TeduMicroservice.IDP.Common.Domains;
using TeduMicroservice.IDP.Entities;
using TeduMicroservice.IDP.Persistence;

namespace TeduMicroservice.IDP.Repositories;

public class RepositoryManager : IRepositoryManager
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly TeduIdentityContext _context;
    public UserManager<User> UserManager { get; }
    public RoleManager<User> RoleManager { get; }

    public RepositoryManager(TeduIdentityContext context, IUnitOfWork unitOfWork, UserManager<User> userManager, RoleManager<User> roleManager)
    {
        _context = context;
        _unitOfWork = unitOfWork;
        UserManager = userManager;
        RoleManager = roleManager;
    }

    public Task<IDbContextTransaction> BeginTransaction()
    {
        return _context.Database.BeginTransactionAsync();
    }

    public Task EndTransactionAsync()
    {
        return _context.Database.CommitTransactionAsync();
    }

    public void RollbackTransaction()
    {
        _context.Database.RollbackTransactionAsync();
    }

    public Task<int> SaveAsync()
    {
        return _unitOfWork.CommitAsync();
    }
}
