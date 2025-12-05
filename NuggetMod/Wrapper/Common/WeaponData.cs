using Metamod.Native.Common;

namespace Metamod.Wrapper.Common;

public class WeaponData : BaseNativeWrapper<NativeWeaponData>
{
    internal unsafe WeaponData(nint ptr) : base((NativeWeaponData*)ptr) { }
    public int Id
    {
        get
        {
            unsafe
            {
                return NativePtr->m_iId;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->m_iId = value;
            }
        }
    }

    public int Clip
    {
        get
        {
            unsafe
            {
                return NativePtr->m_iClip;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->m_iClip = value;
            }
        }
    }

    public float NextPrimaryAttack
    {
        get
        {
            unsafe
            {
                return NativePtr->m_flNextPrimaryAttack;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->m_flNextPrimaryAttack = value;
            }
        }
    }

    public float NextSecondaryAttack
    {
        get
        {
            unsafe
            {
                return NativePtr->m_flNextSecondaryAttack;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->m_flNextSecondaryAttack = value;
            }
        }
    }

    public float TimeWeaponIdle
    {
        get
        {
            unsafe
            {
                return NativePtr->m_flTimeWeaponIdle;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->m_flTimeWeaponIdle = value;
            }
        }
    }

    public int InReload
    {
        get
        {
            unsafe
            {
                return NativePtr->m_fInReload;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->m_fInReload = value;
            }
        }
    }

    public int InSpecialReload
    {
        get
        {
            unsafe
            {
                return NativePtr->m_fInSpecialReload;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->m_fInSpecialReload = value;
            }
        }
    }

    public float NextReload
    {
        get
        {
            unsafe
            {
                return NativePtr->m_flNextReload;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->m_flNextReload = value;
            }
        }
    }

    public float PumpTime
    {
        get
        {
            unsafe
            {
                return NativePtr->m_flPumpTime;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->m_flPumpTime = value;
            }
        }
    }

    public float ReloadTime
    {
        get
        {
            unsafe
            {
                return NativePtr->m_fReloadTime;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->m_fReloadTime = value;
            }
        }
    }

    public float AimedDamage
    {
        get
        {
            unsafe
            {
                return NativePtr->m_fAimedDamage;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->m_fAimedDamage = value;
            }
        }
    }

    public float NextAimBonus
    {
        get
        {
            unsafe
            {
                return NativePtr->m_fNextAimBonus;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->m_fNextAimBonus = value;
            }
        }
    }

    public int InZoom
    {
        get
        {
            unsafe
            {
                return NativePtr->m_fInZoom;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->m_fInZoom = value;
            }
        }
    }

    public int WeaponState
    {
        get
        {
            unsafe
            {
                return NativePtr->m_iWeaponState;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->m_iWeaponState = value;
            }
        }
    }

    public int IUser1
    {
        get
        {
            unsafe
            {
                return NativePtr->iuser1;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->iuser1 = value;
            }
        }
    }

    public int IUser2
    {
        get
        {
            unsafe
            {
                return NativePtr->iuser2;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->iuser2 = value;
            }
        }
    }

    public int IUser3
    {
        get
        {
            unsafe
            {
                return NativePtr->iuser3;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->iuser3 = value;
            }
        }
    }

    public int IUser4
    {
        get
        {
            unsafe
            {
                return NativePtr->iuser4;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->iuser4 = value;
            }
        }
    }

    public float FUser1
    {
        get
        {
            unsafe
            {
                return NativePtr->fuser1;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->fuser1 = value;
            }
        }
    }

    public float FUser2
    {
        get
        {
            unsafe
            {
                return NativePtr->fuser2;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->fuser2 = value;
            }
        }
    }

    public float FUser3
    {
        get
        {
            unsafe
            {
                return NativePtr->fuser3;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->fuser3 = value;
            }
        }
    }

    public float FUser4
    {
        get
        {
            unsafe
            {
                return NativePtr->fuser4;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->fuser4 = value;
            }
        }
    }
}