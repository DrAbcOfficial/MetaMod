using NuggetMod.Helper;
using NuggetMod.Native.Engine;
using NuggetMod.Wrapper.Common;

namespace NuggetMod.Wrapper.Engine;

/// <summary>
/// Represents entity variables (entvars) - the core data for each entity
/// </summary>
public class Entvars : BaseNativeWrapper<NativeEntvars>
{
    /// <summary>
    /// Initializes a new instance with default values
    /// </summary>
    public Entvars() : base() { }

    internal unsafe Entvars(NativeEntvars* nativePtr, bool ownsPointer = false)
        : base(nativePtr, ownsPointer) { }

    // String handle fields
    private StringHandle? _classname;
    public string ClassName
    {
        get
        {
            unsafe
            {
                _classname ??= new StringHandle();
                _classname.SetHandle(NativePtr->classname.value);
                return _classname.ToString();
            }
        }
        set
        {
            unsafe
            {
                _classname ??= new StringHandle();
                _classname.SetString(value);
                NativePtr->classname.value = _classname.ToHandle();
            }
        }
    }

    private StringHandle? _globalname;
    public string GlobalName
    {
        get
        {
            unsafe
            {
                _globalname ??= new StringHandle();
                _globalname.SetHandle(NativePtr->globalname.value);
                return _globalname.ToString();
            }
        }
        set
        {
            unsafe
            {
                _globalname ??= new StringHandle();
                _globalname.SetString(value);
                NativePtr->globalname.value = _globalname.ToHandle();
            }
        }
    }

    // Vector3f fields
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

    private Vector3f? _oldorigin;
    public Vector3f OldOrigin
    {
        get
        {
            unsafe
            {
                _oldorigin ??= new Vector3f(&NativePtr->oldorigin);
                return _oldorigin;
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

    private Vector3f? _basevelocity;
    public Vector3f BaseVelocity
    {
        get
        {
            unsafe
            {
                _basevelocity ??= new Vector3f(&NativePtr->basevelocity);
                return _basevelocity;
            }
        }
    }

    private Vector3f? _clbasevelocity;
    public Vector3f ClBaseVelocity
    {
        get
        {
            unsafe
            {
                _clbasevelocity ??= new Vector3f(&NativePtr->clbasevelocity);
                return _clbasevelocity;
            }
        }
    }

    private Vector3f? _movedir;
    public Vector3f MoveDir
    {
        get
        {
            unsafe
            {
                _movedir ??= new Vector3f(&NativePtr->movedir);
                return _movedir;
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

    private Vector3f? _avelocity;
    public Vector3f AVelocity
    {
        get
        {
            unsafe
            {
                _avelocity ??= new Vector3f(&NativePtr->avelocity);
                return _avelocity;
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

    private Vector3f? _vAngle;
    public Vector3f VAngle
    {
        get
        {
            unsafe
            {
                _vAngle ??= new Vector3f(&NativePtr->v_angle);
                return _vAngle;
            }
        }
    }

    private Vector3f? _endpos;
    public Vector3f EndPos
    {
        get
        {
            unsafe
            {
                _endpos ??= new Vector3f(&NativePtr->endpos);
                return _endpos;
            }
        }
    }

    private Vector3f? _startpos;
    public Vector3f StartPos
    {
        get
        {
            unsafe
            {
                _startpos ??= new Vector3f(&NativePtr->startpos);
                return _startpos;
            }
        }
    }

    // Basic type fields
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

    public int FixAngle
    {
        get
        {
            unsafe
            {
                return NativePtr->fixangle;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->fixangle = value;
            }
        }
    }

    public float IdealPitch
    {
        get
        {
            unsafe
            {
                return NativePtr->idealpitch;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->idealpitch = value;
            }
        }
    }

    public float PitchSpeed
    {
        get
        {
            unsafe
            {
                return NativePtr->pitch_speed;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->pitch_speed = value;
            }
        }
    }

    public float IdealYaw
    {
        get
        {
            unsafe
            {
                return NativePtr->ideal_yaw;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->ideal_yaw = value;
            }
        }
    }

    public float YawSpeed
    {
        get
        {
            unsafe
            {
                return NativePtr->yaw_speed;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->yaw_speed = value;
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

    private StringHandle? _model;
    public string Model
    {
        get
        {
            unsafe
            {
                _model ??= new StringHandle();
                _model.SetHandle(NativePtr->model.value);
                return _model.ToString();
            }
        }
        set
        {
            unsafe
            {
                _model ??= new StringHandle();
                _model.SetString(value);
                NativePtr->model.value = _model.ToHandle();
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

    // Additional Vector3f fields
    private Vector3f? _absmin;
    public Vector3f AbsMin
    {
        get
        {
            unsafe
            {
                _absmin ??= new Vector3f(&NativePtr->absmin);
                return _absmin;
            }
        }
    }

    private Vector3f? _absmax;
    public Vector3f AbsMax
    {
        get
        {
            unsafe
            {
                _absmax ??= new Vector3f(&NativePtr->absmax);
                return _absmax;
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

    private Vector3f? _size;
    public Vector3f Size
    {
        get
        {
            unsafe
            {
                _size ??= new Vector3f(&NativePtr->size);
                return _size;
            }
        }
    }

    // Additional fields (truncated for brevity - follow same pattern for remaining fields)
    public float LTime
    {
        get
        {
            unsafe
            {
                return NativePtr->ltime;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->ltime = value;
            }
        }
    }

    public float NextThink
    {
        get
        {
            unsafe
            {
                return NativePtr->nextthink;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->nextthink = value;
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

    public int Solid
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

    public int Skin
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

    public int LightLevel
    {
        get
        {
            unsafe
            {
                return NativePtr->light_level;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->light_level = value;
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

    public byte[] Controller
    {
        get
        {
            unsafe
            {
                byte[] controller = new byte[4];
                for (int i = 0; i < 4; i++)
                {
                    controller[i] = NativePtr->controller[i];
                }
                return controller;
            }
        }
        set
        {
            unsafe
            {
                int copyLength = Math.Min(value.Length, 4);
                for (int i = 0; i < copyLength; i++)
                {
                    NativePtr->controller[i] = value[i];
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
                byte[] blending = new byte[2];
                for (int i = 0; i < 2; i++)
                {
                    blending[i] = NativePtr->blending[i];
                }
                return blending;
            }
        }
        set
        {
            unsafe
            {
                int copyLength = Math.Min(value.Length, 2);
                for (int i = 0; i < copyLength; i++)
                {
                    NativePtr->blending[i] = value[i];
                }
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

    public float RenderAmt
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

    private Vector3f? _rendercolor;
    public Vector3f RenderColor
    {
        get
        {
            unsafe
            {
                _rendercolor ??= new Vector3f(&NativePtr->rendercolor);
                return _rendercolor;
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

    public float Frags
    {
        get
        {
            unsafe
            {
                return NativePtr->frags;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->frags = value;
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

    public float TakeDamage
    {
        get
        {
            unsafe
            {
                return NativePtr->takedamage;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->takedamage = value;
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

    public int Button
    {
        get
        {
            unsafe
            {
                return NativePtr->button;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->button = value;
            }
        }
    }

    public int Impulse
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

    private Edict? _chain;
    public Edict? Chain
    {
        get
        {
            unsafe
            {
                if (NativePtr->chain == null)
                    return null;

                _chain ??= new Edict(NativePtr->chain);
                return _chain;
            }
        }
        set
        {
            unsafe
            {
                if (value == null)
                    NativePtr->chain = null;
                else
                    NativePtr->chain = (NativeEdict*)value.GetPointer();
            }
        }
    }

    private Edict? _dmgInflictor;
    public Edict? DmgInflictor
    {
        get
        {
            unsafe
            {
                if (NativePtr->dmg_inflictor == null)
                    return null;

                _dmgInflictor ??= new Edict(NativePtr->dmg_inflictor);
                return _dmgInflictor;
            }
        }
        set
        {
            unsafe
            {
                if (value == null)
                    NativePtr->dmg_inflictor = null;
                else
                    NativePtr->dmg_inflictor = (NativeEdict*)value.GetPointer();
            }
        }
    }

    private Edict? _enemy;
    public Edict? Enemy
    {
        get
        {
            unsafe
            {
                if (NativePtr->enemy == null)
                    return null;

                _enemy ??= new Edict(NativePtr->enemy);
                return _enemy;
            }
        }
        set
        {
            unsafe
            {
                if (value == null)
                    NativePtr->enemy = null;
                else
                    NativePtr->enemy = (NativeEdict*)value.GetPointer();
            }
        }
    }

    private Edict? _aiment;
    public Edict? Aiment
    {
        get
        {
            unsafe
            {
                if (NativePtr->aiment == null)
                    return null;

                _aiment ??= new Edict(NativePtr->aiment);
                return _aiment;
            }
        }
        set
        {
            unsafe
            {
                if (value == null)
                    NativePtr->aiment = null;
                else
                    NativePtr->aiment = (NativeEdict*)value.GetPointer();
            }
        }
    }

    private Edict? _owner;
    public Edict? Owner
    {
        get
        {
            unsafe
            {
                if (NativePtr->owner == null)
                    return null;

                _owner ??= new Edict(NativePtr->owner);
                return _owner;
            }
        }
        set
        {
            unsafe
            {
                if (value == null)
                    NativePtr->owner = null;
                else
                    NativePtr->owner = (NativeEdict*)value.GetPointer();
            }
        }
    }

    private Edict? _groundEntity;
    public Edict? GroundEntity
    {
        get
        {
            unsafe
            {
                if (NativePtr->groundentity == null)
                    return null;

                _groundEntity ??= new Edict(NativePtr->groundentity);
                return _groundEntity;
            }
        }
        set
        {
            unsafe
            {
                if (value == null)
                    NativePtr->groundentity = null;
                else
                    NativePtr->groundentity = (NativeEdict*)value.GetPointer();
            }
        }
    }

    public int SpawnFlags
    {
        get
        {
            unsafe
            {
                return NativePtr->spawnflags;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->spawnflags = value;
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

    public int ColorMap
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

    public float MaxHealth
    {
        get
        {
            unsafe
            {
                return NativePtr->max_health;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->max_health = value;
            }
        }
    }

    public float TeleportTime
    {
        get
        {
            unsafe
            {
                return NativePtr->teleport_time;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->teleport_time = value;
            }
        }
    }

    public float ArmorType
    {
        get
        {
            unsafe
            {
                return NativePtr->armortype;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->armortype = value;
            }
        }
    }

    public float ArmorValue
    {
        get
        {
            unsafe
            {
                return NativePtr->armorvalue;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->armorvalue = value;
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

    private StringHandle? _target;
    public string Target
    {
        get
        {
            unsafe
            {
                _target ??= new StringHandle(NativePtr->target);
                return _target.ToString();
            }
        }
        set
        {
            unsafe
            {
                _target ??= new StringHandle(value);
                NativePtr->target.value = _target.ToHandle();
            }
        }
    }

    private StringHandle? _targetname;
    public string TargetName
    {
        get
        {
            unsafe
            {
                _targetname ??= new StringHandle(NativePtr->targetname);
                return _targetname.ToString();
            }
        }
        set
        {
            unsafe
            {
                _targetname ??= new StringHandle(value);
                NativePtr->targetname.value = _targetname.ToHandle();
            }
        }
    }

    private StringHandle? _netname;
    public string NetName
    {
        get
        {
            unsafe
            {
                _netname ??= new StringHandle(NativePtr->netname);
                return _netname.ToString();
            }
        }
        set
        {
            unsafe
            {
                _netname ??= new StringHandle(value);
                NativePtr->netname.value = _netname.ToHandle();
            }
        }
    }

    private StringHandle? _message;
    public string Message
    {
        get
        {
            unsafe
            {
                _message ??= new StringHandle(NativePtr->message);
                return _message.ToString();
            }
        }
        set
        {
            unsafe
            {
                _message ??= new StringHandle(value);
                NativePtr->message.value = _message.ToHandle();
            }
        }
    }

    public float DmgTake
    {
        get
        {
            unsafe
            {
                return NativePtr->dmg_take;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->dmg_take = value;
            }
        }
    }

    public float DmgSave
    {
        get
        {
            unsafe
            {
                return NativePtr->dmg_save;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->dmg_save = value;
            }
        }
    }

    public float Dmg
    {
        get
        {
            unsafe
            {
                return NativePtr->dmg;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->dmg = value;
            }
        }
    }

    public float DmgTime
    {
        get
        {
            unsafe
            {
                return NativePtr->dmgtime;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->dmgtime = value;
            }
        }
    }

    private StringHandle? _noise;
    public string Noise
    {
        get
        {
            unsafe
            {
                _noise ??= new StringHandle(NativePtr->noise);
                return _noise.ToString();
            }
        }
        set
        {
            unsafe
            {
                _noise ??= new StringHandle(value);
                NativePtr->noise.value = _noise.ToHandle();
            }
        }
    }

    private StringHandle? _noise1;
    public string Noise1
    {
        get
        {
            unsafe
            {
                _noise1 ??= new StringHandle(NativePtr->noise1);
                return _noise1.ToString();
            }
        }
        set
        {
            unsafe
            {
                _noise1 ??= new StringHandle(value);
                NativePtr->noise.value = _noise1.ToHandle();
            }
        }
    }

    private StringHandle? _noise2;
    public string Noise2
    {
        get
        {
            unsafe
            {
                _noise2 ??= new StringHandle(NativePtr->noise2);
                return _noise2.ToString();
            }
        }
        set
        {
            unsafe
            {
                _noise2 ??= new StringHandle(value);
                NativePtr->noise2.value = _noise2.ToHandle();
            }
        }
    }

    private StringHandle? _noise3;
    public string Noise3
    {
        get
        {
            unsafe
            {
                _noise3 ??= new StringHandle(NativePtr->noise3);
                return _noise3.ToString();
            }
        }
        set
        {
            unsafe
            {
                _noise3 ??= new StringHandle(value);
                NativePtr->noise3.value = _noise3.ToHandle();
            }
        }
    }


    public float Speed
    {
        get
        {
            unsafe
            {
                return NativePtr->speed;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->speed = value;
            }
        }
    }

    public float AirFinished
    {
        get
        {
            unsafe
            {
                return NativePtr->air_finished;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->air_finished = value;
            }
        }
    }

    public float PainFinished
    {
        get
        {
            unsafe
            {
                return NativePtr->pain_finished;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->pain_finished = value;
            }
        }
    }

    public float RadsuitFinished
    {
        get
        {
            unsafe
            {
                return NativePtr->radsuit_finished;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->radsuit_finished = value;
            }
        }
    }

    private Edict? _pContainingEntity;
    public Edict? PContainingEntity
    {
        get
        {
            unsafe
            {
                if (NativePtr->pContainingEntity == null)
                    return null;

                _pContainingEntity ??= new Edict(NativePtr->pContainingEntity);
                return _pContainingEntity;
            }
        }
        set
        {
            unsafe
            {
                if (value == null)
                    NativePtr->pContainingEntity = null;
                else
                    NativePtr->pContainingEntity = (NativeEdict*)value.GetPointer();
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

    public int Pushmsec
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

    public bool BInDuck
    {
        get
        {
            unsafe
            {
                return NativePtr->bInDuck != 0;
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

    public int FlSwimTime
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

    public int FlDuckTime
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

    public int GameState
    {
        get
        {
            unsafe
            {
                return NativePtr->gamestate;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->gamestate = value;
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

    public int GroupInfo
    {
        get
        {
            unsafe
            {
                return NativePtr->groupinfo;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->groupinfo = value;
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

    private Edict? _eUser1;
    public Edict? EUser1
    {
        get
        {
            unsafe
            {
                if (NativePtr->euser1 == null)
                    return null;

                _eUser1 ??= new Edict(NativePtr->euser1);
                return _eUser1;
            }
        }
        set
        {
            unsafe
            {
                if (value == null)
                    NativePtr->euser1 = null;
                else
                    NativePtr->euser1 = (NativeEdict*)value.GetPointer();
            }
        }
    }

    private Edict? _eUser2;
    public Edict? EUser2
    {
        get
        {
            unsafe
            {
                if (NativePtr->euser2 == null)
                    return null;

                _eUser2 ??= new Edict(NativePtr->euser2);
                return _eUser2;
            }
        }
        set
        {
            unsafe
            {
                if (value == null)
                    NativePtr->euser2 = null;
                else
                    NativePtr->euser2 = (NativeEdict*)value.GetPointer();
            }
        }
    }

    private Edict? _eUser3;
    public Edict? EUser3
    {
        get
        {
            unsafe
            {
                if (NativePtr->euser3 == null)
                    return null;

                _eUser3 ??= new Edict(NativePtr->euser3);
                return _eUser3;
            }
        }
        set
        {
            unsafe
            {
                if (value == null)
                    NativePtr->euser3 = null;
                else
                    NativePtr->euser3 = (NativeEdict*)value.GetPointer();
            }
        }
    }

    private Edict? _eUser4;
    public Edict? EUser4
    {
        get
        {
            unsafe
            {
                if (NativePtr->euser4 == null)
                    return null;

                _eUser4 ??= new Edict(NativePtr->euser4);
                return _eUser4;
            }
        }
        set
        {
            unsafe
            {
                if (value == null)
                    NativePtr->euser4 = null;
                else
                    NativePtr->euser4 = (NativeEdict*)value.GetPointer();
            }
        }
    }
}