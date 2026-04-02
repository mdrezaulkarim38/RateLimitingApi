using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;

namespace RateLimitingApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HomeController : ControllerBase
{
    [EnableRateLimiting("FixedPolicy")]
    [HttpGet("get-name")]
    public string GetName()
    {
        return "hello to controller"+DateTime.Now.ToString("HH:mm:ss");
    }
}