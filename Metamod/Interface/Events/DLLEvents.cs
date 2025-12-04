using Metamod.Enum.Metamod;
using Metamod.Wrapper.Common;
using Metamod.Wrapper.Engine;
using Metamod.Wrapper.Engine.PM;

namespace Metamod.Interface.Events;

#region delegates
#region dll functions
public delegate MetaResult GameInitDelegate();
public delegate (MetaResult, int) SpawnDelegate(Edict pent);
public delegate MetaResult ThinkDelegate(Edict pent);
public delegate MetaResult UseDelegate(Edict pentUsed, Edict pentOther);
public delegate MetaResult TouchDelegate(Edict pentTouched, Edict pentOther);
public delegate MetaResult BlockedDelegate(Edict pentBlocked, Edict pentOther);
public delegate MetaResult KeyValueDelegate(Edict pentKeyvalue, KeyValueData pkvd);
public delegate MetaResult SaveDelegate(Edict pent, nint pSaveData);
public delegate (MetaResult, int) RestoreDelegate(Edict pent, nint pSaveData, int globalEntity);
public delegate MetaResult SetAbsBoxDelegate(Edict pent);
public delegate MetaResult SaveWriteFieldsDelegate(nint a, nint b, nint c, nint d, int max);
public delegate MetaResult SaveReadFieldsDelegate(nint a, nint b, nint c, nint d, int max);
public delegate MetaResult SaveGlobalStateDelegate(nint pSaveData);
public delegate MetaResult RestoreGlobalStateDelegate(nint pSaveData);
public delegate MetaResult ResetGlobalStateDelegate();
public delegate (MetaResult, bool) ClientConnectDelegate(Edict pEntity, string pszName, string pszAddress, ref string szRejectReason);
public delegate MetaResult ClientDisconnectDelegate(Edict pEntity);
public delegate MetaResult ClientKillDelegate(Edict pEntity);
public delegate MetaResult ClientPutInServerDelegate(Edict pEntity);
public delegate MetaResult DllClientCommandDelegate(Edict pEntity);
public delegate MetaResult ClientUserInfoChangedDelegate(Edict pEntity, ref string infobuffer);
public delegate MetaResult ServerActivateDelegate(Edict pEdictList, int edictCount, int clientMax);
public delegate MetaResult ServerDeactivateDelegate();
public delegate MetaResult PlayerPreThinkDelegate(Edict pEntity);
public delegate MetaResult PlayerPostThinkDelegate(Edict pEntity);
public delegate MetaResult StartFrameDelegate();
public delegate MetaResult ParmsNewLevelDelegate();
public delegate MetaResult ParmsChangeLevelDelegate();
public delegate (MetaResult, string) GetGameDescriptionDelegate();
public delegate MetaResult PlayerCustomizationDelegate(Edict pEntity, Customization pCustom);
public delegate MetaResult SpectatorConnectDelegate(Edict pEntity);
public delegate MetaResult SpectatorDisconnectDelegate(Edict pEntity);
public delegate MetaResult SpectatorThinkDelegate(Edict pEntity);
public delegate MetaResult SysErrorDelegate(string error_string);
public delegate MetaResult PMMoveDelegate(PlayerMove pm, bool server);
public delegate MetaResult PMInitDelegate(PlayerMove pm);
public delegate MetaResult PMFindTextureTypeDelegate(string name);
public delegate MetaResult SetupVisibilityDelegate(Edict pViewEntity, Edict pClient, ref byte[] pvs, ref byte[] pas);
public delegate MetaResult UpdateClientDataDelegate(Edict ent, int sendweapons, ClientData cd);
public delegate (MetaResult, int) AddToFullPackDelegate(EntityState state, int e, Edict ent, Edict host, int hostflags, int player, byte[] pSet);
public delegate MetaResult CreateBaselineDelegate(int player, int eindex, EntityState baseline, Edict entity, int playermodelindex, Vector3f player_mins, Vector3f player_maxs);
public delegate MetaResult RegisterEncodersDelegate();
public delegate (MetaResult, int) GetWeaponDataDelegate(Edict player, WeaponData info);
public delegate MetaResult CmdStartDelegate(Edict plyer, UserCmd cmd, uint random_seed);
public delegate MetaResult CmdEndDelegate(Edict plyer);
public delegate (MetaResult, int) ConnectionlessPacketDelegate(NetAdr net_from, string args, ref string response_buffer, ref int response_buffer_size);
public delegate (MetaResult, int) GetHullBoundsDelegate(int hullnumber, ref Vector3f mins, ref Vector3f maxs);
public delegate MetaResult CreateInstancedBaselinesDelegate();
public delegate (MetaResult, int) InconsistentFileDelegate(Edict player, string filename, ref string disconnect_message);
public delegate (MetaResult, int) AllowLagCompensationDelegate();
#endregion
#endregion

public class DLLEvents
{
    #region Events
    public event GameInitDelegate? GameInit;
    public event SpawnDelegate? Spawn;
    public event ThinkDelegate? Think;
    public event UseDelegate? Use;
    public event TouchDelegate? Touch;
    public event BlockedDelegate? Blocked;
    public event KeyValueDelegate? KeyValue;
    public event SaveDelegate? Save;
    public event RestoreDelegate? Restore;
    public event SetAbsBoxDelegate? SetAbsBox;
    public event SaveWriteFieldsDelegate? SaveWriteFields;
    public event SaveReadFieldsDelegate? SaveReadFields;
    public event SaveGlobalStateDelegate? SaveGlobalState;
    public event RestoreGlobalStateDelegate? RestoreGlobalState;
    public event ResetGlobalStateDelegate? ResetGlobalState;
    public event ClientConnectDelegate? ClientConnect;
    public event ClientDisconnectDelegate? ClientDisconnect;
    public event ClientKillDelegate? ClientKill;
    public event ClientPutInServerDelegate? ClientPutInServer;
    public event DllClientCommandDelegate? ClientCommand;
    public event ClientUserInfoChangedDelegate? ClientUserInfoChanged;
    public event ServerActivateDelegate? ServerActivate;
    public event ServerDeactivateDelegate? ServerDeactivate;
    public event PlayerPreThinkDelegate? PlayerPreThink;
    public event PlayerPostThinkDelegate? PlayerPostThink;
    public event StartFrameDelegate? StartFrame;
    public event ParmsNewLevelDelegate? ParmsNewLevel;
    public event ParmsChangeLevelDelegate? ParmsChangeLevel;
    public event GetGameDescriptionDelegate? GetGameDescription;
    public event PlayerCustomizationDelegate? PlayerCustomization;
    public event SpectatorConnectDelegate? SpectatorConnect;
    public event SpectatorDisconnectDelegate? SpectatorDisconnect;
    public event SpectatorThinkDelegate? SpectatorThink;
    public event SysErrorDelegate? SysError;
    public event PMMoveDelegate? PM_Move;
    public event PMInitDelegate? PM_Init;
    public event PMFindTextureTypeDelegate? PM_FindTextureType;
    public event SetupVisibilityDelegate? SetupVisibility;
    public event UpdateClientDataDelegate? UpdateClientData;
    public event AddToFullPackDelegate? AddToFullPack;
    public event CreateBaselineDelegate? CreateBaseline;
    public event RegisterEncodersDelegate? RegisterEncoders;
    public event GetWeaponDataDelegate? GetWeaponData;
    public event CmdStartDelegate? CmdStart;
    public event CmdEndDelegate? CmdEnd;
    public event ConnectionlessPacketDelegate? ConnectionlessPacket;
    public event GetHullBoundsDelegate? GetHullBounds;
    public event CreateInstancedBaselinesDelegate? CreateInstancedBaselines;
    public event InconsistentFileDelegate? InconsistentFile;
    public event AllowLagCompensationDelegate? AllowLagCompensation;
    #endregion
    #region Invoker
    internal void InvokeGameInit()
    {
        var result = GameInit?.Invoke();
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal int InvokeSpawn(Edict pent)
    {
        var result = Spawn?.Invoke(pent);
        if (result == null)
        {
            MetaMod.MetaGlobals.Result = MetaResult.MRES_IGNORED;
            return 0;
        }
        else
        {
            MetaMod.MetaGlobals.Result = result.Value.Item1;
            return result.Value.Item2;
        }
    }
    internal void InvokeThink(Edict pent)
    {
        var result = Think?.Invoke(pent);
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal void InvokeUse(Edict pentUsed, Edict pentOther)
    {
        var result = Use?.Invoke(pentUsed, pentOther);
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal void InvokeTouch(Edict pentTouched, Edict pentOther)
    {
        var result = Touch?.Invoke(pentTouched, pentOther);
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal void InvokeBlocked(Edict pentBlocked, Edict pentOther)
    {
        var result = Blocked?.Invoke(pentBlocked, pentOther);
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal void InvokeKeyValue(Edict pentKeyvalue, KeyValueData pkvd)
    {
        var result = KeyValue?.Invoke(pentKeyvalue, pkvd);
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal void InvokeSave(Edict pent, nint pSaveData)
    {
        var result = Save?.Invoke(pent, pSaveData);
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal int InvokeRestore(Edict pent, nint pSaveData, int globalEntity)
    {
        var result = Restore?.Invoke(pent, pSaveData, globalEntity);
        if (result == null)
        {
            MetaMod.MetaGlobals.Result = MetaResult.MRES_IGNORED;
            return 1;
        }
        else
        {
            MetaMod.MetaGlobals.Result = result.Value.Item1;
            return result.Value.Item2;
        }
    }
    internal void InvokeSetAbsBox(Edict pent)
    {
        var result = SetAbsBox?.Invoke(pent);
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal void InvokeSaveWriteFields(nint a, nint b, nint c, nint d, int max)
    {
        var result = SaveWriteFields?.Invoke(a, b, c, d, max);
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal void InvokeSaveReadFields(nint a, nint b, nint c, nint d, int max)
    {
        var result = SaveReadFields?.Invoke(a, b, c, d, max);
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal void InvokeSaveGlobalState(nint pSaveData)
    {
        var result = SaveGlobalState?.Invoke(pSaveData);
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal void InvokeRestoreGlobalState(nint pSaveData)
    {
        var result = RestoreGlobalState?.Invoke(pSaveData);
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal void InvokeResetGlobalState()
    {
        var result = ResetGlobalState?.Invoke();
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal bool InvokeClientConnect(Edict pEntity, string pszName, string pszAddress, ref string szRejectReason)
    {
        var result = ClientConnect?.Invoke(pEntity, pszName, pszAddress, ref szRejectReason);
        if (result == null)
        {
            MetaMod.MetaGlobals.Result = MetaResult.MRES_IGNORED;
            return true;
        }
        else
        {
            MetaMod.MetaGlobals.Result = result.Value.Item1;
            return result.Value.Item2;
        }
    }
    internal void InvokeClientDisconnect(Edict pEntity)
    {
        var result = ClientDisconnect?.Invoke(pEntity);
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal void InvokeClientKill(Edict pEntity)
    {
        var result = ClientKill?.Invoke(pEntity);
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal void InvokeClientPutInServer(Edict pEntity)
    {
        var result = ClientPutInServer?.Invoke(pEntity);
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal void InvokeClientCommand(Edict pEntity)
    {
        var result = ClientCommand?.Invoke(pEntity);
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal void InvokeClientUserInfoChanged(Edict pEntity, ref string infobuffer)
    {
        var result = ClientUserInfoChanged?.Invoke(pEntity, ref infobuffer);
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal void InvokeServerActivate(Edict pEdictList, int edictCount, int clientMax)
    {
        var result = ServerActivate?.Invoke(pEdictList, edictCount, clientMax);
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal void InvokeServerDeactivate()
    {
        var result = ServerDeactivate?.Invoke();
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal void InvokePlayerPreThink(Edict pEntity)
    {
        var result = PlayerPreThink?.Invoke(pEntity);
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal void InvokePlayerPostThink(Edict pEntity)
    {
        var result = PlayerPostThink?.Invoke(pEntity);
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal void InvokeStartFrame()
    {
        var result = StartFrame?.Invoke();
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal void InvokeParmsNewLevel()
    {
        var result = ParmsNewLevel?.Invoke();
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal void InvokeParmsChangeLevel()
    {
        var result = ParmsChangeLevel?.Invoke();
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal string InvokeGetGameDescription()
    {
        var result = GetGameDescription?.Invoke();
        if (result == null)
        {
            MetaMod.MetaGlobals.Result = MetaResult.MRES_IGNORED;
            return string.Empty;
        }
        else
        {
            MetaMod.MetaGlobals.Result = result.Value.Item1;
            return result.Value.Item2;
        }
    }
    internal void InvokePlayerCustomization(Edict pEntity, Customization pCustom)
    {
        var result = PlayerCustomization?.Invoke(pEntity, pCustom);
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal void InvokeSpectatorConnect(Edict pEntity)
    {
        var result = SpectatorConnect?.Invoke(pEntity);
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal void InvokeSpectatorDisconnect(Edict pEntity)
    {
        var result = SpectatorDisconnect?.Invoke(pEntity);
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal void InvokeSpectatorThink(Edict pEntity)
    {
        var result = SpectatorThink?.Invoke(pEntity);
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal void InvokeSysError(string error_string)
    {
        var result = SysError?.Invoke(error_string);
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal void InvokePM_Move(PlayerMove pm, bool server)
    {
        var result = PM_Move?.Invoke(pm, server);
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal void InvokePM_Init(PlayerMove pm)
    {
        var result = PM_Init?.Invoke(pm);
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal byte InvokePM_FindTextureType(string name)
    {
        var result = PM_FindTextureType?.Invoke(name);
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
        return 0;
    }
    internal void InvokeSetupVisibility(Edict pViewEntity, Edict pClient, ref byte[] pvs, ref byte[] pas)
    {
        var result = SetupVisibility?.Invoke(pViewEntity, pClient, ref pvs, ref pas);
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal void InvokeUpdateClientData(Edict ent, int sendweapons, ClientData cd)
    {
        var result = UpdateClientData?.Invoke(ent, sendweapons, cd);
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal int InvokeAddToFullPack(EntityState state, int e, Edict ent, Edict host, int hostflags, int player, byte[] pSet)
    {
        var result = AddToFullPack?.Invoke(state, e, ent, host, hostflags, player, pSet);
        if (result == null)
        {
            MetaMod.MetaGlobals.Result = MetaResult.MRES_IGNORED;
            return 0;
        }
        else
        {
            MetaMod.MetaGlobals.Result = result.Value.Item1;
            return result.Value.Item2;
        }
    }
    internal void InvokeCreateBaseline(int player, int eindex, EntityState baseline, Edict entity, int playermodelindex, Vector3f player_mins, Vector3f player_maxs)
    {
        var result = CreateBaseline?.Invoke(player, eindex, baseline, entity, playermodelindex, player_mins, player_maxs);
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal void InvokeRegisterEncoders()
    {
        var result = RegisterEncoders?.Invoke();
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal int InvokeGetWeaponData(Edict player, WeaponData info)
    {
        var result = GetWeaponData?.Invoke(player, info);
        if (result == null)
        {
            MetaMod.MetaGlobals.Result = MetaResult.MRES_IGNORED;
            return 0;
        }
        else
        {
            MetaMod.MetaGlobals.Result = result.Value.Item1;
            return result.Value.Item2;
        }
    }
    internal void InvokeCmdStart(Edict plyer, UserCmd cmd, uint random_seed)
    {
        var result = CmdStart?.Invoke(plyer, cmd, random_seed);
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal void InvokeCmdEnd(Edict plyer)
    {
        var result = CmdEnd?.Invoke(plyer);
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal int InvokeConnectionlessPacket(NetAdr net_from, string args, ref string response_buffer, ref int response_buffer_size)
    {
        var result = ConnectionlessPacket?.Invoke(net_from, args, ref response_buffer, ref response_buffer_size);
        if (result == null)
        {
            MetaMod.MetaGlobals.Result = MetaResult.MRES_IGNORED;
            return 0;
        }
        else
        {
            MetaMod.MetaGlobals.Result = result.Value.Item1;
            return result.Value.Item2;
        }
    }
    internal int InvokeGetHullBounds(int hullnumber, ref Vector3f mins, ref Vector3f maxs)
    {
        var result = GetHullBounds?.Invoke(hullnumber, ref mins, ref maxs);
        if (result == null)
        {
            MetaMod.MetaGlobals.Result = MetaResult.MRES_IGNORED;
            return 0;
        }
        else
        {
            MetaMod.MetaGlobals.Result = result.Value.Item1;
            return result.Value.Item2;
        }
    }
    internal void InvokeCreateInstancedBaselines()
    {
        var result = CreateInstancedBaselines?.Invoke();
        MetaMod.MetaGlobals.Result = result ?? MetaResult.MRES_IGNORED;
    }
    internal int InvokeInconsistentFile(Edict player, string filename, ref string disconnect_message)
    {
        var result = InconsistentFile?.Invoke(player, filename, ref disconnect_message);
        if (result == null)
        {
            MetaMod.MetaGlobals.Result = MetaResult.MRES_IGNORED;
            return 0;
        }
        else
        {
            MetaMod.MetaGlobals.Result = result.Value.Item1;
            return result.Value.Item2;
        }
    }
    internal int InvokeAllowLagCompensation()
    {
        var result = AllowLagCompensation?.Invoke();
        if (result == null)
        {
            MetaMod.MetaGlobals.Result = MetaResult.MRES_IGNORED;
            return 0;
        }
        else
        {
            MetaMod.MetaGlobals.Result = result.Value.Item1;
            return result.Value.Item2;
        }
    }
    #endregion
    #region Null Checker
    internal bool IsGameInitNull => GameInit == null;
    internal bool IsSpawnNull => Spawn == null;
    internal bool IsThinkNull => Think == null;
    internal bool IsUseNull => Use == null;
    internal bool IsTouchNull => Touch == null;
    internal bool IsBlockedNull => Blocked == null;
    internal bool IsKeyValueNull => KeyValue == null;
    internal bool IsSaveNull => Save == null;
    internal bool IsRestoreNull => Restore == null;
    internal bool IsSetAbsBoxNull => SetAbsBox == null;
    internal bool IsSaveWriteFieldsNull => SaveWriteFields == null;
    internal bool IsSaveReadFieldsNull => SaveReadFields == null;
    internal bool IsSaveGlobalStateNull => SaveGlobalState == null;
    internal bool IsRestoreGlobalStateNull => RestoreGlobalState == null;
    internal bool IsResetGlobalStateNull => ResetGlobalState == null;
    internal bool IsClientConnectNull => ClientConnect == null;
    internal bool IsClientDisconnectNull => ClientDisconnect == null;
    internal bool IsClientKillNull => ClientKill == null;
    internal bool IsClientPutInServerNull => ClientPutInServer == null;
    internal bool IsClientCommandNull => ClientCommand == null;
    internal bool IsClientUserInfoChangedNull => ClientUserInfoChanged == null;
    internal bool IsServerActivateNull => ServerActivate == null;
    internal bool IsServerDeactivateNull => ServerDeactivate == null;
    internal bool IsPlayerPreThinkNull => PlayerPreThink == null;
    internal bool IsPlayerPostThinkNull => PlayerPostThink == null;
    internal bool IsStartFrameNull => StartFrame == null;
    internal bool IsParmsNewLevelNull => ParmsNewLevel == null;
    internal bool IsParmsChangeLevelNull => ParmsChangeLevel == null;
    internal bool IsGetGameDescriptionNull => GetGameDescription == null;
    internal bool IsPlayerCustomizationNull => PlayerCustomization == null;
    internal bool IsSpectatorConnectNull => SpectatorConnect == null;
    internal bool IsSpectatorDisconnectNull => SpectatorDisconnect == null;
    internal bool IsSpectatorThinkNull => SpectatorThink == null;
    internal bool IsSysErrorNull => SysError == null;
    internal bool IsPM_MoveNull => PM_Move == null;
    internal bool IsPM_InitNull => PM_Init == null;
    internal bool IsPM_FindTextureTypeNull => PM_FindTextureType == null;
    internal bool IsSetupVisibilityNull => SetupVisibility == null;
    internal bool IsUpdateClientDataNull => UpdateClientData == null;
    internal bool IsAddToFullPackNull => AddToFullPack == null;
    internal bool IsCreateBaselineNull => CreateBaseline == null;
    internal bool IsRegisterEncodersNull => RegisterEncoders == null;
    internal bool IsGetWeaponDataNull => GetWeaponData == null;
    internal bool IsCmdStartNull => CmdStart == null;
    internal bool IsCmdEndNull => CmdEnd == null;
    internal bool IsConnectionlessPacketNull => ConnectionlessPacket == null;
    internal bool IsGetHullBoundsNull => GetHullBounds == null;
    internal bool IsCreateInstancedBaselinesNull => CreateInstancedBaselines == null;
    internal bool IsInconsistentFileNull => InconsistentFile == null;
    internal bool IsAllowLagCompensationNull => AllowLagCompensation == null;
    #endregion
}