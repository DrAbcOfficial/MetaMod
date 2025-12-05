using Metamod.Enum.Metamod;
using Metamod.Native.Metamod;

namespace Metamod.Wrapper.Metamod
{
    public class MetaGlobals : BaseNativeWrapper<NativeMetaGlobals>
    {
        internal unsafe MetaGlobals(NativeMetaGlobals* ptr) : base(ptr) { }
        internal unsafe MetaGlobals(nint ptr) : this((NativeMetaGlobals*)ptr) { }
        public MetaResult Result
        {
            get
            {
                unsafe
                {
                    return NativePtr->mres;
                }
            }
            set
            {
                unsafe
                {
                    NativePtr->mres = value;
                }
            }
        }

        public MetaResult PreverseResult
        {
            get
            {
                unsafe
                {
                    return NativePtr->prev_mres;
                }
            }
            set
            {
                unsafe
                {
                    NativePtr->prev_mres = value;
                }
            }
        }

        public MetaResult Status
        {
            get
            {
                unsafe
                {
                    return NativePtr->status;
                }
            }
            set
            {
                unsafe
                {
                    NativePtr->status = value;
                }
            }
        }

        public nint OriginReturn
        {
            get
            {
                unsafe
                {
                    return NativePtr->orig_ret;
                }
            }
            set
            {
                unsafe
                {
                    NativePtr->orig_ret = value;
                }
            }
        }

        public nint OverrideReturn
        {
            get
            {
                unsafe
                {
                    return NativePtr->override_ret;
                }
            }
            set
            {
                unsafe
                {
                    NativePtr->override_ret = value;
                }
            }
        }
    }
}