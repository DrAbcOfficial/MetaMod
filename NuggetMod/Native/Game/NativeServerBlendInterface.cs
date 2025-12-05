using System.Runtime.InteropServices;

namespace Metamod.Native.Game;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void NativeSV_StudioSetupBonesDelegate(
       nint pModel,
       float frame,
       int sequence,
       nint angles,
       nint origin,
       nint pcontroller,
       nint pblending,
       int iBone,
       nint pEdict
   );

[StructLayout(LayoutKind.Sequential)]
public struct NativeServerBlendInterface : INativeStruct
{
    internal int version;
    internal NativeSV_StudioSetupBonesDelegate? pfnSV_StudioSetupBones;
}
