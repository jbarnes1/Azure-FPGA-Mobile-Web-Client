// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tensorflow/core/protobuf/saver.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tensorflow {

  /// <summary>Holder for reflection information generated from tensorflow/core/protobuf/saver.proto</summary>
  public static partial class SaverReflection {

    #region Descriptor
    /// <summary>File descriptor for tensorflow/core/protobuf/saver.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SaverReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiR0ZW5zb3JmbG93L2NvcmUvcHJvdG9idWYvc2F2ZXIucHJvdG8SCnRlbnNv",
            "cmZsb3cingIKCFNhdmVyRGVmEhwKFGZpbGVuYW1lX3RlbnNvcl9uYW1lGAEg",
            "ASgJEhgKEHNhdmVfdGVuc29yX25hbWUYAiABKAkSFwoPcmVzdG9yZV9vcF9u",
            "YW1lGAMgASgJEhMKC21heF90b19rZWVwGAQgASgFEg8KB3NoYXJkZWQYBSAB",
            "KAgSJQoda2VlcF9jaGVja3BvaW50X2V2ZXJ5X25faG91cnMYBiABKAISPQoH",
            "dmVyc2lvbhgHIAEoDjIsLnRlbnNvcmZsb3cuU2F2ZXJEZWYuQ2hlY2twb2lu",
            "dEZvcm1hdFZlcnNpb24iNQoXQ2hlY2twb2ludEZvcm1hdFZlcnNpb24SCgoG",
            "TEVHQUNZEAASBgoCVjEQARIGCgJWMhACQicKE29yZy50ZW5zb3JmbG93LnV0",
            "aWxCC1NhdmVyUHJvdG9zUAH4AQFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.SaverDef), global::Tensorflow.SaverDef.Parser, new[]{ "FilenameTensorName", "SaveTensorName", "RestoreOpName", "MaxToKeep", "Sharded", "KeepCheckpointEveryNHours", "Version" }, null, new[]{ typeof(global::Tensorflow.SaverDef.Types.CheckpointFormatVersion) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Protocol buffer representing the configuration of a Saver.
  /// </summary>
  public sealed partial class SaverDef : pb::IMessage<SaverDef> {
    private static readonly pb::MessageParser<SaverDef> _parser = new pb::MessageParser<SaverDef>(() => new SaverDef());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SaverDef> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.SaverReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SaverDef() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SaverDef(SaverDef other) : this() {
      filenameTensorName_ = other.filenameTensorName_;
      saveTensorName_ = other.saveTensorName_;
      restoreOpName_ = other.restoreOpName_;
      maxToKeep_ = other.maxToKeep_;
      sharded_ = other.sharded_;
      keepCheckpointEveryNHours_ = other.keepCheckpointEveryNHours_;
      version_ = other.version_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SaverDef Clone() {
      return new SaverDef(this);
    }

    /// <summary>Field number for the "filename_tensor_name" field.</summary>
    public const int FilenameTensorNameFieldNumber = 1;
    private string filenameTensorName_ = "";
    /// <summary>
    /// The name of the tensor in which to specify the filename when saving or
    /// restoring a model checkpoint.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FilenameTensorName {
      get { return filenameTensorName_; }
      set {
        filenameTensorName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "save_tensor_name" field.</summary>
    public const int SaveTensorNameFieldNumber = 2;
    private string saveTensorName_ = "";
    /// <summary>
    /// The operation to run when saving a model checkpoint.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SaveTensorName {
      get { return saveTensorName_; }
      set {
        saveTensorName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "restore_op_name" field.</summary>
    public const int RestoreOpNameFieldNumber = 3;
    private string restoreOpName_ = "";
    /// <summary>
    /// The operation to run when restoring a model checkpoint.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RestoreOpName {
      get { return restoreOpName_; }
      set {
        restoreOpName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "max_to_keep" field.</summary>
    public const int MaxToKeepFieldNumber = 4;
    private int maxToKeep_;
    /// <summary>
    /// Maximum number of checkpoints to keep.  If 0, no checkpoints are deleted.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MaxToKeep {
      get { return maxToKeep_; }
      set {
        maxToKeep_ = value;
      }
    }

    /// <summary>Field number for the "sharded" field.</summary>
    public const int ShardedFieldNumber = 5;
    private bool sharded_;
    /// <summary>
    /// Shard the save files, one per device that has Variable nodes.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Sharded {
      get { return sharded_; }
      set {
        sharded_ = value;
      }
    }

    /// <summary>Field number for the "keep_checkpoint_every_n_hours" field.</summary>
    public const int KeepCheckpointEveryNHoursFieldNumber = 6;
    private float keepCheckpointEveryNHours_;
    /// <summary>
    /// How often to keep an additional checkpoint. If not specified, only the last
    /// "max_to_keep" checkpoints are kept; if specified, in addition to keeping
    /// the last "max_to_keep" checkpoints, an additional checkpoint will be kept
    /// for every n hours of training.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float KeepCheckpointEveryNHours {
      get { return keepCheckpointEveryNHours_; }
      set {
        keepCheckpointEveryNHours_ = value;
      }
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 7;
    private global::Tensorflow.SaverDef.Types.CheckpointFormatVersion version_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.SaverDef.Types.CheckpointFormatVersion Version {
      get { return version_; }
      set {
        version_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SaverDef);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SaverDef other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FilenameTensorName != other.FilenameTensorName) return false;
      if (SaveTensorName != other.SaveTensorName) return false;
      if (RestoreOpName != other.RestoreOpName) return false;
      if (MaxToKeep != other.MaxToKeep) return false;
      if (Sharded != other.Sharded) return false;
      if (KeepCheckpointEveryNHours != other.KeepCheckpointEveryNHours) return false;
      if (Version != other.Version) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (FilenameTensorName.Length != 0) hash ^= FilenameTensorName.GetHashCode();
      if (SaveTensorName.Length != 0) hash ^= SaveTensorName.GetHashCode();
      if (RestoreOpName.Length != 0) hash ^= RestoreOpName.GetHashCode();
      if (MaxToKeep != 0) hash ^= MaxToKeep.GetHashCode();
      if (Sharded != false) hash ^= Sharded.GetHashCode();
      if (KeepCheckpointEveryNHours != 0F) hash ^= KeepCheckpointEveryNHours.GetHashCode();
      if (Version != 0) hash ^= Version.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (FilenameTensorName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(FilenameTensorName);
      }
      if (SaveTensorName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(SaveTensorName);
      }
      if (RestoreOpName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(RestoreOpName);
      }
      if (MaxToKeep != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(MaxToKeep);
      }
      if (Sharded != false) {
        output.WriteRawTag(40);
        output.WriteBool(Sharded);
      }
      if (KeepCheckpointEveryNHours != 0F) {
        output.WriteRawTag(53);
        output.WriteFloat(KeepCheckpointEveryNHours);
      }
      if (Version != 0) {
        output.WriteRawTag(56);
        output.WriteEnum((int) Version);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (FilenameTensorName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FilenameTensorName);
      }
      if (SaveTensorName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SaveTensorName);
      }
      if (RestoreOpName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RestoreOpName);
      }
      if (MaxToKeep != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxToKeep);
      }
      if (Sharded != false) {
        size += 1 + 1;
      }
      if (KeepCheckpointEveryNHours != 0F) {
        size += 1 + 4;
      }
      if (Version != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Version);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SaverDef other) {
      if (other == null) {
        return;
      }
      if (other.FilenameTensorName.Length != 0) {
        FilenameTensorName = other.FilenameTensorName;
      }
      if (other.SaveTensorName.Length != 0) {
        SaveTensorName = other.SaveTensorName;
      }
      if (other.RestoreOpName.Length != 0) {
        RestoreOpName = other.RestoreOpName;
      }
      if (other.MaxToKeep != 0) {
        MaxToKeep = other.MaxToKeep;
      }
      if (other.Sharded != false) {
        Sharded = other.Sharded;
      }
      if (other.KeepCheckpointEveryNHours != 0F) {
        KeepCheckpointEveryNHours = other.KeepCheckpointEveryNHours;
      }
      if (other.Version != 0) {
        Version = other.Version;
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
            FilenameTensorName = input.ReadString();
            break;
          }
          case 18: {
            SaveTensorName = input.ReadString();
            break;
          }
          case 26: {
            RestoreOpName = input.ReadString();
            break;
          }
          case 32: {
            MaxToKeep = input.ReadInt32();
            break;
          }
          case 40: {
            Sharded = input.ReadBool();
            break;
          }
          case 53: {
            KeepCheckpointEveryNHours = input.ReadFloat();
            break;
          }
          case 56: {
            version_ = (global::Tensorflow.SaverDef.Types.CheckpointFormatVersion) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the SaverDef message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// A version number that identifies a different on-disk checkpoint format.
      /// Usually, each subclass of BaseSaverBuilder works with a particular
      /// version/format.  However, it is possible that the same builder may be
      /// upgraded to support a newer checkpoint format in the future.
      /// </summary>
      public enum CheckpointFormatVersion {
        /// <summary>
        /// Internal legacy format.
        /// </summary>
        [pbr::OriginalName("LEGACY")] Legacy = 0,
        /// <summary>
        /// Deprecated format: tf.Saver() which works with tensorflow::table::Table.
        /// </summary>
        [pbr::OriginalName("V1")] V1 = 1,
        /// <summary>
        /// Current format: more efficient.
        /// </summary>
        [pbr::OriginalName("V2")] V2 = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
