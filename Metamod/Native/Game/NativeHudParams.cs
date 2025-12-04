using System.Runtime.InteropServices;

namespace Metamod.Native.Game;

[StructLayout(LayoutKind.Sequential)]
public struct NativeHudParams : INativeStruct
{
    internal float x;           // x-coordinate for the HUD text
    internal float y;           // y-coordinate for the HUD text
    internal int effect;        // Effect type (e.g., fade in/out, pulsate, etc.)

    // Color and alpha values for the first color
    internal byte r1;
    internal byte g1;
    internal byte b1;
    internal byte a1;

    // Color and alpha values for the second color
    internal byte r2;
    internal byte g2;
    internal byte b2;
    internal byte a2;

    internal float fadeinTime;  // Time to fade in
    internal float fadeoutTime; // Time to fade out
    internal float holdTime;    // Time to hold the text on screen
    internal float fxTime;      // Time for special effects
    internal int channel;       // Channel for the HUD text
};