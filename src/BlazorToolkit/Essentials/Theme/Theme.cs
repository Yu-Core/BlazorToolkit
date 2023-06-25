using Microsoft.JSInterop;

namespace BlazorToolkit.Essentials
{
    public static class Theme
    {
        static Lazy<ITheme> defaultImplementation = default!;

        public static ITheme Default => defaultImplementation.Value;

        public static event Action<AppTheme>? SystemThemeChanged;
        public static Task<AppTheme> GetSystemThemeAsync() 
            => Default.GetSystemThemeAsync();

        internal static async Task InitializeAsync(IJSRuntime jSRuntime)
        {
            defaultImplementation = new(new ThemeImplementation(jSRuntime));
            Default.SystemThemeChanged += NotifyChanged;
            await Default.AddListent();
        }

        private static void NotifyChanged(AppTheme value)
        {
            SystemThemeChanged?.Invoke(value);
        }
    }
}
