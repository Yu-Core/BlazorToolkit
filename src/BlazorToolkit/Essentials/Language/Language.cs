using Microsoft.JSInterop;

namespace BlazorToolkit.Essentials
{
    public static class Language
    {
        static Lazy<ILanguage> defaultImplementation = default!;

        public static ILanguage Default => defaultImplementation.Value;

        public static event Action<string>? BrowserLanguageChanged;
        public static Task<string> GetBrowserLanguageAsync() 
            => Default.GetBrowserLanguageAsync();

        internal static async Task InitializeAsync(IJSRuntime jSRuntime)
        {
            defaultImplementation = new(new LanguageImplementation(jSRuntime));
            Default.BrowserLanguageChanged += NotifyChanged;
            await Default.AddListent();
        }

        private static void NotifyChanged(string value)
        {
            BrowserLanguageChanged?.Invoke(value);
        }
    }
}
