using Microsoft.JSInterop;

namespace BlazorToolkit.Essentials
{
    public class ThemeImplementation : ITheme
    {
        private JSBinder _jsBinder = default!;
        public event Action<AppTheme>? SystemThemeChanged;

        [JSInvokable]
        public void NotifyChanged(bool value)
        {
            SystemThemeChanged?.Invoke(value ? AppTheme.Dark : AppTheme.Light);
        }

        public async Task<AppTheme> GetSystemThemeAsync()
        {
            var module = await _jsBinder.GetModule();
            var dark = await module.InvokeAsync<bool>("systemIsDarkTheme", new object[] { });
            return dark ? AppTheme.Dark : AppTheme.Light;
        }

        public async Task InitializeAsync(IJSRuntime jSRuntime)
        {
            _jsBinder = new JSBinder(jSRuntime, "./_content/Yu-Core.BlazorToolkit/js/theme.js");
            await AddListentAsync();
        }

        private async Task AddListentAsync()
        {
            var dotNetCallbackRef = DotNetObjectReference.Create(this);
            var module = await _jsBinder.GetModule();
            await module.InvokeVoidAsync("followSystemTheme", new object[2] { dotNetCallbackRef, "NotifyChanged" });
        }
    }
}
