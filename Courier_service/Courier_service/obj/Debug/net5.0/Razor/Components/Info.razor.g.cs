#pragma checksum "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\Info.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c8522582f7d31caf0a5a7200ede8c2a5e2e6d5c"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\Info.razor"
using Courier_service.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/settings")]
    public partial class Info : OwningComponentBase<DatabaseService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "h1");
                __builder2.AddContent(3, "Hello ");
                __builder2.AddContent(4, 
#nullable restore
#line 7 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\Info.razor"
                   context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(5, "!");
                __builder2.CloseElement();
#nullable restore
#line 8 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\Info.razor"
         if (clients == null)
		{

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudSkeleton>(6);
                __builder2.AddAttribute(7, "SkeletonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.SkeletonType>(
#nullable restore
#line 10 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\Info.razor"
                                        SkeletonType.Rectangle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "Width", "30%");
                __builder2.AddAttribute(9, "Height", "50px");
                __builder2.CloseComponent();
#nullable restore
#line 11 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\Info.razor"
		}
		else
		{

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(10, "table");
                __builder2.AddAttribute(11, "border", "1");
                __builder2.AddMarkupContent(12, "<tr><th>Id</th>\r\n\t\t\t\t\t<th>FName</th>\r\n\t\t\t\t\t<th>SName</th>\r\n\t\t\t\t\t<th>Patronimyc</th>\r\n\t\t\t\t\t<th>AspName</th></tr>");
#nullable restore
#line 22 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\Info.razor"
                 foreach (Client item in clients)
				{

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(13, "tr");
                __builder2.OpenElement(14, "td");
                __builder2.AddContent(15, 
#nullable restore
#line 25 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\Info.razor"
                             item.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n\t\t\t\t\t\t");
                __builder2.OpenElement(17, "td");
                __builder2.AddContent(18, 
#nullable restore
#line 26 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\Info.razor"
                             item.FName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n\t\t\t\t\t\t");
                __builder2.OpenElement(20, "td");
                __builder2.AddContent(21, 
#nullable restore
#line 27 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\Info.razor"
                             item.SName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n\t\t\t\t\t\t");
                __builder2.OpenElement(23, "td");
                __builder2.AddContent(24, 
#nullable restore
#line 28 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\Info.razor"
                             item.Patronymic

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n\t\t\t\t\t\t");
                __builder2.OpenElement(26, "td");
                __builder2.AddContent(27, 
#nullable restore
#line 29 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\Info.razor"
                             item.AspName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 31 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\Info.razor"
				}

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 32 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\Info.razor"
                    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.AddAttribute(28, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(29, "<h3>Log in first!</h3>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\Info.razor"
       
	public System.Collections.Generic.IList<Client> clients;

	protected override async void OnInitialized()
	{
		clients = await Service.ClientDataAsync();
		try { this.StateHasChanged(); }
		catch { }
	}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591