using System.Runtime.InteropServices;

namespace Metamod.Native.Common
{
    [StructLayout(LayoutKind.Sequential)]
    public struct NativeColor24 : INativeStruct
    {
        internal byte r;
        internal byte g;
        internal byte b;
    }
}
