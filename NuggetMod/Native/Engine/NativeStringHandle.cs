using System.Runtime.InteropServices;

namespace NuggetMod.Native.Engine;

[StructLayout(LayoutKind.Sequential)]
public struct NativeStringHandle : INativeStruct
{
    internal int value;
}
