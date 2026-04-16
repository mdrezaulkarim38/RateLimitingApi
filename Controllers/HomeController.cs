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

    [EnableRateLimiting("SlidingPolicy")]
    [HttpGet("get-time")]
    public string GetTime()
    {
        return "Sliding Window: "+DateTime.Now.ToString("HH:mm:ss"); 
    }
    
    [EnableRateLimiting("TokenBucketPolicy")]
    [HttpGet("get-data")]
    public string GetData()
    {
        return "Token Bucket: " + DateTime.Now.ToString("HH:mm:ss");
    }
    
    [EnableRateLimiting("ConcurrencyPolicy")]
    [HttpGet("heavy-report")]
    public async Task<string> HeavyReport()
    {
        await Task.Delay(5000);
        return "Report ready: " + DateTime.Now.ToString("HH:mm:ss");
    }
}