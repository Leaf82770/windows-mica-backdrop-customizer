using windows-mica-backdrop-customizer.Models;
using System;

namespace windows-mica-backdrop-customizer.App.Helpers;

public static class EnumHelper
{
    private static TitleBarColorMode[]? _titleBarColorModes;

    public static TitleBarColorMode[] TitleBarColorModes
    {
        get
        {
            return _titleBarColorModes ??= Enum.GetValues<TitleBarColorMode>();
        }
    }

    private static CornerPreference[]? _cornerPreferences;

    public static CornerPreference[] CornerPreferences
    {
        get
        {
            return _cornerPreferences ??= Enum.GetValues<CornerPreference>();
        }
    }
}