// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: common/Command.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace SkyWalking.NetworkProtocol.V3 {

  /// <summary>Holder for reflection information generated from common/Command.proto</summary>
  public static partial class CommandReflection {

    #region Descriptor
    /// <summary>File descriptor for common/Command.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CommandReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRjb21tb24vQ29tbWFuZC5wcm90bxINc2t5d2Fsa2luZy52MxoTY29tbW9u",
            "L0NvbW1vbi5wcm90byJLCgdDb21tYW5kEg8KB2NvbW1hbmQYASABKAkSLwoE",
            "YXJncxgCIAMoCzIhLnNreXdhbGtpbmcudjMuS2V5U3RyaW5nVmFsdWVQYWly",
            "IjQKCENvbW1hbmRzEigKCGNvbW1hbmRzGAEgAygLMhYuc2t5d2Fsa2luZy52",
            "My5Db21tYW5kQoMBCitvcmcuYXBhY2hlLnNreXdhbGtpbmcuYXBtLm5ldHdv",
            "cmsuY29tbW9uLnYzUAFaMnNreXdhbGtpbmcuYXBhY2hlLm9yZy9yZXBvL2dv",
            "YXBpL2NvbGxlY3QvY29tbW9uL3YzqgIdU2t5V2Fsa2luZy5OZXR3b3JrUHJv",
            "dG9jb2wuVjNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::SkyWalking.NetworkProtocol.V3.CommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::SkyWalking.NetworkProtocol.V3.Command), global::SkyWalking.NetworkProtocol.V3.Command.Parser, new[]{ "Command_", "Args" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::SkyWalking.NetworkProtocol.V3.Commands), global::SkyWalking.NetworkProtocol.V3.Commands.Parser, new[]{ "Commands_" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Command represents an protocol customized data when return.
  ///
  /// When the agent communicates with the OAP side using gRPC, the OAP uses Command to return the data content to the Agent.
  ///
  /// The available commands are,
  /// Name: ConfigurationDiscoveryCommand
  /// Args:
  ///     SerialNumber: String
  ///     UUID: String
  ///     properties: Key-value pairs rely on agent-side implementations
  ///
  /// Ref, Java agent supported configurations, https://skywalking.apache.org/docs/skywalking-java/next/en/setup/service-agent/java-agent/configuration-discovery/
  ///
  /// Name: ProfileTaskQuery
  /// Args:
  ///     SerialNumber: String
  ///     TaskId: String
  ///     EndpointName: String
  ///     Duration: Integer
  ///     MinDurationThreshold: Integer
  ///     DumpPeriod: Integer
  ///     MaxSamplingCount: Integer
  ///     StartTime: Date Timestamp
  ///     CreateTime: Date Timestamp
  ///
  /// Name: EBPFProfilingTaskQuery
  /// Args:
  ///     TaskId: String
  ///     ProcessId: Integer List
  ///     TaskUpdateTime: Date timestamp
  ///     TriggerType: Enum, value = FIXED_TIME
  ///     TargetType: Enum, value = ON_CPU, OFF_CPU or NETWORK
  ///     TaskStartTime: Date Timestamp
  ///     ExtensionConfigJSON: JSON serialization of NetworkSamplings.
  ///         --- NetworkSamplings ---
  ///         NetworkSamplings: List
  ///             URIRegex: String
  ///             MinDuration: Integer
  ///             When4xx: Boolean
  ///             When5xx: Boolean
  ///             Settings: Object
  ///                 RequireCompleteRequest: Boolean
  ///                 MaxRequestSize: Integer
  ///                 RequireCompleteResponse: Boolean
  ///                 MaxResponseSize: Integer
  ///         ------------------------
  ///     FixedTriggerDuration: Long
  ///
  /// Name: ContinuousProfilingPolicyQuery
  /// Args:
  ///     ServiceWithPolicyJSON: List JSON serialization of ServiceWithPolicy.
  ///         --- ServiceWithPolicy ---
  ///         ServiceName: String
  ///         UUID: String
  ///         Profiling: Multiple profiling configuration. Map
  ///             Key: Profiling type. Enum, value = ON_CPU, OFF_CPU, NETWORK
  ///             Value: Profiling policies. Map
  ///                 Key: Monitoring type. Enum, value = PROCESS_CPU, PROCESS_THREAD_COUNT, SYSTEM_LOAD, HTTP_ERROR_RATE, HTTP_AVG_RESPONSE_TIME
  ///                 Value: Policy configuration. Object.
  ///                     Threshold: String
  ///                     Period(s): Integer
  ///                     Count: Integer
  ///                     URIList: List&lt;String>
  ///                     URIRegex: String
  ///         ---------------------------
  ///
  /// Name: ContinuousProfilingReportTask
  /// Args:
  ///     TaskId: String
  /// </summary>
  public sealed partial class Command : pb::IMessage<Command>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Command> _parser = new pb::MessageParser<Command>(() => new Command());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Command> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SkyWalking.NetworkProtocol.V3.CommandReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Command() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Command(Command other) : this() {
      command_ = other.command_;
      args_ = other.args_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Command Clone() {
      return new Command(this);
    }

    /// <summary>Field number for the "command" field.</summary>
    public const int Command_FieldNumber = 1;
    private string command_ = "";
    /// <summary>
    /// Use command name to distinguish different data type.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Command_ {
      get { return command_; }
      set {
        command_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "args" field.</summary>
    public const int ArgsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::SkyWalking.NetworkProtocol.V3.KeyStringValuePair> _repeated_args_codec
        = pb::FieldCodec.ForMessage(18, global::SkyWalking.NetworkProtocol.V3.KeyStringValuePair.Parser);
    private readonly pbc::RepeatedField<global::SkyWalking.NetworkProtocol.V3.KeyStringValuePair> args_ = new pbc::RepeatedField<global::SkyWalking.NetworkProtocol.V3.KeyStringValuePair>();
    /// <summary>
    /// Data content in command.
    /// The value of content needs to be serialized as string for transmission.
    ///
    /// Basic data type: convert as string.
    /// The list of basic data: multiple data are split by ",".
    /// Complex data: serialize string through json.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::SkyWalking.NetworkProtocol.V3.KeyStringValuePair> Args {
      get { return args_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Command);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Command other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Command_ != other.Command_) return false;
      if(!args_.Equals(other.args_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Command_.Length != 0) hash ^= Command_.GetHashCode();
      hash ^= args_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Command_.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Command_);
      }
      args_.WriteTo(output, _repeated_args_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Command_.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Command_);
      }
      args_.WriteTo(ref output, _repeated_args_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Command_.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Command_);
      }
      size += args_.CalculateSize(_repeated_args_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Command other) {
      if (other == null) {
        return;
      }
      if (other.Command_.Length != 0) {
        Command_ = other.Command_;
      }
      args_.Add(other.args_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Command_ = input.ReadString();
            break;
          }
          case 18: {
            args_.AddEntriesFrom(input, _repeated_args_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Command_ = input.ReadString();
            break;
          }
          case 18: {
            args_.AddEntriesFrom(ref input, _repeated_args_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Transferring multiple Command in agent and OAP.
  /// </summary>
  public sealed partial class Commands : pb::IMessage<Commands>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Commands> _parser = new pb::MessageParser<Commands>(() => new Commands());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Commands> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SkyWalking.NetworkProtocol.V3.CommandReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Commands() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Commands(Commands other) : this() {
      commands_ = other.commands_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Commands Clone() {
      return new Commands(this);
    }

    /// <summary>Field number for the "commands" field.</summary>
    public const int Commands_FieldNumber = 1;
    private static readonly pb::FieldCodec<global::SkyWalking.NetworkProtocol.V3.Command> _repeated_commands_codec
        = pb::FieldCodec.ForMessage(10, global::SkyWalking.NetworkProtocol.V3.Command.Parser);
    private readonly pbc::RepeatedField<global::SkyWalking.NetworkProtocol.V3.Command> commands_ = new pbc::RepeatedField<global::SkyWalking.NetworkProtocol.V3.Command>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::SkyWalking.NetworkProtocol.V3.Command> Commands_ {
      get { return commands_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Commands);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Commands other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!commands_.Equals(other.commands_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= commands_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      commands_.WriteTo(output, _repeated_commands_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      commands_.WriteTo(ref output, _repeated_commands_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += commands_.CalculateSize(_repeated_commands_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Commands other) {
      if (other == null) {
        return;
      }
      commands_.Add(other.commands_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            commands_.AddEntriesFrom(input, _repeated_commands_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            commands_.AddEntriesFrom(ref input, _repeated_commands_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
