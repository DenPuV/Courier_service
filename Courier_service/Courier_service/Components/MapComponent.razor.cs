using BlazorLeaflet;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Courier_service.Services.LocationService;
using System.Net.Http;
using System;

namespace Courier_service.Components
{

	public class MapComponentCode : ComponentBase
	{
		[Inject]
		public IJSRuntime jsRuntime { get; set; }
		[Inject]
		public IHttpClientFactory clientFactory { get; set; }

		[Parameter]
		public EventCallback<MapController> OnControllerReady { get; set; }
		[Parameter]
		public MapController MapController { get; set; } = null;
		[Parameter]
		public Map Map { get; set; } = null;

		public bool initialized = false;

        protected override void OnInitialized()
        {
			
        }
    }
}
