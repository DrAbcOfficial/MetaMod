using Metamod.Native.Engine.PM;
using Metamod.Wrapper.Common;

namespace Metamod.Wrapper.Engine.PM;

public class PMPlane : BaseNativeWrapper<NativePMPlane>
{
    public PMPlane() : base() { }

    internal unsafe PMPlane(NativePMPlane* nativePtr, bool ownsPointer = false)
        : base(nativePtr, ownsPointer) { }

    private Vector3f? _normal;
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