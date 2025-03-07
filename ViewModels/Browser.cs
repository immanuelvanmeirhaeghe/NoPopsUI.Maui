using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NoPopsUI.Maui.Controls;
using NoPopsUI.Maui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NoPopsUI.Maui.ViewModels;

public partial class Browser : ObservableObject
{

    public string? WebsitePickerTitle { get; set; } = "Choose a Website";
    public IList<Website>? WebsitePickerItemsSource { get; set; } = [];
    public Website? WebsitePickerSelectedItem { get; set; } = null;
    public string? GoToHomeImageButtonSource { get; set; } = $"icon_house.svg";
    public CustomWebView? CustomWebViewSource { get; set; }

    public Browser()
    {
        WebsitePickerItemsSource = [
            new Website { BaseUri = new Uri("https://mangafire.to"), BasePath = "mangafire.to", Host = "MangaFire" },
            ];
    }

    public void CustomWebViewNavigating(object? sender, WebNavigatingEventArgs e)
    {
        
    }

    public void ShellTitleViewOnPinchedUpdated(object? sender, PinchGestureUpdatedEventArgs e)
    {
       
    }

    public void WebsitePickerSelectedIndexChanged(object? sender, EventArgs e)
    {
       
    }

    [RelayCommand]
    public void GoToHomeImageButtonCommand()
    {
        
    }

}
