using Generated;
using System;
using Grpc.Core;
using System.Threading.Tasks;

namespace Server
{
    internal class HalloService : Generated.HalloService.HalloServiceBase
    {
        public override Task<HalloResponse> SayHi(HalloRequest request, ServerCallContext context)
        {
            Console.WriteLine("Hello "+request.Name);
            return Task.FromResult(new HalloResponse());
        }
    }
}
