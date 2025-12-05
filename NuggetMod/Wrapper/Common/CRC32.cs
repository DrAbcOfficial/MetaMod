using Metamod.Native.Common;

namespace Metamod.Wrapper.Common;

public class CRC32 : BaseNativeWrapper<NativeCRC32>
{
    internal unsafe CRC32(nint ptr) : base((NativeCRC32*)ptr) { }
    internal CRC32(NativeCRC32 crc)
    {
        Value = crc.value;
    }
    public ulong Value
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
}
