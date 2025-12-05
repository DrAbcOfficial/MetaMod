using Metamod.Native.Common;

namespace Metamod.Wrapper.Common;

public class UserCmd : BaseNativeWrapper<NativeUserCmd>
{
    internal unsafe UserCmd(nint ptr) : base((NativeUserCmd*)ptr) { }
    public short LerpMsec
    {
        get
        {
            unsafe
            {
                return NativePtr->lerp_msec;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->lerp_msec = value;
            }
        }
    }

    public byte Msec
    {
        get
        {
            unsafe
            {
                return NativePtr->msec;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->msec = value;
            }
        }
    }

    private Vector3f? _viewangles;
    public Vector3f ViewAngles
    {
        get
        {
            unsafe
            {
                _viewangles ??= new Vector3f(&NativePtr->viewangles);
                return _viewangles;
            }
        }
    }

    public float ForwardMove
    {
        get
        {
            unsafe
            {
                return NativePtr->forwardmove;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->forwardmove = value;
            }
        }
    }

    public float SideMove
    {
        get
        {
            unsafe
            {
                return NativePtr->sidemove;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->sidemove = value;
            }
        }
    }

    public float UpMove
    {
        get
        {
            unsafe
            {
                return NativePtr->upmove;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->upmove = value;
            }
        }
    }

    public byte LightLevel
    {
        get
        {
            unsafe
            {
                return NativePtr->lightlevel;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->lightlevel = value;
            }
        }
    }

    public ushort Buttons
    {
        get
        {
            unsafe
            {
                return NativePtr->buttons;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->buttons = value;
            }
        }
    }

    public byte Impulse
    {
        get
        {
            unsafe
            {
                return NativePtr->impulse;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->impulse = value;
            }
        }
    }

    public byte WeaponSelect
    {
        get
        {
            unsafe
            {
                return NativePtr->weaponselect;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->weaponselect = value;
            }
        }
    }

    public int ImpactIndex
    {
        get
        {
            unsafe
            {
                return NativePtr->impact_index;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->impact_index = value;
            }
        }
    }

    private Vector3f? _impact_position;
    public Vector3f ImpactPosition
    {
        get
        {
            unsafe
            {
                _impact_position ??= new Vector3f(&NativePtr->impact_position);
            }
            return _impact_position;
        }
    }
}
