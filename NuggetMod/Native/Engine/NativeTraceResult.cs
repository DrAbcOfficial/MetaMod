using Metamod.Native.Common;
using System.Runtime.InteropServices;

namespace Metamod.Native.Engine;

[StructLayout(LayoutKind.Sequential)]
public struct NativeTraceResult : INativeStruct
{
    internal int fAllSolid;          // if true, plane is not valid
    internal int fStartSolid;        // if true, the initial point was in a solid area
    internal int fInOpen;
    internal int fInWater;
    internal float flFraction;           // time completed, 1.0 = didn't hit anything
    internal NativeVector3f vecEndPos;           // final position
    internal float flPlaneDist;
    internal NativeVector3f vecPlaneNormal;      // surface normal at impact
    internal nint pHit;              // entity the surface is on
    internal int iHitgroup;			// 0 == generic, non zero is specific body part
}
