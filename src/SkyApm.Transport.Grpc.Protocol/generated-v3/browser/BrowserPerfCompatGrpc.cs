// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: browser/BrowserPerfCompat.proto
// </auto-generated>
// Original file comments:
//
// Licensed to the Apache Software Foundation (ASF) under one or more
// contributor license agreements.  See the NOTICE file distributed with
// this work for additional information regarding copyright ownership.
// The ASF licenses this file to You under the Apache License, Version 2.0
// (the "License"); you may not use this file except in compliance with
// the License.  You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace SkyWalking.NetworkProtocol.V3.Compat {
  /// <summary>
  /// Collect performance raw data from browser.
  /// </summary>
  public static partial class BrowserPerfService
  {
    static readonly string __ServiceName = "BrowserPerfService";

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

    static readonly grpc::Marshaller<global::SkyWalking.NetworkProtocol.V3.BrowserPerfData> __Marshaller_skywalking_v3_BrowserPerfData = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::SkyWalking.NetworkProtocol.V3.BrowserPerfData.Parser));
    static readonly grpc::Marshaller<global::SkyWalking.NetworkProtocol.V3.Commands> __Marshaller_skywalking_v3_Commands = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::SkyWalking.NetworkProtocol.V3.Commands.Parser));
    static readonly grpc::Marshaller<global::SkyWalking.NetworkProtocol.V3.BrowserErrorLog> __Marshaller_skywalking_v3_BrowserErrorLog = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::SkyWalking.NetworkProtocol.V3.BrowserErrorLog.Parser));

    static readonly grpc::Method<global::SkyWalking.NetworkProtocol.V3.BrowserPerfData, global::SkyWalking.NetworkProtocol.V3.Commands> __Method_collectPerfData = new grpc::Method<global::SkyWalking.NetworkProtocol.V3.BrowserPerfData, global::SkyWalking.NetworkProtocol.V3.Commands>(
        grpc::MethodType.Unary,
        __ServiceName,
        "collectPerfData",
        __Marshaller_skywalking_v3_BrowserPerfData,
        __Marshaller_skywalking_v3_Commands);

    static readonly grpc::Method<global::SkyWalking.NetworkProtocol.V3.BrowserErrorLog, global::SkyWalking.NetworkProtocol.V3.Commands> __Method_collectErrorLogs = new grpc::Method<global::SkyWalking.NetworkProtocol.V3.BrowserErrorLog, global::SkyWalking.NetworkProtocol.V3.Commands>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "collectErrorLogs",
        __Marshaller_skywalking_v3_BrowserErrorLog,
        __Marshaller_skywalking_v3_Commands);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::SkyWalking.NetworkProtocol.V3.Compat.BrowserPerfCompatReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of BrowserPerfService</summary>
    [grpc::BindServiceMethod(typeof(BrowserPerfService), "BindService")]
    public abstract partial class BrowserPerfServiceBase
    {
      /// <summary>
      /// report once per page
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::SkyWalking.NetworkProtocol.V3.Commands> collectPerfData(global::SkyWalking.NetworkProtocol.V3.BrowserPerfData request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// report one or more error logs for pages, could report multiple times.
      /// </summary>
      /// <param name="requestStream">Used for reading requests from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::SkyWalking.NetworkProtocol.V3.Commands> collectErrorLogs(grpc::IAsyncStreamReader<global::SkyWalking.NetworkProtocol.V3.BrowserErrorLog> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for BrowserPerfService</summary>
    public partial class BrowserPerfServiceClient : grpc::ClientBase<BrowserPerfServiceClient>
    {
      /// <summary>Creates a new client for BrowserPerfService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public BrowserPerfServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for BrowserPerfService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public BrowserPerfServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected BrowserPerfServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected BrowserPerfServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// report once per page
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::SkyWalking.NetworkProtocol.V3.Commands collectPerfData(global::SkyWalking.NetworkProtocol.V3.BrowserPerfData request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return collectPerfData(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// report once per page
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::SkyWalking.NetworkProtocol.V3.Commands collectPerfData(global::SkyWalking.NetworkProtocol.V3.BrowserPerfData request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_collectPerfData, null, options, request);
      }
      /// <summary>
      /// report once per page
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::SkyWalking.NetworkProtocol.V3.Commands> collectPerfDataAsync(global::SkyWalking.NetworkProtocol.V3.BrowserPerfData request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return collectPerfDataAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// report once per page
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::SkyWalking.NetworkProtocol.V3.Commands> collectPerfDataAsync(global::SkyWalking.NetworkProtocol.V3.BrowserPerfData request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_collectPerfData, null, options, request);
      }
      /// <summary>
      /// report one or more error logs for pages, could report multiple times.
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncClientStreamingCall<global::SkyWalking.NetworkProtocol.V3.BrowserErrorLog, global::SkyWalking.NetworkProtocol.V3.Commands> collectErrorLogs(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return collectErrorLogs(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// report one or more error logs for pages, could report multiple times.
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncClientStreamingCall<global::SkyWalking.NetworkProtocol.V3.BrowserErrorLog, global::SkyWalking.NetworkProtocol.V3.Commands> collectErrorLogs(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_collectErrorLogs, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override BrowserPerfServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new BrowserPerfServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(BrowserPerfServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_collectPerfData, serviceImpl.collectPerfData)
          .AddMethod(__Method_collectErrorLogs, serviceImpl.collectErrorLogs).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, BrowserPerfServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_collectPerfData, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::SkyWalking.NetworkProtocol.V3.BrowserPerfData, global::SkyWalking.NetworkProtocol.V3.Commands>(serviceImpl.collectPerfData));
      serviceBinder.AddMethod(__Method_collectErrorLogs, serviceImpl == null ? null : new grpc::ClientStreamingServerMethod<global::SkyWalking.NetworkProtocol.V3.BrowserErrorLog, global::SkyWalking.NetworkProtocol.V3.Commands>(serviceImpl.collectErrorLogs));
    }

  }
}
#endregion
