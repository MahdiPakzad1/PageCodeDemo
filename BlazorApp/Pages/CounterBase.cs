using Microsoft.AspNetCore.Components;

namespace BlazorApp.Pages;

public class CounterBase:ComponentBase
{
    [Inject]
    public ILogger<CounterBase> Logger { get; set; }

    protected int currentCount = 0;

    protected void IncrementCount()
    {
        currentCount++;
        Logger.LogInformation("Hello {counterValue}",currentCount);
    }
}
