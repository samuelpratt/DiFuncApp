using DiFuncApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System;
using Willezone.Azure.WebJobs.Extensions.DependencyInjection;

namespace DiFuncApp
{
    public static class PingFunction
    {
        [FunctionName("Ping")]
        public static IActionResult Ping(
            [HttpTrigger(AuthorizationLevel.Function, "get")]HttpRequest req,
            [Inject]IPing ping)
        {
            
            return new OkObjectResult(ping.PingHost("Foo"));
        }
    }
}
