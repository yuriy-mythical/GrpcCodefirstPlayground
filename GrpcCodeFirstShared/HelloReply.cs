using System.Runtime.Serialization;

namespace GrpcCodeFirstShared;

[DataContract]
public class HelloReply
{
    [DataMember(Order = 1)]
    public string? Message { get; set; }
}