using Microsoft.JSInterop;

namespace Ravenhill.Data;

public class ThemeService {
    private readonly IJSRuntime _jsRuntime;

    public ThemeService(IJSRuntime jsRuntime) {
        _jsRuntime = jsRuntime;
    }

    public string CurrentTheme { get; private set; } = "dark"; // Default to dark

    public async Task InitializeThemeAsync() {
        var savedTheme = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", "theme");
        CurrentTheme = string.IsNullOrEmpty(savedTheme) ? "dark" : savedTheme; // Default to dark if nothing is saved
        await ApplyThemeAsync(CurrentTheme);
    }

    public async Task ToggleThemeAsync() {
        CurrentTheme = CurrentTheme == "light" ? "dark" : "light";
        await ApplyThemeAsync(CurrentTheme);
    }

    private async Task ApplyThemeAsync(string theme) {
        await _jsRuntime.InvokeVoidAsync("localStorage.setItem", "theme", theme);
        await _jsRuntime.InvokeVoidAsync("document.documentElement.setAttribute", "data-theme", theme);
    }
}