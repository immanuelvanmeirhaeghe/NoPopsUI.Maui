using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoPopsUI.Maui.ViewModels;

/// <summary>
/// Viewmodel for more app info management using appsettings.json.
/// </summary>
public partial class MoreAppInfo : ObservableObject
{
    public string? AppName { get; set; } = AppInfo.Current.Name;

    private const string AppGitHubLinkKey = $"{nameof(AppInfo)}:{nameof(AppGitHubLink)}";
    public string? AppGitHubLink { get; set; } = "https://github.com/immanuelvanmeirhaeghe/NoPopsUI"; //ConfigurationManager.GetSection(AppGitHubLinkKey).Value;

    public string? AppTitle { get; set; } = AppInfo.Current.Name;

    private const string AppDescriptionKey = $"{nameof(AppInfo)}:{nameof(AppDescription)}";
    public string? AppDescription { get; set; } = "A simple web browser that blocks popups and other annoyances."; //ConfigurationManager.GetSection(AppDescriptionKey).Value;

    private const string AppLogoImageSourceKey = $"{nameof(AppInfo)}:{nameof(AppLogoImageSource)}";
    public string? AppLogoImageSource { get; set; } = "logo_nopopsui.png"; //ConfigurationManager.GetSection(AppLogoImageSourceKey).Value;

    public string? AppVersion { get; set; } = AppInfo.Current.VersionString;

    private const string AppSloganKey = $"{nameof(AppInfo)}:{nameof(AppSlogan)}";
    public string? AppSlogan { get; set; } = "No more popups out of nowhere!"; //ConfigurationManager.GetSection(AppSloganKey).Value;

    private const string AppReadMeKey = $"{nameof(AppInfo)}:{nameof(AppReadMe)}";
    public string? AppReadMe { get; set; } = "Originally, I created this app to browse Aniwave, Mangafire and other otaku websites. I got fed up with mallicious popups and popunders suddenly appearing on my mobile or portable device while navigating the sites. I could not find a dedicated site app, so the only option was to use my mobile device's build-in web browser.\r\n\r\nI did not want to use any 3rd party browser add-ons nor block the site owner's advertisements and non-exposed site functionality, so decided to develop my own customizable site reader / viewer app.\r\n\r\nNow I use it on a daily basis and hope you will enjoy it to!"; //ConfigurationManager.GetSection(AppReadMeKey).Value;

}
