using Metamod.Enum.Common;
using System.Runtime.InteropServices;

namespace Metamod.Native.Common;

[StructLayout(LayoutKind.Sequential)]
public struct NativeNetAdr : INativeStruct
{
    internal int type;
    internal unsafe fixed byte ip[4];
    internal unsafe fixed byte ipx[10];
    internal ushort port;
}
