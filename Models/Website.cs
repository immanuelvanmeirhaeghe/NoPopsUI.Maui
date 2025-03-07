using NoPopsUI.Maui.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoPopsUI.Maui.Models;

/// <summary>
/// Represents a website.
/// </summary>
public class Website : IWebsite
{
    public Uri? BaseUri { get; set; } = null;
    public string BasePath { get; set; } = string.Empty;
    public string Host { get; set; } = string.Empty;

    public static IWebsite Create(Uri? uri)
    {
        if (uri != null)
        {
            return new Website { BaseUri = uri, BasePath = uri.AbsolutePath, Host = uri.Host };
        }
        return new Website();
    }
}
