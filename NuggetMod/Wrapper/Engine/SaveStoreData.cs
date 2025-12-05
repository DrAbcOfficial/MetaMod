using Metamod.Native.Engine;
using Metamod.Wrapper.Common;
using System.Runtime.InteropServices;

namespace Metamod.Wrapper.Engine;

public class SaveStoreData : BaseNativeWrapper<NativeSaveStoreData>
{
    public SaveStoreData() : base() { }

    internal unsafe SaveStoreData(NativeSaveStoreData* nativePtr, bool ownsPointer = false)
        : base(nativePtr, ownsPointer) { }

    public nint BaseData
    {
        get
        {
            unsafe
            {
                return (nint)NativePtr->pBaseData;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->pBaseData = (byte*)value;
            }
        }
    }

    public nint CurrentData
    {
        get
        {
            unsafe
            {
                return (nint)NativePtr->pCurrentData;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->pCurrentData = (byte*)value;
            }
        }
    }

    public int Size
    {
        get
        {
            unsafe
            {
                return NativePtr->size;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->size = value;
            }
        }
    }

    public int BufferSize
    {
        get
        {
            unsafe
            {
                return NativePtr->bufferSize;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->bufferSize = value;
            }
        }
    }

    public int TokenSize
    {
        get
        {
            unsafe
            {
                return NativePtr->tokenSize;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->tokenSize = value;
            }
        }
    }

    public int TokenCount
    {
        get
        {
            unsafe
            {
                return NativePtr->tokenCount;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->tokenCount = value;
            }
        }
    }

    public nint Tokens
    {
        get
        {
            unsafe
            {
                return (nint)NativePtr->pTokens;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->pTokens = (byte**)value;
            }
        }
    }

    public int CurrentIndex
    {
        get
        {
            unsafe
            {
                return NativePtr->currentIndex;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->currentIndex = value;
            }
        }
    }

    public int TableCount
    {
        get
        {
            unsafe
            {
                return NativePtr->tableCount;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->tableCount = value;
            }
        }
    }

    public int ConnectionCount
    {
        get
        {
            unsafe
            {
                return NativePtr->connectionCount;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->connectionCount = value;
            }
        }
    }

    public nint EntityTable
    {
        get
        {
            unsafe
            {
                return (nint)NativePtr->pTable;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->pTable = (NativeEntityTable*)value;
            }
        }
    }

    private IReadOnlyList<LevelList>? _levelList;
    public IReadOnlyList<LevelList> LevelList
    {
        get
        {
            unsafe
            {
                if (_levelList == null)
                {
                    var list = new List<LevelList>() {
                        new(&NativePtr->levelList0),
                        new(&NativePtr->levelList1),
                        new(&NativePtr->levelList2),
                        new(&NativePtr->levelList3),
                        new(&NativePtr->levelList4),
                        new(&NativePtr->levelList5),
                        new(&NativePtr->levelList6),
                        new(&NativePtr->levelList7),
                        new(&NativePtr->levelList8),
                        new(&NativePtr->levelList9),
                        new(&NativePtr->levelList10),
                        new(&NativePtr->levelList11),
                        new(&NativePtr->levelList12),
                        new(&NativePtr->levelList13),
                        new(&NativePtr->levelList14),
                        new(&NativePtr->levelList15)
                    };
                    _levelList = list.AsReadOnly();
                }
                return _levelList;
            }
        }
    }

    public int UseLandmark
    {
        get
        {
            unsafe
            {
                return NativePtr->fUseLandmark;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->fUseLandmark = value;
            }
        }
    }

    public string LandmarkName
    {
        get
        {
            unsafe
            {
                return Marshal.PtrToStringUTF8((nint)NativePtr->szLandmarkName)?.TrimEnd('\0') ?? string.Empty;
            }
        }
        set
        {
            unsafe
            {
                var bytes = System.Text.Encoding.UTF8.GetBytes(value);
                for (int i = 0; i < 20; i++)
                {
                    NativePtr->szLandmarkName[i] = i < bytes.Length ? bytes[i] : (byte)0;
                }
            }
        }
    }

    private Vector3f? _vecLandmarkOffset;
    public Vector3f VecLandmarkOffset
    {
        get
        {
            unsafe
            {
                _vecLandmarkOffset ??= new Vector3f(&NativePtr->vecLandmarkOffset);
                return _vecLandmarkOffset;
            }
        }
    }

    public float Time
    {
        get
        {
            unsafe
            {
                return NativePtr->time;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->time = value;
            }
        }
    }

    public string CurrentMapName
    {
        get
        {
            unsafe
            {
                return Marshal.PtrToStringUTF8((nint)NativePtr->szCurrentMapName)?.TrimEnd('\0') ?? string.Empty;
            }
        }
        set
        {
            unsafe
            {
                var bytes = System.Text.Encoding.UTF8.GetBytes(value);
                for (int i = 0; i < 32; i++)
                {
                    NativePtr->szCurrentMapName[i] = i < bytes.Length ? bytes[i] : (byte)0;
                }
            }
        }
    }
}