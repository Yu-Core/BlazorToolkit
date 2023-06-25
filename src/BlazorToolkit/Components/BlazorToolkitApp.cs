using BlazorToolkit.Essentials;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorToolkit
{
    public class BlazorToolkitApp : ComponentBase
    {
        [Inject]
        private IJSRuntime JS { get; set; } = default!;
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if(firstRender)
            {
                await Theme.InitializeAsync(JS);
                await Language.InitializeAsync(JS);
            }
            await base.OnAfterRenderAsync(firstRender);
        }
    }
}
