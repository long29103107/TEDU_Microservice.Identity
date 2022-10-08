using Dapper;
using TeduMicroservice.IDP.Infrastructure.Common.Domains;
using TeduMicroservice.IDP.Infrastructure.Entities;
using TeduMicroservice.IDP.Infrastructure.ViewModels;
using TeduMicroservice.IDP.Persistence;

namespace TeduMicroservice.IDP.Infrastructure.Common.Repositories;

public class PermissionRepository : RepositoryBase<Permission, int>, IPermissionRepository
{
    public PermissionRepository(TeduIdentityContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
    {
    }

    public async Task<IReadOnlyList<PermissionViewModel>> GetPermissionByRole(string roleId)
    {
        var parameters = new DynamicParameters();
        parameters.Add("@roleId", roleId);
        var result = await QueryAsync<PermissionViewModel>("Get_Permission_ByRoleId", parameters);
        return result;
    }

    public void UpdatePermission(string roleId, IEnumerable<Permission> permisstionCollection, bool trackChanges)
    {
        throw new NotImplementedException();
    }
}
