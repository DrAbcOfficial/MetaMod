using Metamod.Native.Common;
using System.Runtime.InteropServices;

namespace Metamod.Native.Engine.PM;
[StructLayout(LayoutKind.Sequential)]
public struct NativePMPlane : INativeStruct
{
    internal NativeVector3f normal;
    internal float dist;
}
