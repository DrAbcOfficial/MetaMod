using Metamod.Native.Game;
using System.Runtime.InteropServices;

namespace Metamod.Native.Metamod;

[StructLayout(LayoutKind.Sequential)]
public struct NativeMetaGameDLLFunctions : INativeStruct
{
    internal nint dllapi_table;
    internal nint newapi_table;

    // 2022-07-02 Added by hzqst
    internal nint studio_blend_api;
}