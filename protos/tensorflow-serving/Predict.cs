// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tensorflow_serving/apis/predict.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tensorflow.Serving {

  /// <summary>Holder for reflection information generated from tensorflow_serving/apis/predict.proto</summary>
  public static partial class PredictReflection {

    #region Descriptor
    /// <summary>File descriptor for tensorflow_serving/apis/predict.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PredictReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiV0ZW5zb3JmbG93X3NlcnZpbmcvYXBpcy9wcmVkaWN0LnByb3RvEhJ0ZW5z",
            "b3JmbG93LnNlcnZpbmcaJnRlbnNvcmZsb3cvY29yZS9mcmFtZXdvcmsvdGVu",
            "c29yLnByb3RvGiN0ZW5zb3JmbG93X3NlcnZpbmcvYXBpcy9tb2RlbC5wcm90",
            "byLiAQoOUHJlZGljdFJlcXVlc3QSMQoKbW9kZWxfc3BlYxgBIAEoCzIdLnRl",
            "bnNvcmZsb3cuc2VydmluZy5Nb2RlbFNwZWMSPgoGaW5wdXRzGAIgAygLMi4u",
            "dGVuc29yZmxvdy5zZXJ2aW5nLlByZWRpY3RSZXF1ZXN0LklucHV0c0VudHJ5",
            "EhUKDW91dHB1dF9maWx0ZXIYAyADKAkaRgoLSW5wdXRzRW50cnkSCwoDa2V5",
            "GAEgASgJEiYKBXZhbHVlGAIgASgLMhcudGVuc29yZmxvdy5UZW5zb3JQcm90",
            "bzoCOAEinQEKD1ByZWRpY3RSZXNwb25zZRJBCgdvdXRwdXRzGAEgAygLMjAu",
            "dGVuc29yZmxvdy5zZXJ2aW5nLlByZWRpY3RSZXNwb25zZS5PdXRwdXRzRW50",
            "cnkaRwoMT3V0cHV0c0VudHJ5EgsKA2tleRgBIAEoCRImCgV2YWx1ZRgCIAEo",
            "CzIXLnRlbnNvcmZsb3cuVGVuc29yUHJvdG86AjgBQgP4AQFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Tensorflow.TensorReflection.Descriptor, global::Tensorflow.Serving.ModelReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.Serving.PredictRequest), global::Tensorflow.Serving.PredictRequest.Parser, new[]{ "ModelSpec", "Inputs", "OutputFilter" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.Serving.PredictResponse), global::Tensorflow.Serving.PredictResponse.Parser, new[]{ "Outputs" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// PredictRequest specifies which TensorFlow model to run, as well as
  /// how inputs are mapped to tensors and how outputs are filtered before
  /// returning to user.
  /// </summary>
  public sealed partial class PredictRequest : pb::IMessage<PredictRequest> {
    private static readonly pb::MessageParser<PredictRequest> _parser = new pb::MessageParser<PredictRequest>(() => new PredictRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PredictRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.Serving.PredictReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PredictRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PredictRequest(PredictRequest other) : this() {
      ModelSpec = other.modelSpec_ != null ? other.ModelSpec.Clone() : null;
      inputs_ = other.inputs_.Clone();
      outputFilter_ = other.outputFilter_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PredictRequest Clone() {
      return new PredictRequest(this);
    }

    /// <summary>Field number for the "model_spec" field.</summary>
    public const int ModelSpecFieldNumber = 1;
    private global::Tensorflow.Serving.ModelSpec modelSpec_;
    /// <summary>
    /// Model Specification.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.Serving.ModelSpec ModelSpec {
      get { return modelSpec_; }
      set {
        modelSpec_ = value;
      }
    }

    /// <summary>Field number for the "inputs" field.</summary>
    public const int InputsFieldNumber = 2;
    private static readonly pbc::MapField<string, global::Tensorflow.TensorProto>.Codec _map_inputs_codec
        = new pbc::MapField<string, global::Tensorflow.TensorProto>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::Tensorflow.TensorProto.Parser), 18);
    private readonly pbc::MapField<string, global::Tensorflow.TensorProto> inputs_ = new pbc::MapField<string, global::Tensorflow.TensorProto>();
    /// <summary>
    /// Input tensors.
    /// Names of input tensor are alias names. The mapping from aliases to real
    /// input tensor names is stored in the SavedModel export as a prediction
    /// SignatureDef under the 'inputs' field.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::Tensorflow.TensorProto> Inputs {
      get { return inputs_; }
    }

    /// <summary>Field number for the "output_filter" field.</summary>
    public const int OutputFilterFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_outputFilter_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> outputFilter_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Output filter.
    /// Names specified are alias names. The mapping from aliases to real output
    /// tensor names is stored in the SavedModel export as a prediction
    /// SignatureDef under the 'outputs' field.
    /// Only tensors specified here will be run/fetched and returned, with the
    /// exception that when none is specified, all tensors specified in the
    /// named signature will be run/fetched and returned.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> OutputFilter {
      get { return outputFilter_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PredictRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PredictRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ModelSpec, other.ModelSpec)) return false;
      if (!Inputs.Equals(other.Inputs)) return false;
      if(!outputFilter_.Equals(other.outputFilter_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (modelSpec_ != null) hash ^= ModelSpec.GetHashCode();
      hash ^= Inputs.GetHashCode();
      hash ^= outputFilter_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (modelSpec_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ModelSpec);
      }
      inputs_.WriteTo(output, _map_inputs_codec);
      outputFilter_.WriteTo(output, _repeated_outputFilter_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (modelSpec_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ModelSpec);
      }
      size += inputs_.CalculateSize(_map_inputs_codec);
      size += outputFilter_.CalculateSize(_repeated_outputFilter_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PredictRequest other) {
      if (other == null) {
        return;
      }
      if (other.modelSpec_ != null) {
        if (modelSpec_ == null) {
          modelSpec_ = new global::Tensorflow.Serving.ModelSpec();
        }
        ModelSpec.MergeFrom(other.ModelSpec);
      }
      inputs_.Add(other.inputs_);
      outputFilter_.Add(other.outputFilter_);
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
            if (modelSpec_ == null) {
              modelSpec_ = new global::Tensorflow.Serving.ModelSpec();
            }
            input.ReadMessage(modelSpec_);
            break;
          }
          case 18: {
            inputs_.AddEntriesFrom(input, _map_inputs_codec);
            break;
          }
          case 26: {
            outputFilter_.AddEntriesFrom(input, _repeated_outputFilter_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Response for PredictRequest on successful run.
  /// </summary>
  public sealed partial class PredictResponse : pb::IMessage<PredictResponse> {
    private static readonly pb::MessageParser<PredictResponse> _parser = new pb::MessageParser<PredictResponse>(() => new PredictResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PredictResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.Serving.PredictReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PredictResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PredictResponse(PredictResponse other) : this() {
      outputs_ = other.outputs_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PredictResponse Clone() {
      return new PredictResponse(this);
    }

    /// <summary>Field number for the "outputs" field.</summary>
    public const int OutputsFieldNumber = 1;
    private static readonly pbc::MapField<string, global::Tensorflow.TensorProto>.Codec _map_outputs_codec
        = new pbc::MapField<string, global::Tensorflow.TensorProto>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::Tensorflow.TensorProto.Parser), 10);
    private readonly pbc::MapField<string, global::Tensorflow.TensorProto> outputs_ = new pbc::MapField<string, global::Tensorflow.TensorProto>();
    /// <summary>
    /// Output tensors.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::Tensorflow.TensorProto> Outputs {
      get { return outputs_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PredictResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PredictResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!Outputs.Equals(other.Outputs)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= Outputs.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      outputs_.WriteTo(output, _map_outputs_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += outputs_.CalculateSize(_map_outputs_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PredictResponse other) {
      if (other == null) {
        return;
      }
      outputs_.Add(other.outputs_);
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
            outputs_.AddEntriesFrom(input, _map_outputs_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
