using NoPopsUI.Maui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoPopsUI.Maui.Services
{
    public static class RoutingManager
    {
        public static IList<string> CachedRoutes { get; set; } = ["//main", "//main/home", "//main/browser", "//main/about", "//main/options"];

        public static void CacheRoute(string route)
        {
            if (!CachedRoutes.Contains(route))
            {
                CachedRoutes.Add(route);
            }
        }

        public static string? GetCachedRoute(string route)
        {
            if(string.IsNullOrWhiteSpace(route))
            {
                return null;
            }
            return CachedRoutes?.FirstOrDefault(r => r.ToLowerInvariant().Trim().Equals(route));
        }
    }
}
