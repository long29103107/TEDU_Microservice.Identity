using TeduMicroservice.IDP.Infrastructure.Common.Domains;
using TeduMicroservice.IDP.Infrastructure.Entities;
using TeduMicroservice.IDP.Persistence;

namespace TeduMicroservice.IDP.Infrastructure.Common.Repositories;

public class PermissionRepository : RepositoryBase<Permission, int>, IPermissionRepository
{
    public PermissionRepository(TeduIdentityContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
    {
    }

    public Task<IEnumerable<Permission>> GetPermissionByRole(string roleId, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public void UpdatePermission(string roleId, IEnumerable<Permission> permisstionCollection, bool trackChanges)
    {
        throw new NotImplementedException();
    }
}
