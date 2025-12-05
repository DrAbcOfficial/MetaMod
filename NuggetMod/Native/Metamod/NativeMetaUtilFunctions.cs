using Metamod.Enum.Metamod;
using Metamod.Native;
using Metamod.Native.Engine;
using Metamod.Native.Game;
using Metamod.Native.Metamod;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
public struct NativeMetaUtilFunctions : INativeStruct
{
    internal LogDelegate pfnLogConsole;
    internal LogDelegate pfnLogMessage;
    internal LogDelegate pfnLogError;
    internal LogDeveloperDelegate pfnLogDeveloper;
    internal LogDelegate pfnCenterSay;
    internal CenterSayParmsDelegate pfnCenterSayParms;
    internal CenterSayVarargsDelegate pfnCenterSayVarargs;
    internal CallGameEntityDelegate pfnCallGameEntity;
    internal GetUserMsgIDDelegate pfnGetUserMsgID;
    internal GetUserMsgNameDelegate pfnGetUserMsgName;
    internal GetPluginPathDelegate pfnGetPluginPath;
    internal GetGameInfoDelegate pfnGetGameInfo;
    internal LoadPluginDelegate pfnLoadPlugin;
    internal UnloadPluginDelegate pfnUnloadPlugin;
    internal UnloadPluginByHandleDelegate pfnUnloadPluginByHandle;
    internal IsQueryingClientCvarDelegate pfnIsQueryingClientCvar;
    internal MakeRequestIDDelegate pfnMakeRequestID;
    internal GetHookTablesDelegate pfnGetHookTables;
    internal GetModuleBaseByHandleDelegate pfnGetModuleBaseByHandle;
    internal GetModuleHandleDelegate pfnGetModuleHandle;
    internal GetModuleBaseByNameDelegate pfnGetModuleBaseByName;
    internal GetImageSizeDelegate pfnGetImageSize;
    internal IsAddressInModuleRangeDelegate pfnIsAddressInModuleRange;
    internal GetGameDllHandleDelegate pfnGetGameDllHandle;
    internal GetGameDllBaseDelegate pfnGetGameDllBase;
    internal GetEngineHandleDelegate pfnGetEngineHandle;
    internal GetEngineBaseDelegate pfnGetEngineBase;
    internal GetEngineEndDelegate pfnGetEngineEnd;
    internal GetEngineCodeBaseDelegate pfnGetEngineCodeBase;
    internal GetEngineCodeEndDelegate pfnGetEngineCodeEnd;
    internal IsValidCodePointerInEngineDelegate pfnIsValidCodePointerInEngine;
    internal UnHookDelegate pfnUnHook;
    internal InlineHookDelegate pfnInlineHook;
    internal GetNextCallAddrDelegate pfnGetNextCallAddr;
    internal SearchPatternDelegate pfnSearchPattern;
    internal ReverseSearchPatternDelegate pfnReverseSearchPattern;
    internal DisasmSingleInstructionDelegate pfnDisasmSingleInstruction;
    internal DisasmRangesDelegate pfnDisasmRanges;
    internal ReverseSearchFunctionBeginDelegate pfnReverseSearchFunctionBegin;
    internal ReverseSearchFunctionBeginExDelegate pfnReverseSearchFunctionBeginEx;
    internal CloseModuleHandleDelegate pfnCloseModuleHandle;
    internal LoadLibraryDelegate pfnLoadLibrary;
    internal FreeLibraryDelegate pfnFreeLibrary;
    internal GetProcAddressDelegate pfnGetProcAddress;
    internal GetServerStudioBlendInterfaceDelegate pfnGetServerStudioBlendInterface;
    internal GetEngineStudioBlendInterfaceDelegate pfnGetEngineStudioBlendInterface;
    internal GetEngineStudioAPIDelegate pfnGetEngineStudioAPI;
    internal GetRotationMatrixDelegate pfnGetRotationMatrix;
    internal GetBoneMatrixDelegate pfnGetBoneMatrix;
    internal GetEngineTypeDelegate pfnGetEngineType;

#pragma warning disable CS8500 // 这会获取托管类型的地址、获取其大小或声明指向它的指针
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void LogDelegate(NativePluginInfo* plid, byte* fmt);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void LogDeveloperDelegate(NativePluginInfo* plid, byte* fmt);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void CenterSayParmsDelegate(NativePluginInfo* plid, NativeHudParams tparms, byte* fmt);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void CenterSayVarargsDelegate(NativePluginInfo* plid, NativeHudParams tparms, byte* fmt, nint va_list);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate int CallGameEntityDelegate(NativePluginInfo* plid, byte* entStr, NativeEntvars* pev);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate int GetUserMsgIDDelegate(NativePluginInfo* plid, byte* msgname, int* size);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate nint GetUserMsgNameDelegate(NativePluginInfo* plid, int msgid, int* size);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate nint GetPluginPathDelegate(NativePluginInfo* plid);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate nint GetGameInfoDelegate(NativePluginInfo* plid, GetGameInfoType tag);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate int LoadPluginDelegate(NativePluginInfo* plid, byte* cmdline, PluginLoadTime now, out nint plugin_handle);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate int UnloadPluginDelegate(NativePluginInfo* plid, byte* cmdline, PluginLoadTime now, PluginUnloadReason reason);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate int UnloadPluginByHandleDelegate(NativePluginInfo* plid, nint plugin_handle, PluginLoadTime now, PluginUnloadReason reason);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate nint IsQueryingClientCvarDelegate(NativePluginInfo* plid, NativeEdict* player);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate int MakeRequestIDDelegate(NativePluginInfo* plid);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void GetHookTablesDelegate(NativePluginInfo* plid, out NativeEngineFuncs* peng, out NativeDllFuncs* pdll, out NativeNewDllFuncs* pnewdll);

    // 2022-07 Added by hzqst
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint GetModuleBaseByHandleDelegate(nint hModule);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate nint GetModuleHandleDelegate(byte* szModuleName);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate nint GetModuleBaseByNameDelegate(byte* szModuleName);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate uint GetImageSizeDelegate(nint imageBase);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int IsAddressInModuleRangeDelegate(nint lpAddress, nint lpModuleBase);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint GetGameDllHandleDelegate();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint GetGameDllBaseDelegate();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint GetEngineHandleDelegate();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint GetEngineBaseDelegate();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint GetEngineEndDelegate();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint GetEngineCodeBaseDelegate();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint GetEngineCodeEndDelegate();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int IsValidCodePointerInEngineDelegate(nint ptr);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int UnHookDelegate(NativeHook pHook);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate NativeHook* InlineHookDelegate(nint pOldFuncAddr, nint pNewFuncAddr, out nint pOrginalCall, bool bTranscation);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint GetNextCallAddrDelegate(nint pAddress, int dwCount);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate nint SearchPatternDelegate(nint pStartSearch, uint dwSearchLen, byte* pPattern, uint dwPatternLen);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate nint ReverseSearchPatternDelegate(nint pStartSearch, uint dwSearchLen, byte* pPattern, uint dwPatternLen);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int DisasmSingleInstructionDelegate(nint address, nint fnDisasmSingleCallback, nint context);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int DisasmRangesDelegate(nint disasmBase, uint disasmSize, nint fnDisasmCallback, int depth, nint context);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint ReverseSearchFunctionBeginDelegate(nint searchBegin, uint searchSize);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint ReverseSearchFunctionBeginExDelegate(nint searchBegin, uint searchSize, nint fnFindAddressCallback);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void CloseModuleHandleDelegate(nint hModule);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate nint LoadLibraryDelegate(byte* szModuleName);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void FreeLibraryDelegate(nint hModule);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate nint GetProcAddressDelegate(nint hModule, byte* szProcName);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate NativeServerBlendInterface* GetServerStudioBlendInterfaceDelegate();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate NativeServerBlendInterface* GetEngineStudioBlendInterfaceDelegate();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate NativeServerStudioAPI* GetEngineStudioAPIDelegate();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint GetRotationMatrixDelegate();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nint GetBoneMatrixDelegate();

    // 2024-10 Added by hzqst
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate byte* GetEngineTypeDelegate();
#pragma warning restore CS8500 // 这会获取托管类型的地址、获取其大小或声明指向它的指针
}

#region Delegate For Delegate
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void DisasmSingleCallbackDelegate(nint inst, nint address, uint instLen, nint context);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int DisasmCallbackDelegate(nint inst, nint address, uint instLen, int instCount, int depth, nint context);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int FindAddressCallbackDelegate(nint address);
#endregion