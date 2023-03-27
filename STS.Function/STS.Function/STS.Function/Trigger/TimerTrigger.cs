using System;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace STS.Function;

public static class TimerTrigger
{
    [FunctionName("TimerTrigger")]
    public static async Task RunAsync([TimerTrigger("5,8,10 * * * * *")] TimerInfo myTimer, ILogger log)
    {
        log.LogInformation($"C# Timer trigger function executed at: {DateTime.UtcNow}");
    }
}