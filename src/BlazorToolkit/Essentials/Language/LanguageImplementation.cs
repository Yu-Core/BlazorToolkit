using Microsoft.JSInterop;

namespace BlazorToolkit.Essentials
{
    public class LanguageImplementation : ILanguage
    {
        private readonly JSBinder _jsBinder = default!;
        public event Action<string>? BrowserLanguageChanged;

        public LanguageImplementation(IJSRuntime jSRuntime)
        {
            _jsBinder = new JSBinder(jSRuntime, "./_content/Yu-Core.BlazorToolkit/js/language.js");
        }

        [JSInvokable]
        public void NotifyChanged(string value)
        {
            BrowserLanguageChanged?.Invoke(value);
        }

        public async Task<string> GetBrowserLanguageAsync()
        {
            var module = await _jsBinder.GetModule();
            return await module.InvokeAsync<string>("getBrowserLanguage", new object[] { });
        }

        public async Task AddListent()
        {
            var dotNetCallbackRef = DotNetObjectReference.Create(this);
            var module = await _jsBinder.GetModule();
            await module.InvokeVoidAsync("followBrowserLanguage", new object[2] { dotNetCallbackRef, "NotifyChanged" });
        }
    }
}
