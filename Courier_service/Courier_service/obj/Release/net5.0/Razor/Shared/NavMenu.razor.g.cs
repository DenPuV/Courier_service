#pragma checksum "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e724ae9793976b99a106448c2ea94af6b0cea5e8"
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudNavMenu>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(2);
                __builder2.AddAttribute(3, "Roles", "Client");
                __builder2.AddAttribute(4, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudText>(5);
                    __builder3.AddAttribute(6, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 5 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\NavMenu.razor"
                           Typo.h4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(7, "Class", "px-4");
                    __builder3.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(9, "Client menu");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(10, "\r\n\t\t\t");
                    __builder3.OpenComponent<MudBlazor.MudDivider>(11);
                    __builder3.AddAttribute(12, "Class", "my-2");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(13, "\r\n\t\t\t");
                    __builder3.OpenComponent<MudBlazor.MudNavGroup>(14);
                    __builder3.AddAttribute(15, "Title", "Orders");
                    __builder3.AddAttribute(16, "Expanded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 7 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\NavMenu.razor"
                                                  false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(18);
                        __builder4.AddAttribute(19, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\NavMenu.razor"
                                   Icons.Filled.List

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(20, "Href", "orderslist");
                        __builder4.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(22, "Orders list");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(23, "\r\n\t\t\t\t");
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(24);
                        __builder4.AddAttribute(25, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\NavMenu.razor"
                                   Icons.Filled.Create

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(26, "Href", "neworder");
                        __builder4.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(28, "New order");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(29, "\r\n\t\t\t");
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(30);
                    __builder3.AddAttribute(31, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\NavMenu.razor"
                               Icons.Filled.Settings

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(32, "Href", "Identity/Account/Manage");
                    __builder3.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(34, "Client settings");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n\r\n\t");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(36);
                __builder2.AddAttribute(37, "Roles", "Courier");
                __builder2.AddAttribute(38, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudText>(39);
                    __builder3.AddAttribute(40, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 17 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\NavMenu.razor"
                           Typo.h4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(41, "Class", "px-4");
                    __builder3.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(43, "Courier menu");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(44, "\r\n\t\t\t");
                    __builder3.OpenComponent<MudBlazor.MudDivider>(45);
                    __builder3.AddAttribute(46, "Class", "my-2");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(47, "\r\n\t\t\t");
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(48);
                    __builder3.AddAttribute(49, "Href", "courierorders");
                    __builder3.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(51, "Orders");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n\r\n\t");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(53);
                __builder2.AddAttribute(54, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudText>(55);
                    __builder3.AddAttribute(56, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 25 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\NavMenu.razor"
                           Typo.h4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(57, "Class", "px-4");
                    __builder3.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(59, "User menu");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(60, "\r\n\t\t\t");
                    __builder3.OpenComponent<MudBlazor.MudDivider>(61);
                    __builder3.AddAttribute(62, "Class", "my-2");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(63, "\r\n\t\t\t");
                    __builder3.OpenComponent<MudBlazor.MudText>(64);
                    __builder3.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(66, "Enter all client data first!");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(67, "\r\n\t\t\t");
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(68);
                    __builder3.AddAttribute(69, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\NavMenu.razor"
                               Icons.Filled.Settings

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(70, "Href", "Identity/Account/Manage");
                    __builder3.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(72, "Client settings");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\NavMenu.razor"
      
	[CascadingParameter]
	public bool downloading { get; set; }

	public void SetDownloading() => downloading = true;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
