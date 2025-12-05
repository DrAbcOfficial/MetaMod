using NuggetMod.Native.Game;
using NuggetMod.Wrapper.Engine;
using System.Runtime.InteropServices;

namespace NuggetMod.Wrapper.Game;

/// <summary>
/// Wrapper for new DLL functions (extended game DLL API)
/// </summary>
public class NewDLLFunctions(nint ptr) : BaseFunctionWrapper<NativeNewDllFuncs>(ptr)
{
    /// <summary>
    /// Called right before the object's memory is freed. Calls its destructor.
    /// </summary>
    /// <param name="pEnt">Entity being freed</param>
    public void OnFreeEntPrivateData(Edict pEnt)
    {
        if (Base.pfnOnFreeEntPrivateData == null)
        {
            throw new NullReferenceException($"{nameof(Base.pfnOnFreeEntPrivateData)} is null"!);
        }
        Base.pfnOnFreeEntPrivateData(pEnt.GetPointer());
    }
    
    /// <summary>
    /// Called when the game is shutting down
    /// </summary>
    public void GameShutdown()
    {
        if (Base.pfnGameShutdown == null)
        {
            throw new NullReferenceException($"{nameof(Base.pfnGameShutdown)} is null"!);
        }
        Base.pfnGameShutdown();
    }
    public int ShouldCollide(Edict pentTouched, Edict pentOther)
    {
        if (Base.pfnShouldCollide == null)
        {
            throw new NullReferenceException($"{nameof(Base.pfnShouldCollide)} is null"!);
        }
        return Base.pfnShouldCollide(pentTouched.GetPointer(), pentOther.GetPointer());
    }
    // Added 2005/08/11 (no SDK update):
    public void CvarValue(Edict pEnt, string value)
    {
        if (Base.pfnCvarValue == null)
        {
            throw new NullReferenceException($"{nameof(Base.pfnCvarValue)} is null"!);
        }
        nint ns = Marshal.StringToHGlobalAnsi(value);
        Base.pfnCvarValue(pEnt.GetPointer(), ns);
        Marshal.FreeHGlobal(ns);
    }
    // Added 2005/11/21 (no SDK update):
    //    value is "Bad CVAR request" on failure (i.e that user is not connected or the cvar does not exist).
    //    value is "Bad Player" if invalid player edict.
    public void CvarValue2(Edict pEnt, int requestID, string cvarName, string value)
    {
        if (Base.pfnCvarValue2 == null)
        {
            throw new NullReferenceException($"{nameof(Base.pfnCvarValue2)} is null"!);
        }
        nint ns1 = Marshal.StringToHGlobalAnsi(cvarName);
        nint ns2 = Marshal.StringToHGlobalAnsi(value);
        Base.pfnCvarValue2(pEnt.GetPointer(), requestID, ns1, ns2);
        Marshal.FreeHGlobal(ns1);
        Marshal.FreeHGlobal(ns2);
    }
}
