using NuggetMod.Interface;
using NuggetMod.Native.Engine;
using System.Runtime.InteropServices;

namespace NuggetMod.Helper;

/// <summary>
/// Handles string references in the game engine's string pool
/// </summary>
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
    
    /// <summary>
    /// Initializes a new instance with a string value
    /// </summary>
    /// <param name="str">String to store</param>
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

    /// <summary>
    /// Sets the string value
    /// </summary>
    /// <param name="str">String to set</param>
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

    /// <summary>
    /// Converts the string handle to a string
    /// </summary>
    /// <returns>String value</returns>
    public override string ToString()
    {
        nint ptr = MetaMod.GlobalVars.StringBase + _value;
        return Marshal.PtrToStringUTF8(ptr) ?? string.Empty;
    }

    internal int ToHandle()
    {
        return _value;
    }
    /// <summary>
    /// Release a StringHandle instance
    /// </summary>
    ~StringHandle()
    {
        if (_need_release)
        {
            Marshal.FreeHGlobal(_handle);
        }
    }
}
