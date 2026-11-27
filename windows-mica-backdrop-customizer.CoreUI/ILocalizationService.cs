using windows-mica-backdrop-customizer.Models;

namespace windows-mica-backdrop-customizer.CoreUI;

public interface ILocalizationService
{
    string GetLocalizedString(string key);

    string GetLocalizedTitleBarColor(TitleBarColorMode titleBarColorMode);

    string GetLocalizedBackdropType(BackdropType backdropType);

    string GetLocalizedCornerPreference(CornerPreference cornerPreference);

    string GetRuleName(Rule rule);
}