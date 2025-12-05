using Metamod.Native.Game;
using Metamod.Wrapper.Common;
using Metamod.Wrapper.Engine;
using Metamod.Wrapper.Engine.PM;
using System.Runtime.InteropServices;

namespace Metamod.Wrapper.Game;

public class DLLFunctions(nint ptr) : BaseFunctionWrapper<NativeDllFuncs>(ptr)
{
    // Initialize/shutdown the game (one-time call after loading of game .dll )
    public void GameInit() => Base.pfnGameInit();
    public int Spawn(Edict pent) => Base.pfnSpawn(pent.GetPointer());
    public void Think(Edict pent) => Base.pfnThink(pent.GetPointer());
    public void Use(Edict pentUsed, Edict pentOther) => Base.pfnUse(pentUsed.GetPointer(), pentOther.GetPointer());
    public void Touch(Edict pentTouched, Edict pentOther) => Base.pfnTouch(pentTouched.GetPointer(), pentOther.GetPointer());
    public void Blocked(Edict pentBlocked, Edict pentOther) => Base.pfnBlocked(pentBlocked.GetPointer(), pentOther.GetPointer());
    public void KeyValue(Edict pentKeyvalue, KeyValueData pkvd) => Base.pfnKeyValue(pentKeyvalue.GetPointer(), pkvd.GetPointer());

    public void Save(Edict pent, nint pSaveData) => Base.pfnSave(pent.GetPointer(), pSaveData);
    public int Restore(Edict pent, nint pSaveData, int globalEntity) => Base.pfnRestore(pent.GetPointer(), pSaveData, globalEntity);
    public void SetAbsBox(Edict pent) => Base.pfnSetAbsBox(pent.GetPointer());
    public void SveWriteFields(nint a, nint b, nint c, nint d, int max) => Base.pfnSaveWriteFields(a, b, c, d, max);
    public void SaveReadFields(nint a, nint b, nint c, nint d, int max) => Base.pfnSaveReadFields(a, b, c, d, max);
    public void SaveGlobalState(nint pSaveData) => Base.pfnSaveGlobalState(pSaveData);
    public void RestoreGlobalState(nint pSaveData) => Base.pfnRestoreGlobalState(pSaveData);
    public void ResetGlobalState() => Base.pfnResetGlobalState();
    public bool ClientConnect(Edict pEntity, string pszName, string pszAddress, ref string szRejectReason)
    {
        nint ns1 = Marshal.StringToHGlobalAnsi(pszName);
        nint ns2 = Marshal.StringToHGlobalAnsi(pszAddress);
        nint ns3 = Marshal.AllocHGlobal(128 * sizeof(byte));
        for (int i = 0; i < Math.Min(szRejectReason.Length, 128); i++)
        {
            Marshal.WriteByte(ns3, i, (byte)szRejectReason[i]);
        }
        bool res = Base.pfnClientConnect(pEntity.GetPointer(), ns1, ns2, ns3) == 1;
        szRejectReason = Marshal.PtrToStringUTF8(ns3) ?? string.Empty;
        Marshal.FreeHGlobal(ns3);
        Marshal.FreeHGlobal(ns2);
        Marshal.FreeHGlobal(ns1);
        return res;
    }
    public void ClientDisconnect(Edict pEntity) => Base.pfnClientDisconnect(pEntity.GetPointer());
    public void ClientKill(Edict pEntity) => Base.pfnClientKill(pEntity.GetPointer());
    public void ClientPutInServer(Edict pEntity) => Base.pfnClientPutInServer(pEntity.GetPointer());
    public void ClientCommand(Edict pEntity) => Base.pfnClientCommand(pEntity.GetPointer());
    public void ClientUserInfoChanged(Edict pEntity, ref string infobuffer)
    {
        nint ns = Marshal.StringToHGlobalAnsi(infobuffer);
        Base.pfnClientUserInfoChanged(pEntity.GetPointer(), ns);
        infobuffer = Marshal.PtrToStringUTF8(ns) ?? string.Empty;
        Marshal.FreeHGlobal(ns);
    }

    public void ServerActivate(Edict pEdictList, int edictCount, int clientMax) => Base.pfnServerActivate(pEdictList.GetPointer(), edictCount, clientMax);
    public void ServerDeactivate() => Base.pfnServerDeactivate();

    public void PlayerPreThink(Edict pEntity) => Base.pfnPlayerPreThink(pEntity.GetPointer());
    public void PlayerPostThink(Edict pEntity) => Base.pfnPlayerPostThink(pEntity.GetPointer());

    public void StartFrame() => Base.pfnStartFrame();
    public void ParmsNewLevel() => Base.pfnParmsNewLevel();
    public void ParmsChangeLevel() => Base.pfnParmsChangeLevel();

    // Returns string describing current .dll.  E.g., TeamFotrress 2, Half-Life
    public string GetGameDescription()
    {
        nint ptr = Base.pfnGetGameDescription();
        return Marshal.PtrToStringUTF8(ptr) ?? string.Empty;
    }

    // Notify dll about a player customization.
    public void PlayerCustomization(Edict pEntity, Customization pCustom) => Base.pfnPlayerCustomization(pEntity.GetPointer(), pCustom.GetPointer());

    // Spectator funcs
    public void SpectatorConnect(Edict pEntity) => Base.pfnSpectatorConnect(pEntity.GetPointer());
    public void SpectatorDisconnect(Edict pEntity) => Base.pfnSpectatorDisconnect(pEntity.GetPointer());
    public void SpectatorThink(Edict pEntity) => Base.pfnSpectatorThink(pEntity.GetPointer());

    // Notify game .dll that engine is going to shut down.  Allows mod authors to set a breakpoint.
    public void SysError(string error_string)
    {
        nint ns = Marshal.StringToHGlobalAnsi(error_string);
        Base.pfnSysError(ns);
        Marshal.FreeHGlobal(ns);
    }

    public void PMMove(PlayerMove pm, bool server) => Base.pfnPMMove(pm.GetPointer(), server ? 1 : 0);
    public void PMInit(PlayerMove pm) => Base.pfnPMInit(pm.GetPointer());

    public int PMFindTextureType(string name)
    {
        nint ns = Marshal.StringToHGlobalAnsi(name);
        int res = Base.pfnPMFindTextureType(ns);
        Marshal.FreeHGlobal(ns);
        return res;
    }

    public void SetupVisibility(Edict pViewEntity, Edict pClient, ref byte[] pvs, ref byte[] pas)
    {
        unsafe
        {
            fixed (byte* ppvs = pvs)
            {
                fixed (byte* ppas = pas)
                {
                    Base.pfnSetupVisibility(pViewEntity.GetPointer(), pClient.GetPointer(), (nint)(&ppvs), (nint)(&ppas));
                }
            }
        }
    }

    public void UpdateClientData(Edict ent, int sendweapons, ClientData cd) => Base.pfnUpdateClientData(ent.GetPointer(), sendweapons, cd.GetPointer());
    public int AddToFullPack(EntityState state, int e, Edict ent, Edict host, int hostflags, int player, byte[] pSet)
    {
        int res = 0;
        unsafe
        {
            fixed (byte* ppSet = pSet)
            {
                res = Base.pfnAddToFullPack(state.GetPointer(), e, ent.GetPointer(), host.GetPointer(), hostflags, player, (nint)ppSet);
            }
        }
        return res;
    }

    public void CreateBaseline(int player, int eindex, EntityState baseline, Edict entity, int playermodelindex, Vector3f player_mins, Vector3f player_maxs) => Base.pfnCreateBaseline(player, eindex, baseline.GetPointer(), entity.GetPointer(), playermodelindex, player_mins.GetPointer(), player_maxs.GetPointer());
    public void RegisterEncoders() => Base.pfnRegisterEncoders();
    public int GetWeaponData(Edict player, WeaponData info) => Base.pfnGetWeaponData(player.GetPointer(), info.GetPointer());
    public void CmdStart(Edict plyer, UserCmd cmd, uint random_seed) => Base.pfnCmdStart(plyer.GetPointer(), cmd.GetPointer(), random_seed);
    public void CmdEnd(Edict plyer) => Base.pfnCmdEnd(plyer.GetPointer());

    // Return 1 if the packet is valid.  Set response_buffer_size if you want to send a response packet.  Incoming, it holds the max
    //  size of the response_buffer, so you must zero it out if you choose not to respond.
    public int ConnectionlessPacket(NetAdr net_from, string args, ref string response_buffer, ref int response_buffer_size)
    {
        nint ns1 = Marshal.StringToHGlobalAnsi(args);
        nint ns2 = Marshal.AllocHGlobal(response_buffer_size);
        nint ni = Marshal.AllocHGlobal(sizeof(int));
        int res = Base.pfnConnectionlessPacket(net_from.GetPointer(), ns1, ns2, ni);
        response_buffer = Marshal.PtrToStringUTF8(ns2) ?? string.Empty;
        response_buffer_size = Marshal.ReadInt32(ni);
        Marshal.FreeHGlobal(ni);
        Marshal.FreeHGlobal(ns2);
        Marshal.FreeHGlobal(ns1);
        return res;
    }

    // Enumerates player hulls.  Returns 0 if the hull number doesn't exist, 1 otherwise
    public int GetHullBounds(int hullnumber, ref Vector3f mins, ref Vector3f maxs) => Base.pfnGetHullBounds(hullnumber, mins.GetPointer(), maxs.GetPointer());

    // Create baselines for certain "unplaced" items.
    public void CreateInstancedBaselines() => Base.pfnCreateInstancedBaselines();

    // One of the pfnForceUnmodified files failed the consistency check for the specified player
    // Return 0 to allow the client to continue, 1 to force immediate disconnection ( with an optional disconnect message of up to 256 characters )
    public int InconsistentFile(Edict player, string filename, ref string disconnect_message)
    {
        nint ns1 = Marshal.StringToHGlobalAnsi(filename);
        nint ns2 = Marshal.AllocHGlobal(256 * sizeof(byte));
        for (int i = 0; i < Math.Min(disconnect_message.Length, 256); i++)
        {
            Marshal.WriteByte(ns2, i, (byte)disconnect_message[i]);
        }
        int res = Base.pfnInconsistentFile(player.GetPointer(), ns1, ns2);
        disconnect_message = Marshal.PtrToStringUTF8(ns2) ?? string.Empty;
        Marshal.FreeHGlobal(ns2);
        Marshal.FreeHGlobal(ns1);
        return res;
    }

    // The game .dll should return 1 if lag compensation should be allowed ( could also just set
    //  the sv_unlag cvar.
    // Most games right now should return 0, until client-side weapon prediction code is written
    //  and tested for them.
    int AllowLagCompensation() => Base.pfnAllowLagCompensation();
}
