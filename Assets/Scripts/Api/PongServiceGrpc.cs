// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/pong_service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Api {
  public static partial class PongApiService
  {
    static readonly string __ServiceName = "api.PongApiService";

    static readonly grpc::Marshaller<global::Api.NewScore> __Marshaller_api_NewScore = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Api.NewScore.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Api.PlayerScore> __Marshaller_api_PlayerScore = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Api.PlayerScore.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Api.PlayerId> __Marshaller_api_PlayerId = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Api.PlayerId.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Api.PlayerScores> __Marshaller_api_PlayerScores = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Api.PlayerScores.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Api.NewPlayerName> __Marshaller_api_NewPlayerName = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Api.NewPlayerName.Parser.ParseFrom);

    static readonly grpc::Method<global::Api.NewScore, global::Api.PlayerScore> __Method_AddScore = new grpc::Method<global::Api.NewScore, global::Api.PlayerScore>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddScore",
        __Marshaller_api_NewScore,
        __Marshaller_api_PlayerScore);

    static readonly grpc::Method<global::Api.PlayerId, global::Api.PlayerScore> __Method_GetScore = new grpc::Method<global::Api.PlayerId, global::Api.PlayerScore>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetScore",
        __Marshaller_api_PlayerId,
        __Marshaller_api_PlayerScore);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Api.PlayerId> __Method_Login = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Api.PlayerId>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Login",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_api_PlayerId);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Api.PlayerScores> __Method_GetScores = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Api.PlayerScores>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetScores",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_api_PlayerScores);

    static readonly grpc::Method<global::Api.NewPlayerName, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SetName = new grpc::Method<global::Api.NewPlayerName, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SetName",
        __Marshaller_api_NewPlayerName,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Api.PongServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PongApiService</summary>
    [grpc::BindServiceMethod(typeof(PongApiService), "BindService")]
    public abstract partial class PongApiServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Api.PlayerScore> AddScore(global::Api.NewScore request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Api.PlayerScore> GetScore(global::Api.PlayerId request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Api.PlayerId> Login(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Api.PlayerScores> GetScores(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> SetName(global::Api.NewPlayerName request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for PongApiService</summary>
    public partial class PongApiServiceClient : grpc::ClientBase<PongApiServiceClient>
    {
      /// <summary>Creates a new client for PongApiService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public PongApiServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for PongApiService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public PongApiServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected PongApiServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected PongApiServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Api.PlayerScore AddScore(global::Api.NewScore request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddScore(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Api.PlayerScore AddScore(global::Api.NewScore request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddScore, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Api.PlayerScore> AddScoreAsync(global::Api.NewScore request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddScoreAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Api.PlayerScore> AddScoreAsync(global::Api.NewScore request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddScore, null, options, request);
      }
      public virtual global::Api.PlayerScore GetScore(global::Api.PlayerId request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetScore(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Api.PlayerScore GetScore(global::Api.PlayerId request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetScore, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Api.PlayerScore> GetScoreAsync(global::Api.PlayerId request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetScoreAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Api.PlayerScore> GetScoreAsync(global::Api.PlayerId request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetScore, null, options, request);
      }
      public virtual global::Api.PlayerId Login(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Login(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Api.PlayerId Login(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Login, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Api.PlayerId> LoginAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LoginAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Api.PlayerId> LoginAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Login, null, options, request);
      }
      public virtual global::Api.PlayerScores GetScores(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetScores(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Api.PlayerScores GetScores(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetScores, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Api.PlayerScores> GetScoresAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetScoresAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Api.PlayerScores> GetScoresAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetScores, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty SetName(global::Api.NewPlayerName request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SetName(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty SetName(global::Api.NewPlayerName request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SetName, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> SetNameAsync(global::Api.NewPlayerName request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SetNameAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> SetNameAsync(global::Api.NewPlayerName request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SetName, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override PongApiServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new PongApiServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(PongApiServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AddScore, serviceImpl.AddScore)
          .AddMethod(__Method_GetScore, serviceImpl.GetScore)
          .AddMethod(__Method_Login, serviceImpl.Login)
          .AddMethod(__Method_GetScores, serviceImpl.GetScores)
          .AddMethod(__Method_SetName, serviceImpl.SetName).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PongApiServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_AddScore, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Api.NewScore, global::Api.PlayerScore>(serviceImpl.AddScore));
      serviceBinder.AddMethod(__Method_GetScore, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Api.PlayerId, global::Api.PlayerScore>(serviceImpl.GetScore));
      serviceBinder.AddMethod(__Method_Login, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::Api.PlayerId>(serviceImpl.Login));
      serviceBinder.AddMethod(__Method_GetScores, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::Api.PlayerScores>(serviceImpl.GetScores));
      serviceBinder.AddMethod(__Method_SetName, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Api.NewPlayerName, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.SetName));
    }

  }
}
#endregion
