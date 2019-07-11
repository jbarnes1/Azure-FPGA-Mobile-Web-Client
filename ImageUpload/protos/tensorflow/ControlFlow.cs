// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tensorflow/core/protobuf/control_flow.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tensorflow {

  /// <summary>Holder for reflection information generated from tensorflow/core/protobuf/control_flow.proto</summary>
  public static partial class ControlFlowReflection {

    #region Descriptor
    /// <summary>File descriptor for tensorflow/core/protobuf/control_flow.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ControlFlowReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cit0ZW5zb3JmbG93L2NvcmUvcHJvdG9idWYvY29udHJvbF9mbG93LnByb3Rv",
            "Egp0ZW5zb3JmbG93IpYBCglWYWx1ZXNEZWYSDgoGdmFsdWVzGAEgAygJEkIK",
            "D2V4dGVybmFsX3ZhbHVlcxgCIAMoCzIpLnRlbnNvcmZsb3cuVmFsdWVzRGVm",
            "LkV4dGVybmFsVmFsdWVzRW50cnkaNQoTRXh0ZXJuYWxWYWx1ZXNFbnRyeRIL",
            "CgNrZXkYASABKAkSDQoFdmFsdWUYAiABKAk6AjgBIogBCg5Db25kQ29udGV4",
            "dERlZhIUCgxjb250ZXh0X25hbWUYASABKAkSEQoJcHJlZF9uYW1lGAIgASgJ",
            "EhIKCnBpdm90X25hbWUYAyABKAkSDgoGYnJhbmNoGAQgASgFEikKCnZhbHVl",
            "c19kZWYYBSABKAsyFS50ZW5zb3JmbG93LlZhbHVlc0RlZiKYAgoPV2hpbGVD",
            "b250ZXh0RGVmEhQKDGNvbnRleHRfbmFtZRgBIAEoCRIbChNwYXJhbGxlbF9p",
            "dGVyYXRpb25zGAIgASgFEhEKCWJhY2tfcHJvcBgDIAEoCBITCgtzd2FwX21l",
            "bW9yeRgEIAEoCBISCgpwaXZvdF9uYW1lGAUgASgJEhsKE3Bpdm90X2Zvcl9w",
            "cmVkX25hbWUYBiABKAkSGwoTcGl2b3RfZm9yX2JvZHlfbmFtZRgHIAEoCRIX",
            "Cg9sb29wX2V4aXRfbmFtZXMYCCADKAkSGAoQbG9vcF9lbnRlcl9uYW1lcxgK",
            "IAMoCRIpCgp2YWx1ZXNfZGVmGAkgASgLMhUudGVuc29yZmxvdy5WYWx1ZXNE",
            "ZWZCMgoYb3JnLnRlbnNvcmZsb3cuZnJhbWV3b3JrQhFDb250cm9sRmxvd1By",
            "b3Rvc1AB+AEBYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.ValuesDef), global::Tensorflow.ValuesDef.Parser, new[]{ "Values", "ExternalValues" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.CondContextDef), global::Tensorflow.CondContextDef.Parser, new[]{ "ContextName", "PredName", "PivotName", "Branch", "ValuesDef" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.WhileContextDef), global::Tensorflow.WhileContextDef.Parser, new[]{ "ContextName", "ParallelIterations", "BackProp", "SwapMemory", "PivotName", "PivotForPredName", "PivotForBodyName", "LoopExitNames", "LoopEnterNames", "ValuesDef" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Protocol buffer representing the values in ControlFlowContext.
  /// </summary>
  public sealed partial class ValuesDef : pb::IMessage<ValuesDef> {
    private static readonly pb::MessageParser<ValuesDef> _parser = new pb::MessageParser<ValuesDef>(() => new ValuesDef());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ValuesDef> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.ControlFlowReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ValuesDef() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ValuesDef(ValuesDef other) : this() {
      values_ = other.values_.Clone();
      externalValues_ = other.externalValues_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ValuesDef Clone() {
      return new ValuesDef(this);
    }

    /// <summary>Field number for the "values" field.</summary>
    public const int ValuesFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _repeated_values_codec
        = pb::FieldCodec.ForString(10);
    private readonly pbc::RepeatedField<string> values_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Value names that have been seen in this context.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Values {
      get { return values_; }
    }

    /// <summary>Field number for the "external_values" field.</summary>
    public const int ExternalValuesFieldNumber = 2;
    private static readonly pbc::MapField<string, string>.Codec _map_externalValues_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 18);
    private readonly pbc::MapField<string, string> externalValues_ = new pbc::MapField<string, string>();
    /// <summary>
    /// Value names referenced by but external to this context.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> ExternalValues {
      get { return externalValues_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ValuesDef);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ValuesDef other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!values_.Equals(other.values_)) return false;
      if (!ExternalValues.Equals(other.ExternalValues)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= values_.GetHashCode();
      hash ^= ExternalValues.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      values_.WriteTo(output, _repeated_values_codec);
      externalValues_.WriteTo(output, _map_externalValues_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += values_.CalculateSize(_repeated_values_codec);
      size += externalValues_.CalculateSize(_map_externalValues_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ValuesDef other) {
      if (other == null) {
        return;
      }
      values_.Add(other.values_);
      externalValues_.Add(other.externalValues_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            values_.AddEntriesFrom(input, _repeated_values_codec);
            break;
          }
          case 18: {
            externalValues_.AddEntriesFrom(input, _map_externalValues_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Protocol buffer representing a CondContext object.
  /// </summary>
  public sealed partial class CondContextDef : pb::IMessage<CondContextDef> {
    private static readonly pb::MessageParser<CondContextDef> _parser = new pb::MessageParser<CondContextDef>(() => new CondContextDef());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CondContextDef> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.ControlFlowReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CondContextDef() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CondContextDef(CondContextDef other) : this() {
      contextName_ = other.contextName_;
      predName_ = other.predName_;
      pivotName_ = other.pivotName_;
      branch_ = other.branch_;
      ValuesDef = other.valuesDef_ != null ? other.ValuesDef.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CondContextDef Clone() {
      return new CondContextDef(this);
    }

    /// <summary>Field number for the "context_name" field.</summary>
    public const int ContextNameFieldNumber = 1;
    private string contextName_ = "";
    /// <summary>
    /// Name of the context.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ContextName {
      get { return contextName_; }
      set {
        contextName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "pred_name" field.</summary>
    public const int PredNameFieldNumber = 2;
    private string predName_ = "";
    /// <summary>
    /// Name of the pred tensor.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PredName {
      get { return predName_; }
      set {
        predName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "pivot_name" field.</summary>
    public const int PivotNameFieldNumber = 3;
    private string pivotName_ = "";
    /// <summary>
    /// Name of the pivot tensor.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PivotName {
      get { return pivotName_; }
      set {
        pivotName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "branch" field.</summary>
    public const int BranchFieldNumber = 4;
    private int branch_;
    /// <summary>
    /// Branch prediction. 0 or 1.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Branch {
      get { return branch_; }
      set {
        branch_ = value;
      }
    }

    /// <summary>Field number for the "values_def" field.</summary>
    public const int ValuesDefFieldNumber = 5;
    private global::Tensorflow.ValuesDef valuesDef_;
    /// <summary>
    /// Values and external values in control flow context.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.ValuesDef ValuesDef {
      get { return valuesDef_; }
      set {
        valuesDef_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CondContextDef);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CondContextDef other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ContextName != other.ContextName) return false;
      if (PredName != other.PredName) return false;
      if (PivotName != other.PivotName) return false;
      if (Branch != other.Branch) return false;
      if (!object.Equals(ValuesDef, other.ValuesDef)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ContextName.Length != 0) hash ^= ContextName.GetHashCode();
      if (PredName.Length != 0) hash ^= PredName.GetHashCode();
      if (PivotName.Length != 0) hash ^= PivotName.GetHashCode();
      if (Branch != 0) hash ^= Branch.GetHashCode();
      if (valuesDef_ != null) hash ^= ValuesDef.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ContextName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ContextName);
      }
      if (PredName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PredName);
      }
      if (PivotName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PivotName);
      }
      if (Branch != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Branch);
      }
      if (valuesDef_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(ValuesDef);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ContextName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ContextName);
      }
      if (PredName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PredName);
      }
      if (PivotName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PivotName);
      }
      if (Branch != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Branch);
      }
      if (valuesDef_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ValuesDef);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CondContextDef other) {
      if (other == null) {
        return;
      }
      if (other.ContextName.Length != 0) {
        ContextName = other.ContextName;
      }
      if (other.PredName.Length != 0) {
        PredName = other.PredName;
      }
      if (other.PivotName.Length != 0) {
        PivotName = other.PivotName;
      }
      if (other.Branch != 0) {
        Branch = other.Branch;
      }
      if (other.valuesDef_ != null) {
        if (valuesDef_ == null) {
          valuesDef_ = new global::Tensorflow.ValuesDef();
        }
        ValuesDef.MergeFrom(other.ValuesDef);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            ContextName = input.ReadString();
            break;
          }
          case 18: {
            PredName = input.ReadString();
            break;
          }
          case 26: {
            PivotName = input.ReadString();
            break;
          }
          case 32: {
            Branch = input.ReadInt32();
            break;
          }
          case 42: {
            if (valuesDef_ == null) {
              valuesDef_ = new global::Tensorflow.ValuesDef();
            }
            input.ReadMessage(valuesDef_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Protocol buffer representing a WhileContext object.
  /// </summary>
  public sealed partial class WhileContextDef : pb::IMessage<WhileContextDef> {
    private static readonly pb::MessageParser<WhileContextDef> _parser = new pb::MessageParser<WhileContextDef>(() => new WhileContextDef());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<WhileContextDef> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.ControlFlowReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WhileContextDef() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WhileContextDef(WhileContextDef other) : this() {
      contextName_ = other.contextName_;
      parallelIterations_ = other.parallelIterations_;
      backProp_ = other.backProp_;
      swapMemory_ = other.swapMemory_;
      pivotName_ = other.pivotName_;
      pivotForPredName_ = other.pivotForPredName_;
      pivotForBodyName_ = other.pivotForBodyName_;
      loopExitNames_ = other.loopExitNames_.Clone();
      loopEnterNames_ = other.loopEnterNames_.Clone();
      ValuesDef = other.valuesDef_ != null ? other.ValuesDef.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WhileContextDef Clone() {
      return new WhileContextDef(this);
    }

    /// <summary>Field number for the "context_name" field.</summary>
    public const int ContextNameFieldNumber = 1;
    private string contextName_ = "";
    /// <summary>
    /// Name of the context.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ContextName {
      get { return contextName_; }
      set {
        contextName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "parallel_iterations" field.</summary>
    public const int ParallelIterationsFieldNumber = 2;
    private int parallelIterations_;
    /// <summary>
    /// The number of iterations allowed to run in parallel.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ParallelIterations {
      get { return parallelIterations_; }
      set {
        parallelIterations_ = value;
      }
    }

    /// <summary>Field number for the "back_prop" field.</summary>
    public const int BackPropFieldNumber = 3;
    private bool backProp_;
    /// <summary>
    /// Whether backprop is enabled for this while loop.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool BackProp {
      get { return backProp_; }
      set {
        backProp_ = value;
      }
    }

    /// <summary>Field number for the "swap_memory" field.</summary>
    public const int SwapMemoryFieldNumber = 4;
    private bool swapMemory_;
    /// <summary>
    /// Whether GPU-CPU memory swap is enabled for this loop.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool SwapMemory {
      get { return swapMemory_; }
      set {
        swapMemory_ = value;
      }
    }

    /// <summary>Field number for the "pivot_name" field.</summary>
    public const int PivotNameFieldNumber = 5;
    private string pivotName_ = "";
    /// <summary>
    /// Name of the pivot tensor.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PivotName {
      get { return pivotName_; }
      set {
        pivotName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "pivot_for_pred_name" field.</summary>
    public const int PivotForPredNameFieldNumber = 6;
    private string pivotForPredName_ = "";
    /// <summary>
    /// Name of the pivot_for_pred tensor.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PivotForPredName {
      get { return pivotForPredName_; }
      set {
        pivotForPredName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "pivot_for_body_name" field.</summary>
    public const int PivotForBodyNameFieldNumber = 7;
    private string pivotForBodyName_ = "";
    /// <summary>
    /// Name of the pivot_for_body tensor.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PivotForBodyName {
      get { return pivotForBodyName_; }
      set {
        pivotForBodyName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "loop_exit_names" field.</summary>
    public const int LoopExitNamesFieldNumber = 8;
    private static readonly pb::FieldCodec<string> _repeated_loopExitNames_codec
        = pb::FieldCodec.ForString(66);
    private readonly pbc::RepeatedField<string> loopExitNames_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// List of names for exit tensors.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> LoopExitNames {
      get { return loopExitNames_; }
    }

    /// <summary>Field number for the "loop_enter_names" field.</summary>
    public const int LoopEnterNamesFieldNumber = 10;
    private static readonly pb::FieldCodec<string> _repeated_loopEnterNames_codec
        = pb::FieldCodec.ForString(82);
    private readonly pbc::RepeatedField<string> loopEnterNames_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// List of names for enter tensors.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> LoopEnterNames {
      get { return loopEnterNames_; }
    }

    /// <summary>Field number for the "values_def" field.</summary>
    public const int ValuesDefFieldNumber = 9;
    private global::Tensorflow.ValuesDef valuesDef_;
    /// <summary>
    /// Values and external values in control flow context.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.ValuesDef ValuesDef {
      get { return valuesDef_; }
      set {
        valuesDef_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as WhileContextDef);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(WhileContextDef other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ContextName != other.ContextName) return false;
      if (ParallelIterations != other.ParallelIterations) return false;
      if (BackProp != other.BackProp) return false;
      if (SwapMemory != other.SwapMemory) return false;
      if (PivotName != other.PivotName) return false;
      if (PivotForPredName != other.PivotForPredName) return false;
      if (PivotForBodyName != other.PivotForBodyName) return false;
      if(!loopExitNames_.Equals(other.loopExitNames_)) return false;
      if(!loopEnterNames_.Equals(other.loopEnterNames_)) return false;
      if (!object.Equals(ValuesDef, other.ValuesDef)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ContextName.Length != 0) hash ^= ContextName.GetHashCode();
      if (ParallelIterations != 0) hash ^= ParallelIterations.GetHashCode();
      if (BackProp != false) hash ^= BackProp.GetHashCode();
      if (SwapMemory != false) hash ^= SwapMemory.GetHashCode();
      if (PivotName.Length != 0) hash ^= PivotName.GetHashCode();
      if (PivotForPredName.Length != 0) hash ^= PivotForPredName.GetHashCode();
      if (PivotForBodyName.Length != 0) hash ^= PivotForBodyName.GetHashCode();
      hash ^= loopExitNames_.GetHashCode();
      hash ^= loopEnterNames_.GetHashCode();
      if (valuesDef_ != null) hash ^= ValuesDef.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ContextName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ContextName);
      }
      if (ParallelIterations != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(ParallelIterations);
      }
      if (BackProp != false) {
        output.WriteRawTag(24);
        output.WriteBool(BackProp);
      }
      if (SwapMemory != false) {
        output.WriteRawTag(32);
        output.WriteBool(SwapMemory);
      }
      if (PivotName.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(PivotName);
      }
      if (PivotForPredName.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(PivotForPredName);
      }
      if (PivotForBodyName.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(PivotForBodyName);
      }
      loopExitNames_.WriteTo(output, _repeated_loopExitNames_codec);
      if (valuesDef_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(ValuesDef);
      }
      loopEnterNames_.WriteTo(output, _repeated_loopEnterNames_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ContextName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ContextName);
      }
      if (ParallelIterations != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ParallelIterations);
      }
      if (BackProp != false) {
        size += 1 + 1;
      }
      if (SwapMemory != false) {
        size += 1 + 1;
      }
      if (PivotName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PivotName);
      }
      if (PivotForPredName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PivotForPredName);
      }
      if (PivotForBodyName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PivotForBodyName);
      }
      size += loopExitNames_.CalculateSize(_repeated_loopExitNames_codec);
      size += loopEnterNames_.CalculateSize(_repeated_loopEnterNames_codec);
      if (valuesDef_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ValuesDef);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(WhileContextDef other) {
      if (other == null) {
        return;
      }
      if (other.ContextName.Length != 0) {
        ContextName = other.ContextName;
      }
      if (other.ParallelIterations != 0) {
        ParallelIterations = other.ParallelIterations;
      }
      if (other.BackProp != false) {
        BackProp = other.BackProp;
      }
      if (other.SwapMemory != false) {
        SwapMemory = other.SwapMemory;
      }
      if (other.PivotName.Length != 0) {
        PivotName = other.PivotName;
      }
      if (other.PivotForPredName.Length != 0) {
        PivotForPredName = other.PivotForPredName;
      }
      if (other.PivotForBodyName.Length != 0) {
        PivotForBodyName = other.PivotForBodyName;
      }
      loopExitNames_.Add(other.loopExitNames_);
      loopEnterNames_.Add(other.loopEnterNames_);
      if (other.valuesDef_ != null) {
        if (valuesDef_ == null) {
          valuesDef_ = new global::Tensorflow.ValuesDef();
        }
        ValuesDef.MergeFrom(other.ValuesDef);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            ContextName = input.ReadString();
            break;
          }
          case 16: {
            ParallelIterations = input.ReadInt32();
            break;
          }
          case 24: {
            BackProp = input.ReadBool();
            break;
          }
          case 32: {
            SwapMemory = input.ReadBool();
            break;
          }
          case 42: {
            PivotName = input.ReadString();
            break;
          }
          case 50: {
            PivotForPredName = input.ReadString();
            break;
          }
          case 58: {
            PivotForBodyName = input.ReadString();
            break;
          }
          case 66: {
            loopExitNames_.AddEntriesFrom(input, _repeated_loopExitNames_codec);
            break;
          }
          case 74: {
            if (valuesDef_ == null) {
              valuesDef_ = new global::Tensorflow.ValuesDef();
            }
            input.ReadMessage(valuesDef_);
            break;
          }
          case 82: {
            loopEnterNames_.AddEntriesFrom(input, _repeated_loopEnterNames_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
