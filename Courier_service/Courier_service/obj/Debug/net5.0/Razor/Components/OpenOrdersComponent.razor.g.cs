#pragma checksum "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\OpenOrdersComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "193312da1c2e11f647450ec3f91859f2c2605f13"
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
    public partial class OpenOrdersComponent : OpenOrders
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\OpenOrdersComponent.razor"
 if (CountersLoaded)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MudBlazor.MudText>(0);
            __builder.AddAttribute(1, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 5 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\OpenOrdersComponent.razor"
                   Typo.h5

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(3, 
#nullable restore
#line 5 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\OpenOrdersComponent.razor"
                             Message

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 6 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\OpenOrdersComponent.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MudBlazor.MudSkeleton>(4);
            __builder.AddAttribute(5, "SkeletonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.SkeletonType>(
#nullable restore
#line 9 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\OpenOrdersComponent.razor"
                               SkeletonType.Text

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "Width", "100");
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n\t");
            __builder.OpenComponent<MudBlazor.MudSkeleton>(8);
            __builder.AddAttribute(9, "SkeletonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.SkeletonType>(
#nullable restore
#line 10 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\OpenOrdersComponent.razor"
                               SkeletonType.Text

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "Width", "80");
            __builder.CloseComponent();
#nullable restore
#line 11 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Components\OpenOrdersComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591