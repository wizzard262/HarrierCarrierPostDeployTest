using Microsoft.Playwright;
using Reqnroll;

namespace HarrierCarrierPostDeployTest.Hooks;

[Binding]
public class PlaywrightHooks
{
    public static IPlaywright? Playwright { get; private set; }
    public static IBrowser? Browser { get; private set; }
    public static IPage? Page { get; private set; }

    [BeforeTestRun]
    public static async Task BeforeTestRun()
    {
        Playwright = await Microsoft.Playwright.Playwright.CreateAsync();
        Browser = await Playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = true
        });

        var context = await Browser.NewContextAsync();
        Page = await context.NewPageAsync();
    }

    [AfterTestRun]
    public static async Task AfterTestRun()
    {
        await Browser?.CloseAsync();
        Playwright?.Dispose();
    }
}
