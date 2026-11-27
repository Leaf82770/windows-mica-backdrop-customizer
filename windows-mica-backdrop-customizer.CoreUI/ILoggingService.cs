namespace windows-mica-backdrop-customizer.CoreUI;

public interface ILoggingService
{
    void LogException(Exception exception);

    Task FlushAsync();
}