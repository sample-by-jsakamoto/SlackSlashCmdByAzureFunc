using System;
using System.Net;
using System.Net.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

public static class SlashCommands
{
    [FunctionName("SlashCommands")]
    public static HttpResponseMessage Run([HttpTrigger(AuthorizationLevel.Function, "post")]HttpRequestMessage req, TraceWriter log)
    {
        return req.CreateResponse(HttpStatusCode.OK, new
        {
            text = DateTime.Now.ToString(),
            response_type = "in_channel",
        });
    }
}
