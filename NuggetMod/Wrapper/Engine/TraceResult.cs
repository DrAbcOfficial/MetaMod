using Metamod.Native.Engine;
using Metamod.Wrapper.Common;

namespace Metamod.Wrapper.Engine;

public class TraceResult : BaseNativeWrapper<NativeTraceResult>
{
    public TraceResult() : base() { }

    internal unsafe TraceResult(nint ptr) : this((NativeTraceResult*)ptr) { }
    internal unsafe TraceResult(NativeTraceResult* nativePtr, bool ownsPointer = false)
        : base(nativePtr, ownsPointer) { }

    public int AllSolid
    {
        get
        {
            unsafe
            {
                return NativePtr->fAllSolid;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->fAllSolid = value;
            }
        }
    }

    public int StartSolid
    {
        get
        {
            unsafe
            {
                return NativePtr->fStartSolid;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->fStartSolid = value;
            }
        }
    }

    public int InOpen
    {
        get
        {
            unsafe
            {
                return NativePtr->fInOpen;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->fInOpen = value;
            }
        }
    }

    public int InWater
    {
        get
        {
            unsafe
            {
                return NativePtr->fInWater;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->fInWater = value;
            }
        }
    }

    public float Fraction
    {
        get
        {
            unsafe
            {
                return NativePtr->flFraction;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->flFraction = value;
            }
        }
    }

    private Vector3f? _endPos;
    public Vector3f EndPos
    {
        get
        {
            unsafe
            {
                _endPos ??= new Vector3f(&NativePtr->vecEndPos);
                return _endPos;
            }
        }
    }

    public float PlaneDist
    {
        get
        {
            unsafe
            {
                return NativePtr->flPlaneDist;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->flPlaneDist = value;
            }
        }
    }

    private Vector3f? _planeNormal;
    public Vector3f PlaneNormal
    {
        get
        {
            unsafe
            {
                _planeNormal ??= new Vector3f(&NativePtr->vecPlaneNormal);
                return _planeNormal;
            }
        }
    }

    public nint PHit
    {
        get
        {
            unsafe
            {
                return NativePtr->pHit;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->pHit = value;
            }
        }
    }

    public int Hitgroup
    {
        get
        {
            unsafe
            {
                return NativePtr->iHitgroup;
            }
        }
        set
        {
            unsafe
            {
                NativePtr->iHitgroup = value;
            }
        }
    }
}