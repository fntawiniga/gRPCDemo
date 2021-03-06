// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: character.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Demo {
  public static partial class Characters
  {
    static readonly string __ServiceName = "KidsCharacters.Characters";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::Demo.CharacterRequest> __Marshaller_KidsCharacters_CharacterRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Demo.CharacterRequest.Parser));
    static readonly grpc::Marshaller<global::Demo.CharacterResponse> __Marshaller_KidsCharacters_CharacterResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Demo.CharacterResponse.Parser));
    static readonly grpc::Marshaller<global::Demo.SearchRequest> __Marshaller_KidsCharacters_SearchRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Demo.SearchRequest.Parser));
    static readonly grpc::Marshaller<global::Demo.SumRequest> __Marshaller_KidsCharacters_SumRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Demo.SumRequest.Parser));
    static readonly grpc::Marshaller<global::Demo.SumResponse> __Marshaller_KidsCharacters_SumResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Demo.SumResponse.Parser));

    static readonly grpc::Method<global::Demo.CharacterRequest, global::Demo.CharacterResponse> __Method_GetCharacter = new grpc::Method<global::Demo.CharacterRequest, global::Demo.CharacterResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCharacter",
        __Marshaller_KidsCharacters_CharacterRequest,
        __Marshaller_KidsCharacters_CharacterResponse);

    static readonly grpc::Method<global::Demo.SearchRequest, global::Demo.CharacterResponse> __Method_SearchCharacters = new grpc::Method<global::Demo.SearchRequest, global::Demo.CharacterResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "SearchCharacters",
        __Marshaller_KidsCharacters_SearchRequest,
        __Marshaller_KidsCharacters_CharacterResponse);

    static readonly grpc::Method<global::Demo.SumRequest, global::Demo.SumResponse> __Method_DoSum = new grpc::Method<global::Demo.SumRequest, global::Demo.SumResponse>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "DoSum",
        __Marshaller_KidsCharacters_SumRequest,
        __Marshaller_KidsCharacters_SumResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Demo.CharacterReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Characters</summary>
    [grpc::BindServiceMethod(typeof(Characters), "BindService")]
    public abstract partial class CharactersBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Demo.CharacterResponse> GetCharacter(global::Demo.CharacterRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task SearchCharacters(global::Demo.SearchRequest request, grpc::IServerStreamWriter<global::Demo.CharacterResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Demo.SumResponse> DoSum(grpc::IAsyncStreamReader<global::Demo.SumRequest> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CharactersBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetCharacter, serviceImpl.GetCharacter)
          .AddMethod(__Method_SearchCharacters, serviceImpl.SearchCharacters)
          .AddMethod(__Method_DoSum, serviceImpl.DoSum).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CharactersBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetCharacter, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Demo.CharacterRequest, global::Demo.CharacterResponse>(serviceImpl.GetCharacter));
      serviceBinder.AddMethod(__Method_SearchCharacters, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Demo.SearchRequest, global::Demo.CharacterResponse>(serviceImpl.SearchCharacters));
      serviceBinder.AddMethod(__Method_DoSum, serviceImpl == null ? null : new grpc::ClientStreamingServerMethod<global::Demo.SumRequest, global::Demo.SumResponse>(serviceImpl.DoSum));
    }

  }
}
#endregion
