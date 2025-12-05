using NuggetMod.Native.Common;
using System.Runtime.InteropServices;

namespace NuggetMod.Native.Engine.PM;
/// <summary>
/// native structure representing player movement data for physics calculations.
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct NativePlayerMove : INativeStruct
{
    internal int player_index;  // So we don't try to run the PM_CheckStuck nudging too quickly.
    internal int server;        // For debugging, are we running physics code on server side?

    internal int multiplayer;   // 1 == multiplayer server
    internal float time;          // realtime on host, for reckoning duck timing
    internal float frametime;       // Duration of this frame

    internal NativeVector3f forward, right, up; // Vectors for angles
                                                // player state
    internal NativeVector3f origin;        // Movement origin.
    internal NativeVector3f angles;        // Movement view angles.
    internal NativeVector3f oldangles;     // Angles before movement view angles were looked at.
    internal NativeVector3f velocity;      // Current movement direction.
    internal NativeVector3f movedir;       // For waterjumping, a forced forward velocity so we can fly over lip of ledge.
    internal NativeVector3f basevelocity;  // Velocity of the conveyor we are standing, e.g.

    // For ducking/dead
    internal NativeVector3f view_ofs;      // Our eye position.
    internal float flDuckTime;    // Time we started duck
    internal int bInDuck;       // In process of ducking or ducked already?

    // For walking/falling
    internal int flTimeStepSound;  // Next time we can play a step sound
    internal int iStepLeft;

    internal float flFallVelocity;
    internal NativeVector3f punchangle;

    internal float flSwimTime;

    internal float flNextPrimaryAttack;

    internal int effects;        // MUZZLE FLASH, e.g.

    internal int flags;         // FL_ONGROUND, FL_DUCKING, etc.
    internal int usehull;       // 0 = regular player hull, 1 = ducked player hull, 2 = point hull
    internal float gravity;       // Our current gravity and friction.
    internal float friction;
    internal int oldbuttons;    // Buttons last usercmd
    internal float waterjumptime; // Amount of time left in jumping out of water cycle.
    internal int dead;          // Are we a dead player?
    internal int deadflag;
    internal int spectator;     // Should we use spectator physics model?
    internal int movetype;      // Our movement type, NOCLIP, WALK, FLY

    internal int onground;
    internal int waterlevel;
    internal int watertype;
    internal int oldwaterlevel;

    internal unsafe fixed byte sztexturename[256];
    internal byte chtexturetype;

    internal float maxspeed;
    internal float clientmaxspeed; // Player specific maxspeed

    // For mods
    internal int iuser1;
    internal int iuser2;
    internal int iuser3;
    internal int iuser4;
    internal float fuser1;
    internal float fuser2;
    internal float fuser3;
    internal float fuser4;
    internal NativeVector3f vuser1;
    internal NativeVector3f vuser2;
    internal NativeVector3f vuser3;
    internal NativeVector3f vuser4;
    // world state
    // Number of entities to clip against.
    internal int numphysent;

    //TODO: FUCK ME
    //internal unsafe fixed NativePhySent physents[64];
    //// Number of momvement entities (ladders)
    //internal int nummoveent;
    //// just a list of ladders
    //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    //internal NativePhySent[] moveents;

    //// All things being rendered, for tracing against things you don't actually collide with
    //internal int numvisent;
    //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    //internal NativePhySent[] visents;

    //// input to run through physics.
    //NativeUserCmd cmd;

    //// Trace results for objects we collided with.
    //int numtouch;
    //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    //NativePMTrace[] touchindex;

    //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
    //byte[] physinfo; // Physics info string

    //nint movevars;
    //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    //NativeVector3f[] player_mins;
    //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    //NativeVector3f[] player_maxs;

    // Common functions
    //TODO: Implement these
    //const char*(*PM_Info_ValueForKey) ( const char* s, const char* key );
    //void (* PM_Particle) (float* origin, int color, float life, int zpos, int zvel);
    //int (* PM_TestPlayerPosition) (float* pos, pmtrace_t* ptrace);
    //void (* Con_NPrintf) (int idx, char* fmt, ... );
    //void (* Con_DPrintf) (char* fmt, ... );
    //void (* Con_Printf) (char* fmt, ... );
    //double (* Sys_FloatTime) (void );
    //void (* PM_StuckTouch) (int hitent, pmtrace_t* ptraceresult);
    //int (* PM_PointContents) (float* p, int* truecontents /*filled in if this is non-null*/ );
    //int (* PM_TruePointContents) (float* p);
    //int (* PM_HullPointContents) ( struct hull_s *hull, int num, float* p);
    //pmtrace_t(*PM_PlayerTrace) (float* start, float* end, int traceFlags, int ignore_pe);
    //struct pmtrace_s *(* PM_TraceLine) (float* start, float* end, int flags, int usehulll, int ignore_pe);
    //long (* RandomLong) (long lLow, long lHigh);
    //float (* RandomFloat) (float flLow, float flHigh);
    //int (* PM_GetModelType) ( struct model_s *mod );
    //void (* PM_GetModelBounds) ( struct model_s *mod, float* mins, float* maxs );
    //void* (* PM_HullForBsp) (physent_t* pe, float* offset);
    //float (* PM_TraceModel) (physent_t* pEnt, float* start, float* end, trace_t* trace);
    //int (* COM_FileSize) (char* filename);
    //byte* (* COM_LoadFile) (char* path, int usehunk, int* pLength);
    //void (* COM_FreeFile) (void* buffer );
    //char* (* memfgets) (byte* pMemFile, int fileSize, int* pFilePos, char* pBuffer, int bufferSize);
    //
    //// Functions
    //// Run functions for this frame?
    //qboolean runfuncs;
    //void (* PM_PlaySound) (int channel, const char* sample, float volume, float attenuation, int fFlags, int pitch );
    //const char*(*PM_TraceTexture) (int ground, float* vstart, float* vend);
    //void (* PM_PlaybackEventFull) (int flags, int clientindex, unsigned short eventindex, float delay, float* origin, float* angles, float fparam1, float fparam2, int iparam1, int iparam2, int bparam1, int bparam2 );
    //
    //pmtrace_t(*PM_PlayerTraceEx) (float* start, float* end, int traceFlags, int (* pfnIgnore) (physent_t* pe ) );
    //int (* PM_TestPlayerPositionEx) (float* pos, pmtrace_t* ptrace, int (* pfnIgnore) (physent_t* pe ) );
    //struct pmtrace_s *(* PM_TraceLineEx) (float* start, float* end, int flags, int usehulll, int (* pfnIgnore) (physent_t* pe ) );

}
