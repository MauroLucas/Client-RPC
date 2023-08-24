
using Grpc.Net.Client;
using GrpcService1;

var channel = GrpcChannel.ForAddress("http://localhost:50051");
var client = new Greeter.GreeterClient(channel);

var reply = client.SayHello(new HelloRequest { Name = "World" });
var reply2 = client.SayHelloAgain(new HelloRequest { Name = "Mauro" });
Console.WriteLine("Greeting: " + reply.Message);
Console.WriteLine("Greeting: " + reply2
    .Message);

