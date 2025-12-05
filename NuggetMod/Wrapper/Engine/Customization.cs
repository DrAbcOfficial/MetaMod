using NuggetMod.Native.Engine;

namespace NuggetMod.Wrapper.Engine;

/// <summary>
/// Represents player customization data (sprays, models, etc.)
/// </summary>
public class Customization : BaseNativeWrapper<NativeCustomization>
{
    /// <summary>
    /// Initializes a new instance with default values
    /// </summary>
    public Customization() : base() { }

    internal unsafe Customization(nint ptr) : this((NativeCustomization*)ptr) { }
    internal unsafe Customization(NativeCustomization* nativePtr, bool ownsPointer = false)
        : base(nativePtr, ownsPointer) { }

    public bool InUse
    {
        get
        {
            unsafe
            {
                return NativePtr->bInUse == 1;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->bInUse = value ? 1 : 0;
            }
        }
    }

    private Resource? _resource;
    public Resource Resource
    {
        get
        {
            unsafe
            {
                _resource ??= new Resource(&NativePtr->resource);
                return _resource;
            }
        }
    }

    public bool Translated
    {
        get
        {
            unsafe
            {
                return NativePtr->bTranslated == 1;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->bTranslated = value ? 1 : 0;
            }
        }
    }

    public int UserData1
    {
        get
        {
            unsafe
            {
                return NativePtr->nUserData1;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->nUserData1 = value;
            }
        }
    }

    public int UserData2
    {
        get
        {
            unsafe
            {
                return NativePtr->nUserData2;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->nUserData2 = value;
            }
        }
    }

    public nint Info
    {
        get
        {
            unsafe
            {
                return NativePtr->pInfo;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->pInfo = value;
            }
        }
    }

    public nint Buffer
    {
        get
        {
            unsafe
            {
                return NativePtr->pBuffer;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->pBuffer = value;
            }
        }
    }

    private Customization? _next;
    public Customization? Next
    {
        get
        {
            unsafe
            {
                if (NativePtr->pNext == null)
                    return null;

                _next ??= new Customization(NativePtr->pNext);
                return _next;
            }
        }
        set
        {
            unsafe
            {
                if (value == null)
                    NativePtr->pNext = (NativeCustomization*)nint.Zero;
                else
                    NativePtr->pNext = value.NativePtr;
            }
        }
    }
}