#pragma checksum "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c6033488596eff33bc5d678f30eea639ef3a7aa"
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
#nullable restore
#line 2 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\MainLayout.razor"
using Courier_service.Components;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudLayout>(2);
                __builder2.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudSwipeArea>(4);
                    __builder3.AddAttribute(5, "OnSwipe", new System.Action<MudBlazor.SwipeDirection>(
#nullable restore
#line 7 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\MainLayout.razor"
                                    OnSwipe

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(6, "Style", "width: 100%;");
                    __builder3.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudAppBar>(8);
                        __builder4.AddAttribute(9, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\MainLayout.razor"
                                      1

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudIconButton>(11);
                            __builder5.AddAttribute(12, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\MainLayout.razor"
                                          Icons.Material.Filled.Menu

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(13, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 9 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\MainLayout.razor"
                                                                             Color.Inherit

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(14, "Edge", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Edge>(
#nullable restore
#line 9 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\MainLayout.razor"
                                                                                                  Edge.Start

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(15, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\MainLayout.razor"
                                                                                                                        ToggleDrawer

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(16, "\r\n\t\t\t\t\t");
                            __builder5.OpenComponent<MudBlazor.MudAppBarSpacer>(17);
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(18, "\r\n\t\t\t\t\t");
                            __builder5.OpenComponent<Courier_service.Shared.LoginDisplay>(19);
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(20, "\r\n\t\t\t\t");
                        __builder4.OpenComponent<MudBlazor.MudDrawer>(21);
                        __builder4.AddAttribute(22, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 13 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\MainLayout.razor"
                                                         1

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(23, "Open", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\MainLayout.razor"
                                        open

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(24, "OpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => open = __value, open))));
                        __builder4.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Courier_service.Shared.NavMenu>(26);
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(27, "\r\n\t\t\t\t");
                        __builder4.OpenComponent<MudBlazor.MudMainContent>(28);
                        __builder4.AddAttribute(29, "Class", "pt-16 px-16");
                        __builder4.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudContainer>(31);
                            __builder5.AddAttribute(32, "Class", "mt-6");
                            __builder5.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(34, 
#nullable restore
#line 18 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\MainLayout.razor"
                         Body

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(35, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<Courier_service.Components.MainView>(36);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\MainLayout.razor"
      
	bool open = false;

	void ToggleDrawer()
	{
		open = !open;
	}

	public void OnSwipe(SwipeDirection direction)
	{
		if (direction == SwipeDirection.LeftToRight && !open)
		{
			open = true;
			StateHasChanged();
		}
		else if (direction == SwipeDirection.RightToLeft && open)
		{
			open = false;
			StateHasChanged();
		}
	}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
