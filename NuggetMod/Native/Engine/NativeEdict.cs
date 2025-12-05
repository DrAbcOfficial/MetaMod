using System.Runtime.InteropServices;

namespace Metamod.Native.Engine;

[StructLayout(LayoutKind.Sequential)]
public struct NativeEdict : INativeStruct
{
    internal int free;
    internal int serialnumber;
    internal NativeLink area;                // linked to a division node or leaf

    internal int headnode;           // -1 to use normal leaf check
    internal int num_leafs;
    internal unsafe fixed short leafnums[48];

    internal float freetime;         // sv.time when the object was freed

    internal nint pvPrivateData;        // Alloced and freed by engine, used by DLLs

    internal NativeEntvars v;                    // C exported fields from progs

    // other fields from progs come immediately after
}
