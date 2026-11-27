using CommunityToolkit.Mvvm.ComponentModel;
using windows-mica-backdrop-customizer.CoreUI;

namespace windows-mica-backdrop-customizer.App.ViewModels;

public sealed partial class SettingsViewModel : ObservableObject
{
    public ISettingsService SettingsService { get; }

    public SettingsViewModel(ISettingsService settingsService)
    {
        SettingsService = settingsService;
    }
}