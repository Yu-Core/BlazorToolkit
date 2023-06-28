using Microsoft.JSInterop;

namespace BlazorToolkit.Essentials
{
    public class BrowserImplementation : IBrowser
    {
        private JSBinder _jsBinder = default!;

        public async Task OpenAsync(string uri)
        {
            var module = await _jsBinder.GetModule();
            await module.InvokeVoidAsync("openBrowser", new object[2] { uri, uri });
        }

        public void Initialize(IJSRuntime jSRuntime)
        {
            _jsBinder = new JSBinder(jSRuntime, "./_content/Yu-Core.BlazorToolkit/js/browser.js");
        }
    }
}
