using System.Runtime.InteropServices;

namespace NuggetMod.Native.Engine;

[StructLayout(LayoutKind.Sequential)]
public struct NativeCVar : INativeStruct
{
    internal nint name;
    internal nint str;
    internal int flags;
    internal float value;
    internal nint next;
}
