#pragma checksum "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3192c33cbe236f3f92dde0a23c9d13a1ae30ccd"
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
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Roles", "Client");
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudIconButton>(3);
                __builder2.AddAttribute(4, "Link", "Identity/Account/Manage");
                __builder2.AddAttribute(5, "Target", "_self");
                __builder2.AddAttribute(6, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 5 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\LoginDisplay.razor"
                                  Icons.Filled.Settings

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 6 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\LoginDisplay.razor"
                                  Color.Inherit

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(9);
            __builder.AddAttribute(10, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(11, "form");
                __builder2.AddAttribute(12, "method", "post");
                __builder2.AddAttribute(13, "action", "Identity/Account/LogOut");
                __builder2.OpenComponent<MudBlazor.MudIconButton>(14);
                __builder2.AddAttribute(15, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\LoginDisplay.razor"
                                      Icons.Filled.Logout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.ButtonType>(
#nullable restore
#line 14 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\LoginDisplay.razor"
                                           ButtonType.Submit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 15 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\LoginDisplay.razor"
                                      Color.Inherit

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(18, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudIconButton>(19);
                __builder2.AddAttribute(20, "Link", "Identity/Account/Register");
                __builder2.AddAttribute(21, "Target", "_self");
                __builder2.AddAttribute(22, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\LoginDisplay.razor"
                                  Icons.Filled.AppRegistration

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 22 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\LoginDisplay.razor"
                                  Color.Inherit

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n\t\t\t");
                __builder2.OpenComponent<MudBlazor.MudIconButton>(25);
                __builder2.AddAttribute(26, "Link", "Identity/Account/Login");
                __builder2.AddAttribute(27, "Target", "_self");
                __builder2.AddAttribute(28, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\LoginDisplay.razor"
                                  Icons.Filled.Login

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 26 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\LoginDisplay.razor"
                                  Color.Inherit

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
