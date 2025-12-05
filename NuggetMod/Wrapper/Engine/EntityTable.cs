using NuggetMod.Helper;
using NuggetMod.Native.Engine;

namespace NuggetMod.Wrapper.Engine;

/// <summary>
/// Represents an entity table entry for save/restore
/// </summary>
public class EntityTable : BaseNativeWrapper<NativeEntityTable>
{
    /// <summary>
    /// Initializes a new instance with default values
    /// </summary>
    public EntityTable() : base() { }

    internal unsafe EntityTable(NativeEntityTable* nativePtr, bool ownsPointer = false)
        : base(nativePtr, ownsPointer) { }

    public int Id
    {
        get
        {
            unsafe
            {
                return NativePtr->id;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->id = value;
            }
        }
    }

    public nint Pent
    {
        get
        {
            unsafe
            {
                return (nint)NativePtr->pent;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->pent = (NativeEdict*)value;
            }
        }
    }

    public int Location
    {
        get
        {
            unsafe
            {
                return NativePtr->location;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->location = value;
            }
        }
    }

    public int Size
    {
        get
        {
            unsafe
            {
                return NativePtr->size;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->size = value;
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

    private StringHandle? _classname;
    public string Classname
    {
        get
        {
            unsafe
            {
                _classname ??= new StringHandle(NativePtr->classname);
                return _classname.ToString();
            }
        }
        set
        {
            unsafe
            {
                _classname ??= new StringHandle(value);
                NativePtr->classname.value = _classname.ToHandle();
            }
        }
    }
}