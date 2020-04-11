using Grpc.Core;
using System;
using Generated;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            const string Host = "localhost";
            const int Port = 16842;

            var channel = new Channel($"{Host}:{Port}", ChannelCredentials.Insecure);

            var request = new HalloRequest();

            Console.WriteLine("Enter you'r name: ");

            request.Name = Console.ReadLine();

            var client = new HalloService.HalloServiceClient(channel);

            client.SayHi(request);

            // Shutdown
            channel.ShutdownAsync().Wait();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
