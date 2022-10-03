using Microsoft.AspNetCore.Mvc;
using TeduMicroservice.IDP.Infrastructure.Common.Repositories;

namespace TeduMicroservice.IDP.Presentation.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PermissionsController : ControllerBase
{
    private readonly IRepositoryManager repositoryManager;
    public PermissionsController()
    {

    }
}
