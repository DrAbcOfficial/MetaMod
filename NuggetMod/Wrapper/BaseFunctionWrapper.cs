using Metamod.Native;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Metamod.Wrapper;

public abstract class BaseFunctionWrapper<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors)] T> where T : INativeStruct
{
    /// <summary>
    /// 托管内存结构体
    /// </summary>
    public unsafe T Base { get; private set; }

    internal BaseFunctionWrapper(nint nativePtr)
    {
        Base = Marshal.PtrToStructure<T>(nativePtr) ?? throw new ArgumentNullException(nameof(nativePtr), "Function ptr is NULL!");
    }
}
