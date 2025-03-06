using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoPopsUI.Maui.Services
{
    public static class ExceptionManager
    {
        public static async Task DisplayErrorAlert(string message, Exception exc, object v, ShellNavigatingEventArgs e)
        {
            throw new NotImplementedException();
        }

        public static async Task DisplayErrorAlert(string message, Exception exc, ShellNavigatingEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
