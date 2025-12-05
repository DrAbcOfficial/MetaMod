using NuggetMod.Enum.NuggetMod;
using NuggetMod.Native.Engine.PM;
using NuggetMod.Wrapper.Common;
using System.Text;

namespace NuggetMod.Wrapper.Engine.PM;

/// <summary>
/// Represents player movement state and parameters
/// </summary>
public class PlayerMove : BaseNativeWrapper<NativePlayerMove>
{
    internal unsafe PlayerMove(nint ptr) : base((NativePlayerMove*)ptr) { }
    
    /// <summary>
    /// Gets or sets the player index
    /// </summary>
    public int PlayerIndex
    {
        get
        {
            unsafe
            {
                return NativePtr->player_index;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->player_index = value;
            }
        }
    }

    public bool Server
    {
        get
        {
            unsafe
            {
                return NativePtr->server == 1;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->server = value ? 1 : 0;
            }
        }
    }

    public bool Multiplayer
    {
        get
        {
            unsafe
            {
                return NativePtr->multiplayer == 1;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->multiplayer = value ? 1 : 0;
            }
        }
    }

    public float Time
    {
        get
        {
            unsafe
            {
                return NativePtr->time;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->time = value;
            }
        }
    }

    public float FrameTime
    {
        get
        {
            unsafe
            {
                return NativePtr->frametime;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->frametime = value;
            }
        }
    }

    private Vector3f? _forward;
    public Vector3f Forward
    {
        get
        {
            unsafe
            {
                _forward ??= new Vector3f(&NativePtr->forward);
                return _forward;
            }
        }
    }

    private Vector3f? _right;
    public Vector3f Right
    {
        get
        {
            unsafe
            {
                _right ??= new Vector3f(&NativePtr->right);
                return _right;
            }
        }
    }

    private Vector3f? _up;
    public Vector3f Up
    {
        get
        {
            unsafe
            {
                _up ??= new Vector3f(&NativePtr->up);
                return _up;
            }
        }
    }

    private Vector3f? _origin;
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

    private Vector3f? _angles;
    public Vector3f Angles
    {
        get
        {
            unsafe
            {
                _angles ??= new Vector3f(&NativePtr->angles);
                return _angles;
            }
        }
    }

    private Vector3f? _oldAngles;
    public Vector3f OldAngles
    {
        get
        {
            unsafe
            {
                _oldAngles ??= new Vector3f(&NativePtr->oldangles);
                return _oldAngles;
            }
        }
    }

    private Vector3f? _velocity;
    public Vector3f Velocity
    {
        get
        {
            unsafe
            {
                _velocity ??= new Vector3f(&NativePtr->velocity);
                return _velocity;
            }
        }
    }

    private Vector3f? _moveDir;
    public Vector3f MoveDir
    {
        get
        {
            unsafe
            {
                _moveDir ??= new Vector3f(&NativePtr->movedir);
                return _moveDir;
            }
        }
    }

    private Vector3f? _baseVelocity;
    public Vector3f BaseVelocity
    {
        get
        {
            unsafe
            {
                _baseVelocity ??= new Vector3f(&NativePtr->basevelocity);
                return _baseVelocity;
            }
        }
    }

    private Vector3f? _viewOfs;
    public Vector3f ViewOfs
    {
        get
        {
            unsafe
            {
                _viewOfs ??= new Vector3f(&NativePtr->view_ofs);
                return _viewOfs;
            }
        }
    }

    public float DuckTime
    {
        get
        {
            unsafe
            {
                return NativePtr->flDuckTime;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->flDuckTime = value;
            }
        }
    }

    public bool InDuck
    {
        get
        {
            unsafe
            {
                return NativePtr->bInDuck == 1;
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

    public int FlTimeStepSound
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

    public int IStepLeft
    {
        get
        {
            unsafe
            {
                return NativePtr->iStepLeft;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->iStepLeft = value;
            }
        }
    }

    public float FlFallVelocity
    {
        get
        {
            unsafe
            {
                return NativePtr->flFallVelocity;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->flFallVelocity = value;
            }
        }
    }

    private Vector3f? _punchAngle;
    public Vector3f PunchAngle
    {
        get
        {
            unsafe
            {
                _punchAngle ??= new Vector3f(&NativePtr->punchangle);
                return _punchAngle;
            }
        }
    }

    public float FlSwimTime
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

    public float FlNextPrimaryAttack
    {
        get
        {
            unsafe
            {
                return NativePtr->flNextPrimaryAttack;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->flNextPrimaryAttack = value;
            }
        }
    }

    public int Effects
    {
        get
        {
            unsafe
            {
                return NativePtr->effects;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->effects = value;
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

    public int UseHull
    {
        get
        {
            unsafe
            {
                return NativePtr->usehull;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->usehull = value;
            }
        }
    }

    public float Gravity
    {
        get
        {
            unsafe
            {
                return NativePtr->gravity;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->gravity = value;
            }
        }
    }

    public float Friction
    {
        get
        {
            unsafe
            {
                return NativePtr->friction;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->friction = value;
            }
        }
    }

    public int OldButtons
    {
        get
        {
            unsafe
            {
                return NativePtr->oldbuttons;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->oldbuttons = value;
            }
        }
    }

    public float WaterJumpTime
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

    public bool Dead
    {
        get
        {
            unsafe
            {
                return NativePtr->dead == 1;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->dead = value ? 1 : 0;
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

    public int Spectator
    {
        get
        {
            unsafe
            {
                return NativePtr->spectator;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->spectator = value;
            }
        }
    }

    public int MoveType
    {
        get
        {
            unsafe
            {
                return NativePtr->movetype;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->movetype = value;
            }
        }
    }

    public int OnGround
    {
        get
        {
            unsafe
            {
                return NativePtr->onground;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->onground = value;
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

    public int OldWaterLevel
    {
        get
        {
            unsafe
            {
                return NativePtr->oldwaterlevel;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->oldwaterlevel = value;
            }
        }
    }

    public string SzTextureName
    {
        get
        {
            unsafe
            {
                byte[] buffer = new byte[256];
                fixed (byte* managedPtr = buffer)
                {
                    byte* nativePtr = NativePtr->sztexturename;
                    for (int i = 0; i < 256; i++)
                    {
                        managedPtr[i] = nativePtr[i];
                    }
                }
                return Encoding.UTF8.GetString(buffer);
            }
        }
        set
        {
            unsafe
            {
                ArgumentNullException.ThrowIfNull(value);
                byte[] bytes = Encoding.UTF8.GetBytes(value);
                if (bytes.Length > 256)
                    throw new ArgumentOutOfRangeException(nameof(value), "Texture name length cannot exceed 256 bytes");
                for (int i = 0; i < 256; i++)
                {
                    NativePtr->sztexturename[i] = i < bytes.Length ? bytes[i] : (byte)0;
                }
            }
        }
    }

    public byte ChTextureType
    {
        get
        {
            unsafe
            {
                return NativePtr->chtexturetype;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->chtexturetype = value;
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

    public float ClientMaxSpeed
    {
        get
        {
            unsafe
            {
                return NativePtr->clientmaxspeed;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->clientmaxspeed = value;
            }
        }
    }

    // User variables
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

    private Vector3f? _vUser1;
    public Vector3f VUser1
    {
        get
        {
            unsafe
            {
                _vUser1 ??= new Vector3f(&NativePtr->vuser1);
                return _vUser1;
            }
        }
    }

    private Vector3f? _vUser2;
    public Vector3f VUser2
    {
        get
        {
            unsafe
            {
                _vUser2 ??= new Vector3f(&NativePtr->vuser2);
                return _vUser2;
            }
        }
    }

    private Vector3f? _vUser3;
    public Vector3f VUser3
    {
        get
        {
            unsafe
            {
                _vUser3 ??= new Vector3f(&NativePtr->vuser3);
                return _vUser3;
            }
        }
    }

    private Vector3f? _vUser4;
    public Vector3f VUser4
    {
        get
        {
            unsafe
            {
                _vUser4 ??= new Vector3f(&NativePtr->vuser4);
                return _vUser4;
            }
        }
    }

    public int NumPhysEnt
    {
        get
        {
            unsafe
            {
                return NativePtr->numphysent;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->numphysent = value;
            }
        }
    }
}