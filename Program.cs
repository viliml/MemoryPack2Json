using System.Text.Json;
using System.Text.Json.Nodes;
using Google.FlatBuffers;
using MemoryPack;
using MemoryPack2Json;
using reflection;

string schemaPath = args[0];
string pathIn = Path.GetFullPath(args[1]);
string pathOut = Path.ChangeExtension(pathIn, "json");

SchemaT schema = Schema.GetRootAsSchema(new ByteBuffer(File.ReadAllBytes(schemaPath))).UnPack();
var converter = new Converter(schema);

JsonObject jsonObject;
using (var optionalState = MemoryPackReaderOptionalStatePool.Rent(null))
{
    var reader = new MemoryPackReader(File.ReadAllBytes(pathIn), optionalState);
    jsonObject = converter.TranslateObject(ref reader, schema.RootTable)!;
}

{
    var writerOptions = new JsonWriterOptions { Indented = true };
    using var stream = File.OpenWrite(pathOut);
    using var utf8JsonWriter = new Utf8JsonWriter(stream, writerOptions);

    jsonObject.WriteTo(utf8JsonWriter);
}