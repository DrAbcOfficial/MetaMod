using Metamod.Native.Engine;
using Metamod.Wrapper;

namespace Metamod.Wrapper.Engine;

public class Link : BaseNativeWrapper<NativeLink>
{
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