#pragma checksum "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5347323a40cf129e2b1b4b31411b2e51f948b306"
// <auto-generated/>
#pragma warning disable 1591
namespace Courier_service
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
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudDialogProvider>(2);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(3, "\r\n\t");
                __builder2.OpenComponent<MudBlazor.MudSnackbarProvider>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n\t");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(6);
                __builder2.AddAttribute(7, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 5 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\App.razor"
                          typeof(Program).Assembly

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "PreferExactMatches", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 5 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\App.razor"
                                                                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeRouteView>(10);
                    __builder3.AddAttribute(11, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 7 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\App.razor"
                                            routeData

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 7 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\App.razor"
                                                                       typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(13, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(14);
                    __builder3.AddAttribute(15, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 10 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\App.razor"
                                 typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(17, "<p>Sorry, there\'s nothing at this address.</p>");
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
    }
}
#pragma warning restore 1591