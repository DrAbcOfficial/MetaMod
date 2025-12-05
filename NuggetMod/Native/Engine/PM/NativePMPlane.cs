using NuggetMod.Native.Common;
using System.Runtime.InteropServices;

namespace NuggetMod.Native.Engine.PM;
[StructLayout(LayoutKind.Sequential)]
public struct NativePMPlane : INativeStruct
{
    internal NativeVector3f normal;
    internal float dist;
}
