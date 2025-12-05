using Metamod.Native.Common;
using System.Net;

namespace Metamod.Wrapper.Common;

public class NetAdr : BaseNativeWrapper<NativeNetAdr>
{
    internal unsafe NetAdr(nint ptr) : base((NativeNetAdr*)ptr) { }
    public enum NetAdrType
    {
        NA_UNUSED,
        NA_LOOPBACK,
        NA_BROADCAST,
        NA_IP,
        NA_IPX,
        NA_BROADCAST_IPX,
    }

    public NetAdrType Type
    {
        get
        {
            unsafe
            {
                return (NetAdrType)NativePtr->type;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->type = (int)value;
            }
        }
    }

    public IPAddress IPAddress
    {
        get
        {
            unsafe
            {
                byte[] ipCopy = new byte[4];
                for (int i = 0; i < 4; i++)
                {
                    ipCopy[i] = NativePtr->ip[i];
                }
                return new IPAddress(ipCopy);
            }
        }
        set
        {
            unsafe
            {
                byte[] ip = value.GetAddressBytes();
                for (int i = 0; i < 4; i++)
                {
                    NativePtr->ip[i] = ip[i];
                }
            }
        }
    }
    public byte[] Ipx
    {
        get
        {
            unsafe
            {
                byte[] ipxCopy = new byte[10];
                for (int i = 0; i < 10; i++)
                {
                    ipxCopy[i] = NativePtr->ipx[i];
                }
                return ipxCopy;
            }
        }
        set
        {
            unsafe
            {
                ArgumentNullException.ThrowIfNull(value);
                if (value.Length != 10)
                    throw new ArgumentOutOfRangeException(nameof(value), "IPX address must be 10 bytes long");

                for (int i = 0; i < 10; i++)
                {
                    NativePtr->ipx[i] = value[i];
                }
            }
        }
    }

    public ushort Port
    {
        get
        {
            unsafe
            {
                return NativePtr->port;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->port = value;
            }
        }
    }
}
