namespace windows-mica-backdrop-customizer.CoreUI;

public interface IThemingService
{
    bool IsDarkMode();

    event EventHandler? ThemeChanged;
}