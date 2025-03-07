using NoPopsUI.Maui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoPopsUI.Maui.Services
{
    public static class PreferenceManager
    {
        public static UserOptions UserOptions { get; set; } = new UserOptions();

        public static bool LoadUserPreferences()
        {
           return false;
        }

    }
}
