﻿using Microsoft.JSInterop;

namespace BlazorToolkit
{
    internal class JSBinder
    {
        internal IJSRuntime JSRuntime;
        private readonly string _importPath;
        private Task<IJSObjectReference>? _module;

        public JSBinder(IJSRuntime jsRuntime, string importPath)
        {
            JSRuntime = jsRuntime;
            _importPath = importPath;
        }

        internal async Task<IJSObjectReference> GetModule()
        {
            return await (_module ??= JSRuntime.InvokeAsync<IJSObjectReference>("import", _importPath).AsTask());
        }

        /// <inheritdoc/>
        public async ValueTask DisposeAsync()
        {
            if (_module != null)
            {
                var module = await _module;
                await module.DisposeAsync();
            }
        }
    }
}
