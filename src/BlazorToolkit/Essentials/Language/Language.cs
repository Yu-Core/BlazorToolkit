using Microsoft.JSInterop;

namespace BlazorToolkit.Essentials
{
    public static class Language
    {
        static readonly Lazy<ILanguage> defaultImplementation = new(new LanguageImplementation());
        public static ILanguage Default => defaultImplementation.Value;
        public static event Action<string>? BrowserLanguageChanged;

        public static Task<string> GetBrowserLanguageAsync() 
            => Default.GetBrowserLanguageAsync();

        internal static async Task InitializeAsync(IJSRuntime jSRuntime)
        {

            await Default.InitializeAsync(jSRuntime);
            Default.BrowserLanguageChanged += NotifyChanged;
        }

        private static void NotifyChanged(string value)
        {
            BrowserLanguageChanged?.Invoke(value);
        }
    }
}
