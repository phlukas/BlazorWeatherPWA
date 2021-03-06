// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WeatherBlazorPWA.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\lukas\Desktop\Projektai\WeatherBlazorPWA\WeatherBlazorPWA\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lukas\Desktop\Projektai\WeatherBlazorPWA\WeatherBlazorPWA\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lukas\Desktop\Projektai\WeatherBlazorPWA\WeatherBlazorPWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lukas\Desktop\Projektai\WeatherBlazorPWA\WeatherBlazorPWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lukas\Desktop\Projektai\WeatherBlazorPWA\WeatherBlazorPWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lukas\Desktop\Projektai\WeatherBlazorPWA\WeatherBlazorPWA\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lukas\Desktop\Projektai\WeatherBlazorPWA\WeatherBlazorPWA\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lukas\Desktop\Projektai\WeatherBlazorPWA\WeatherBlazorPWA\_Imports.razor"
using WeatherBlazorPWA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lukas\Desktop\Projektai\WeatherBlazorPWA\WeatherBlazorPWA\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\lukas\Desktop\Projektai\WeatherBlazorPWA\WeatherBlazorPWA\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\lukas\Desktop\Projektai\WeatherBlazorPWA\WeatherBlazorPWA\Components\Autocomplete.razor"
using WeatherBlazorPWA.DataModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lukas\Desktop\Projektai\WeatherBlazorPWA\WeatherBlazorPWA\Components\Autocomplete.razor"
using WeatherBlazorPWA.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lukas\Desktop\Projektai\WeatherBlazorPWA\WeatherBlazorPWA\Components\Autocomplete.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
    public partial class Autocomplete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\lukas\Desktop\Projektai\WeatherBlazorPWA\WeatherBlazorPWA\Components\Autocomplete.razor"
       
    [Parameter]
    public City SelectedCity { get; set; }
    [Parameter]
    public EventCallback<OnInputChangedEventArgs> TextChanged { get; set; }

    protected async Task<IEnumerable<City>> GetCities(string searchText)
    {
        List<City> cities = await citiesProvider.GetCities(searchText);
        if (cities.FirstOrDefault(x => x.Title == searchText) != null)
            await TextChanged.InvokeAsync(new OnInputChangedEventArgs() { City = searchText, temperatures = await temperatureProvider.GetTemperature(searchText) });
        return cities;
    }

    protected async void SelectedResultChanged(string searchText)
    {
        try
        {
            await TextChanged.InvokeAsync(new OnInputChangedEventArgs() { City = searchText, temperatures = await temperatureProvider.GetTemperature(searchText) });
        }
        catch (Exception)
        {
            await TextChanged.InvokeAsync(new OnInputChangedEventArgs() { City = searchText + " City is not found.", temperatures = null });
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CitiesProvider citiesProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TemperatureProvider temperatureProvider { get; set; }
    }
}
#pragma warning restore 1591
