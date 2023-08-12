using System;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace queuetrigger
{
    public class mytrigger
    {
        private readonly ILogger _logger;

        public mytrigger(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<mytrigger>();
        }

        [Function("mytrigger")]
        public void Run([QueueTrigger("myqueue-items", Connection = "")] string myQueueItem)
        {
            _logger.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
