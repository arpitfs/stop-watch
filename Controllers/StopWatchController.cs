using System;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.ServiceBus;
    

namespace StopWatch.Controllers
{
    public class StopWatchController : Controller
    {
        private string serviceBusConnectionString = "Endpoint=sb://stopwatchmessanger.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=9ZnB0nAufUN6hIcFvWLIcT6gesobxSYTfTohEkmz/ZU=";
        private string queueName = "stopwatchqueue";
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