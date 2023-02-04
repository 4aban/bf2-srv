using System.Text.RegularExpressions;

namespace bf2srv-wadmin.Server.Extensions;

public static class ProjectContext
{
    public static string GetDirectory()
    {
        var dir = AppContext.BaseDirectory;

        dir = Regex.Replace(dir, @"(\\|\/)+bin(\\|\/)+.+$", string.Empty,
            RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);

        return dir;
    }

    public static string GetEnvironmentName()
    {
#if DEBUG
        return "debug";
#else
            return "release";
#endif
    }
}