using Metamod.Native.Common;

namespace Metamod.Wrapper.Common;

public class Color24 : BaseNativeWrapper<NativeColor24>
{
    public byte R
    {
        get
        {
            unsafe
            {
                return NativePtr->r;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->r = value;
            }
        }
    }

    public byte G
    {
        get
        {
            unsafe
            {
                return NativePtr->g;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->g = value;
            }
        }
    }

    public byte B
    {
        get
        {
            unsafe
            {
                return NativePtr->b;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->b = value;
            }
        }
    }

    public Color24(byte r, byte g, byte b) : base()
    {
        R = r;
        G = g;
        B = b;
    }

    public Color24(int color) : base()
    {
        R = (byte)((color >> 16) & 0xFF);
        G = (byte)((color >> 8) & 0xFF);
        B = (byte)(color & 0xFF);
    }

    public Color24() : base() { }

    internal unsafe Color24(NativeColor24* ptr) : base(ptr) { }
}
