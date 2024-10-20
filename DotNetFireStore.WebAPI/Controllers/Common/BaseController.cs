using Microsoft.AspNetCore.Mvc;

namespace DotNetFireStore.WebAPI.Controllers.Common
{
    [Route("api/[controller]/[Action]")]
    //[Authorize]
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
    }
}
