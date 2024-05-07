using System.Text.Json.Nodes;
using MemoryPack;
using reflection;

namespace MemoryPack2Json;

public class Converter(SchemaT schema)
{
    public JsonNode? TranslateValue(ref MemoryPackReader reader, TypeT type)
    {
        switch (type.BaseType)
        {
            case BaseType.Bool:
                return reader.ReadUnmanaged<bool>();
            case BaseType.Byte:
                return reader.ReadUnmanaged<sbyte>();
            case BaseType.UByte:
                return reader.ReadUnmanaged<byte>();
            case BaseType.Short:
                return reader.ReadUnmanaged<short>();
            case BaseType.UShort:
                return reader.ReadUnmanaged<ushort>();
            case BaseType.Int:
                return reader.ReadUnmanaged<int>();
            case BaseType.UInt:
                return reader.ReadUnmanaged<uint>();
            case BaseType.Long:
                return reader.ReadUnmanaged<long>();
            case BaseType.ULong:
                return reader.ReadUnmanaged<ulong>();
            case BaseType.Float:
                return reader.ReadUnmanaged<float>();
            case BaseType.Double:
                return reader.ReadUnmanaged<double>();
            case BaseType.String:
                return reader.ReadString();
            case BaseType.Obj:
            {
                ObjectT @object = schema.Objects[type.Index];
                return TranslateObject(ref reader, @object);
            }
            case BaseType.Vector:
            {
                if (!reader.TryReadCollectionHeader(out int length))
                {
                    return null;
                }

                if (type.Element == BaseType.Obj
                    && schema.Objects[type.Index] is var elementObject
                    && elementObject.Name.StartsWith("KeyValue", StringComparison.Ordinal)
                    && elementObject.Fields is
                    [
                        { Name: "key", Key: true, Type: { BaseType: BaseType.String } keyType },
                        { Name: "value", Type: var valueType }
                    ])
                {
                    var obj = new JsonObject();

                    for (var i = 0; i < length; i++)
                    {
                        var key = TranslateValue(ref reader, keyType)!.GetValue<string>();
                        JsonNode? value = TranslateValue(ref reader, valueType);

                        obj.Add(key, value);
                    }

                    return obj;
                }

                var arr = new JsonArray();

                for (var i = 0; i < length; i++)
                {
                    TypeT typeT = new() { BaseType = type.Element, Index = type.Index, ElementSize = type.ElementSize };
                    arr.Add(TranslateValue(ref reader, typeT));
                }

                return arr;
            }
            default:
                throw new NotImplementedException(type.BaseType.ToString());
        }
    }

    public JsonObject? TranslateObject(ref MemoryPackReader reader, ObjectT @object)
    {
        var obj = new JsonObject();

        int count;
        if (@object.IsStruct)
        {
            count = @object.Fields.Count;
        }
        else
        {
            if (!reader.TryReadObjectHeader(out byte countFromHeader))
            {
                return null;
            }

            count = countFromHeader;
        }

        var indices = new int[@object.Fields.Count];
        for (var i = 0; i < count; i++)
        {
            indices[@object.Fields[i].Id] = i;
        }

        for (var i = 0; i < count; i++)
        {
            FieldT field = @object.Fields[indices[i]];
            TypeT fieldType = field.Type;
            obj.Add(field.Name, TranslateValue(ref reader, fieldType));
        }

        return obj;
    }
}