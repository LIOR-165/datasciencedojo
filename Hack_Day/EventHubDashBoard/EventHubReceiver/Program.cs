﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.ServiceBus.Messaging;

namespace EventHubReceiver
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            string eventHubConnectionString = "Endpoint=sb://sensortaghub-ns.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=M3m5CupqfK6O1NPEeNAwC0EcOcyFtcxciQflmrIcN+8=";
            string eventHubName = "aggregatesensorhub";
=======
            string eventHubConnectionString = "Endpoint=sb://tolltest.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=V93mgRhRp0d1FkslcsyjOZNLjo5iSZ730wJuWbZIbS8=";
            string eventHubName = "entry";
>>>>>>> 6edc406adff5d3b8d28a07808578776317ef3704
            string storageAccountName = "dojoattendeestorage";
            string storageAccountKey = "OtJ77t3X6uMNIf6zd3xr4ZewW9vXDK9XQtaGXx7gOoaULgGQyBuvAfrC2aiOkUY/WV9H4lVU+ngaLUle7gVuWQ==";
            string storageConnectionString = string.Format("DefaultEndpointsProtocol=https;AccountName={0};AccountKey={1}",
                        storageAccountName, storageAccountKey);

            string eventProcessorHostName = Guid.NewGuid().ToString();
            EventProcessorHost eventProcessorHost = new EventProcessorHost(eventProcessorHostName, eventHubName, EventHubConsumerGroup.DefaultGroupName, eventHubConnectionString, storageConnectionString);
            eventProcessorHost.RegisterEventProcessorAsync<SimpleEventProcessor>().Wait();

            Console.WriteLine("Receiving. Press enter key to stop worker.");
            Console.ReadLine();
        }
    }
}
