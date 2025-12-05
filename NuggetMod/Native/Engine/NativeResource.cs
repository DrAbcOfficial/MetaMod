using Metamod.Enum.Engine;
using System.Runtime.InteropServices;

namespace Metamod.Native.Engine;

[StructLayout(LayoutKind.Sequential)]
public struct NativeResource : INativeStruct
{
    internal unsafe fixed byte szFileName[64]; // File name to download/precache.
    internal ResourceType type;                // t_sound, t_skin, t_model, t_decal.
    internal int nIndex;              // For t_decals
    internal int nDownloadSize;       // Size in Bytes if this must be downloaded.
    internal byte ucFlags;

    // For handling client to client resource propagation
    internal unsafe fixed byte rgucMD5_hash[16];    // To determine if we already have it.
    internal byte playernum;           // Which player index this resource is associated with, if it's a custom resource.

    internal unsafe fixed byte rguc_reserved[32]; // For future expansion
    internal nint pNext;              // Next in chain.
    internal nint pPrev;
}
