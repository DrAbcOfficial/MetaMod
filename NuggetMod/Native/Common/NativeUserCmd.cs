using System.Runtime.InteropServices;

namespace NuggetMod.Native.Common;

[StructLayout(LayoutKind.Sequential)]
public struct NativeUserCmd : INativeStruct
{
    internal short lerp_msec;      // Interpolation time on client
    internal byte msec;           // Duration in ms of command
    internal NativeVector3f viewangles;     // Command view angles.

    // intended velocities
    internal float forwardmove;    // Forward velocity.
    internal float sidemove;       // Sideways velocity.
    internal float upmove;         // Upward velocity.
    internal byte lightlevel;     // Light level at spot where we are standing.
    internal ushort buttons;  // Attack buttons
    internal byte impulse;          // Impulse command issued.
    internal byte weaponselect;  // Current weapon id

    // Experimental player impact stuff.
    internal int impact_index;
    internal NativeVector3f impact_position;
}
