using windows-mica-backdrop-customizer.CoreUI;
using Windows.ApplicationModel;

namespace windows-mica-backdrop-customizer.App.Services;

public sealed class PackagedVersionInfoService : IVersionInfoService
{
    public string GetVersion()
    {
        var version = Package.Current.Id.Version;
        return $"{version.Major}.{version.Minor}.{version.Build}.{version.Revision}";
    }
}
