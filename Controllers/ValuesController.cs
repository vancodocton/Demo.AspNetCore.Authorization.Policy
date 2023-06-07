using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ValuesController : ControllerBase
{
    [HttpGet("DefaultPolicy")]
    [Authorize]
    public ActionResult<string> DefaultPolicy()
    {
        return Ok("DefaultPolicy");
    }

    [HttpGet("CustomPolicy")]
    [Authorize("CustomPolicy")]
    public ActionResult<string> CustomPolicy()
    {
        return Ok("CustomPolicy");
    }
}
