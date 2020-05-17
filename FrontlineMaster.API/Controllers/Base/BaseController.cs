using Microsoft.AspNetCore.Mvc;

namespace FrontlineMaster.API.Controllers.Base
{
    [Route("api/[controller]")]
    [ApiController]
    //[APIAttributes]
    public class BaseController : ControllerBase
    {
        // to be added in later stage
        // The base api of all API Controller
        // add logs for both request & response
    }
}
