using Microsoft.AspNetCore.Mvc;

namespace RateLimitingApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HomeController : ControllerBase
{
    [HttpGet("get-name")]
    public string GetName()
    {
        return "hello to controller";
    }
}