using System.ServiceModel;
using ProtoBuf.Grpc;

namespace GrpcCodeFirstShared;

[ServiceContract]
public interface IGreeterService
{
    [OperationContract]
    Task<HelloReply> SayHelloAsync(HelloRequest request, CallContext context = default);
}