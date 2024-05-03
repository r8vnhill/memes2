using Microsoft.JSInterop;

namespace Ravenhill.Data;

/// <summary>
///     Provides services to manage and apply themes in the application.
/// </summary>
public class ThemeService {
    private readonly IJSRuntime _jsRuntime;

    /// <summary>
    ///     Initializes a new instance of the <see cref="ThemeService" /> class.
    /// </summary>
    /// <param name="jsRuntime">The JSRuntime instance used for calling JavaScript functions.</param>
    public ThemeService(IJSRuntime jsRuntime) {
        _jsRuntime = jsRuntime;
    }

    /// <summary>
    ///     Gets the current theme applied in the application. Default is "dark".
    /// </summary>
    public string CurrentTheme { get; private set; } = "dark";

    /// <summary>
    ///     Initializes the theme based on the value stored in localStorage. If no theme is stored, defaults to "dark".
    /// </summary>
    public async Task InitializeThemeAsync() {
        var savedTheme = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", "theme");
        CurrentTheme = string.IsNullOrEmpty(savedTheme) ? "dark" : savedTheme;
        await ApplyThemeAsync(CurrentTheme);
    }

    /// <summary>
    ///     Toggles the current theme between "light" and "dark" and applies the change.
    /// </summary>
    public async Task ToggleThemeAsync() {
        CurrentTheme = CurrentTheme == "light" ? "dark" : "light";
        await ApplyThemeAsync(CurrentTheme);
    }

    /// <summary>
    ///     Applies the specified theme by setting it in localStorage and as a data attribute on the document element.
    /// </summary>
    /// <param name="theme">The theme to apply ("light" or "dark").</param>
    private async Task ApplyThemeAsync(string theme) {
        await _jsRuntime.InvokeVoidAsync("localStorage.setItem", "theme", theme);
        await _jsRuntime.InvokeVoidAsync("document.documentElement.setAttribute", "data-theme", theme);
    }
}