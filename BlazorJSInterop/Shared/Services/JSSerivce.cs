using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorJSInterop.Shared.Services
{
    public class JSSerivce
    {
        private readonly IJSRuntime _jsRuntime;
        public JSSerivce(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public Task<string> SetText(string text)
        {
            return _jsRuntime.InvokeAsync<string>(
            "SetText",
            text);
        }
    }
}
