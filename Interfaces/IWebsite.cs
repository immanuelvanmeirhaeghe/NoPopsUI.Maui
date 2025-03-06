using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoPopsUI.Maui.Interfaces
{
    public interface IWebsite
    {
        public Uri? BaseUri { get; set; }
        public string BasePath { get; set; }
    }
}
