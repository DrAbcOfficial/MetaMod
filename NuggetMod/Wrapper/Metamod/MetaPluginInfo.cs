using Metamod.Enum.Metamod;

namespace Metamod.Wrapper.Metamod;

public class MetaPluginInfo
{
    public required InterfaceVersion InterfaceVersion;             // meta_interface version
    public required string Name;                   // full name of plugin
    public required string Version;                // version
    public required string Date;                   // date
    public required string Author;             // author name/email
    public required string Url;                    // URL
    public required string LogTag;             // log message prefix (unused right now)
    public required PluginLoadTime Loadable;     // when loadable
    public required PluginLoadTime Unloadable;   // when unloadable

    internal nint NavitePtr;

    public string GetInterfaceVersionString()
    {
        string str = InterfaceVersion.ToString();
        str = str[1..].Replace('_', ':');
        return str;
    }
}
