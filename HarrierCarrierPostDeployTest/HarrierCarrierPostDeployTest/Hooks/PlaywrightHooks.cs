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
        Console.WriteLine("Starting Playwright setup...");

        Playwright = await Microsoft.Playwright.Playwright.CreateAsync();
        Browser = await Playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = true,
            Args = new[] { "--no-sandbox", "--disable-dev-shm-usage" }
        });

        var context = await Browser.NewContextAsync();
        Page = await context.NewPageAsync();

        Console.WriteLine("Playwright Chromium launched successfully.");
    }

    [AfterTestRun]
    public static async Task AfterTestRun()
    {
        await Browser?.CloseAsync();
        Playwright?.Dispose();
    }
}
