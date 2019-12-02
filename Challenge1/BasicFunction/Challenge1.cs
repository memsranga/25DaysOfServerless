using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace BasicFunction
{
    public static class Challenge1
    {
        [FunctionName("Challenge1")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
            ILogger log)
        {

            var preferredOutput = new char[] { 'נ', 'ג', 'ה', 'ש' };
            var random = new Random();
            var randomIdex = random.Next(4);

            return (ActionResult)new OkObjectResult(preferredOutput[randomIdex]);
        }
    }
}