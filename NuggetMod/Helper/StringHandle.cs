using Metamod.Interface;
using Metamod.Native.Engine;
using System.Runtime.InteropServices;

namespace Metamod.Helper;

public class StringHandle
{
    private nint _handle;
    private bool _need_release = false;
    private int _value;

    internal StringHandle()
    {
        _need_release = false;
    }
    internal StringHandle(NativeStringHandle str)
    {
        _value = str.value;
        _need_release = false; 
    }
    public StringHandle(string str)
    {
        SetString(str);
    }

    internal void SetHandle(int handle)
    {
        if (_need_release)
        {
            Marshal.FreeHGlobal(_handle);
        }
        _handle = nint.Zero;
        _value = handle;
        _need_release = false;
    }

    public void SetString(string str)
    {
        if (_need_release)
        {
            Marshal.FreeHGlobal(_handle);
        }
        _handle = Marshal.StringToHGlobalAnsi(str);
        _need_release = true;
        _value = (int)(_handle - MetaMod.GlobalVars.StringBase);
    }

    public override string ToString()
    {
        nint ptr = MetaMod.GlobalVars.StringBase + _value;
        return Marshal.PtrToStringUTF8(ptr) ?? string.Empty;
    }

    internal int ToHandle()
    {
        return _value;
    }

    ~StringHandle()
    {
        if (_need_release)
        {
            Marshal.FreeHGlobal(_handle);
        }
    }
}
