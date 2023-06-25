using Microsoft.JSInterop;

namespace BlazorToolkit.Essentials
{
    public static class Browser
    {
        static Lazy<IBrowser> defaultImplementation = default!;
        public static IBrowser Default => defaultImplementation.Value;

        public static Task OpenAsync(string uri)
            => defaultImplementation.Value.OpenAsync(uri);

        internal static void InitializeAsync(IJSRuntime jSRuntime)
        {
            defaultImplementation = new(new BrowserImplementation(jSRuntime));
        }
    }
}
