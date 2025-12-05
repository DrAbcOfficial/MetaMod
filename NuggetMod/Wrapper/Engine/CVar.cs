using Metamod.Native.Engine;
using System.Runtime.InteropServices;

namespace Metamod.Wrapper.Engine;

public class CVar : BaseNativeWrapper<NativeCVar>
{
    public enum FCVAR
    {
        None = 0,
        Archive = 1 << 0,
        UserInfo = 1 << 1,
        Server = 1 << 2,
        ExternalDLL = 1 << 3,
        ClientDLL = 1 << 4,
        Protected = 1 << 5,
        SinglePlayOnly = 1 << 6,
        PrintableOnly = 1 << 7,
        Unlogged = 1 << 8,
    }
    internal unsafe CVar(nint ptr) : this((NativeCVar*)ptr) { }
    internal unsafe CVar(NativeCVar* native) : base(native) { }
    public string Name
    {
        get
        {
            unsafe
            {
                return Marshal.PtrToStringUTF8(NativePtr->name) ?? string.Empty;
            }
        }
        set
        {
            unsafe
            {
                var bytes = System.Text.Encoding.UTF8.GetBytes(value + '\0');
                Marshal.Copy(bytes, 0, NativePtr->name, bytes.Length);
            }

        }
    }

    public string Str
    {
        get
        {
            unsafe
            {
                return Marshal.PtrToStringUTF8(NativePtr->str) ?? string.Empty;
            }
        }
        set
        {
            unsafe
            {
                var bytes = System.Text.Encoding.UTF8.GetBytes(value + '\0');
                Marshal.Copy(bytes, 0, NativePtr->str, bytes.Length);
            }

        }
    }

    public int Flags
    {
        get
        {
            unsafe
            {
                return NativePtr->flags;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->flags = value;
            }
        }
    }

    public bool TestFlag(FCVAR flag)
    {
        return (Flags & (int)flag) != 0;
    }

    public void SetFlag(FCVAR flag)
    {
        Flags |= (int)flag;
    }

    public void RemoveFlag(FCVAR flag)
    {
        Flags &= ~(int)flag;
    }

    public float Value
    {
        get
        {
            unsafe
            {
                return NativePtr->value;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->value = value;
            }
        }
    }

    public CVar? Next
    {
        get
        {
            unsafe
            {
                var nextPtr = (NativeCVar*)NativePtr->next;
                return nextPtr != null ? new CVar(nextPtr) : null;
            }
        }
    }
}
