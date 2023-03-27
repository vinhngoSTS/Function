using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace STS.Function;

public static class BlobTrigger
{
    [FunctionName("BlobTrigger")]
    public static async Task RunAsync([BlobTrigger("file/{name}", Connection = "BlobConnectionString")] Stream myBlob,
        string name, ILogger log)
    {
        log.LogInformation($"====C# Blob trigger function Processed blob Name:{name}, Size: {myBlob.Length} Bytes - Time: {DateTime.Now}");
    }
}