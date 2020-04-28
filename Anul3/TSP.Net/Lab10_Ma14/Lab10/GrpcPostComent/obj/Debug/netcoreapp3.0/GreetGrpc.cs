// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/greet.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcPostComent {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class Greeter
  {
    static readonly string __ServiceName = "Greet.Greeter";

    static readonly grpc::Marshaller<global::GrpcPostComent.GetPostObject> __Marshaller_Greet_GetPostObject = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcPostComent.GetPostObject.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcPostComent.GetBoolResult> __Marshaller_Greet_GetBoolResult = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcPostComent.GetBoolResult.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcPostComent.GetPostObjectResult> __Marshaller_Greet_GetPostObjectResult = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcPostComent.GetPostObjectResult.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcPostComent.GetId> __Marshaller_Greet_GetId = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcPostComent.GetId.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcPostComent.GetPostIdResult> __Marshaller_Greet_GetPostIdResult = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcPostComent.GetPostIdResult.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcPostComent.GetCommentObject> __Marshaller_Greet_GetCommentObject = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcPostComent.GetCommentObject.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcPostComent.GetCommentObjectResult> __Marshaller_Greet_GetCommentObjectResult = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcPostComent.GetCommentObjectResult.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcPostComent.GetPostObject, global::GrpcPostComent.GetBoolResult> __Method_AddPost = new grpc::Method<global::GrpcPostComent.GetPostObject, global::GrpcPostComent.GetBoolResult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddPost",
        __Marshaller_Greet_GetPostObject,
        __Marshaller_Greet_GetBoolResult);

    static readonly grpc::Method<global::GrpcPostComent.GetPostObject, global::GrpcPostComent.GetPostObjectResult> __Method_UpdatePost = new grpc::Method<global::GrpcPostComent.GetPostObject, global::GrpcPostComent.GetPostObjectResult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdatePost",
        __Marshaller_Greet_GetPostObject,
        __Marshaller_Greet_GetPostObjectResult);

    static readonly grpc::Method<global::GrpcPostComent.GetId, global::GrpcPostComent.GetPostIdResult> __Method_DeletePost = new grpc::Method<global::GrpcPostComent.GetId, global::GrpcPostComent.GetPostIdResult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeletePost",
        __Marshaller_Greet_GetId,
        __Marshaller_Greet_GetPostIdResult);

    static readonly grpc::Method<global::GrpcPostComent.GetId, global::GrpcPostComent.GetPostObjectResult> __Method_GetPostById = new grpc::Method<global::GrpcPostComent.GetId, global::GrpcPostComent.GetPostObjectResult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPostById",
        __Marshaller_Greet_GetId,
        __Marshaller_Greet_GetPostObjectResult);

    static readonly grpc::Method<global::GrpcPostComent.GetCommentObject, global::GrpcPostComent.GetBoolResult> __Method_AddComment = new grpc::Method<global::GrpcPostComent.GetCommentObject, global::GrpcPostComent.GetBoolResult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddComment",
        __Marshaller_Greet_GetCommentObject,
        __Marshaller_Greet_GetBoolResult);

    static readonly grpc::Method<global::GrpcPostComent.GetId, global::GrpcPostComent.GetCommentObjectResult> __Method_GetCommentById = new grpc::Method<global::GrpcPostComent.GetId, global::GrpcPostComent.GetCommentObjectResult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCommentById",
        __Marshaller_Greet_GetId,
        __Marshaller_Greet_GetCommentObjectResult);

    static readonly grpc::Method<global::GrpcPostComent.GetCommentObject, global::GrpcPostComent.GetCommentObjectResult> __Method_UpdateComment = new grpc::Method<global::GrpcPostComent.GetCommentObject, global::GrpcPostComent.GetCommentObjectResult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateComment",
        __Marshaller_Greet_GetCommentObject,
        __Marshaller_Greet_GetCommentObjectResult);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcPostComent.GreetReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Greeter</summary>
    [grpc::BindServiceMethod(typeof(Greeter), "BindService")]
    public abstract partial class GreeterBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GrpcPostComent.GetBoolResult> AddPost(global::GrpcPostComent.GetPostObject request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcPostComent.GetPostObjectResult> UpdatePost(global::GrpcPostComent.GetPostObject request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcPostComent.GetPostIdResult> DeletePost(global::GrpcPostComent.GetId request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcPostComent.GetPostObjectResult> GetPostById(global::GrpcPostComent.GetId request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcPostComent.GetBoolResult> AddComment(global::GrpcPostComent.GetCommentObject request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcPostComent.GetCommentObjectResult> GetCommentById(global::GrpcPostComent.GetId request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcPostComent.GetCommentObjectResult> UpdateComment(global::GrpcPostComent.GetCommentObject request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(GreeterBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AddPost, serviceImpl.AddPost)
          .AddMethod(__Method_UpdatePost, serviceImpl.UpdatePost)
          .AddMethod(__Method_DeletePost, serviceImpl.DeletePost)
          .AddMethod(__Method_GetPostById, serviceImpl.GetPostById)
          .AddMethod(__Method_AddComment, serviceImpl.AddComment)
          .AddMethod(__Method_GetCommentById, serviceImpl.GetCommentById)
          .AddMethod(__Method_UpdateComment, serviceImpl.UpdateComment).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, GreeterBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_AddPost, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcPostComent.GetPostObject, global::GrpcPostComent.GetBoolResult>(serviceImpl.AddPost));
      serviceBinder.AddMethod(__Method_UpdatePost, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcPostComent.GetPostObject, global::GrpcPostComent.GetPostObjectResult>(serviceImpl.UpdatePost));
      serviceBinder.AddMethod(__Method_DeletePost, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcPostComent.GetId, global::GrpcPostComent.GetPostIdResult>(serviceImpl.DeletePost));
      serviceBinder.AddMethod(__Method_GetPostById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcPostComent.GetId, global::GrpcPostComent.GetPostObjectResult>(serviceImpl.GetPostById));
      serviceBinder.AddMethod(__Method_AddComment, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcPostComent.GetCommentObject, global::GrpcPostComent.GetBoolResult>(serviceImpl.AddComment));
      serviceBinder.AddMethod(__Method_GetCommentById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcPostComent.GetId, global::GrpcPostComent.GetCommentObjectResult>(serviceImpl.GetCommentById));
      serviceBinder.AddMethod(__Method_UpdateComment, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcPostComent.GetCommentObject, global::GrpcPostComent.GetCommentObjectResult>(serviceImpl.UpdateComment));
    }

  }
}
#endregion