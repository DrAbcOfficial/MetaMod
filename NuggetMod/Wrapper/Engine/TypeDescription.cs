using NuggetMod.Enum.Engine;
using NuggetMod.Native.Engine;
using NuggetMod.Wrapper;
using System.Runtime.InteropServices;

namespace NuggetMod.Wrapper.Engine;

/// <summary>
/// Represents a type description for save/restore operations
/// </summary>
public class TypeDescription : BaseNativeWrapper<NativeTypeDescription>
{
    /// <summary>
    /// Initializes a new instance with default values
    /// </summary>
    public TypeDescription() : base() { }

    internal unsafe TypeDescription(NativeTypeDescription* nativePtr, bool ownsPointer = false)
        : base(nativePtr, ownsPointer) { }

    public FieldType FieldType
    {
        get
        {
            unsafe
            {
                return NativePtr->fieldType;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->fieldType = value;
            }
        }
    }

    public string FieldName
    {
        get
        {
            unsafe
            {
                return Marshal.PtrToStringUTF8((nint)NativePtr->fieldName) ?? string.Empty;
            }
        }
    }

    public int FieldOffset
    {
        get
        {
            unsafe
            {
                return NativePtr->fieldOffset;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->fieldOffset = value;
            }
        }
    }

    public short FieldSize
    {
        get
        {
            unsafe
            {
                return NativePtr->fieldSize;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->fieldSize = value;
            }
        }
    }

    public short Flags
    {
        get
        {
            unsafe
            {
                return NativePtr->flags;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->flags = value;
            }
        }
    }
}