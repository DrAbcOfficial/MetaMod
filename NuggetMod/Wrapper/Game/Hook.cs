using NuggetMod.Helper;
using NuggetMod.Native.Game;
using NuggetMod.Wrapper;
using System.Runtime.InteropServices;

namespace NuggetMod.Wrapper.Game;

/// <summary>
/// Represents a game hook structure
/// </summary>
public class Hook : BaseNativeWrapper<NativeHook>
{
    /// <summary>
    /// Initializes a new instance with default values
    /// </summary>
    public Hook() : base() { }

    internal unsafe Hook(NativeHook* nativePtr, bool ownsPointer = false)
        : base(nativePtr, ownsPointer) { }

    /// <summary>
    /// Gets or sets the hook type
    /// </summary>
    public int Type
    {
        get
        {
            unsafe
            {
                return NativePtr->iType;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->iType = value;
            }
        }
    }

    public int Committed
    {
        get
        {
            unsafe
            {
                return NativePtr->bCommitted;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->bCommitted = value;
            }
        }
    }

    public nint OldFuncAddr
    {
        get
        {
            unsafe
            {
                return NativePtr->pOldFuncAddr;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->pOldFuncAddr = value;
            }
        }
    }

    public nint NewFuncAddr
    {
        get
        {
            unsafe
            {
                return NativePtr->pNewFuncAddr;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->pNewFuncAddr = value;
            }
        }
    }

    public nint OriginalCall
    {
        get
        {
            unsafe
            {
                return NativePtr->pOrginalCall;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->pOrginalCall = value;
            }
        }
    }

    public nint Class
    {
        get
        {
            unsafe
            {
                return NativePtr->pClass;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->pClass = value;
            }
        }
    }

    public int TableIndex
    {
        get
        {
            unsafe
            {
                return NativePtr->iTableIndex;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->iTableIndex = value;
            }
        }
    }

    public int FuncIndex
    {
        get
        {
            unsafe
            {
                return NativePtr->iFuncIndex;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->iFuncIndex = value;
            }
        }
    }

    public nint ModuleHandle
    {
        get
        {
            unsafe
            {
                return NativePtr->hModule;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->hModule = value;
            }
        }
    }

    public string ModuleName
    {
        get
        {
            unsafe
            {
                return Marshal.PtrToStringUTF8(NativePtr->pszModuleName) ?? string.Empty;
            }
        }
    }

    public string FuncName
    {
        get
        {
            unsafe
            {
                return Marshal.PtrToStringUTF8(NativePtr->pszFuncName) ?? string.Empty;
            }
        }
    }

    public nint Next
    {
        get
        {
            unsafe
            {
                return NativePtr->pNext;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->pNext = value;
            }
        }
    }

    public nint Info
    {
        get
        {
            unsafe
            {
                return NativePtr->pInfo;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->pInfo = value;
            }
        }
    }
}