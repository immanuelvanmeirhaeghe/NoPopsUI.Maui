using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoPopsUI.Maui.ViewModels
{
    public partial class Options : ObservableObject
    {
        public object? AddWebsiteEntryText { get; set; }
        public object? WebsitePickerItemsSource { get; set; }
        public object? WebsitePickerSelectedItem { get; set; }

        public void AddWebsiteEntryTextChanged(object? sender, TextChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void CustomCheckBoxCheckedChanged(object? sender, CheckedChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void WebsitePickerSelectedIndexChanged(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
