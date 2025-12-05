using NuggetMod.Native.Engine;
using NuggetMod.Wrapper;

namespace NuggetMod.Wrapper.Engine;

/// <summary>
/// Represents a linked list node for spatial partitioning
/// </summary>
public class Link : BaseNativeWrapper<NativeLink>
{
    /// <summary>
    /// Initializes a new instance with default values
    /// </summary>
    public Link() : base() { }

    internal unsafe Link(NativeLink* nativePtr, bool ownsPointer = false)
        : base(nativePtr, ownsPointer) { }

    public nint Prev
    {
        get
        {
            unsafe
            {
                return NativePtr->prev;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->prev = value;
            }
        }
    }

    public nint Next
    {
        get
        {
            unsafe
            {
                return NativePtr->next;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->next = value;
            }
        }
    }
}