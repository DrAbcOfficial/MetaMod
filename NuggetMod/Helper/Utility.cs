using NuggetMod.Interface;
using NuggetMod.Wrapper.Engine;

namespace NuggetMod.Helper;

/// <summary>
/// utility helper functions
/// </summary>
public class Utility
{
    /// <summary>
    /// get all player list
    /// </summary>
    /// <returns>player list</returns>
    public static List<Edict> GetAllPlayers()
    {
        List<Edict> edicts = [];
        for (int i = 1; i <= 33; i++)
        {
            var edict = MetaMod.EngineFuncs.PEntityOfEntIndex(i);
            if (edict != null)
            {
                edicts.Add(edict);
            }
        }
        return edicts;
    }
}
