using Microsoft.JSInterop;

namespace BlazorToolkit.Essentials
{
    public static class Theme
    {
        static readonly Lazy<ITheme> defaultImplementation = new(new ThemeImplementation());

        public static ITheme Default => defaultImplementation.Value;

        public static event Action<AppTheme>? SystemThemeChanged;
        public static Task<AppTheme> GetSystemThemeAsync() 
            => Default.GetSystemThemeAsync();

        internal static async Task InitializeAsync(IJSRuntime jSRuntime)
        {
            await Default.InitializeAsync(jSRuntime);
            Default.SystemThemeChanged += NotifyChanged;
        }

        private static void NotifyChanged(AppTheme value)
        {
            SystemThemeChanged?.Invoke(value);
        }
    }
}
