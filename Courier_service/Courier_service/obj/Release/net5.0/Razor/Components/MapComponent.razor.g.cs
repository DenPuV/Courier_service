#pragma checksum "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\MapComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fc870ab32b9ddeb6f47386cf928170240852c37"
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
#line 1 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\MapComponent.razor"
using BlazorLeaflet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\MapComponent.razor"
using BlazorLeaflet.Models;

#line default
#line hidden
#nullable disable
    public partial class MapComponent : MapComponentCode
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\MapComponent.razor"
 if (!initialized)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MudBlazor.MudSkeleton>(0);
            __builder.AddAttribute(1, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\MapComponent.razor"
                       Width + "px"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\MapComponent.razor"
                                                Height + "px"

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 7 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\MapComponent.razor"
                                                                  }
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "style", "height:" + " " + (
#nullable restore
#line 10 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\MapComponent.razor"
                          Height

#line default
#line hidden
#nullable disable
            ) + "px;" + " width:" + " " + (
#nullable restore
#line 10 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\MapComponent.razor"
                                              Width

#line default
#line hidden
#nullable disable
            ) + "px;");
            __builder.OpenComponent<BlazorLeaflet.LeafletMap>(5);
            __builder.AddAttribute(6, "Map", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorLeaflet.Map>(
#nullable restore
#line 11 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\MapComponent.razor"
                          Map

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 13 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\MapComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\MapComponent.razor"
      
	[Parameter]
	public int Height { get; set; } = 500;
	[Parameter]
	public int Width { get; set; } = 500;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
