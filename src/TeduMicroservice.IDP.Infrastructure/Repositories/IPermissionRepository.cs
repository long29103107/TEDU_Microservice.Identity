using TeduMicroservice.IDP.Infrastructure.Common.Domains;
using TeduMicroservice.IDP.Infrastructure.Entities;

namespace TeduMicroservice.IDP.Infrastructure.Common.Repositories;

public interface IPermissionRepository : IRepositoryBase<Permission, int>
{
    Task<IEnumerable<Permission>> GetPermissionByRole(string roleId, bool trackChanges);

    void UpdatePermission(string roleId, IEnumerable<Permission> permisstionCollection, bool trackChanges);


}
