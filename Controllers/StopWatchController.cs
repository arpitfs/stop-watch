using System;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.ServiceBus;
    

namespace StopWatch.Controllers
{
    public class StopWatchController : Controller
    {
        private string serviceBusConnectionString = "CONNECTION_STRING";
        private string queueName = "QUEUE_NAME";
        public IActionResult Duration()
        {
            return View();
        }

        public void SendToASB(string inputData)
        {
            var queueClient = new QueueClient(serviceBusConnectionString, queueName);
            var messageBody = $"Total Time : " + inputData;
            var message = new Message(Encoding.UTF8.GetBytes(messageBody));
            queueClient.SendAsync(message);
        }
    }
}
