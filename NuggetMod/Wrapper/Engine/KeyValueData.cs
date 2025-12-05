using NuggetMod.Native.Engine;
using System.Runtime.InteropServices;

namespace NuggetMod.Wrapper.Engine;

/// <summary>
/// Represents key-value data for entity properties
/// </summary>
public class KeyValueData : BaseNativeWrapper<NativeKeyValueData>
{
    internal unsafe KeyValueData(nint ptr) : base((NativeKeyValueData*)ptr) { }
    
    /// <summary>
    /// Gets the class name
    /// </summary>
    public string ClassName
    {
        get
        {
            unsafe
            {
                return Marshal.PtrToStringUTF8(NativePtr->szClassName) ?? string.Empty;
            }
        }
    }

    public string KeyName
    {
        get
        {
            unsafe
            {
                return Marshal.PtrToStringUTF8(NativePtr->szKeyName) ?? string.Empty;
            }
        }
    }

    public string Value
    {
        get
        {
            unsafe
            {
                return Marshal.PtrToStringUTF8(NativePtr->szValue) ?? string.Empty;
            }
        }
    }

    public int Handled
    {
        get
        {
            unsafe
            {
                return NativePtr->fHandled;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->fHandled = value;
            }
        }
    }
}
