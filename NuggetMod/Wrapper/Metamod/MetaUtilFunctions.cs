using NuggetMod.Enum.NuggetMod;
using NuggetMod.Interface;
using NuggetMod.Native.Engine;
using NuggetMod.Native.Game;
using NuggetMod.Native.NuggetMod;
using NuggetMod.Wrapper.Engine;
using NuggetMod.Wrapper.Game;
using System.Runtime.InteropServices;

namespace NuggetMod.Wrapper.NuggetMod;

/// <summary>
/// Wrapper for MetaMod utility functions
/// </summary>
public class MetaUtilFunctions(nint ptr) : BaseFunctionWrapper<NativeMetaUtilFunctions>(ptr)
{
    /// <summary>
    /// Logs a message to the console
    /// </summary>
    /// <param name="fmt">Format string</param>
    /// <param name="parm">Format parameters</param>
    public void LogConsole(string fmt, params string[] parm)
    {
        string str = string.Format(fmt, parm);
        nint strptr = Marshal.StringToHGlobalAnsi(str);
        unsafe
        {
            Base.pfnLogConsole((NativePluginInfo*)MetaMod.PluginInfo.NavitePtr, (byte*)strptr);
        }
        Marshal.FreeHGlobal(strptr);
    }

    /// <summary>
    /// Logs a general message
    /// </summary>
    /// <param name="fmt">Format string</param>
    /// <param name="parm">Format parameters</param>
    public void LogMessage(string fmt, params string[] parm)
    {
        string str = string.Format(fmt, parm);
        nint strptr = Marshal.StringToHGlobalAnsi(str);
        unsafe
        {
            Base.pfnLogMessage((NativePluginInfo*)MetaMod.PluginInfo.NavitePtr, (byte*)strptr);
        }
        Marshal.FreeHGlobal(strptr);
    }

    /// <summary>
    /// Logs an error message
    /// </summary>
    /// <param name="fmt">Format string</param>
    /// <param name="parm">Format parameters</param>
    public void LogError(string fmt, params string[] parm)
    {
        string str = string.Format(fmt, parm);
        nint strptr = Marshal.StringToHGlobalAnsi(str);
        unsafe
        {
            Base.pfnLogError((NativePluginInfo*)MetaMod.PluginInfo.NavitePtr, (byte*)strptr);
        }
        Marshal.FreeHGlobal(strptr);
    }

    public void LogDeveloper(string fmt, params string[] parm)
    {
        string str = string.Format(fmt, parm);
        nint strptr = Marshal.StringToHGlobalAnsi(str);
        unsafe
        {
            Base.pfnLogDeveloper((NativePluginInfo*)MetaMod.PluginInfo.NavitePtr, (byte*)strptr);
        }
        Marshal.FreeHGlobal(strptr);
    }

    public void CenterSay(string fmt, params string[] parm)
    {
        string str = string.Format(fmt, parm);
        nint strptr = Marshal.StringToHGlobalAnsi(str);
        unsafe
        {
            Base.pfnCenterSay((NativePluginInfo*)MetaMod.PluginInfo.NavitePtr, (byte*)strptr);
        }
        Marshal.FreeHGlobal(strptr);
    }

    public void CenterSayPams(HudParams hudParams, string fmt, params string[] parm)
    {
        string str = string.Format(fmt, parm);
        nint strptr = Marshal.StringToHGlobalAnsi(str);
        unsafe
        {
            Base.pfnCenterSayParms((NativePluginInfo*)MetaMod.PluginInfo.NavitePtr, *((NativeHudParams*)hudParams.GetPointer()), (byte*)strptr);
        }
        Marshal.FreeHGlobal(strptr);
    }

    public void CallGameEntity(string entStr, Entvars pev)
    {
        nint strptr = Marshal.StringToHGlobalAnsi(entStr);
        unsafe
        {
            Base.pfnCallGameEntity((NativePluginInfo*)MetaMod.PluginInfo.NavitePtr, (byte*)strptr, (NativeEntvars*)pev.GetPointer());
        }
        Marshal.FreeHGlobal(strptr);
    }

    public int GetUserMessageId(string msgname, out int size)
    {
        nint temp = Marshal.AllocHGlobal(sizeof(int));
        nint strptr = Marshal.StringToHGlobalAnsi(msgname);
        int result = 0;
        unsafe
        {
            result = Base.pfnGetUserMsgID((NativePluginInfo*)MetaMod.PluginInfo.NavitePtr, (byte*)strptr, (int*)temp);
        }
        size = Marshal.ReadInt32(temp);
        Marshal.FreeHGlobal(strptr);
        Marshal.FreeHGlobal(temp);
        return result;
    }

    public string GetUserMessageName(int msgid, out int size)
    {
        nint temp = Marshal.AllocHGlobal(sizeof(int));
        nint result = nint.Zero;
        unsafe
        {
            result = Base.pfnGetUserMsgName((NativePluginInfo*)MetaMod.PluginInfo.NavitePtr, msgid, (int*)temp);
        }
        string? str = Marshal.PtrToStringUTF8(result);
        size = Marshal.ReadInt32(temp);
        Marshal.FreeHGlobal(temp);
        return str ?? string.Empty;
    }

    public string GetPluginPath()
    {
        nint result = nint.Zero;
        unsafe
        {
            result = Base.pfnGetPluginPath((NativePluginInfo*)MetaMod.PluginInfo.NavitePtr);
        }
        string? str = Marshal.PtrToStringUTF8(result);
        return str ?? string.Empty;
    }

    public string GetGameInfo(GetGameInfoType type)
    {
        nint result = nint.Zero;
        unsafe
        {
            result = Base.pfnGetGameInfo((NativePluginInfo*)MetaMod.PluginInfo.NavitePtr, type);
        }
        string? str = Marshal.PtrToStringUTF8(result);
        return str ?? string.Empty;
    }

    public bool LoadPlugin(string cmdline, PluginLoadTime now, out nint pluginHandle)
    {
        nint strptr = Marshal.StringToHGlobalAnsi(cmdline);
        int res = 0;
        unsafe
        {
            res = Base.pfnLoadPlugin((NativePluginInfo*)MetaMod.PluginInfo.NavitePtr, (byte*)strptr, now, out pluginHandle);
        }
        Marshal.FreeHGlobal(strptr);
        return res != 0;
    }

    public bool UnloadPlugin(string cmdline, PluginLoadTime now, PluginUnloadReason reason)
    {
        nint strptr = Marshal.StringToHGlobalAnsi(cmdline);
        int res = 0;
        unsafe
        {
            res = Base.pfnUnloadPlugin((NativePluginInfo*)MetaMod.PluginInfo.NavitePtr, (byte*)strptr, now, reason);
        }
        Marshal.FreeHGlobal(strptr);
        return res != 0;
    }

    public bool UnloadPluginByHandle(nint handle, PluginLoadTime now, PluginUnloadReason reason)
    {
        int res = 0;
        unsafe
        {
            res = Base.pfnUnloadPluginByHandle((NativePluginInfo*)MetaMod.PluginInfo.NavitePtr, handle, now, reason);
        }
        return res != 0;
    }

    public string IsQueryingClientCVar(Edict player)
    {
        nint result = nint.Zero;
        unsafe
        {
#pragma warning disable CS8500 // 这会获取托管类型的地址、获取其大小或声明指向它的指针
            result = Base.pfnIsQueryingClientCvar((NativePluginInfo*)MetaMod.PluginInfo.NavitePtr, (NativeEdict*)player.GetPointer());
#pragma warning restore CS8500 // 这会获取托管类型的地址、获取其大小或声明指向它的指针
        }
        return Marshal.PtrToStringUTF8(result) ?? string.Empty;
    }

    public int MakeRequestID()
    {
        int res = 0;
        unsafe
        {
            res = Base.pfnMakeRequestID((NativePluginInfo*)MetaMod.PluginInfo.NavitePtr);
        }
        return res;
    }

    //TODO: Finish it
    public void GetHookTables(/*out*/ EngineFuncs peng, /*out*/ int pdll, /*out*/ int pnewdll)
    {

    }

    public nint GetModuleBaseByHandle(nint handle)
    {
        return Base.pfnGetModuleBaseByHandle(handle);
    }

    public nint GetModuleHandle(string modulename)
    {
        nint strptr = Marshal.StringToHGlobalAnsi(modulename);
        nint result = nint.Zero;
        unsafe
        {
            result = Base.pfnGetModuleHandle((byte*)strptr);
        }
        Marshal.FreeHGlobal(strptr);
        return result;
    }

    public nint GetModuleBaseByName(string name)
    {
        nint strptr = Marshal.StringToHGlobalAnsi(name);
        nint result = nint.Zero;
        unsafe
        {
            result = Base.pfnGetModuleBaseByName((byte*)strptr);
        }
        Marshal.FreeHGlobal(strptr);
        return result;
    }

    public uint GetImageSize(nint imageBase)
    {
        return Base.pfnGetImageSize(imageBase);
    }

    public bool IsAddressInModuleRange(nint lpAddress, nint lpModuleBase)
    {
        return Base.pfnIsAddressInModuleRange(lpAddress, lpModuleBase) == 1;
    }

    public nint GetGameDllHandle()
    {
        return Base.pfnGetGameDllHandle();
    }

    public nint GetGameDllBase()
    {
        return Base.pfnGetGameDllBase();
    }

    public nint GetEngineHandle()
    {
        return Base.pfnGetEngineHandle();
    }

    public nint GetEngineBase()
    {
        return Base.pfnGetEngineBase();
    }

    public nint GetEngineEnd()
    {
        return Base.pfnGetEngineEnd();
    }

    public nint GetEngineCodeBase()
    {
        return Base.pfnGetEngineCodeBase();
    }

    public nint GetEngineCodeEnd()
    {
        return Base.pfnGetEngineCodeEnd();
    }

    public bool IsValidCodePointerInEngine(nint ptr)
    {
        return Base.pfnIsValidCodePointerInEngine(ptr) == 1;
    }

    public bool UnHook(Hook pHook)
    {
        bool res = false;
        unsafe
        {
            res = Base.pfnUnHook(*(NativeHook*)pHook.GetPointer()) == 1;
        }
        return res;
    }

    public Hook InlineHook(nint pOldFuncAddr, nint pNewFuncAddr, out nint pOrigialCall, bool bTranscation)
    {
        nint ptr = nint.Zero;
        unsafe
        {
            ptr = (nint)Base.pfnInlineHook(pOldFuncAddr, pNewFuncAddr, out pOrigialCall, bTranscation);
            return new Hook((NativeHook*)ptr);
        }
    }

    public nint GetNextCallAddr(nint pAddress, int dwCout)
    {
        return Base.pfnGetNextCallAddr(pAddress, dwCout);
    }

    public nint SearchPattern(nint pStartSearch, uint dwSearchLen, byte[] szPattern, uint dwPatternLen)
    {
        nint result = nint.Zero;
        unsafe
        {
            fixed (byte* pPattern = szPattern)
            {
                result = Base.pfnSearchPattern(pStartSearch, dwSearchLen, pPattern, dwPatternLen);
            }
        }
        return result;
    }

    public nint ReverseSearchPattern(nint pStartSearch, uint dwSearchLen, byte[] szPattern, uint dwPatternLen)
    {
        nint result = nint.Zero;
        unsafe
        {
            fixed (byte* pPattern = szPattern)
            {
                result = Base.pfnReverseSearchPattern(pStartSearch, dwSearchLen, pPattern, dwPatternLen);
            }
        }
        return result;
    }

    public int DisasmSingleInstruction(nint address, DisasmSingleCallbackDelegate fnDisasmSingleCallback, nint context)
    {
        nint ptr = Marshal.GetFunctionPointerForDelegate(fnDisasmSingleCallback);
        return Base.pfnDisasmSingleInstruction(address, ptr, context); ;
    }

    public bool DisasmRange(nint disasmBase, uint disasmSize, DisasmCallbackDelegate fnDisasmCallback, int depth, nint context)
    {
        nint ptr = Marshal.GetFunctionPointerForDelegate(fnDisasmCallback);
        return Base.pfnDisasmRanges(disasmBase, disasmSize, ptr, depth, context) == 1;
    }

    public nint ReverseSearchFunctionBegin(nint searchBegin, uint searchSize)
    {
        return Base.pfnReverseSearchFunctionBegin(searchBegin, searchSize);
    }

    public nint ReverseSearchFuntionBeginEx(nint searchBegin, uint searchSize, FindAddressCallbackDelegate findAddressCallback)
    {
        nint ptr = Marshal.GetFunctionPointerForDelegate(findAddressCallback);
        return Base.pfnReverseSearchFunctionBeginEx(searchBegin, searchSize, ptr);
    }

    public void CloseModuleHandle(nint hModule)
    {
        Base.pfnCloseModuleHandle(hModule);
    }

    public nint LoadLibrary(string szModuleName)
    {
        nint strptr = Marshal.StringToHGlobalAnsi(szModuleName);
        nint result = nint.Zero;
        unsafe
        {
            result = Base.pfnLoadLibrary((byte*)strptr);
        }
        Marshal.FreeHGlobal(strptr);
        return result;
    }

    public void FreeLibrary(nint hModule)
    {
        Base.pfnFreeLibrary(hModule);
    }

    public nint GetProcAddress(nint hModule, string szProcName)
    {
        nint strptr = Marshal.StringToHGlobalAnsi(szProcName);
        nint result = nint.Zero;
        unsafe
        {
            result = Base.pfnGetProcAddress(hModule, (byte*)strptr);
        }
        Marshal.FreeHGlobal(strptr);
        return result;
    }

    public ServerBlendInterface GetServerStudioBlendInterface()
    {
        nint ptr = nint.Zero;
        unsafe
        {
            ptr = (nint)Base.pfnGetServerStudioBlendInterface();
        }
        return new ServerBlendInterface(ptr);
    }

    public ServerBlendInterface GetEngineStudioBlendInterface()
    {
        nint ptr = nint.Zero;
        unsafe
        {
            ptr = (nint)Base.pfnGetServerStudioBlendInterface();
        }
        return new ServerBlendInterface(ptr);
    }

    public ServerStudioAPI GetEngineStudioAPI()
    {
        nint ptr = nint.Zero;
        unsafe
        {
            ptr = (nint)Base.pfnGetEngineStudioAPI();
        }
        return new ServerStudioAPI(ptr);
    }

    public nint GetRotationMatrix() => Base.pfnGetRotationMatrix();
    public nint GetBoneMatrix() => Base.pfnGetBoneMatrix();

    public string GetEngineType()
    {
        string? str = string.Empty;
        unsafe
        {
            str = Marshal.PtrToStringUTF8((nint)Base.pfnGetEngineType());
        }
        return str ?? string.Empty;
    }
}
