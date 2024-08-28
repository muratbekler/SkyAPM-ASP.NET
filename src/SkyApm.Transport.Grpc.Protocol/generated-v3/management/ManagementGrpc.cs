// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: management/Management.proto
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

namespace SkyWalking.NetworkProtocol.V3 {
  /// <summary>
  /// Define the service reporting the extra information of the instance.
  /// </summary>
  public static partial class ManagementService
  {
    static readonly string __ServiceName = "skywalking.v3.ManagementService";

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

    static readonly grpc::Marshaller<global::SkyWalking.NetworkProtocol.V3.InstanceProperties> __Marshaller_skywalking_v3_InstanceProperties = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::SkyWalking.NetworkProtocol.V3.InstanceProperties.Parser));
    static readonly grpc::Marshaller<global::SkyWalking.NetworkProtocol.V3.Commands> __Marshaller_skywalking_v3_Commands = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::SkyWalking.NetworkProtocol.V3.Commands.Parser));
    static readonly grpc::Marshaller<global::SkyWalking.NetworkProtocol.V3.InstancePingPkg> __Marshaller_skywalking_v3_InstancePingPkg = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::SkyWalking.NetworkProtocol.V3.InstancePingPkg.Parser));

    static readonly grpc::Method<global::SkyWalking.NetworkProtocol.V3.InstanceProperties, global::SkyWalking.NetworkProtocol.V3.Commands> __Method_reportInstanceProperties = new grpc::Method<global::SkyWalking.NetworkProtocol.V3.InstanceProperties, global::SkyWalking.NetworkProtocol.V3.Commands>(
        grpc::MethodType.Unary,
        __ServiceName,
        "reportInstanceProperties",
        __Marshaller_skywalking_v3_InstanceProperties,
        __Marshaller_skywalking_v3_Commands);

    static readonly grpc::Method<global::SkyWalking.NetworkProtocol.V3.InstancePingPkg, global::SkyWalking.NetworkProtocol.V3.Commands> __Method_keepAlive = new grpc::Method<global::SkyWalking.NetworkProtocol.V3.InstancePingPkg, global::SkyWalking.NetworkProtocol.V3.Commands>(
        grpc::MethodType.Unary,
        __ServiceName,
        "keepAlive",
        __Marshaller_skywalking_v3_InstancePingPkg,
        __Marshaller_skywalking_v3_Commands);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::SkyWalking.NetworkProtocol.V3.ManagementReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ManagementService</summary>
    [grpc::BindServiceMethod(typeof(ManagementService), "BindService")]
    public abstract partial class ManagementServiceBase
    {
      /// <summary>
      /// Report custom properties of a service instance.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::SkyWalking.NetworkProtocol.V3.Commands> reportInstanceProperties(global::SkyWalking.NetworkProtocol.V3.InstanceProperties request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Keep the instance alive in the backend analysis.
      /// Only recommend to do separate keepAlive report when no trace and metrics needs to be reported.
      /// Otherwise, it is duplicated.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::SkyWalking.NetworkProtocol.V3.Commands> keepAlive(global::SkyWalking.NetworkProtocol.V3.InstancePingPkg request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ManagementService</summary>
    public partial class ManagementServiceClient : grpc::ClientBase<ManagementServiceClient>
    {
      /// <summary>Creates a new client for ManagementService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ManagementServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ManagementService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ManagementServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ManagementServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ManagementServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Report custom properties of a service instance.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::SkyWalking.NetworkProtocol.V3.Commands reportInstanceProperties(global::SkyWalking.NetworkProtocol.V3.InstanceProperties request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return reportInstanceProperties(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Report custom properties of a service instance.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::SkyWalking.NetworkProtocol.V3.Commands reportInstanceProperties(global::SkyWalking.NetworkProtocol.V3.InstanceProperties request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_reportInstanceProperties, null, options, request);
      }
      /// <summary>
      /// Report custom properties of a service instance.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::SkyWalking.NetworkProtocol.V3.Commands> reportInstancePropertiesAsync(global::SkyWalking.NetworkProtocol.V3.InstanceProperties request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return reportInstancePropertiesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Report custom properties of a service instance.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::SkyWalking.NetworkProtocol.V3.Commands> reportInstancePropertiesAsync(global::SkyWalking.NetworkProtocol.V3.InstanceProperties request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_reportInstanceProperties, null, options, request);
      }
      /// <summary>
      /// Keep the instance alive in the backend analysis.
      /// Only recommend to do separate keepAlive report when no trace and metrics needs to be reported.
      /// Otherwise, it is duplicated.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::SkyWalking.NetworkProtocol.V3.Commands keepAlive(global::SkyWalking.NetworkProtocol.V3.InstancePingPkg request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return keepAlive(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Keep the instance alive in the backend analysis.
      /// Only recommend to do separate keepAlive report when no trace and metrics needs to be reported.
      /// Otherwise, it is duplicated.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::SkyWalking.NetworkProtocol.V3.Commands keepAlive(global::SkyWalking.NetworkProtocol.V3.InstancePingPkg request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_keepAlive, null, options, request);
      }
      /// <summary>
      /// Keep the instance alive in the backend analysis.
      /// Only recommend to do separate keepAlive report when no trace and metrics needs to be reported.
      /// Otherwise, it is duplicated.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::SkyWalking.NetworkProtocol.V3.Commands> keepAliveAsync(global::SkyWalking.NetworkProtocol.V3.InstancePingPkg request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return keepAliveAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Keep the instance alive in the backend analysis.
      /// Only recommend to do separate keepAlive report when no trace and metrics needs to be reported.
      /// Otherwise, it is duplicated.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::SkyWalking.NetworkProtocol.V3.Commands> keepAliveAsync(global::SkyWalking.NetworkProtocol.V3.InstancePingPkg request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_keepAlive, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ManagementServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ManagementServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ManagementServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_reportInstanceProperties, serviceImpl.reportInstanceProperties)
          .AddMethod(__Method_keepAlive, serviceImpl.keepAlive).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ManagementServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_reportInstanceProperties, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::SkyWalking.NetworkProtocol.V3.InstanceProperties, global::SkyWalking.NetworkProtocol.V3.Commands>(serviceImpl.reportInstanceProperties));
      serviceBinder.AddMethod(__Method_keepAlive, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::SkyWalking.NetworkProtocol.V3.InstancePingPkg, global::SkyWalking.NetworkProtocol.V3.Commands>(serviceImpl.keepAlive));
    }

  }
}
#endregion
