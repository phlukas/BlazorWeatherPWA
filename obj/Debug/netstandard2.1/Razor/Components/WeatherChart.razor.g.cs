#pragma checksum "C:\Users\lukas\Desktop\Projektai\WeatherBlazorPWA\WeatherBlazorPWA\Components\WeatherChart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bc38421831deffaca8f0b65f7e373affc7e4f43"
// <auto-generated/>
#pragma warning disable 1591
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
#line 1 "C:\Users\lukas\Desktop\Projektai\WeatherBlazorPWA\WeatherBlazorPWA\Components\WeatherChart.razor"
using WeatherBlazorPWA.DataModels;

#line default
#line hidden
#nullable disable
    public partial class WeatherChart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenChart>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n    ");
                __Blazor.WeatherBlazorPWA.Components.WeatherChart.TypeInference.CreateRadzenLineSeries_0(__builder2, 3, 4, 
#nullable restore
#line 4 "C:\Users\lukas\Desktop\Projektai\WeatherBlazorPWA\WeatherBlazorPWA\Components\WeatherChart.razor"
                              true

#line default
#line hidden
#nullable disable
                , 5, 
#nullable restore
#line 4 "C:\Users\lukas\Desktop\Projektai\WeatherBlazorPWA\WeatherBlazorPWA\Components\WeatherChart.razor"
                                           Temperatures

#line default
#line hidden
#nullable disable
                , 6, "Date", 7, "Temperature °C", 8, 
#nullable restore
#line 4 "C:\Users\lukas\Desktop\Projektai\WeatherBlazorPWA\WeatherBlazorPWA\Components\WeatherChart.razor"
                                                                                                                  LineType.Solid

#line default
#line hidden
#nullable disable
                , 9, "Temperature", 10, (__builder3) => {
                    __builder3.AddMarkupContent(11, "\r\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMarkers>(12);
                    __builder3.AddAttribute(13, "MarkerType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Blazor.MarkerType>(
#nullable restore
#line 5 "C:\Users\lukas\Desktop\Projektai\WeatherBlazorPWA\WeatherBlazorPWA\Components\WeatherChart.razor"
                                   MarkerType.Circle

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(14, "\r\n    ");
                }
                );
                __builder2.AddMarkupContent(15, "\r\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCategoryAxis>(16);
                __builder2.AddAttribute(17, "Padding", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 7 "C:\Users\lukas\Desktop\Projektai\WeatherBlazorPWA\WeatherBlazorPWA\Components\WeatherChart.razor"
                                 20

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "FormatString", "{0:ddd, hh}");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridLines>(20);
                __builder2.AddAttribute(21, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "C:\Users\lukas\Desktop\Projektai\WeatherBlazorPWA\WeatherBlazorPWA\Components\WeatherChart.razor"
                              true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\lukas\Desktop\Projektai\WeatherBlazorPWA\WeatherBlazorPWA\Components\WeatherChart.razor"
       
    [Parameter]
    public List<TemperatureData> Temperatures { get; set; }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.WeatherBlazorPWA.Components.WeatherChart
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenLineSeries_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.Collections.Generic.IEnumerable<TItem> __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::Radzen.Blazor.LineType __arg4, int __seq5, global::System.String __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenLineSeries<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Smooth", __arg0);
        __builder.AddAttribute(__seq1, "Data", __arg1);
        __builder.AddAttribute(__seq2, "CategoryProperty", __arg2);
        __builder.AddAttribute(__seq3, "Title", __arg3);
        __builder.AddAttribute(__seq4, "LineType", __arg4);
        __builder.AddAttribute(__seq5, "ValueProperty", __arg5);
        __builder.AddAttribute(__seq6, "ChildContent", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591