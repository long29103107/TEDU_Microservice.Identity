using TeduMicroservice.IDP.Infrastructure.Common.Domains;
using TeduMicroservice.IDP.Infrastructure.Entities;
using TeduMicroservice.IDP.Infrastructure.ViewModels;

namespace TeduMicroservice.IDP.Infrastructure.Common.Repositories;

public interface IPermissionRepository : IRepositoryBase<Permission, int>
{
    Task<IReadOnlyList<PermissionViewModel>> GetPermissionByRole(string roleId);

    void UpdatePermission(string roleId, IEnumerable<Permission> permisstionCollection, bool trackChanges);


}
