#pragma checksum "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d97b49712bce0c818108f71c4ef9d856d0a6fd5e"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-yqf7u6omf0");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-yqf7u6omf0>Courier_service</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-yqf7u6omf0");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-yqf7u6omf0></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(10);
            __builder.AddAttribute(11, "Roles", "Client");
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(13, "<p style=\"color: whitesmoke;\" class=\"text-center\" b-yqf7u6omf0>Client menu</p>\r\n\t\t");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", 
#nullable restore
#line 10 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\NavMenu.razor"
                     NavMenuCssClass

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\NavMenu.razor"
                                                ToggleNavMenu

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "b-yqf7u6omf0");
                __builder2.OpenElement(18, "ul");
                __builder2.AddAttribute(19, "class", "nav flex-column");
                __builder2.AddAttribute(20, "b-yqf7u6omf0");
                __builder2.OpenElement(21, "li");
                __builder2.AddAttribute(22, "class", "nav-item px-3");
                __builder2.AddAttribute(23, "b-yqf7u6omf0");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(24);
                __builder2.AddAttribute(25, "class", "nav-link");
                __builder2.AddAttribute(26, "href", "");
                __builder2.AddAttribute(27, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 13 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\NavMenu.razor"
                                                             NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(29, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-yqf7u6omf0></span> Home\r\n\t\t\t\t\t");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n\t\t\t\t");
                __builder2.OpenElement(31, "li");
                __builder2.AddAttribute(32, "class", "nav-item px-3");
                __builder2.AddAttribute(33, "b-yqf7u6omf0");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(34);
                __builder2.AddAttribute(35, "class", "nav-link");
                __builder2.AddAttribute(36, "href", "settings");
                __builder2.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(38, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-yqf7u6omf0></span> Client settings\r\n\t\t\t\t\t");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(39, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(40);
            __builder.AddAttribute(41, "Roles", "Courier");
            __builder.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(43, "<p style=\"color: whitesmoke;\" class=\"text-center\" b-yqf7u6omf0>Courier menu</p>\r\n\t");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", 
#nullable restore
#line 28 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\NavMenu.razor"
                 NavMenuCssClass

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\NavMenu.razor"
                                            ToggleNavMenu

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "b-yqf7u6omf0");
                __builder2.OpenElement(48, "ul");
                __builder2.AddAttribute(49, "class", "nav flex-column");
                __builder2.AddAttribute(50, "b-yqf7u6omf0");
                __builder2.OpenElement(51, "li");
                __builder2.AddAttribute(52, "class", "nav-item px-3");
                __builder2.AddAttribute(53, "b-yqf7u6omf0");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(54);
                __builder2.AddAttribute(55, "class", "nav-link");
                __builder2.AddAttribute(56, "href", "");
                __builder2.AddAttribute(57, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 31 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\NavMenu.razor"
                                                         NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(59, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-yqf7u6omf0></span> Home\r\n\t\t\t\t");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n\t\t\t");
                __builder2.OpenElement(61, "li");
                __builder2.AddAttribute(62, "class", "nav-item px-3");
                __builder2.AddAttribute(63, "b-yqf7u6omf0");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(64);
                __builder2.AddAttribute(65, "class", "nav-link");
                __builder2.AddAttribute(66, "href", "map");
                __builder2.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(68, "<span class=\"oi oi-plus\" aria-hidden=\"true\" b-yqf7u6omf0></span> Map\r\n\t\t\t\t");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
