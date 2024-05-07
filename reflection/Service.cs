// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace reflection
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct Service : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static Service GetRootAsService(ByteBuffer _bb) { return GetRootAsService(_bb, new Service()); }
  public static Service GetRootAsService(ByteBuffer _bb, Service obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public Service __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Name { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(4); }
  public reflection.RPCCall? Calls(int j) { int o = __p.__offset(6); return o != 0 ? (reflection.RPCCall?)(new reflection.RPCCall()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int CallsLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
  public reflection.RPCCall? CallsByKey(string key) { int o = __p.__offset(6); return o != 0 ? reflection.RPCCall.__lookup_by_key(__p.__vector(o), key, __p.bb) : null; }
  public reflection.KeyValue? Attributes(int j) { int o = __p.__offset(8); return o != 0 ? (reflection.KeyValue?)(new reflection.KeyValue()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int AttributesLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
  public reflection.KeyValue? AttributesByKey(string key) { int o = __p.__offset(8); return o != 0 ? reflection.KeyValue.__lookup_by_key(__p.__vector(o), key, __p.bb) : null; }
  public string Documentation(int j) { int o = __p.__offset(10); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int DocumentationLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
  /// File that this Service is declared in.
  public string DeclarationFile { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDeclarationFileBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetDeclarationFileBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetDeclarationFileArray() { return __p.__vector_as_array<byte>(12); }

  public static Offset<reflection.Service> CreateService(FlatBufferBuilder builder,
      StringOffset nameOffset = default(StringOffset),
      VectorOffset callsOffset = default(VectorOffset),
      VectorOffset attributesOffset = default(VectorOffset),
      VectorOffset documentationOffset = default(VectorOffset),
      StringOffset declaration_fileOffset = default(StringOffset)) {
    builder.StartTable(5);
    Service.AddDeclarationFile(builder, declaration_fileOffset);
    Service.AddDocumentation(builder, documentationOffset);
    Service.AddAttributes(builder, attributesOffset);
    Service.AddCalls(builder, callsOffset);
    Service.AddName(builder, nameOffset);
    return Service.EndService(builder);
  }

  public static void StartService(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(0, nameOffset.Value, 0); }
  public static void AddCalls(FlatBufferBuilder builder, VectorOffset callsOffset) { builder.AddOffset(1, callsOffset.Value, 0); }
  public static VectorOffset CreateCallsVector(FlatBufferBuilder builder, Offset<reflection.RPCCall>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateCallsVectorBlock(FlatBufferBuilder builder, Offset<reflection.RPCCall>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCallsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<reflection.RPCCall>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCallsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<reflection.RPCCall>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartCallsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttributes(FlatBufferBuilder builder, VectorOffset attributesOffset) { builder.AddOffset(2, attributesOffset.Value, 0); }
  public static VectorOffset CreateAttributesVector(FlatBufferBuilder builder, Offset<reflection.KeyValue>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateAttributesVectorBlock(FlatBufferBuilder builder, Offset<reflection.KeyValue>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateAttributesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<reflection.KeyValue>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateAttributesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<reflection.KeyValue>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartAttributesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDocumentation(FlatBufferBuilder builder, VectorOffset documentationOffset) { builder.AddOffset(3, documentationOffset.Value, 0); }
  public static VectorOffset CreateDocumentationVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDocumentationVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDocumentationVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDocumentationVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDocumentationVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDeclarationFile(FlatBufferBuilder builder, StringOffset declarationFileOffset) { builder.AddOffset(4, declarationFileOffset.Value, 0); }
  public static Offset<reflection.Service> EndService(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    builder.Required(o, 4);  // name
    return new Offset<reflection.Service>(o);
  }

  public static VectorOffset CreateSortedVectorOfService(FlatBufferBuilder builder, Offset<Service>[] offsets) {
    Array.Sort(offsets,
      (Offset<Service> o1, Offset<Service> o2) =>
        new Service().__assign(builder.DataBuffer.Length - o1.Value, builder.DataBuffer).Name.CompareTo(new Service().__assign(builder.DataBuffer.Length - o2.Value, builder.DataBuffer).Name));
    return builder.CreateVectorOfTables(offsets);
  }

  public static Service? __lookup_by_key(int vectorLocation, string key, ByteBuffer bb) {
    Service obj_ = new Service();
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
  public ServiceT UnPack() {
    var _o = new ServiceT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ServiceT _o) {
    _o.Name = this.Name;
    _o.Calls = new List<reflection.RPCCallT>();
    for (var _j = 0; _j < this.CallsLength; ++_j) {_o.Calls.Add(this.Calls(_j).HasValue ? this.Calls(_j).Value.UnPack() : null);}
    _o.Attributes = new List<reflection.KeyValueT>();
    for (var _j = 0; _j < this.AttributesLength; ++_j) {_o.Attributes.Add(this.Attributes(_j).HasValue ? this.Attributes(_j).Value.UnPack() : null);}
    _o.Documentation = new List<string>();
    for (var _j = 0; _j < this.DocumentationLength; ++_j) {_o.Documentation.Add(this.Documentation(_j));}
    _o.DeclarationFile = this.DeclarationFile;
  }
  public static Offset<reflection.Service> Pack(FlatBufferBuilder builder, ServiceT _o) {
    if (_o == null) return default(Offset<reflection.Service>);
    var _name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    var _calls = default(VectorOffset);
    if (_o.Calls != null) {
      var __calls = new Offset<reflection.RPCCall>[_o.Calls.Count];
      for (var _j = 0; _j < __calls.Length; ++_j) { __calls[_j] = reflection.RPCCall.Pack(builder, _o.Calls[_j]); }
      _calls = CreateCallsVector(builder, __calls);
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
    return CreateService(
      builder,
      _name,
      _calls,
      _attributes,
      _documentation,
      _declaration_file);
  }
}

public class ServiceT
{
  public string Name { get; set; }
  public List<reflection.RPCCallT> Calls { get; set; }
  public List<reflection.KeyValueT> Attributes { get; set; }
  public List<string> Documentation { get; set; }
  public string DeclarationFile { get; set; }

  public ServiceT() {
    this.Name = null;
    this.Calls = null;
    this.Attributes = null;
    this.Documentation = null;
    this.DeclarationFile = null;
  }
}


static public class ServiceVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyString(tablePos, 4 /*Name*/, true)
      && verifier.VerifyVectorOfTables(tablePos, 6 /*Calls*/, reflection.RPCCallVerify.Verify, false)
      && verifier.VerifyVectorOfTables(tablePos, 8 /*Attributes*/, reflection.KeyValueVerify.Verify, false)
      && verifier.VerifyVectorOfStrings(tablePos, 10 /*Documentation*/, false)
      && verifier.VerifyString(tablePos, 12 /*DeclarationFile*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}