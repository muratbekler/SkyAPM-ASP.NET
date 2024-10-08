// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: language-agent/CLRMetric.proto
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
  public static partial class CLRMetricReportService
  {
    static readonly string __ServiceName = "skywalking.v3.CLRMetricReportService";

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

    static readonly grpc::Marshaller<global::SkyWalking.NetworkProtocol.V3.CLRMetricCollection> __Marshaller_skywalking_v3_CLRMetricCollection = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::SkyWalking.NetworkProtocol.V3.CLRMetricCollection.Parser));
    static readonly grpc::Marshaller<global::SkyWalking.NetworkProtocol.V3.Commands> __Marshaller_skywalking_v3_Commands = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::SkyWalking.NetworkProtocol.V3.Commands.Parser));

    static readonly grpc::Method<global::SkyWalking.NetworkProtocol.V3.CLRMetricCollection, global::SkyWalking.NetworkProtocol.V3.Commands> __Method_collect = new grpc::Method<global::SkyWalking.NetworkProtocol.V3.CLRMetricCollection, global::SkyWalking.NetworkProtocol.V3.Commands>(
        grpc::MethodType.Unary,
        __ServiceName,
        "collect",
        __Marshaller_skywalking_v3_CLRMetricCollection,
        __Marshaller_skywalking_v3_Commands);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::SkyWalking.NetworkProtocol.V3.CLRMetricReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CLRMetricReportService</summary>
    [grpc::BindServiceMethod(typeof(CLRMetricReportService), "BindService")]
    public abstract partial class CLRMetricReportServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::SkyWalking.NetworkProtocol.V3.Commands> collect(global::SkyWalking.NetworkProtocol.V3.CLRMetricCollection request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for CLRMetricReportService</summary>
    public partial class CLRMetricReportServiceClient : grpc::ClientBase<CLRMetricReportServiceClient>
    {
      /// <summary>Creates a new client for CLRMetricReportService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CLRMetricReportServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CLRMetricReportService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CLRMetricReportServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CLRMetricReportServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CLRMetricReportServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::SkyWalking.NetworkProtocol.V3.Commands collect(global::SkyWalking.NetworkProtocol.V3.CLRMetricCollection request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return collect(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::SkyWalking.NetworkProtocol.V3.Commands collect(global::SkyWalking.NetworkProtocol.V3.CLRMetricCollection request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_collect, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::SkyWalking.NetworkProtocol.V3.Commands> collectAsync(global::SkyWalking.NetworkProtocol.V3.CLRMetricCollection request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return collectAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::SkyWalking.NetworkProtocol.V3.Commands> collectAsync(global::SkyWalking.NetworkProtocol.V3.CLRMetricCollection request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_collect, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override CLRMetricReportServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CLRMetricReportServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CLRMetricReportServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_collect, serviceImpl.collect).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CLRMetricReportServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_collect, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::SkyWalking.NetworkProtocol.V3.CLRMetricCollection, global::SkyWalking.NetworkProtocol.V3.Commands>(serviceImpl.collect));
    }

  }
}
#endregion
