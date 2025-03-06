using CommunityToolkit.Mvvm.ComponentModel;
using NoPopsUI.Maui.Controls;
using NoPopsUI.Maui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoPopsUI.Maui.ViewModels;

public partial class Browser : ObservableObject
{

    public string? WebsitePickerTitle { get; set; }

    public IList<Website>? WebsitePickerItemsSource { get; set; }

    public Website? WebsitePickerSelectedItem { get; set; }

    public object? GoToHomeImageButtonSource { get; set; }

    public object? GoToHomeImageButtonCommand { get; set; }

    public CustomWebView? CustomWebViewSource { get; set; }

    public void CustomWebViewNavigating(object? sender, WebNavigatingEventArgs e)
    {
        throw new NotImplementedException();
    }

    public void ShellTitleViewOnPinchedUpdated(object? sender, PinchGestureUpdatedEventArgs e)
    {
        throw new NotImplementedException();
    }

    public void WebsitePickerSelectedIndexChanged(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }
}
