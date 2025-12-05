using System.Runtime.InteropServices;
namespace Metamod.Native.Common;

[StructLayout(LayoutKind.Sequential)]
public struct NativeVector3f : INativeStruct
{
    public float x;
    public float y;
    public float z;
}
