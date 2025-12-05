using NuggetMod.Native.Common;

namespace NuggetMod.Wrapper.Common;

/// <summary>
/// Represents a 24-bit RGB color
/// </summary>
public class Color24 : BaseNativeWrapper<NativeColor24>
{
    /// <summary>
    /// Gets or sets the red component
    /// </summary>
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

    /// <summary>
    /// Gets or sets the green component
    /// </summary>
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

    /// <summary>
    /// Gets or sets the blue component
    /// </summary>
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

    /// <summary>
    /// Initializes a new instance with specified RGB components
    /// </summary>
    /// <param name="r">Red component</param>
    /// <param name="g">Green component</param>
    /// <param name="b">Blue component</param>
    public Color24(byte r, byte g, byte b) : base()
    {
        R = r;
        G = g;
        B = b;
    }

    /// <summary>
    /// Initializes a new instance from a packed integer color value
    /// </summary>
    /// <param name="color">Packed RGB color (0xRRGGBB format)</param>
    public Color24(int color) : base()
    {
        R = (byte)((color >> 16) & 0xFF);
        G = (byte)((color >> 8) & 0xFF);
        B = (byte)(color & 0xFF);
    }

    /// <summary>
    /// Initializes a new instance with default values
    /// </summary>
    public Color24() : base() { }

    internal unsafe Color24(NativeColor24* ptr) : base(ptr) { }
}
