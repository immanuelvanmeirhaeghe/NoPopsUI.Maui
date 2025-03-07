using CommunityToolkit.Mvvm.ComponentModel;
using NoPopsUI.Maui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoPopsUI.Maui.ViewModels
{
    public partial class Options : ObservableObject
    {
        public string? AddWebsiteEntryText { get; set; }
        public IList<Website>? WebsitePickerItemsSource { get; set; }
        public Website? WebsitePickerSelectedItem { get; set; }

        public void AddWebsiteEntryTextChanged(object? sender, TextChangedEventArgs e)
        {
           
        }

        public void CustomCheckBoxCheckedChanged(object? sender, CheckedChangedEventArgs e)
        {
           
        }

        public void WebsitePickerSelectedIndexChanged(object? sender, EventArgs e)
        {
            
        }
    }
}
