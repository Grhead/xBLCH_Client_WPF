// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ProtoContract.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Client_BLCHxVote_WPF {
  public static partial class BLCH_Contract
  {
    static readonly string __ServiceName = "Contract.BLCH_Contract";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
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

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
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

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Client_BLCHxVote_WPF.RegData> __Marshaller_Contract_RegData = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Client_BLCHxVote_WPF.RegData.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Client_BLCHxVote_WPF.AuthRegResult> __Marshaller_Contract_AuthRegResult = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Client_BLCHxVote_WPF.AuthRegResult.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Client_BLCHxVote_WPF.AuthData> __Marshaller_Contract_AuthData = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Client_BLCHxVote_WPF.AuthData.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Client_BLCHxVote_WPF.Wpar> __Marshaller_Contract_Wpar = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Client_BLCHxVote_WPF.Wpar.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Client_BLCHxVote_WPF.ResponseSize> __Marshaller_Contract_ResponseSize = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Client_BLCHxVote_WPF.ResponseSize.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Client_BLCHxVote_WPF.Address> __Marshaller_Contract_Address = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Client_BLCHxVote_WPF.Address.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Client_BLCHxVote_WPF.Lanb> __Marshaller_Contract_Lanb = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Client_BLCHxVote_WPF.Lanb.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Client_BLCHxVote_WPF.CandidateList> __Marshaller_Contract_CandidateList = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Client_BLCHxVote_WPF.CandidateList.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Client_BLCHxVote_WPF.LowDataChain> __Marshaller_Contract_LowDataChain = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Client_BLCHxVote_WPF.LowDataChain.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Client_BLCHxVote_WPF.IsComplited> __Marshaller_Contract_IsComplited = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Client_BLCHxVote_WPF.IsComplited.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Client_BLCHxVote_WPF.LowData> __Marshaller_Contract_LowData = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Client_BLCHxVote_WPF.LowData.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Client_BLCHxVote_WPF.TimeData> __Marshaller_Contract_TimeData = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Client_BLCHxVote_WPF.TimeData.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Client_BLCHxVote_WPF.Chain> __Marshaller_Contract_Chain = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Client_BLCHxVote_WPF.Chain.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Client_BLCHxVote_WPF.CandidateListWithBalance> __Marshaller_Contract_CandidateListWithBalance = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Client_BLCHxVote_WPF.CandidateListWithBalance.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Client_BLCHxVote_WPF.RegData, global::Client_BLCHxVote_WPF.AuthRegResult> __Method_AuthRegister = new grpc::Method<global::Client_BLCHxVote_WPF.RegData, global::Client_BLCHxVote_WPF.AuthRegResult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AuthRegister",
        __Marshaller_Contract_RegData,
        __Marshaller_Contract_AuthRegResult);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Client_BLCHxVote_WPF.AuthData, global::Client_BLCHxVote_WPF.AuthRegResult> __Method_AuthLogin = new grpc::Method<global::Client_BLCHxVote_WPF.AuthData, global::Client_BLCHxVote_WPF.AuthRegResult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AuthLogin",
        __Marshaller_Contract_AuthData,
        __Marshaller_Contract_AuthRegResult);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Client_BLCHxVote_WPF.Wpar, global::Client_BLCHxVote_WPF.ResponseSize> __Method_ChainSize = new grpc::Method<global::Client_BLCHxVote_WPF.Wpar, global::Client_BLCHxVote_WPF.ResponseSize>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ChainSize",
        __Marshaller_Contract_Wpar,
        __Marshaller_Contract_ResponseSize);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Client_BLCHxVote_WPF.Address, global::Client_BLCHxVote_WPF.Lanb> __Method_Balance = new grpc::Method<global::Client_BLCHxVote_WPF.Address, global::Client_BLCHxVote_WPF.Lanb>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Balance",
        __Marshaller_Contract_Address,
        __Marshaller_Contract_Lanb);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Client_BLCHxVote_WPF.Wpar, global::Client_BLCHxVote_WPF.CandidateList> __Method_ViewCandidates = new grpc::Method<global::Client_BLCHxVote_WPF.Wpar, global::Client_BLCHxVote_WPF.CandidateList>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "ViewCandidates",
        __Marshaller_Contract_Wpar,
        __Marshaller_Contract_CandidateList);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Client_BLCHxVote_WPF.LowDataChain, global::Client_BLCHxVote_WPF.IsComplited> __Method_Transfer = new grpc::Method<global::Client_BLCHxVote_WPF.LowDataChain, global::Client_BLCHxVote_WPF.IsComplited>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Transfer",
        __Marshaller_Contract_LowDataChain,
        __Marshaller_Contract_IsComplited);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Client_BLCHxVote_WPF.LowData, global::Client_BLCHxVote_WPF.IsComplited> __Method_Vote = new grpc::Method<global::Client_BLCHxVote_WPF.LowData, global::Client_BLCHxVote_WPF.IsComplited>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Vote",
        __Marshaller_Contract_LowData,
        __Marshaller_Contract_IsComplited);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Client_BLCHxVote_WPF.Wpar, global::Client_BLCHxVote_WPF.TimeData> __Method_TimeBlock = new grpc::Method<global::Client_BLCHxVote_WPF.Wpar, global::Client_BLCHxVote_WPF.TimeData>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "TimeBlock",
        __Marshaller_Contract_Wpar,
        __Marshaller_Contract_TimeData);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Client_BLCHxVote_WPF.Wpar, global::Client_BLCHxVote_WPF.Chain> __Method_ChainPrint = new grpc::Method<global::Client_BLCHxVote_WPF.Wpar, global::Client_BLCHxVote_WPF.Chain>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ChainPrint",
        __Marshaller_Contract_Wpar,
        __Marshaller_Contract_Chain);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Client_BLCHxVote_WPF.Wpar, global::Client_BLCHxVote_WPF.CandidateListWithBalance> __Method_ResultsWinner = new grpc::Method<global::Client_BLCHxVote_WPF.Wpar, global::Client_BLCHxVote_WPF.CandidateListWithBalance>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "ResultsWinner",
        __Marshaller_Contract_Wpar,
        __Marshaller_Contract_CandidateListWithBalance);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Client_BLCHxVote_WPF.Wpar, global::Client_BLCHxVote_WPF.CandidateList> __Method_SoloWinner = new grpc::Method<global::Client_BLCHxVote_WPF.Wpar, global::Client_BLCHxVote_WPF.CandidateList>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SoloWinner",
        __Marshaller_Contract_Wpar,
        __Marshaller_Contract_CandidateList);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Client_BLCHxVote_WPF.ProtoContractReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for BLCH_Contract</summary>
    public partial class BLCH_ContractClient : grpc::ClientBase<BLCH_ContractClient>
    {
      /// <summary>Creates a new client for BLCH_Contract</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public BLCH_ContractClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for BLCH_Contract that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public BLCH_ContractClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected BLCH_ContractClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected BLCH_ContractClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Client_BLCHxVote_WPF.AuthRegResult AuthRegister(global::Client_BLCHxVote_WPF.RegData request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AuthRegister(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Client_BLCHxVote_WPF.AuthRegResult AuthRegister(global::Client_BLCHxVote_WPF.RegData request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AuthRegister, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Client_BLCHxVote_WPF.AuthRegResult> AuthRegisterAsync(global::Client_BLCHxVote_WPF.RegData request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AuthRegisterAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Client_BLCHxVote_WPF.AuthRegResult> AuthRegisterAsync(global::Client_BLCHxVote_WPF.RegData request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AuthRegister, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Client_BLCHxVote_WPF.AuthRegResult AuthLogin(global::Client_BLCHxVote_WPF.AuthData request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AuthLogin(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Client_BLCHxVote_WPF.AuthRegResult AuthLogin(global::Client_BLCHxVote_WPF.AuthData request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AuthLogin, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Client_BLCHxVote_WPF.AuthRegResult> AuthLoginAsync(global::Client_BLCHxVote_WPF.AuthData request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AuthLoginAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Client_BLCHxVote_WPF.AuthRegResult> AuthLoginAsync(global::Client_BLCHxVote_WPF.AuthData request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AuthLogin, null, options, request);
      }
      /// <summary>
      ///размер цепи
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Client_BLCHxVote_WPF.ResponseSize ChainSize(global::Client_BLCHxVote_WPF.Wpar request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ChainSize(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///размер цепи
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Client_BLCHxVote_WPF.ResponseSize ChainSize(global::Client_BLCHxVote_WPF.Wpar request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ChainSize, null, options, request);
      }
      /// <summary>
      ///размер цепи
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Client_BLCHxVote_WPF.ResponseSize> ChainSizeAsync(global::Client_BLCHxVote_WPF.Wpar request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ChainSizeAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///размер цепи
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Client_BLCHxVote_WPF.ResponseSize> ChainSizeAsync(global::Client_BLCHxVote_WPF.Wpar request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ChainSize, null, options, request);
      }
      /// <summary>
      ///баланс на счете
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Client_BLCHxVote_WPF.Lanb Balance(global::Client_BLCHxVote_WPF.Address request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Balance(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///баланс на счете
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Client_BLCHxVote_WPF.Lanb Balance(global::Client_BLCHxVote_WPF.Address request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Balance, null, options, request);
      }
      /// <summary>
      ///баланс на счете
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Client_BLCHxVote_WPF.Lanb> BalanceAsync(global::Client_BLCHxVote_WPF.Address request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return BalanceAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///баланс на счете
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Client_BLCHxVote_WPF.Lanb> BalanceAsync(global::Client_BLCHxVote_WPF.Address request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Balance, null, options, request);
      }
      /// <summary>
      /// вывод кандидатов
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::Client_BLCHxVote_WPF.CandidateList> ViewCandidates(global::Client_BLCHxVote_WPF.Wpar request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ViewCandidates(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// вывод кандидатов
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::Client_BLCHxVote_WPF.CandidateList> ViewCandidates(global::Client_BLCHxVote_WPF.Wpar request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_ViewCandidates, null, options, request);
      }
      /// <summary>
      /// раздача токенов
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Client_BLCHxVote_WPF.IsComplited Transfer(global::Client_BLCHxVote_WPF.LowDataChain request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Transfer(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// раздача токенов
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Client_BLCHxVote_WPF.IsComplited Transfer(global::Client_BLCHxVote_WPF.LowDataChain request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Transfer, null, options, request);
      }
      /// <summary>
      /// раздача токенов
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Client_BLCHxVote_WPF.IsComplited> TransferAsync(global::Client_BLCHxVote_WPF.LowDataChain request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return TransferAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// раздача токенов
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Client_BLCHxVote_WPF.IsComplited> TransferAsync(global::Client_BLCHxVote_WPF.LowDataChain request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Transfer, null, options, request);
      }
      /// <summary>
      /// голосование
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Client_BLCHxVote_WPF.IsComplited Vote(global::Client_BLCHxVote_WPF.LowData request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Vote(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// голосование
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Client_BLCHxVote_WPF.IsComplited Vote(global::Client_BLCHxVote_WPF.LowData request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Vote, null, options, request);
      }
      /// <summary>
      /// голосование
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Client_BLCHxVote_WPF.IsComplited> VoteAsync(global::Client_BLCHxVote_WPF.LowData request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return VoteAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// голосование
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Client_BLCHxVote_WPF.IsComplited> VoteAsync(global::Client_BLCHxVote_WPF.LowData request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Vote, null, options, request);
      }
      /// <summary>
      ///время до конца голосования
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::Client_BLCHxVote_WPF.TimeData> TimeBlock(global::Client_BLCHxVote_WPF.Wpar request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return TimeBlock(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///время до конца голосования
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::Client_BLCHxVote_WPF.TimeData> TimeBlock(global::Client_BLCHxVote_WPF.Wpar request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_TimeBlock, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Client_BLCHxVote_WPF.Chain ChainPrint(global::Client_BLCHxVote_WPF.Wpar request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ChainPrint(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Client_BLCHxVote_WPF.Chain ChainPrint(global::Client_BLCHxVote_WPF.Wpar request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ChainPrint, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Client_BLCHxVote_WPF.Chain> ChainPrintAsync(global::Client_BLCHxVote_WPF.Wpar request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ChainPrintAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Client_BLCHxVote_WPF.Chain> ChainPrintAsync(global::Client_BLCHxVote_WPF.Wpar request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ChainPrint, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::Client_BLCHxVote_WPF.CandidateListWithBalance> ResultsWinner(global::Client_BLCHxVote_WPF.Wpar request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ResultsWinner(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::Client_BLCHxVote_WPF.CandidateListWithBalance> ResultsWinner(global::Client_BLCHxVote_WPF.Wpar request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_ResultsWinner, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Client_BLCHxVote_WPF.CandidateList SoloWinner(global::Client_BLCHxVote_WPF.Wpar request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SoloWinner(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Client_BLCHxVote_WPF.CandidateList SoloWinner(global::Client_BLCHxVote_WPF.Wpar request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SoloWinner, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Client_BLCHxVote_WPF.CandidateList> SoloWinnerAsync(global::Client_BLCHxVote_WPF.Wpar request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SoloWinnerAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Client_BLCHxVote_WPF.CandidateList> SoloWinnerAsync(global::Client_BLCHxVote_WPF.Wpar request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SoloWinner, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override BLCH_ContractClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new BLCH_ContractClient(configuration);
      }
    }

  }
}
#endregion
