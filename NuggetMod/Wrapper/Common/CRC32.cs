using NuggetMod.Native.Common;

namespace NuggetMod.Wrapper.Common;

/// <summary>
/// Represents a CRC32 checksum value
/// </summary>
public class CRC32 : BaseNativeWrapper<NativeCRC32>
{
    internal unsafe CRC32(nint ptr) : base((NativeCRC32*)ptr) { }
    internal CRC32(NativeCRC32 crc)
    {
        Value = crc.value;
    }
    
    /// <summary>
    /// Gets or sets the CRC32 value
    /// </summary>
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
