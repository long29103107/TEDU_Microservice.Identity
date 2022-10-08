using Microsoft.AspNetCore.Mvc;
using TeduMicroservice.IDP.Infrastructure.Common.Repositories;

namespace TeduMicroservice.IDP.Presentation.Controllers;
[Route("api/roles/{roleId}/[controller]")]
[ApiController]
public class PermissionsController : ControllerBase
{
    private readonly IRepositoryManager _repository;
    public PermissionsController(IRepositoryManager repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public async Task<IActionResult>GetPermissions(string roleId)
    {
        var result = await _repository.Permission.GetPermissionByRole(roleId);
        return Ok(result);
    }    
}
