namespace Metamod.Enum.Metamod;

// Version consists of "major:minor", two separate integer numbers.
public enum InterfaceVersion
{
    // Version 1	original
    V1,
    // Version 2	added plugin_info_t **pinfo
    V2,
    // Version 3	init split into query and attach, added detach
    V3,
    // Version 4	added (PLUG_LOADTIME now) to attach
    V4,
    // Version 5	changed mm ifvers int* to string, moved pl ifvers to info
    V5,
    // Version 5:1	added link support for entity "adminmod_timer" (adminmod)
    V5_1,
    // Version 5:2	added gamedll_funcs to meta_attach() [v1.0-rc2]
    V5_2,
    // Version 5:3	added mutil_funcs to meta_query() [v1.05]
    V5_3,
    // Version 5:4	added centersay utility functions [v1.06]
    V5_4,
    // Version 5:5	added Meta_Init to plugin API [v1.08]
    V5_5,
    // Version 5:6	added CallGameEntity utility function [v1.09]
    V5_6,
    // Version 5:7	added GetUserMsgID, GetUserMsgName util funcs [v1.11]
    V5_7,
    // Version 5:8	added GetPluginPath [v1.11]
    V5_8,
    // Version 5:9	added GetGameInfo [v1.14]
    V5_9,
    // Version 5:10 added GINFO_REALDLL_FULLPATH for GetGameInfo [v1.17]
    V5_10,
    // Version 5:11 added plugin loading and unloading API [v1.18]
    V5_11,
    // Version 5:12 added IS_QUERYING_CLIENT_CVAR to mutils [v1.18]
    V5_12,
    // Version 5:13 added MAKE_REQUESTID and GET_HOOK_TABLES to mutils [v1.19]
    V5_13,
    // Version 5:14 added Binary Analysis and InlineHook to mutils by hzqst
    V5_14,
    // Version 5:15 added EngineStudioAPI, rotationmatrix and bonematrix to mutils by hzqst
    V5_15,
    // Version 5:16 added GetEngineType to mutils by hzqst
    V5_16
}
