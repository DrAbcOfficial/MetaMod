using NuggetMod.Native.Engine.PM;
using NuggetMod.Wrapper.Common;

namespace NuggetMod.Wrapper.Engine.PM;

/// <summary>
/// Represents a plane for player movement collision
/// </summary>
public class PMPlane : BaseNativeWrapper<NativePMPlane>
{
    /// <summary>
    /// Initializes a new instance with default values
    /// </summary>
    public PMPlane() : base() { }

    internal unsafe PMPlane(NativePMPlane* nativePtr, bool ownsPointer = false)
        : base(nativePtr, ownsPointer) { }

    private Vector3f? _normal;
    
    /// <summary>
    /// Gets the plane normal vector
    /// </summary>
    public Vector3f Normal
    {
        get
        {
            unsafe
            {
                _normal ??= new Vector3f(&NativePtr->normal);
                return _normal;
            }
        }
        set
        {
            unsafe
            {
                // 拷贝值到非托管内存
                NativePtr->normal.x = value.X;
                NativePtr->normal.y = value.Y;
                NativePtr->normal.z = value.Z;
            }
        }
    }

    public float Dist
    {
        get
        {
            unsafe
            {
                return NativePtr->dist;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->dist = value;
            }
        }
    }
}