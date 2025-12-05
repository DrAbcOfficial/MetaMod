using Metamod.Enum.Metamod;
using Metamod.Native.Metamod;
using Metamod.Wrapper.Engine;
using Metamod.Wrapper.Metamod;
using System.Runtime.InteropServices;

namespace Metamod.Interface;

public abstract class PluginEntry
{
    protected static IPlugin? Interface;
    public static IPlugin GetPluginInterface()
    {
        if (Interface == null)
            throw new NullReferenceException(nameof(Interface));
        return Interface;
    }
    public static MetaPluginInfo GetPluginInfo()
    {
        if (Interface == null)
            throw new NullReferenceException(nameof(Interface));
        return Interface.GetPluginInfo();
    }

    protected static void Native_GiveFnptrsToDll(nint pengfuncsFromEngine, nint pGlobals)
    {
        EngineFuncs engineFuncs = new(pengfuncsFromEngine);
        GlobalVars globalVars = new(pGlobals);
        MetaMod._engineFuncs = engineFuncs;
        MetaMod._globalVars = globalVars;
        MetaMod._utility = new();
    }

    protected static void Native_Meta_Init()
    {

    }

    protected static int Native_Meta_Query(nint interfaceVersion, nint plinfo, nint pMetaUtilFuncs)
    {
        string? version = Marshal.PtrToStringAnsi(interfaceVersion) ?? throw new Exception("Interface version is null");
        var ifver = version switch
        {
            "1" => InterfaceVersion.V1,
            "2" => InterfaceVersion.V2,
            "3" => InterfaceVersion.V3,
            "4" => InterfaceVersion.V4,
            "5" => InterfaceVersion.V5,
            "5:1" => InterfaceVersion.V5_1,
            "5:2" => InterfaceVersion.V5_2,
            "5:3" => InterfaceVersion.V5_3,
            "5:4" => InterfaceVersion.V5_4,
            "5:5" => InterfaceVersion.V5_5,
            "5:6" => InterfaceVersion.V5_6,
            "5:7" => InterfaceVersion.V5_7,
            "5:8" => InterfaceVersion.V5_8,
            "5:9" => InterfaceVersion.V5_9,
            "5:10" => InterfaceVersion.V5_10,
            "5:11" => InterfaceVersion.V5_11,
            "5:12" => InterfaceVersion.V5_12,
            "5:13" => InterfaceVersion.V5_13,
            "5:14" => InterfaceVersion.V5_14,
            "5:15" => InterfaceVersion.V5_15,
            "5:16" => InterfaceVersion.V5_16,
            _ => throw new Exception("Unknown interface version"),
        };

        var pinterface = GetPluginInterface();
        var pinfo = GetPluginInfo();
        MetaMod._pluginInfo = pinfo;
        MetaMod._metaUtilFuncs = new MetaUtilFunctions(pMetaUtilFuncs);
        bool result = pinterface.Meta_Query(ifver, MetaMod.MetaUtilFuncs);
        unsafe
        {
            nint ptr = Marshal.AllocHGlobal(sizeof(NativePluginInfo));
            *(NativePluginInfo**)plinfo = (NativePluginInfo*)ptr;
            (*(NativePluginInfo**)plinfo)->ifvers = Marshal.StringToHGlobalAnsi(pinfo.GetInterfaceVersionString());
            (*(NativePluginInfo**)plinfo)->name = Marshal.StringToHGlobalAnsi(pinfo.Name);
            (*(NativePluginInfo**)plinfo)->version = Marshal.StringToHGlobalAnsi(pinfo.Version);
            (*(NativePluginInfo**)plinfo)->date = Marshal.StringToHGlobalAnsi(pinfo.Date);
            (*(NativePluginInfo**)plinfo)->author = Marshal.StringToHGlobalAnsi(pinfo.Author);
            (*(NativePluginInfo**)plinfo)->url = Marshal.StringToHGlobalAnsi(pinfo.Url);
            (*(NativePluginInfo**)plinfo)->logtag = Marshal.StringToHGlobalAnsi(pinfo.LogTag);
            (*(NativePluginInfo**)plinfo)->loadable = (int)pinfo.Loadable;
            (*(NativePluginInfo**)plinfo)->unloadable = (int)pinfo.Unloadable;
            pinfo.NavitePtr = ptr;
        }
        return result ? 1 : 0;
    }

    protected static unsafe int Native_Meta_Attach(PluginLoadTime now, nint pFunctionTable, nint pMGlobals, nint pGamedllFuncs)
    {
        MetaGlobals metaGlobals = new(pMGlobals);
        MetaGameDLLFunctions gameDllFuncs = new(pGamedllFuncs);
        MetaMod._metaGlobals = metaGlobals;
        MetaMod._gameDllFuncs = gameDllFuncs;
        var pinterface = GetPluginInterface();
        bool result = pinterface.Meta_Attach(now, metaGlobals, gameDllFuncs);


        // 本地方法：将托管 delegate 转换为函数指针并写入到宿主内存（按字段偏移）
        static void WriteDelegateField<TDelegate>(nint basePtr, string fieldName, TDelegate? del) where TDelegate : Delegate
        {
            nint offset = Marshal.OffsetOf<NativeMetaFuncs>(fieldName);
            nint dest = (nint)(basePtr + offset.ToInt64());
            nint fp = del == null ? nint.Zero : Marshal.GetFunctionPointerForDelegate(del);
            Marshal.WriteIntPtr(dest, fp);
        }
        NativeMetaFuncs funcs = MetaMod.GetNative();
        // 替换调用方式，显式指定委托类型
        WriteDelegateField(pFunctionTable, "pfnGetEntityAPI", funcs.pfnGetEntityAPI);
        WriteDelegateField(pFunctionTable, "pfnGetEntityAPI_Post", funcs.pfnGetEntityAPI_Post);
        WriteDelegateField(pFunctionTable, "pfnGetEntityAPI2", funcs.pfnGetEntityAPI2);
        WriteDelegateField(pFunctionTable, "pfnGetEntityAPI2_Post", funcs.pfnGetEntityAPI2_Post);
        WriteDelegateField(pFunctionTable, "pfnGetNewDLLFunctions", funcs.pfnGetNewDLLFunctions);
        WriteDelegateField(pFunctionTable, "pfnGetNewDLLFunctions_Post", funcs.pfnGetNewDLLFunctions_Post);
        WriteDelegateField(pFunctionTable, "pfnGetEngineFunctions", funcs.pfnGetEngineFunctions);
        WriteDelegateField(pFunctionTable, "pfnGetEngineFunctions_Post", funcs.pfnGetEngineFunctions_Post);
        WriteDelegateField(pFunctionTable, "pfnGetStudioBlendingInterface", funcs.pfnGetStudioBlendingInterface);
        WriteDelegateField(pFunctionTable, "pfnGetStudioBlendingInterface_Post", funcs.pfnGetStudioBlendingInterface_Post);
        return result ? 1 : 0;
    }

    protected static int Native_Meta_Detach(PluginLoadTime now, PluginUnloadReason reason)
    {
        var pinterface = GetPluginInterface();
        bool result = pinterface.Meta_Detach(now, reason);
        return result ? 1 : 0;
    }
}