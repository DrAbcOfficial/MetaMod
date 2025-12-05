using System.Runtime.InteropServices;

namespace NuggetMod.Native.Common;

[StructLayout(LayoutKind.Sequential)]
public struct NativeWeaponData : INativeStruct
{
    internal int m_iId;
    internal int m_iClip;

    internal float m_flNextPrimaryAttack;
    internal float m_flNextSecondaryAttack;
    internal float m_flTimeWeaponIdle;

    internal int m_fInReload;
    internal int m_fInSpecialReload;
    internal float m_flNextReload;
    internal float m_flPumpTime;
    internal float m_fReloadTime;

    internal float m_fAimedDamage;
    internal float m_fNextAimBonus;
    internal int m_fInZoom;
    internal int m_iWeaponState;

    internal int iuser1;
    internal int iuser2;
    internal int iuser3;
    internal int iuser4;
    internal float fuser1;
    internal float fuser2;
    internal float fuser3;
    internal float fuser4;
}
