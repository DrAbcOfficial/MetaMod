using Metamod.Native.Engine;

namespace Metamod.Wrapper.Engine;

public class Edict : BaseNativeWrapper<NativeEdict>
{
    public Edict() : base() { }

    internal unsafe Edict(nint ptr) : this((NativeEdict*)ptr) { }
    internal unsafe Edict(NativeEdict* nativePtr, bool ownsPointer = false)
        : base(nativePtr, ownsPointer) { }

    public int Free
    {
        get
        {
            unsafe
            {
                return NativePtr->free;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->free = value;
            }
        }
    }

    public int SerialNumber
    {
        get
        {
            unsafe
            {
                return NativePtr->serialnumber;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->serialnumber = value;
            }
        }
    }

    private Link? _area;
    public Link Area
    {
        get
        {
            unsafe
            {
                _area ??= new Link(&NativePtr->area);
                return _area;
            }
        }
    }

    public int HeadNode
    {
        get
        {
            unsafe
            {
                return NativePtr->headnode;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->headnode = value;
            }
        }
    }

    public int NumLeafs
    {
        get
        {
            unsafe
            {
                return NativePtr->num_leafs;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->num_leafs = value;
            }
        }
    }

    public short[] LeafNums
    {
        get
        {
            unsafe
            {
                short[] leafs = new short[48];
                for (int i = 0; i < 48; i++)
                {
                    leafs[i] = NativePtr->leafnums[i];
                }
                return leafs;
            }
        }
        set
        {
            unsafe
            {
                int copyLength = Math.Min(value.Length, 48);
                for (int i = 0; i < copyLength; i++)
                {
                    NativePtr->leafnums[i] = value[i];
                }
            }
        }
    }

    public float FreeTime
    {
        get
        {
            unsafe
            {
                return NativePtr->freetime;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->freetime = value;
            }
        }
    }

    public nint PrivateData
    {
        get
        {
            unsafe
            {
                return NativePtr->pvPrivateData;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->pvPrivateData = value;
            }
        }
    }

    private Entvars? _entVars;
    public Entvars EntVars
    {
        get
        {
            unsafe
            {
                _entVars ??= new Entvars(&NativePtr->v);
                return _entVars;
            }
        }
    }
}