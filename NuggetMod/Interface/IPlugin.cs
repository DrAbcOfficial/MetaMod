using Metamod.Enum.Metamod;
using Metamod.Wrapper.Metamod;

namespace Metamod.Interface;

public interface IPlugin
{
    public MetaPluginInfo GetPluginInfo();
    public void Meta_Init();
    public bool Meta_Query(InterfaceVersion interfaceVersion, MetaUtilFunctions pMetaUtilFuncs);
    public bool Meta_Attach(PluginLoadTime now, MetaGlobals pMGlobals, MetaGameDLLFunctions pGamedllFuncs);
    public bool Meta_Detach(PluginLoadTime now, PluginUnloadReason reason);
}
