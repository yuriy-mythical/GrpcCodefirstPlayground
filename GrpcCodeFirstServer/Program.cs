using GrpcCodeFirstServer;
using ProtoBuf.Grpc.Server;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCodeFirstGrpc();
var app = builder.Build();
app.UseRouting();
app.UseEndpoints(enpoints =>
{
    enpoints.MapGrpcService<GreeterService>();
});


app.Run();