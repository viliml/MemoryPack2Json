// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace reflection
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

/// File specific information.
/// Symbols declared within a file may be recovered by iterating over all
/// symbols and examining the `declaration_file` field.
public struct SchemaFile : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static SchemaFile GetRootAsSchemaFile(ByteBuffer _bb) { return GetRootAsSchemaFile(_bb, new SchemaFile()); }
  public static SchemaFile GetRootAsSchemaFile(ByteBuffer _bb, SchemaFile obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public SchemaFile __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  /// Filename, relative to project root.
  public string Filename { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetFilenameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetFilenameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetFilenameArray() { return __p.__vector_as_array<byte>(4); }
  /// Names of included files, relative to project root.
  public string IncludedFilenames(int j) { int o = __p.__offset(6); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int IncludedFilenamesLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<reflection.SchemaFile> CreateSchemaFile(FlatBufferBuilder builder,
      StringOffset filenameOffset = default(StringOffset),
      VectorOffset included_filenamesOffset = default(VectorOffset)) {
    builder.StartTable(2);
    SchemaFile.AddIncludedFilenames(builder, included_filenamesOffset);
    SchemaFile.AddFilename(builder, filenameOffset);
    return SchemaFile.EndSchemaFile(builder);
  }

  public static void StartSchemaFile(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddFilename(FlatBufferBuilder builder, StringOffset filenameOffset) { builder.AddOffset(0, filenameOffset.Value, 0); }
  public static void AddIncludedFilenames(FlatBufferBuilder builder, VectorOffset includedFilenamesOffset) { builder.AddOffset(1, includedFilenamesOffset.Value, 0); }
  public static VectorOffset CreateIncludedFilenamesVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateIncludedFilenamesVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateIncludedFilenamesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateIncludedFilenamesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartIncludedFilenamesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<reflection.SchemaFile> EndSchemaFile(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    builder.Required(o, 4);  // filename
    return new Offset<reflection.SchemaFile>(o);
  }

  public static VectorOffset CreateSortedVectorOfSchemaFile(FlatBufferBuilder builder, Offset<SchemaFile>[] offsets) {
    Array.Sort(offsets,
      (Offset<SchemaFile> o1, Offset<SchemaFile> o2) =>
        new SchemaFile().__assign(builder.DataBuffer.Length - o1.Value, builder.DataBuffer).Filename.CompareTo(new SchemaFile().__assign(builder.DataBuffer.Length - o2.Value, builder.DataBuffer).Filename));
    return builder.CreateVectorOfTables(offsets);
  }

  public static SchemaFile? __lookup_by_key(int vectorLocation, string key, ByteBuffer bb) {
    SchemaFile obj_ = new SchemaFile();
    int span = bb.GetInt(vectorLocation - 4);
    int start = 0;
    while (span != 0) {
      int middle = span / 2;
      int tableOffset = Table.__indirect(vectorLocation + 4 * (start + middle), bb);
      obj_.__assign(tableOffset, bb);
      int comp = obj_.Filename.CompareTo(key);
      if (comp > 0) {
        span = middle;
      } else if (comp < 0) {
        middle++;
        start += middle;
        span -= middle;
      } else {
        return obj_;
      }
    }
    return null;
  }
  public SchemaFileT UnPack() {
    var _o = new SchemaFileT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(SchemaFileT _o) {
    _o.Filename = this.Filename;
    _o.IncludedFilenames = new List<string>();
    for (var _j = 0; _j < this.IncludedFilenamesLength; ++_j) {_o.IncludedFilenames.Add(this.IncludedFilenames(_j));}
  }
  public static Offset<reflection.SchemaFile> Pack(FlatBufferBuilder builder, SchemaFileT _o) {
    if (_o == null) return default(Offset<reflection.SchemaFile>);
    var _filename = _o.Filename == null ? default(StringOffset) : builder.CreateString(_o.Filename);
    var _included_filenames = default(VectorOffset);
    if (_o.IncludedFilenames != null) {
      var __included_filenames = new StringOffset[_o.IncludedFilenames.Count];
      for (var _j = 0; _j < __included_filenames.Length; ++_j) { __included_filenames[_j] = builder.CreateString(_o.IncludedFilenames[_j]); }
      _included_filenames = CreateIncludedFilenamesVector(builder, __included_filenames);
    }
    return CreateSchemaFile(
      builder,
      _filename,
      _included_filenames);
  }
}

public class SchemaFileT
{
  public string Filename { get; set; }
  public List<string> IncludedFilenames { get; set; }

  public SchemaFileT() {
    this.Filename = null;
    this.IncludedFilenames = null;
  }
}


static public class SchemaFileVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyString(tablePos, 4 /*Filename*/, true)
      && verifier.VerifyVectorOfStrings(tablePos, 6 /*IncludedFilenames*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}