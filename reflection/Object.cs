// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace reflection
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct Object : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static Object GetRootAsObject(ByteBuffer _bb) { return GetRootAsObject(_bb, new Object()); }
  public static Object GetRootAsObject(ByteBuffer _bb, Object obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public Object __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Name { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(4); }
  public reflection.Field? Fields(int j) { int o = __p.__offset(6); return o != 0 ? (reflection.Field?)(new reflection.Field()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int FieldsLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
  public reflection.Field? FieldsByKey(string key) { int o = __p.__offset(6); return o != 0 ? reflection.Field.__lookup_by_key(__p.__vector(o), key, __p.bb) : null; }
  public bool IsStruct { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public int Minalign { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Bytesize { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public reflection.KeyValue? Attributes(int j) { int o = __p.__offset(14); return o != 0 ? (reflection.KeyValue?)(new reflection.KeyValue()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int AttributesLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
  public reflection.KeyValue? AttributesByKey(string key) { int o = __p.__offset(14); return o != 0 ? reflection.KeyValue.__lookup_by_key(__p.__vector(o), key, __p.bb) : null; }
  public string Documentation(int j) { int o = __p.__offset(16); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int DocumentationLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
  /// File that this Object is declared in.
  public string DeclarationFile { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDeclarationFileBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetDeclarationFileBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetDeclarationFileArray() { return __p.__vector_as_array<byte>(18); }

  public static Offset<reflection.Object> CreateObject(FlatBufferBuilder builder,
      StringOffset nameOffset = default(StringOffset),
      VectorOffset fieldsOffset = default(VectorOffset),
      bool is_struct = false,
      int minalign = 0,
      int bytesize = 0,
      VectorOffset attributesOffset = default(VectorOffset),
      VectorOffset documentationOffset = default(VectorOffset),
      StringOffset declaration_fileOffset = default(StringOffset)) {
    builder.StartTable(8);
    Object.AddDeclarationFile(builder, declaration_fileOffset);
    Object.AddDocumentation(builder, documentationOffset);
    Object.AddAttributes(builder, attributesOffset);
    Object.AddBytesize(builder, bytesize);
    Object.AddMinalign(builder, minalign);
    Object.AddFields(builder, fieldsOffset);
    Object.AddName(builder, nameOffset);
    Object.AddIsStruct(builder, is_struct);
    return Object.EndObject(builder);
  }

  public static void StartObject(FlatBufferBuilder builder) { builder.StartTable(8); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(0, nameOffset.Value, 0); }
  public static void AddFields(FlatBufferBuilder builder, VectorOffset fieldsOffset) { builder.AddOffset(1, fieldsOffset.Value, 0); }
  public static VectorOffset CreateFieldsVector(FlatBufferBuilder builder, Offset<reflection.Field>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateFieldsVectorBlock(FlatBufferBuilder builder, Offset<reflection.Field>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateFieldsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<reflection.Field>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateFieldsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<reflection.Field>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartFieldsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddIsStruct(FlatBufferBuilder builder, bool isStruct) { builder.AddBool(2, isStruct, false); }
  public static void AddMinalign(FlatBufferBuilder builder, int minalign) { builder.AddInt(3, minalign, 0); }
  public static void AddBytesize(FlatBufferBuilder builder, int bytesize) { builder.AddInt(4, bytesize, 0); }
  public static void AddAttributes(FlatBufferBuilder builder, VectorOffset attributesOffset) { builder.AddOffset(5, attributesOffset.Value, 0); }
  public static VectorOffset CreateAttributesVector(FlatBufferBuilder builder, Offset<reflection.KeyValue>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateAttributesVectorBlock(FlatBufferBuilder builder, Offset<reflection.KeyValue>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateAttributesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<reflection.KeyValue>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateAttributesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<reflection.KeyValue>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartAttributesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDocumentation(FlatBufferBuilder builder, VectorOffset documentationOffset) { builder.AddOffset(6, documentationOffset.Value, 0); }
  public static VectorOffset CreateDocumentationVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDocumentationVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDocumentationVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDocumentationVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDocumentationVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDeclarationFile(FlatBufferBuilder builder, StringOffset declarationFileOffset) { builder.AddOffset(7, declarationFileOffset.Value, 0); }
  public static Offset<reflection.Object> EndObject(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    builder.Required(o, 4);  // name
    builder.Required(o, 6);  // fields
    return new Offset<reflection.Object>(o);
  }

  public static VectorOffset CreateSortedVectorOfObject(FlatBufferBuilder builder, Offset<Object>[] offsets) {
    Array.Sort(offsets,
      (Offset<Object> o1, Offset<Object> o2) =>
        new Object().__assign(builder.DataBuffer.Length - o1.Value, builder.DataBuffer).Name.CompareTo(new Object().__assign(builder.DataBuffer.Length - o2.Value, builder.DataBuffer).Name));
    return builder.CreateVectorOfTables(offsets);
  }

  public static Object? __lookup_by_key(int vectorLocation, string key, ByteBuffer bb) {
    Object obj_ = new Object();
    int span = bb.GetInt(vectorLocation - 4);
    int start = 0;
    while (span != 0) {
      int middle = span / 2;
      int tableOffset = Table.__indirect(vectorLocation + 4 * (start + middle), bb);
      obj_.__assign(tableOffset, bb);
      int comp = obj_.Name.CompareTo(key);
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
  public ObjectT UnPack() {
    var _o = new ObjectT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ObjectT _o) {
    _o.Name = this.Name;
    _o.Fields = new List<reflection.FieldT>();
    for (var _j = 0; _j < this.FieldsLength; ++_j) {_o.Fields.Add(this.Fields(_j).HasValue ? this.Fields(_j).Value.UnPack() : null);}
    _o.IsStruct = this.IsStruct;
    _o.Minalign = this.Minalign;
    _o.Bytesize = this.Bytesize;
    _o.Attributes = new List<reflection.KeyValueT>();
    for (var _j = 0; _j < this.AttributesLength; ++_j) {_o.Attributes.Add(this.Attributes(_j).HasValue ? this.Attributes(_j).Value.UnPack() : null);}
    _o.Documentation = new List<string>();
    for (var _j = 0; _j < this.DocumentationLength; ++_j) {_o.Documentation.Add(this.Documentation(_j));}
    _o.DeclarationFile = this.DeclarationFile;
  }
  public static Offset<reflection.Object> Pack(FlatBufferBuilder builder, ObjectT _o) {
    if (_o == null) return default(Offset<reflection.Object>);
    var _name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    var _fields = default(VectorOffset);
    if (_o.Fields != null) {
      var __fields = new Offset<reflection.Field>[_o.Fields.Count];
      for (var _j = 0; _j < __fields.Length; ++_j) { __fields[_j] = reflection.Field.Pack(builder, _o.Fields[_j]); }
      _fields = CreateFieldsVector(builder, __fields);
    }
    var _attributes = default(VectorOffset);
    if (_o.Attributes != null) {
      var __attributes = new Offset<reflection.KeyValue>[_o.Attributes.Count];
      for (var _j = 0; _j < __attributes.Length; ++_j) { __attributes[_j] = reflection.KeyValue.Pack(builder, _o.Attributes[_j]); }
      _attributes = CreateAttributesVector(builder, __attributes);
    }
    var _documentation = default(VectorOffset);
    if (_o.Documentation != null) {
      var __documentation = new StringOffset[_o.Documentation.Count];
      for (var _j = 0; _j < __documentation.Length; ++_j) { __documentation[_j] = builder.CreateString(_o.Documentation[_j]); }
      _documentation = CreateDocumentationVector(builder, __documentation);
    }
    var _declaration_file = _o.DeclarationFile == null ? default(StringOffset) : builder.CreateString(_o.DeclarationFile);
    return CreateObject(
      builder,
      _name,
      _fields,
      _o.IsStruct,
      _o.Minalign,
      _o.Bytesize,
      _attributes,
      _documentation,
      _declaration_file);
  }
}

public class ObjectT
{
  public string Name { get; set; }
  public List<reflection.FieldT> Fields { get; set; }
  public bool IsStruct { get; set; }
  public int Minalign { get; set; }
  public int Bytesize { get; set; }
  public List<reflection.KeyValueT> Attributes { get; set; }
  public List<string> Documentation { get; set; }
  public string DeclarationFile { get; set; }

  public ObjectT() {
    this.Name = null;
    this.Fields = null;
    this.IsStruct = false;
    this.Minalign = 0;
    this.Bytesize = 0;
    this.Attributes = null;
    this.Documentation = null;
    this.DeclarationFile = null;
  }
}


static public class ObjectVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyString(tablePos, 4 /*Name*/, true)
      && verifier.VerifyVectorOfTables(tablePos, 6 /*Fields*/, reflection.FieldVerify.Verify, true)
      && verifier.VerifyField(tablePos, 8 /*IsStruct*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 10 /*Minalign*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*Bytesize*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfTables(tablePos, 14 /*Attributes*/, reflection.KeyValueVerify.Verify, false)
      && verifier.VerifyVectorOfStrings(tablePos, 16 /*Documentation*/, false)
      && verifier.VerifyString(tablePos, 18 /*DeclarationFile*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}