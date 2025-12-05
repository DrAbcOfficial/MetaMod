using Metamod.Native.Engine;
using Metamod.Wrapper;
using Metamod.Wrapper.Common;
using System.Runtime.InteropServices;

namespace Metamod.Wrapper.Engine;

public class LevelList : BaseNativeWrapper<NativeLevelList>
{
    public LevelList() : base() { }

    internal unsafe LevelList(NativeLevelList* nativePtr, bool ownsPointer = false)
        : base(nativePtr, ownsPointer) { }

    public string MapName
    {
        get
        {
            unsafe
            {
                return Marshal.PtrToStringAnsi((nint)NativePtr->mapName)?.TrimEnd('\0') ?? string.Empty;
            }
        }
        set
        {
            unsafe
            {
                var bytes = System.Text.Encoding.UTF8.GetBytes(value);
                for (int i = 0; i < 32; i++)
                {
                    NativePtr->mapName[i] = i < bytes.Length ? bytes[i] : (byte)0;
                }
            }
        }
    }

    public string LandmarkName
    {
        get
        {
            unsafe
            {
                return Marshal.PtrToStringAnsi((nint)NativePtr->landmarkName)?.TrimEnd('\0') ?? string.Empty;
            }
        }
        set
        {
            unsafe
            {
                var bytes = System.Text.Encoding.UTF8.GetBytes(value);
                for (int i = 0; i < 32; i++)
                {
                    NativePtr->landmarkName[i] = i < bytes.Length ? bytes[i] : (byte)0;
                }
            }
        }
    }

    private Edict? _pentlandmark;
    public Edict PentLandmark
    {
        get
        {
            unsafe
            {
                _pentlandmark ??= new Edict(NativePtr->pentLandmark);
                return _pentlandmark;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->pentLandmark = (NativeEdict*)value.GetPointer();
            }
        }
    }

    private Vector3f? _vecLandmarkOrigin;
    public Vector3f VecLandmarkOrigin
    {
        get
        {
            unsafe
            {
                _vecLandmarkOrigin ??= new Vector3f(&NativePtr->vecLandmarkOrigin);
                return _vecLandmarkOrigin;
            }
        }
    }
}