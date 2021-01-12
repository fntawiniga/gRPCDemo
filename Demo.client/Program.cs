using Grpc.Core;
using Grpc.Net.Client;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Demo.client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Return "true" to allow certificates that are untrusted/invalid
            //https://github.com/grpc/grpc-dotnet/issues/792
            var httpHandler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback =
                    HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };

            var channel = GrpcChannel.ForAddress("https://localhost:5001", new GrpcChannelOptions { HttpHandler = httpHandler });
            var client = new Characters.CharactersClient(channel);

            var responseUnary =  await client.GetCharacterAsync(new CharacterRequest { Id = 3 });

            Console.WriteLine($"Character is: {responseUnary.Character.FirstName} {responseUnary.Character.LastName}");

            AsyncServerStreamingCall<CharacterResponse> requestServerStreaming = client.SearchCharacters(new SearchRequest { Query = "wiggles" });
            await foreach(var responseServerStreaming in requestServerStreaming.ResponseStream.ReadAllAsync())
            {
                Console.WriteLine($"Character is: {responseServerStreaming.Character.FirstName} {responseServerStreaming.Character.LastName}");
            }
            
            var key = Console.ReadKey();
            using (AsyncClientStreamingCall<SumRequest, SumResponse> call = client.DoSum())
            {
                while(char.IsDigit(key.KeyChar))
                {
                    var number = int.Parse(key.KeyChar.ToString());
                    var request = new SumRequest { Value = number };

                    await call.RequestStream.WriteAsync(request);
                    key = Console.ReadKey();
                }
                await call.RequestStream.CompleteAsync();

                var response = await call.ResponseAsync;
                Console.WriteLine();
                Console.WriteLine($"Total is {response.Total}");
            }
        }
    }
}
