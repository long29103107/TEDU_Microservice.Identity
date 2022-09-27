using TeduMicroservice.IDP.Common.Domains;
using TeduMicroservice.IDP.Entities;

namespace TeduMicroservice.IDP.Common.Repositories;

public interface IPermissionRepository : IRepositoryBase<Permission, int>
{
    Task<IEnumerable<Permission>> GetPermissionByRole(string roleId, bool trackChanges);

    void UpdatePermission(string roleId, IEnumerable<Permission> permisstionCollection, bool trackChanges);


}
