namespace windows-mica-backdrop-customizer.CoreUI;

public interface IUpdateCheckerService
{
    Task<UpdateAvailability> CheckForUpdateAsync();
}

public enum UpdateAvailability
{
    NoUpdate,
    UpdateAvailable,
    Error
}