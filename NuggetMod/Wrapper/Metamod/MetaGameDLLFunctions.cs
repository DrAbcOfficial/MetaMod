using Metamod.Native.Metamod;
using Metamod.Wrapper.Game;

namespace Metamod.Wrapper.Metamod;

public class MetaGameDLLFunctions : BaseFunctionWrapper<NativeMetaGameDLLFunctions>
{
    public DLLFunctions? DllFuncs;
    public NewDLLFunctions? NewDllFuncs;
    public ServerBlendInterface? ServerBlendInterface;
    internal MetaGameDLLFunctions(nint ptr) : base(ptr)
    {
        DllFuncs = new(Base.dllapi_table);
        NewDllFuncs = new(Base.newapi_table);
        ServerBlendInterface = new(Base.studio_blend_api);
    }
}
