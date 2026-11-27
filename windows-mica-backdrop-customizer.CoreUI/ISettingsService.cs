using windows-mica-backdrop-customizer.Models;
using System.ComponentModel;

namespace windows-mica-backdrop-customizer.CoreUI;

public interface ISettingsService : INotifyPropertyChanged, IDisposable
{
    SettingsFileModel? Settings { get; set; }

    Task InitializeAsync();

    Task SaveAsync();

    Task OpenConfigurationFileAsync();
}
