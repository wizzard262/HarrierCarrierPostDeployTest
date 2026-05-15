using HarrierCarrierPostDeployTest.Hooks;
using HarrierCarrierPostDeployTest.Support;
using Microsoft.Playwright;
using Reqnroll;

namespace HarrierCarrierPostDeployTest.Steps;

[Binding]
public class HarrierCarrierHomepageSteps
{
    [Given("I am on the Harrier Carrier Homepage")]
    public async Task GivenIAmOnTheHarrierCarrierHomepage()
    {
        await PlaywrightHooks.Page.GotoAsync(TestConfig.BaseUrl);
    }
    [When(@"I click the Google Play link")]
    public async Task WhenIClickTheGooglePlayLink()
    {
        await PlaywrightHooks.Page.ClickAsync("a[href*='play.google.com']");
    }

    [When(@"I click the YouTube link")]
    public async Task WhenIClickTheYouTubeLink()
    {
        await PlaywrightHooks.Page.ClickAsync("a[href*='www.youtube.com']");
    }

    [When(@"I click the PlayNow link")]
    public async Task WhenIClickThePlayNowLink()
    {
        await PlaywrightHooks.Page.ClickAsync("a[href*='game/index.htm']");
    }

    [When(@"I click the Poster link")]
    public async Task WhenIClickThePosterLink()
    {
        await PlaywrightHooks.Page.ClickAsync("a[href*='assets/harrier_carrier_poster.png']");
    }

    [When(@"I click the BattleOfHoth link")]
    public async Task WhenIClickTheBattleOfHothLink()
    {
        await PlaywrightHooks.Page.ClickAsync("a[href*='battleofhoth/index.html']");
    }

    [Then(@"I should be redirected to ""(.*)""")]
    public async Task ThenIShouldBeRedirectedTo(string expectedUrl)
    {
        // Wait for navigation to complete
        await PlaywrightHooks.Page.WaitForLoadStateAsync(LoadState.NetworkIdle);

        var actualUrl = PlaywrightHooks.Page.Url;

        Assert.That(actualUrl.StartsWith(expectedUrl),
            $"Expected redirect to '{expectedUrl}' but got '{actualUrl}'");
    }

    [Then(@"the image ""(.*)"" should be visible")]
    public async Task ThenTheImageShouldBeVisible(string imageName)
    {
        //confirms it’s in the DOM and visible
        var img = PlaywrightHooks.Page.Locator($"img[src*='{imageName}']");
        await Assertions.Expect(img).ToBeVisibleAsync();

        //confirms the browser actually loaded the image file
        var naturalWidth = await img.EvaluateAsync<int>("e => e.naturalWidth");
        Assert.That(naturalWidth, Is.GreaterThan(0), $"Image '{imageName}' failed to load.");
    }
}