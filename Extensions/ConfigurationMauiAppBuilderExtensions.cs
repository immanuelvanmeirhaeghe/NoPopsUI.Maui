using Microsoft.Extensions.Configuration;
using NoPopsUI.Maui.Models;
using NoPopsUI.Maui.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Browser = NoPopsUI.Maui.ViewModels.Browser;

namespace NoPopsUI.Maui.Extensions
{
    public static class ConfigurationMauiAppBuilderExtensions
    {
        public static MauiAppBuilder ConfigureApp(this MauiAppBuilder builder)
        {
            
            return builder;
        }

        public static MauiAppBuilder ConfigureRouting(this MauiAppBuilder builder)
        {
            Routing.RegisterRoute("//main/home", typeof(Home));
            Routing.RegisterRoute("//main/browser", typeof(Browser));
            Routing.RegisterRoute("//main/options", typeof(Options));
            Routing.RegisterRoute("//main/about", typeof(About));
            //routes =>
            //{
            //    routes.AddRoute("//main/home", typeof(HomePage));
            //    routes.AddRoute("//main/browser", typeof(BrowserPage));
            //    routes.AddRoute("//main/options", typeof(OptionsPage));
            //    routes.AddRoute("//main/about", typeof(AboutPage));
            //}
            return builder;
        }
    }
}
