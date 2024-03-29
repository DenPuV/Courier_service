// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Courier_service.Components
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
#line 1 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\NewClientComponent.razor"
using Courier_service.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\NewClientComponent.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    public partial class NewClientComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\NewClientComponent.razor"
       
	[Parameter]
	public EventCallback<Client> OnClickCallback { get; set; }

	[Parameter]
	public Client Client { get; set; } = null;

	public bool varified = false;
	public bool textDis = false;
	public bool downloading = true;

	public string FNameTextValue { get; set; } = "";
	public string SNameTextValue { get; set; } = "";
	public string PatronymicTextValue { get; set; } = "";

	public void Varify()
	{
		if (FNameTextValue != "" && SNameTextValue != "") varified = true;
	}

	public void StoreData()
	{
		Client newClient = null;
		if (Client != null) newClient = Client;
		else
		{
			newClient = new Client()
			{
				Deleted = false,
				AspName = null
			};
		}
		newClient.FName = FNameTextValue;
		newClient.SName = SNameTextValue;
		newClient.Patronymic = PatronymicTextValue;

		if (varified)
		{
			textDis = true;
			OnClickCallback.InvokeAsync(newClient);
		}
	}

	protected override void OnInitialized()
	{
		if (Client != null)
		{
			FNameTextValue = Client.FName;
			SNameTextValue = Client.SName;
			PatronymicTextValue = Client.Patronymic;
			downloading = false;
			this.StateHasChanged();
		}
	}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
