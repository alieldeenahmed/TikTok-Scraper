using Microsoft.Playwright;

namespace TikTokTasteProfiler.Services;

public class TikTokScraperService
{
    public async Task RunAsync()
    {
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
        var page = await browser.NewPageAsync();
        await page.GotoAsync("https://www.tiktok.com/@hassannmk");

        await page.WaitForTimeoutAsync(60000);
    }
}