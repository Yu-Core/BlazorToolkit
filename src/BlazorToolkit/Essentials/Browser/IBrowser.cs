using Microsoft.JSInterop;

namespace BlazorToolkit.Essentials
{
    public interface IBrowser
    {
        Task OpenAsync(string uri);
        internal void Initialize(IJSRuntime jSRuntime);
    }
}
