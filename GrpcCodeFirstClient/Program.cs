using Grpc.Net.Client;
using GrpcCodeFirstShared;
using ProtoBuf.Grpc.Client;

using var channel = GrpcChannel.ForAddress("https://localhost:5296");
var client = channel.CreateGrpcService<IGreeterService>();

var reply = await client.SayHelloAsync(
    new HelloRequest { Name = "GreeterClient" });

Console.WriteLine($"Greeting: {reply.Message}");
Console.ReadLine();
