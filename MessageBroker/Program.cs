using Microsoft.Extensions.DependencyInjection;
using Operations.Interfaces;
using System;

namespace MessageBroker
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new ServiceCollection();

            collection.AddTransient<IMessaging, Operations.Implementations.Messaging>();

            var servicingProvider = collection.BuildServiceProvider();
            var service = servicingProvider.GetService<IMessaging>();

            Console.WriteLine(service.GetMessage());
            Console.ReadKey();
        }
    }
}
