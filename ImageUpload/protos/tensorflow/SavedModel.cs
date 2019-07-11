// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tensorflow/core/protobuf/saved_model.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tensorflow {

  /// <summary>Holder for reflection information generated from tensorflow/core/protobuf/saved_model.proto</summary>
  public static partial class SavedModelReflection {

    #region Descriptor
    /// <summary>File descriptor for tensorflow/core/protobuf/saved_model.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SavedModelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cip0ZW5zb3JmbG93L2NvcmUvcHJvdG9idWYvc2F2ZWRfbW9kZWwucHJvdG8S",
            "CnRlbnNvcmZsb3caKXRlbnNvcmZsb3cvY29yZS9wcm90b2J1Zi9tZXRhX2dy",
            "YXBoLnByb3RvIl8KClNhdmVkTW9kZWwSIgoac2F2ZWRfbW9kZWxfc2NoZW1h",
            "X3ZlcnNpb24YASABKAMSLQoLbWV0YV9ncmFwaHMYAiADKAsyGC50ZW5zb3Jm",
            "bG93Lk1ldGFHcmFwaERlZkIxChhvcmcudGVuc29yZmxvdy5mcmFtZXdvcmtC",
            "EFNhdmVkTW9kZWxQcm90b3NQAfgBAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Tensorflow.MetaGraphReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.SavedModel), global::Tensorflow.SavedModel.Parser, new[]{ "SavedModelSchemaVersion", "MetaGraphs" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// SavedModel is the high level serialization format for TensorFlow Models.
  /// See [todo: doc links, similar to session_bundle] for more information.
  /// </summary>
  public sealed partial class SavedModel : pb::IMessage<SavedModel> {
    private static readonly pb::MessageParser<SavedModel> _parser = new pb::MessageParser<SavedModel>(() => new SavedModel());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SavedModel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.SavedModelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SavedModel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SavedModel(SavedModel other) : this() {
      savedModelSchemaVersion_ = other.savedModelSchemaVersion_;
      metaGraphs_ = other.metaGraphs_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SavedModel Clone() {
      return new SavedModel(this);
    }

    /// <summary>Field number for the "saved_model_schema_version" field.</summary>
    public const int SavedModelSchemaVersionFieldNumber = 1;
    private long savedModelSchemaVersion_;
    /// <summary>
    /// The schema version of the SavedModel instance. Used for versioning when
    /// making future changes to the specification/implementation. Initial value
    /// at release will be 1.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long SavedModelSchemaVersion {
      get { return savedModelSchemaVersion_; }
      set {
        savedModelSchemaVersion_ = value;
      }
    }

    /// <summary>Field number for the "meta_graphs" field.</summary>
    public const int MetaGraphsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Tensorflow.MetaGraphDef> _repeated_metaGraphs_codec
        = pb::FieldCodec.ForMessage(18, global::Tensorflow.MetaGraphDef.Parser);
    private readonly pbc::RepeatedField<global::Tensorflow.MetaGraphDef> metaGraphs_ = new pbc::RepeatedField<global::Tensorflow.MetaGraphDef>();
    /// <summary>
    /// One or more MetaGraphs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Tensorflow.MetaGraphDef> MetaGraphs {
      get { return metaGraphs_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SavedModel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SavedModel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SavedModelSchemaVersion != other.SavedModelSchemaVersion) return false;
      if(!metaGraphs_.Equals(other.metaGraphs_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SavedModelSchemaVersion != 0L) hash ^= SavedModelSchemaVersion.GetHashCode();
      hash ^= metaGraphs_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (SavedModelSchemaVersion != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(SavedModelSchemaVersion);
      }
      metaGraphs_.WriteTo(output, _repeated_metaGraphs_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SavedModelSchemaVersion != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(SavedModelSchemaVersion);
      }
      size += metaGraphs_.CalculateSize(_repeated_metaGraphs_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SavedModel other) {
      if (other == null) {
        return;
      }
      if (other.SavedModelSchemaVersion != 0L) {
        SavedModelSchemaVersion = other.SavedModelSchemaVersion;
      }
      metaGraphs_.Add(other.metaGraphs_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            SavedModelSchemaVersion = input.ReadInt64();
            break;
          }
          case 18: {
            metaGraphs_.AddEntriesFrom(input, _repeated_metaGraphs_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
