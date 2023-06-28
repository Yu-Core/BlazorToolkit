using Microsoft.JSInterop;

namespace BlazorToolkit.Essentials
{
    public interface ITheme
    {
        event Action<AppTheme>? SystemThemeChanged;
        Task<AppTheme> GetSystemThemeAsync();
        internal Task InitializeAsync(IJSRuntime jSRuntime);
    }
}
