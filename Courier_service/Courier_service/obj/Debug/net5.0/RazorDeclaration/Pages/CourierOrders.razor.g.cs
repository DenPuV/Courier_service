// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Courier_service.Pages
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
#line 3 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Pages\CourierOrders.razor"
using Courier_service.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Pages\CourierOrders.razor"
using BlazorLeaflet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Pages\CourierOrders.razor"
using BlazorLeaflet.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Pages\CourierOrders.razor"
using Courier_service.Services.LocationService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Pages\CourierOrders.razor"
           [Authorize(Roles = "Courier")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/courierorders")]
    public partial class CourierOrders : CourierOrdersCode
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 115 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Pages\CourierOrders.razor"
      
	[Inject]
	IJSRuntime _jsRuntime { get; set; }
	public bool mapReady { get; set; } = false;
	protected Map _map { get; set; }


	protected override void OnInitialized()
	{
		_map = new Map(_jsRuntime)
		{
			Center = new LatLng(58.6035f, 49.668f),
			Zoom = 10,
			ZoomControl = false,
			MaxBounds = Tuple.Create<LatLng, LatLng>(new LatLng(58.6784f, 49.4508f), new LatLng(58.545f, 49.8065f))
		};
		_map.OnInitialized += () =>
		{
			_mapController = new MapController(_jsRuntime, _clientFactory, _map);
			mapReady = true;
		};

		_map.RaiseOnInitialized();
	}

	public void showRouteOnMap(Route route)
	{
		if (mapReady)
		{
			var parameters = new DialogParameters { ["route"] = route, ["mapController"] = _mapController };
			var options = new DialogOptions { MaxWidth = MaxWidth.Medium, FullWidth = true };

			DialogService.Show<MapDialog>("Map", parameters, options);
		}
	}



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService DialogService { get; set; }
    }
}
#pragma warning restore 1591
