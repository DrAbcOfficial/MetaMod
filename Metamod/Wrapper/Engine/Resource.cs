using Metamod.Enum.Engine;
using Metamod.Native.Engine;
using System.Text;

namespace Metamod.Wrapper.Engine;

public class Resource : BaseNativeWrapper<NativeResource>
{
    public Resource() : base() { }

    internal unsafe Resource(NativeResource* nativePtr, bool ownsPointer = false)
        : base(nativePtr, ownsPointer) { }

    public string FileName
    {
        get
        {
            unsafe
            {
                byte[] buffer = new byte[64];
                fixed (byte* unmanaged = buffer)
                {
                    for (int i = 0; i < 64; i++)
                    {
                        unmanaged[i] = NativePtr->szFileName[i];
                    }
                }
                return Encoding.UTF8.GetString(NativePtr->szFileName, Array.IndexOf(buffer, (byte)0));
            }
        }
        set
        {
            unsafe
            {
                byte[] bytes = Encoding.UTF8.GetBytes(value);
                int copyLength = Math.Min(bytes.Length, 63); // 保留1个字节给null终止符
                fixed (byte* pBytes = bytes)
                {
                    for (int i = 0; i < copyLength; i++)
                    {
                        NativePtr->szFileName[i] = pBytes[i];
                    }
                }
                NativePtr->szFileName[copyLength] = 0;
            }
        }
    }

    public ResourceType Type
    {
        get
        {
            unsafe
            {
                return NativePtr->type;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->type = value;
            }
        }
    }

    public int Index
    {
        get
        {
            unsafe
            {
                return NativePtr->nIndex;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->nIndex = value;
            }
        }
    }

    public int DownloadSize
    {
        get
        {
            unsafe
            {
                return NativePtr->nDownloadSize;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->nDownloadSize = value;
            }
        }
    }

    public byte Flags
    {
        get
        {
            unsafe
            {
                return NativePtr->ucFlags;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->ucFlags = value;
            }
        }
    }

    public byte[] Md5Hash
    {
        get
        {
            unsafe
            {
                // 复制16字节的MD5哈希
                byte[] hash = new byte[16];
                for (int i = 0; i < 16; i++)
                {
                    hash[i] = NativePtr->rgucMD5_hash[i];
                }
                return hash;
            }
        }
        set
        {
            unsafe
            {
                // 复制输入的MD5哈希（限制长度为16）
                int copyLength = Math.Min(value.Length, 16);
                for (int i = 0; i < copyLength; i++)
                {
                    NativePtr->rgucMD5_hash[i] = value[i];
                }
            }
        }
    }

    public byte PlayerNum
    {
        get
        {
            unsafe
            {
                return NativePtr->playernum;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->playernum = value;
            }
        }
    }

    public byte[] Reserved
    {
        get
        {
            unsafe
            {
                // 复制32字节的保留数据
                byte[] reserved = new byte[32];
                for (int i = 0; i < 32; i++)
                {
                    reserved[i] = NativePtr->rguc_reserved[i];
                }
                return reserved;
            }
        }
        set
        {
            unsafe
            {
                // 复制输入的保留数据（限制长度为32）
                int copyLength = Math.Min(value.Length, 32);
                for (int i = 0; i < copyLength; i++)
                {
                    NativePtr->rguc_reserved[i] = value[i];
                }
            }
        }
    }

    private Resource? _next;
    public Resource? Next
    {
        get
        {
            unsafe
            {
                if (NativePtr->pNext == nint.Zero)
                    return null;

                _next ??= new Resource((NativeResource*)NativePtr->pNext);
                return _next;
            }
        }
        set
        {
            unsafe
            {
                if (value == null)
                    NativePtr->pNext = nint.Zero;
                else
                    NativePtr->pNext = (nint)value.NativePtr;
            }
        }
    }

    private Resource? _previous;
    public Resource? Previous
    {
        get
        {
            unsafe
            {
                if (NativePtr->pPrev == nint.Zero)
                    return null;
                _previous ??= new Resource((NativeResource*)NativePtr->pPrev);
                return _previous;
            }
        }
        set
        {
            unsafe
            {
                if (value == null)
                    NativePtr->pPrev = nint.Zero;
                else
                    NativePtr->pPrev = (nint)value.NativePtr;
            }
        }
    }
}