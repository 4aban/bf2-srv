// using bf2srv-wadmin.Common.Abstractions;
// using MessagePack;
//
// namespace bf2srv-wadmin.Common.Communication;
//
// public class MsgPackSerializer : IMessageSerializer
// {
//     private static readonly IFormatterResolver Resolver;
//
//     static MsgPackSerializer()
//     {
//         //Resolver = MessagePack.Resolvers.TypelessContractlessStandardResolver.Instance;
//         Resolver = MessagePack.Resolvers.ContractlessStandardResolver.Instance;
//         //MessagePackSerializer.SetDefaultResolver(MessagePack.Resolvers.ContractlessStandardResolver.Instance);
//     }
//
//     public byte[] Serialize<T>(T message)
//     {
//         return MessagePackSerializer.Serialize(message, Resolver);
//     }
//
//     public T Deserialize<T>(byte[] source)
//     {
//         return MessagePackSerializer.Deserialize<T>(source, Resolver);
//     }
// }