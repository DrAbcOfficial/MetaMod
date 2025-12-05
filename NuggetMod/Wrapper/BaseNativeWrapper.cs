using Metamod.Native;
using System.Runtime.InteropServices;

namespace Metamod.Wrapper;

/// <summary>
/// 非托管结构体包装器基类
/// </summary>
/// <typeparam name="T">非托管结构体类型</typeparam>
public abstract class BaseNativeWrapper<T> : IDisposable where T : unmanaged, INativeStruct
{
    /// <summary>
    /// 非托管内存指针
    /// </summary>
    protected unsafe T* NativePtr { get; private set; }

    /// <summary>
    /// 是否拥有指针所有权（是否需要释放）
    /// </summary>
    private readonly bool _ownsPointer;

    /// <summary>
    /// 构造函数（包装现有非托管指针）
    /// </summary>
    /// <param name="nativePtr">非托管结构体指针</param>
    /// <param name="ownsPointer">是否拥有指针所有权</param>
    internal unsafe BaseNativeWrapper(T* nativePtr, bool ownsPointer = false)
    {
        NativePtr = nativePtr;
        _ownsPointer = ownsPointer;
    }

    /// <summary>
    /// 构造函数（分配新的非托管内存）
    /// </summary>
    public BaseNativeWrapper()
    {
        unsafe
        {
            NativePtr = (T*)Marshal.AllocHGlobal(sizeof(T));
        }
        _ownsPointer = true;
    }

    /// <summary>
    /// 获取原始指针
    /// </summary>
    /// <returns>非托管指针</returns>
    public nint GetPointer()
    {
        unsafe
        {
            return (nint)NativePtr;
        }
    }

    /// <summary>
    /// 释放非托管资源
    /// </summary>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    public bool IsValid()
    {
        unsafe
        {
            return NativePtr != null;
        }
    }

    protected virtual void Dispose(bool disposing)
    {
        unsafe
        {
            if (NativePtr != null && _ownsPointer)
            {
                Marshal.FreeHGlobal((nint)NativePtr);
                NativePtr = null;
            }
        }
    }

    ~BaseNativeWrapper()
    {
        Dispose(false);
    }
}