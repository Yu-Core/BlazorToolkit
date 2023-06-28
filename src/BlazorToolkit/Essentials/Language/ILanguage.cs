using Microsoft.JSInterop;

namespace BlazorToolkit.Essentials
{
    public interface ILanguage
    {
        event Action<string>? BrowserLanguageChanged;
        Task<string> GetBrowserLanguageAsync();
        internal Task InitializeAsync(IJSRuntime jSRuntime);
    }
}
