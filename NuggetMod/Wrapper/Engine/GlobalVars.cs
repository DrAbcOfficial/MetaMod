using NuggetMod.Helper;
using NuggetMod.Native.Engine;
using NuggetMod.Wrapper.Common;

namespace NuggetMod.Wrapper.Engine;

/// <summary>
/// Represents global variables shared between the engine and game DLL
/// </summary>
public class GlobalVars : BaseNativeWrapper<NativeGlobalVars>
{
    /// <summary>
    /// Initializes a new instance with default values
    /// </summary>
    public GlobalVars() : base() { }

    internal unsafe GlobalVars(nint nativePtr) : this((NativeGlobalVars*)nativePtr) { }
    internal unsafe GlobalVars(NativeGlobalVars* nativePtr, bool ownsPointer = false)
        : base(nativePtr, ownsPointer) { }

    /// <summary>
    /// Gets or sets the current game time in seconds
    /// </summary>
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

    /// <summary>
    /// Gets or sets the duration of the current frame in seconds
    /// </summary>
    public float Frametime
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

    public float ForceRetouch
    {
        get
        {
            unsafe
            {
                return NativePtr->force_retouch;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->force_retouch = value;
            }
        }
    }

    private StringHandle? _mapname;
    public string MapName
    {
        get
        {
            unsafe
            {
                _mapname ??= new StringHandle(NativePtr->mapname);
                return _mapname.ToString();
            }
        }
        set
        {
            unsafe
            {
                _mapname ??= new StringHandle(value);
                NativePtr->mapname.value = _mapname.ToHandle();
            }
        }
    }

    private StringHandle? _startspot;
    public string StartSpot
    {
        get
        {
            unsafe
            {
                _startspot ??= new StringHandle(NativePtr->startspot);
                return _startspot.ToString();
            }
        }
        set
        {
            unsafe
            {
                _startspot ??= new StringHandle(value);
                NativePtr->startspot.value = _startspot.ToHandle();
            }
        }
    }

    public float Deathmatch
    {
        get
        {
            unsafe
            {
                return NativePtr->deathmatch;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->deathmatch = value;
            }
        }
    }

    public float Coop
    {
        get
        {
            unsafe
            {
                return NativePtr->coop;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->coop = value;
            }
        }
    }

    public float Teamplay
    {
        get
        {
            unsafe
            {
                return NativePtr->teamplay;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->teamplay = value;
            }
        }
    }

    public float Serverflags
    {
        get
        {
            unsafe
            {
                return NativePtr->serverflags;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->serverflags = value;
            }
        }
    }

    public float FoundSecrets
    {
        get
        {
            unsafe
            {
                return NativePtr->found_secrets;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->found_secrets = value;
            }
        }
    }

    private Vector3f? _vForward;
    public Vector3f VForward
    {
        get
        {
            unsafe
            {
                _vForward ??= new Vector3f(&NativePtr->v_forward);
                return _vForward;
            }
        }
    }

    private Vector3f? _vUp;
    public Vector3f VUp
    {
        get
        {
            unsafe
            {
                _vUp ??= new Vector3f(&NativePtr->v_up);
                return _vUp;
            }
        }
    }

    private Vector3f? _vRight;
    public Vector3f VRight
    {
        get
        {
            unsafe
            {
                _vRight ??= new Vector3f(&NativePtr->v_right);
                return _vRight;
            }
        }
    }

    public float TraceAllSolid
    {
        get
        {
            unsafe
            {
                return NativePtr->trace_allsolid;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->trace_allsolid = value;
            }
        }
    }

    public float TraceStartSolid
    {
        get
        {
            unsafe
            {
                return NativePtr->trace_startsolid;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->trace_startsolid = value;
            }
        }
    }

    public float TraceFraction
    {
        get
        {
            unsafe
            {
                return NativePtr->trace_fraction;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->trace_fraction = value;
            }
        }
    }

    private Vector3f? _traceEndPos;
    public Vector3f TraceEndPos
    {
        get
        {
            unsafe
            {
                _traceEndPos ??= new Vector3f(&NativePtr->trace_endpos);
                return _traceEndPos;
            }
        }
    }

    private Vector3f? _tracePlaneNormal;
    public Vector3f TracePlaneNormal
    {
        get
        {
            unsafe
            {
                _tracePlaneNormal ??= new Vector3f(&NativePtr->trace_plane_normal);
                return _tracePlaneNormal;
            }
        }
    }

    public float TracePlaneDist
    {
        get
        {
            unsafe
            {
                return NativePtr->trace_plane_dist;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->trace_plane_dist = value;
            }
        }
    }

    public nint TraceEnt
    {
        get
        {
            unsafe
            {
                return NativePtr->trace_ent;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->trace_ent = value;
            }
        }
    }

    public float TraceInOpen
    {
        get
        {
            unsafe
            {
                return NativePtr->trace_inopen;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->trace_inopen = value;
            }
        }
    }

    public float TraceInWater
    {
        get
        {
            unsafe
            {
                return NativePtr->trace_inwater;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->trace_inwater = value;
            }
        }
    }

    public int TraceHitgroup
    {
        get
        {
            unsafe
            {
                return NativePtr->trace_hitgroup;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->trace_hitgroup = value;
            }
        }
    }

    public int TraceFlags
    {
        get
        {
            unsafe
            {
                return NativePtr->trace_flags;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->trace_flags = value;
            }
        }
    }

    public int MsgEntity
    {
        get
        {
            unsafe
            {
                return NativePtr->msg_entity;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->msg_entity = value;
            }
        }
    }

    public int CdAudioTrack
    {
        get
        {
            unsafe
            {
                return NativePtr->cdAudioTrack;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->cdAudioTrack = value;
            }
        }
    }

    public int MaxClients
    {
        get
        {
            unsafe
            {
                return NativePtr->maxClients;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->maxClients = value;
            }
        }
    }

    public int MaxEntities
    {
        get
        {
            unsafe
            {
                return NativePtr->maxEntities;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->maxEntities = value;
            }
        }
    }

    public nint StringBase
    {
        get
        {
            unsafe
            {
                return NativePtr->pStringBase;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->pStringBase = value;
            }
        }
    }

    public nint SaveData
    {
        get
        {
            unsafe
            {
                return NativePtr->pSaveData;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->pSaveData = value;
            }
        }
    }

    private Vector3f? _vecLandmarkOffset;
    public Vector3f VecLandmarkOffset
    {
        get
        {
            unsafe
            {
                _vecLandmarkOffset ??= new Vector3f(&NativePtr->vecLandmarkOffset);
                return _vecLandmarkOffset;
            }
        }
    }
}