using NuggetMod.Native.Common;

namespace NuggetMod.Wrapper.Common;

/// <summary>
/// Represents client-specific data sent to the client
/// </summary>
public class ClientData : BaseNativeWrapper<NativeClientData>
{
    internal unsafe ClientData(nint ptr) : base((NativeClientData*)ptr) { }
    private Vector3f? _origin;
    
    /// <summary>
    /// Gets the client's origin position
    /// </summary>
    public Vector3f Origin
    {
        get
        {
            unsafe
            {
                _origin ??= new Vector3f(&NativePtr->origin);
                return _origin;
            }
        }
    }

    private Vector3f? _veloctiy;
    public Vector3f Veloctiy
    {
        get
        {
            unsafe
            {
                _veloctiy ??= new Vector3f(&NativePtr->velocity);
                return _veloctiy;
            }
        }
    }

    public int ViewModel
    {
        get
        {
            unsafe
            {
                return NativePtr->viewmodel;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->viewmodel = value;
            }
        }
    }

    private Vector3f? _punchangle;
    public Vector3f PunchAngle
    {
        get
        {
            unsafe
            {
                _punchangle ??= new Vector3f(&NativePtr->punchangle);
                return _punchangle;
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

    public int WaterLevel
    {
        get
        {
            unsafe
            {
                return NativePtr->waterlevel;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->waterlevel = value;
            }
        }
    }

    public int WaterType
    {
        get
        {
            unsafe
            {
                return NativePtr->watertype;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->watertype = value;
            }
        }
    }

    private Vector3f? _view_ofs;
    public Vector3f ViewOFS
    {
        get
        {
            unsafe
            {
                _view_ofs ??= new Vector3f(&NativePtr->view_ofs);
                return _view_ofs;
            }
        }
    }

    public float Health
    {
        get
        {
            unsafe
            {
                return NativePtr->health;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->health = value;
            }
        }
    }

    public bool InDuck
    {
        get
        {
            unsafe
            {
                return NativePtr->bInDuck > 0;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->bInDuck = value ? 1 : 0;
            }
        }
    }

    public int Weapons
    {
        get
        {
            unsafe
            {
                return NativePtr->weapons;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->weapons = value;
            }
        }
    }

    public int FLTimeStepSound
    {
        get
        {
            unsafe
            {
                return NativePtr->flTimeStepSound;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->flTimeStepSound = value;
            }
        }
    }

    public int FLDuckTime
    {
        get
        {
            unsafe
            {
                return NativePtr->flTimeStepSound;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->flTimeStepSound = value;
            }
        }
    }
    public int FLSwimTime
    {
        get
        {
            unsafe
            {
                return NativePtr->flSwimTime;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->flSwimTime = value;
            }
        }
    }

    public int WaterJumpTime
    {
        get
        {
            unsafe
            {
                return NativePtr->waterjumptime;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->waterjumptime = value;
            }
        }
    }

    public float MaxSpeed
    {
        get
        {
            unsafe
            {
                return NativePtr->maxspeed;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->maxspeed = value;
            }
        }
    }

    public float FOV
    {
        get
        {
            unsafe
            {
                return NativePtr->fov;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->fov = value;
            }
        }
    }

    public int WeaponAnim
    {
        get
        {
            unsafe
            {
                return NativePtr->weaponanim;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->weaponanim = value;
            }
        }
    }

    public int Id
    {
        get
        {
            unsafe
            {
                return NativePtr->m_iId;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->m_iId = value;
            }
        }
    }
    public int AmmoShells
    {
        get
        {
            unsafe
            {
                return NativePtr->ammo_shells;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->ammo_shells = value;
            }
        }
    }
    public int AmmoNails
    {
        get
        {
            unsafe
            {
                return NativePtr->ammo_nails;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->ammo_nails = value;
            }
        }
    }

    public int AmmoCells
    {
        get
        {
            unsafe
            {
                return NativePtr->ammo_cells;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->ammo_cells = value;
            }
        }
    }
    public int AmmoRockets
    {
        get
        {
            unsafe
            {
                return NativePtr->ammo_rockets;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->ammo_rockets = value;
            }
        }
    }

    public float NextAttack
    {
        get
        {
            unsafe
            {
                return NativePtr->m_flNextAttack;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->m_flNextAttack = value;
            }
        }
    }

    public int TFState
    {
        get
        {
            unsafe
            {
                return NativePtr->tfstate;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->tfstate = value;
            }
        }
    }

    public int PushMSec
    {
        get
        {
            unsafe
            {
                return NativePtr->pushmsec;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->pushmsec = value;
            }
        }
    }

    public int DeadFlag
    {
        get
        {
            unsafe
            {
                return NativePtr->deadflag;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->deadflag = value;
            }
        }
    }

    public byte[] Physinfo
    {
        get
        {
            unsafe
            {
                byte[] buffer = new byte[256];
                fixed (byte* managedPtr = buffer)
                {
                    byte* nativeBuffer = NativePtr->physinfo;
                    for (int i = 0; i < 256; i++)
                    {
                        managedPtr[i] = nativeBuffer[i];
                    }
                }
                return buffer;
            }
        }
        set
        {
            unsafe
            {
                ArgumentNullException.ThrowIfNull(value);
                if (value.Length > 256)
                    throw new ArgumentOutOfRangeException(nameof(value), "Array Length out of range(256)");
                byte* nativeBuffer = NativePtr->physinfo;
                for (int i = 0; i < 256; i++)
                {
                    nativeBuffer[i] = 0;
                }
                for (int i = 0; i < value.Length; i++)
                {
                    nativeBuffer[i] = value[i];
                }
            }
        }
    }

    public int IUser1
    {
        get
        {
            unsafe
            {
                return NativePtr->iuser1;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->iuser1 = value;
            }
        }
    }
    public int IUser2
    {
        get
        {
            unsafe
            {
                return NativePtr->iuser2;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->iuser2 = value;
            }
        }
    }
    public int IUser3
    {
        get
        {
            unsafe
            {
                return NativePtr->iuser3;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->iuser3 = value;
            }
        }
    }
    public int IUser4
    {
        get
        {
            unsafe
            {
                return NativePtr->iuser4;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->iuser4 = value;
            }
        }
    }
    public float FUser1
    {
        get
        {
            unsafe
            {
                return NativePtr->fuser1;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->fuser1 = value;
            }
        }
    }
    public float FUser2
    {
        get
        {
            unsafe
            {
                return NativePtr->fuser2;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->fuser2 = value;
            }
        }
    }
    public float FUser3
    {
        get
        {
            unsafe
            {
                return NativePtr->fuser3;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->fuser3 = value;
            }
        }
    }
    public float FUser4
    {
        get
        {
            unsafe
            {
                return NativePtr->fuser4;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->fuser4 = value;
            }
        }
    }

    private Vector3f? _vuser1;
    public Vector3f VUser1
    {
        get
        {
            unsafe
            {
                _vuser1 ??= new Vector3f(&NativePtr->vuser1);
                return _vuser1;
            }
        }
    }
    private Vector3f? _vuser2;
    public Vector3f VUser2
    {
        get
        {
            unsafe
            {
                _vuser2 ??= new Vector3f(&NativePtr->vuser2);
                return _vuser2;
            }
        }
    }

    private Vector3f? _vuser3;
    public Vector3f VUser3
    {
        get
        {
            unsafe
            {
                _vuser3 ??= new Vector3f(&NativePtr->vuser3);
                return _vuser3;
            }
        }
    }

    private Vector3f? _vuser4;
    public Vector3f VUser4
    {
        get
        {
            unsafe
            {
                _vuser4 ??= new Vector3f(&NativePtr->vuser4);
                return _vuser4;
            }
        }
    }
}
