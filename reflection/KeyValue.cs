// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace reflection
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct KeyValue : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static KeyValue GetRootAsKeyValue(ByteBuffer _bb) { return GetRootAsKeyValue(_bb, new KeyValue()); }
  public static KeyValue GetRootAsKeyValue(ByteBuffer _bb, KeyValue obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public KeyValue __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Key { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetKeyBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetKeyBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetKeyArray() { return __p.__vector_as_array<byte>(4); }
  public string Value { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetValueBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetValueBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetValueArray() { return __p.__vector_as_array<byte>(6); }

  public static Offset<reflection.KeyValue> CreateKeyValue(FlatBufferBuilder builder,
      StringOffset keyOffset = default(StringOffset),
      StringOffset valueOffset = default(StringOffset)) {
    builder.StartTable(2);
    KeyValue.AddValue(builder, valueOffset);
    KeyValue.AddKey(builder, keyOffset);
    return KeyValue.EndKeyValue(builder);
  }

  public static void StartKeyValue(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset) { builder.AddOffset(0, keyOffset.Value, 0); }
  public static void AddValue(FlatBufferBuilder builder, StringOffset valueOffset) { builder.AddOffset(1, valueOffset.Value, 0); }
  public static Offset<reflection.KeyValue> EndKeyValue(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    builder.Required(o, 4);  // key
    return new Offset<reflection.KeyValue>(o);
  }

  public static VectorOffset CreateSortedVectorOfKeyValue(FlatBufferBuilder builder, Offset<KeyValue>[] offsets) {
    Array.Sort(offsets,
      (Offset<KeyValue> o1, Offset<KeyValue> o2) =>
        new KeyValue().__assign(builder.DataBuffer.Length - o1.Value, builder.DataBuffer).Key.CompareTo(new KeyValue().__assign(builder.DataBuffer.Length - o2.Value, builder.DataBuffer).Key));
    return builder.CreateVectorOfTables(offsets);
  }

  public static KeyValue? __lookup_by_key(int vectorLocation, string key, ByteBuffer bb) {
    KeyValue obj_ = new KeyValue();
    int span = bb.GetInt(vectorLocation - 4);
    int start = 0;
    while (span != 0) {
      int middle = span / 2;
      int tableOffset = Table.__indirect(vectorLocation + 4 * (start + middle), bb);
      obj_.__assign(tableOffset, bb);
      int comp = obj_.Key.CompareTo(key);
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
  public KeyValueT UnPack() {
    var _o = new KeyValueT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(KeyValueT _o) {
    _o.Key = this.Key;
    _o.Value = this.Value;
  }
  public static Offset<reflection.KeyValue> Pack(FlatBufferBuilder builder, KeyValueT _o) {
    if (_o == null) return default(Offset<reflection.KeyValue>);
    var _key = _o.Key == null ? default(StringOffset) : builder.CreateString(_o.Key);
    var _value = _o.Value == null ? default(StringOffset) : builder.CreateString(_o.Value);
    return CreateKeyValue(
      builder,
      _key,
      _value);
  }
}

public class KeyValueT
{
  public string Key { get; set; }
  public string Value { get; set; }

  public KeyValueT() {
    this.Key = null;
    this.Value = null;
  }
}


static public class KeyValueVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyString(tablePos, 4 /*Key*/, true)
      && verifier.VerifyString(tablePos, 6 /*Value*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
