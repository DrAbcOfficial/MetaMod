using System.Runtime.InteropServices;

namespace Metamod.Native.Engine;

[StructLayout(LayoutKind.Sequential)]
public struct NativeKeyValueData : INativeStruct
{
    internal nint szClassName;  // in: entity classname
    internal nint szKeyName;        // in: name of key
    internal nint szValue;      // in: value of key
    internal int fHandled;		// out: DLL sets to true if key-value pair was understood
}
