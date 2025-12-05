using Metamod.Native.Common;

namespace Metamod.Wrapper.Common;

public class EntityState : BaseNativeWrapper<NativeEntityState>
{
    internal unsafe EntityState(nint ptr) : this((NativeEntityState*)ptr) { }
    internal unsafe EntityState(NativeEntityState* nativePtr, bool ownsPointer = false) : base(nativePtr, ownsPointer) { }
    public EntityState() : base() { }

    public int EntityType
    {
        get
        {
            unsafe
            {
                return NativePtr->entityType;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->entityType = value;
            }
        }
    }

    public int Number
    {
        get
        {
            unsafe
            {
                return NativePtr->number;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->number = value;
            }
        }
    }

    public float MsgTime
    {
        get
        {
            unsafe
            {
                return NativePtr->msg_time;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->msg_time = value;
            }
        }
    }

    public int MessageNum
    {
        get
        {
            unsafe
            {
                return NativePtr->messagenum;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->messagenum = value;
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

    public int ModelIndex
    {
        get
        {
            unsafe
            {
                return NativePtr->modelindex;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->modelindex = value;
            }
        }
    }

    public int Sequence
    {
        get
        {
            unsafe
            {
                return NativePtr->sequence;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->sequence = value;
            }
        }
    }

    public float Frame
    {
        get
        {
            unsafe
            {
                return NativePtr->frame;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->frame = value;
            }
        }
    }

    public int Colormap
    {
        get
        {
            unsafe
            {
                return NativePtr->colormap;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->colormap = value;
            }
        }
    }

    public short Skin
    {
        get
        {
            unsafe
            {
                return NativePtr->skin;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->skin = value;
            }
        }
    }

    public short Solid
    {
        get
        {
            unsafe
            {
                return NativePtr->solid;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->solid = value;
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

    public float Scale
    {
        get
        {
            unsafe
            {
                return NativePtr->scale;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->scale = value;
            }
        }
    }

    public byte EFlags
    {
        get
        {
            unsafe
            {
                return NativePtr->eflags;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->eflags = value;
            }
        }
    }

    public int RenderMode
    {
        get
        {
            unsafe
            {
                return NativePtr->rendermode;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->rendermode = value;
            }
        }
    }

    public int RenderAmt
    {
        get
        {
            unsafe
            {
                return NativePtr->renderamt;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->renderamt = value;
            }
        }
    }

    public Color24 RenderColor
    {
        get
        {
            unsafe
            {
                return new Color24(NativePtr->rendercolor);
            }
        }
    }

    public int RenderFx
    {
        get
        {
            unsafe
            {
                return NativePtr->renderfx;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->renderfx = value;
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

    public float AnimTime
    {
        get
        {
            unsafe
            {
                return NativePtr->animtime;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->animtime = value;
            }
        }
    }

    public float FrameRate
    {
        get
        {
            unsafe
            {
                return NativePtr->framerate;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->framerate = value;
            }
        }
    }

    public int Body
    {
        get
        {
            unsafe
            {
                return NativePtr->body;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->body = value;
            }
        }
    }

    public byte[] Controller
    {
        get
        {
            unsafe
            {
                byte[] controller = new byte[4];
                fixed (byte* ptr = controller)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        ptr[i] = NativePtr->controller[i];
                    }
                }
                return controller;
            }
        }
        set
        {
            unsafe
            {
                if (value.Length != 4)
                    throw new ArgumentException("Controller array must be 4 bytes long", nameof(value));

                fixed (byte* ptr = value)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        NativePtr->controller[i] = ptr[i];
                    }
                }
            }
        }
    }

    public byte[] Blending
    {
        get
        {
            unsafe
            {
                byte[] blending = new byte[4];
                fixed (byte* ptr = blending)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        ptr[i] = NativePtr->blending[i];
                    }
                }
                return blending;
            }
        }
        set
        {
            unsafe
            {
                if (value.Length != 4)
                    throw new ArgumentException("Blending array must be 4 bytes long", nameof(value));

                fixed (byte* ptr = value)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        NativePtr->blending[i] = ptr[i];
                    }
                }
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

    private Vector3f? _mins;
    public Vector3f Mins
    {
        get
        {
            unsafe
            {
                _mins ??= new Vector3f(&NativePtr->mins);
                return _mins;
            }
        }
    }

    private Vector3f? _maxs;
    public Vector3f Maxs
    {
        get
        {
            unsafe
            {
                _maxs ??= new Vector3f(&NativePtr->maxs);
                return _maxs;
            }
        }
    }

    public int AimEnt
    {
        get
        {
            unsafe
            {
                return NativePtr->aiment;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->aiment = value;
            }
        }
    }

    public int Owner
    {
        get
        {
            unsafe
            {
                return NativePtr->owner;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->owner = value;
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

    public int Team
    {
        get
        {
            unsafe
            {
                return NativePtr->team;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->team = value;
            }
        }
    }

    public int PlayerClass
    {
        get
        {
            unsafe
            {
                return NativePtr->playerclass;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->playerclass = value;
            }
        }
    }

    public int Health
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

    public bool Spectator
    {
        get
        {
            unsafe
            {
                return NativePtr->spectator == 1;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->spectator = value ? 1 : 0;
            }
        }
    }

    public int WeaponModel
    {
        get
        {
            unsafe
            {
                return NativePtr->weaponmodel;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->weaponmodel = value;
            }
        }
    }

    public int GaitSequence
    {
        get
        {
            unsafe
            {
                return NativePtr->gaitsequence;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->gaitsequence = value;
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

    public float Fov
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

    private Vector3f? _startPos;
    public Vector3f StartPos
    {
        get
        {
            unsafe
            {
                _startPos ??= new Vector3f(&NativePtr->startpos);
                return _startPos;
            }
        }
    }

    private Vector3f? _endPos;
    public Vector3f EndPos
    {
        get
        {
            unsafe
            {
                _endPos ??= new Vector3f(&NativePtr->endpos);
                return _endPos;
            }
        }
    }

    public float ImpactTime
    {
        get
        {
            unsafe
            {
                return NativePtr->impacttime;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->impacttime = value;
            }
        }
    }

    public float StartTime
    {
        get
        {
            unsafe
            {
                return NativePtr->starttime;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->starttime = value;
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
}