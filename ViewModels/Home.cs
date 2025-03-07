using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoPopsUI.Maui.ViewModels;

/// <summary>
/// Viewmodel for HomePage
/// </summary>
public partial class Home : ObservableObject
{
    /// <summary>
    /// Get or set more app information.
    /// </summary>
    public MoreAppInfo? AppInfo { get; set; } = new();
}
