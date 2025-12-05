using Metamod.Native.Game;
using System.Runtime.InteropServices;

namespace Metamod.Wrapper.Game;

public class ServerStudioAPI(nint ptr) : BaseFunctionWrapper<NativeServerStudioAPI>(ptr)
{
    public nint MemCalloc(int number, uint size) => Base.Mem_Calloc(number, size);
    public nint CacheCheck(nint cacheUser) => Base.Cache_Check(cacheUser);
    public void LoadCacheFile(string path, nint cacheUser)
    {
        nint ptr = Marshal.StringToHGlobalAnsi(path);
        unsafe
        {
            Base.LoadCacheFile((byte*)ptr, cacheUser);
        }
        Marshal.FreeHGlobal(ptr);
    }
    public nint ModExtradata(nint model) => Base.Mod_Extradata(model);
}
