#pragma checksum "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\MapDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49fa2a133bfbefcd98217e71ac5b858f15feba8b"
// <auto-generated/>
#pragma warning disable 1591
namespace Courier_service.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\_Imports.razor"
using Courier_service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\_Imports.razor"
using Courier_service.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\MapDialog.razor"
using BlazorLeaflet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\MapDialog.razor"
using BlazorLeaflet.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\MapDialog.razor"
using Courier_service.Services.LocationService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\MapDialog.razor"
using Courier_service.Models;

#line default
#line hidden
#nullable disable
    public partial class MapDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudDialog>(0);
            __builder.AddAttribute(1, "TitleContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudText>(2);
                __builder2.AddAttribute(3, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 8 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\MapDialog.razor"
                       Typo.h4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(5, "\r\n\t\t\tКарта\r\n\t\t");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(6, "DialogContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "style", "width: 100%; height: 400px;");
                __builder2.OpenComponent<BlazorLeaflet.LeafletMap>(9);
                __builder2.AddAttribute(10, "Map", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorLeaflet.Map>(
#nullable restore
#line 14 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\MapDialog.razor"
                              mapController.Map

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(11, "DialogActions", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudButton>(12);
                __builder2.AddAttribute(13, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\MapDialog.razor"
                            Cancel

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(15, "Закрыть");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\MapDialog.razor"
       
	[CascadingParameter] MudDialogInstance MudDialog { get; set; }
	[Parameter] public MapController mapController { get; set; }
	[Parameter] public Route route { get; set; }

	protected async override Task OnInitializedAsync()
	{
		await Task.Delay(500);
		ShowRoute();
	}

	void ShowRoute()
	{
		LatLng sc = LocationDistance.ParseLatLng(route.StartCoordinates);
		LatLng fc = LocationDistance.ParseLatLng(route.FinishCoordinates);
		if (sc != null && fc != null)
		{
			mapController.AddMarker(new Marker(sc) { Popup = new Popup() { Content = route.StartName } });
			mapController.AddMarker(new Marker(fc) { Popup = new Popup() { Content = route.FinishName } });
			mapController.AddPathAndBound($"[{route.StartCoordinates},{route.FinishCoordinates}]",
				$"Расстояние: {LocationDistance.DistanceBetweenPlaces(sc, fc).ToString("N0") + " м"}");

		}
	}

	void Cancel() => MudDialog.Cancel();

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
