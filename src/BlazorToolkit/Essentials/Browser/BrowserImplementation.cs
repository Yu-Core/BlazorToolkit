using Microsoft.JSInterop;

namespace BlazorToolkit.Essentials
{
    public class BrowserImplementation : IBrowser
    {
        private readonly JSBinder _jsBinder = default!;

        public BrowserImplementation(IJSRuntime jSRuntime)
        {
            _jsBinder = new JSBinder(jSRuntime, "./_content/Yu-Core.BlazorToolkit/js/browser.js");
        }

        public async Task OpenAsync(string uri)
        {
            var module = await _jsBinder.GetModule();
            await module.InvokeVoidAsync("openBrowser", new object[2] { uri, uri });
        }
    }
}
