using System.Runtime.InteropServices;

namespace NuggetMod.Native.Engine;

[StructLayout(LayoutKind.Sequential)]
public struct NativeLink : INativeStruct
{
    internal nint prev; // Pointer to the previous node in the linked list
    internal nint next; // Pointer to the next node in the linked list
}
