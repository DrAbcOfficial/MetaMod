using Metamod.Native.Engine;
using System.Runtime.InteropServices;

namespace Metamod.Wrapper.Engine;

public class KeyValueData : BaseNativeWrapper<NativeKeyValueData>
{
    internal unsafe KeyValueData(nint ptr) : base((NativeKeyValueData*)ptr) { }
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
