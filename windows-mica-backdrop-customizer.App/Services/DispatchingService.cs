using windows-mica-backdrop-customizer.App.Dispatching;
using windows-mica-backdrop-customizer.CoreUI;
using Microsoft.UI.Dispatching;
using System.Threading.Tasks;

namespace windows-mica-backdrop-customizer.App.Services;

public sealed class DispatchingService : IDispatchingService
{
    private DispatcherQueueValueTaskSource _dispatcherQueueValueTaskSource;

    public DispatchingService(DispatcherQueue dispatcherQueue)
    {
        _dispatcherQueueValueTaskSource = new(dispatcherQueue);
    }

    public ValueTask YieldAsync()
        => new ValueTask(_dispatcherQueueValueTaskSource, 0);
}
