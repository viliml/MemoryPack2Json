Since the MemoryPack serialized format is not self-describing and has no schema of its own, I decided to co-opt the FlatBuffers schema format to describe the data. The FlatBuffers schema file (.fbs) needs to be first compiled into its binary format (.bfbs) to be used by this tool.

## Usage
`MemoryPack2Json.exe <path to bfbs file> <path to data file>`

## Creating the bfbs file
`flatc -b --schema <path to fbs file>`
