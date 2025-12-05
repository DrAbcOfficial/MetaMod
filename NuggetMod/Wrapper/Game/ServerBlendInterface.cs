using Metamod.Native.Game;

namespace Metamod.Wrapper.Game;

public class ServerBlendInterface(nint ptr) : BaseFunctionWrapper<NativeServerBlendInterface>(ptr)
{
    public int Version
    {
        get => Base.version;
    }

    public void SV_SudioSetupBones(nint pModel, float frame, int sequence, nint angles, nint origin, nint pcontroller, nint pblending, int iBone, nint pEdict)
    {
        if (Base.pfnSV_StudioSetupBones == null)
            throw new NullReferenceException("SV_StudioSetupBones function pointer is null.");
        Base.pfnSV_StudioSetupBones(pModel, frame, sequence, angles, origin, pcontroller, pblending, iBone, pEdict);
    }
}
