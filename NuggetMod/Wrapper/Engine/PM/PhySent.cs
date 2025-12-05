using Metamod.Native.Engine.PM;
using Metamod.Wrapper.Common;
using System.Text;

namespace Metamod.Wrapper.Engine.PM;

public class PhySent : BaseNativeWrapper<NativePhySent>
{
    public string Name
    {
        get
        {
            unsafe
            {
                byte[] buffer = new byte[32];
                for (int i = 0; i < 32; i++)
                {
                    buffer[i] = NativePtr->name[i];
                }
                return Encoding.UTF8.GetString(buffer);
            }
        }
        set
        {
            unsafe
            {
                ArgumentNullException.ThrowIfNull(value);
                byte[] buffer = Encoding.UTF8.GetBytes(value);
                if (buffer.Length > 32)
                    throw new ArgumentOutOfRangeException(nameof(value), "Name length cannot exceed 32 bytes");
                for (int i = 0; i < 32; i++)
                {
                    NativePtr->name[i] = i < buffer.Length ? buffer[i] : (byte)0;
                }
            }
        }
    }

    // 基础int类型属性
    public int Player
    {
        get
        {
            unsafe
            {
                return NativePtr->player;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->player = value;
            }
        }
    }

    // Vector3f类型属性 (origin)
    private Vector3f? _origin;
    public Vector3f Origin
    {
        get
        {
            unsafe
            {
                _origin ??= new Vector3f(&NativePtr->origin);
                return _origin;
            }
        }
    }

    // 指针类型属性 (model)
    public nint Model
    {
        get
        {
            unsafe
            {
                return NativePtr->model;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->model = value;
            }
        }
    }

    // 指针类型属性 (studiomodel)
    public nint StudioModel
    {
        get
        {
            unsafe
            {
                return NativePtr->studiomodel;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->studiomodel = value;
            }
        }
    }

    // Vector3f类型属性 (mins)
    private Vector3f? _mins;
    public Vector3f Mins
    {
        get
        {
            unsafe
            {
                _mins ??= new Vector3f(&NativePtr->mins);
                return _mins;
            }
        }
    }

    // Vector3f类型属性 (maxs)
    private Vector3f? _maxs;
    public Vector3f Maxs
    {
        get
        {
            unsafe
            {
                _maxs ??= new Vector3f(&NativePtr->maxs);
                return _maxs;
            }
        }
    }

    // 基础int类型属性
    public int Info
    {
        get
        {
            unsafe
            {
                return NativePtr->info;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->info = value;
            }
        }
    }

    // Vector3f类型属性 (angles)
    private Vector3f? _angles;
    public Vector3f Angles
    {
        get
        {
            unsafe
            {
                _angles ??= new Vector3f(&NativePtr->angles);
                return _angles;
            }
        }
    }

    // 基础int类型属性
    public int Solid
    {
        get
        {
            unsafe
            {
                return NativePtr->solid;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->solid = value;
            }
        }
    }

    public int Skin
    {
        get
        {
            unsafe
            {
                return NativePtr->skin;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->skin = value;
            }
        }
    }

    public int RenderMode
    {
        get
        {
            unsafe
            {
                return NativePtr->rendermode;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->rendermode = value;
            }
        }
    }

    // 基础float类型属性
    public float Frame
    {
        get
        {
            unsafe
            {
                return NativePtr->frame;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->frame = value;
            }
        }
    }

    public int Sequence
    {
        get
        {
            unsafe
            {
                return NativePtr->sequence;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->sequence = value;
            }
        }
    }

    // 固定大小字节数组属性 (controller[4])
    public byte[] Controller
    {
        get
        {
            unsafe
            {
                byte[] buffer = new byte[4];
                fixed (byte* managedPtr = buffer)
                {
                    byte* nativePtr = NativePtr->controller;
                    for (int i = 0; i < 4; i++)
                    {
                        managedPtr[i] = nativePtr[i];
                    }
                }
                return buffer;
            }
        }
        set
        {
            unsafe
            {
                ArgumentNullException.ThrowIfNull(value);
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException(nameof(value), "Controller length cannot exceed 4 bytes");
                for (int i = 0; i < 4; i++)
                {
                    NativePtr->controller[i] = i < value.Length ? value[i] : (byte)0;
                }
            }
        }
    }

    // 固定大小字节数组属性 (blending[2])
    public byte[] Blending
    {
        get
        {
            unsafe
            {
                byte[] buffer = new byte[2];
                fixed (byte* managedPtr = buffer)
                {
                    byte* nativePtr = NativePtr->blending;
                    for (int i = 0; i < 2; i++)
                    {
                        managedPtr[i] = nativePtr[i];
                    }
                }
                return buffer;
            }
        }
        set
        {
            unsafe
            {
                ArgumentNullException.ThrowIfNull(value);
                if (value.Length > 2)
                    throw new ArgumentOutOfRangeException(nameof(value), "Blending length cannot exceed 2 bytes");
                for (int i = 0; i < 2; i++)
                {
                    NativePtr->blending[i] = i < value.Length ? value[i] : (byte)0;
                }
            }
        }
    }

    // 剩余基础类型属性
    public int MoveType
    {
        get
        {
            unsafe
            {
                return NativePtr->movetype;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->movetype = value;
            }
        }
    }

    public int TakeDamage
    {
        get
        {
            unsafe
            {
                return NativePtr->takedamage;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->takedamage = value;
            }
        }
    }

    public int BloodDecal
    {
        get
        {
            unsafe
            {
                return NativePtr->blooddecal;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->blooddecal = value;
            }
        }
    }

    public int Team
    {
        get
        {
            unsafe
            {
                return NativePtr->team;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->team = value;
            }
        }
    }

    public int ClassNumber
    {
        get
        {
            unsafe
            {
                return NativePtr->classnumber;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->classnumber = value;
            }
        }
    }

    // 用户自定义字段 (iuser1-iuser4)
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

    // 用户自定义字段 (fuser1-fuser4)
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

    // 用户自定义字段 (vuser1-vuser4)
    private Vector3f? _vuser1;
    public Vector3f VUser1
    {
        get
        {
            unsafe
            {
                _vuser1 ??= new Vector3f(&NativePtr->vuser1);
                return _vuser1;
            }
        }
    }

    private Vector3f? _vuser2;
    public Vector3f VUser2
    {
        get
        {
            unsafe
            {
                _vuser2 ??= new Vector3f(&NativePtr->vuser2);
                return _vuser2;
            }
        }
    }

    private Vector3f? _vuser3;
    public Vector3f VUser3
    {
        get
        {
            unsafe
            {
                _vuser3 ??= new Vector3f(&NativePtr->vuser3);
                return _vuser3;
            }
        }
    }

    private Vector3f? _vuser4;
    public Vector3f VUser4
    {
        get
        {
            unsafe
            {
                _vuser4 ??= new Vector3f(&NativePtr->vuser4);
                return _vuser4;
            }
        }
    }
}