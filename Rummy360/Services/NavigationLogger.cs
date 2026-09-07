using System;
using System.Collections.Generic;
using System.Text;

namespace Rummy360.Services;

public static class NavigationLogger
{
    public static void Log(string pageName)
    {
        System.Diagnostics.Debug.WriteLine("");
        System.Diagnostics.Debug.WriteLine("==========================");
        System.Diagnostics.Debug.WriteLine("Rummy360 UI Navigation");
        System.Diagnostics.Debug.WriteLine("==========================");
        System.Diagnostics.Debug.WriteLine($"[{DateTime.Now:HH:mm:ss}] {pageName} Loaded");
        System.Diagnostics.Debug.WriteLine($"Route : {pageName}");
        System.Diagnostics.Debug.WriteLine("");
    }
}
