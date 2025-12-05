namespace Metamod.Helper;

public class Utility
{
    public static string String(StringHandle str)
    {
        return str.ToString();
    }
    public static StringHandle MakeString(string str)
    {
        return new StringHandle(str);
    }
}
