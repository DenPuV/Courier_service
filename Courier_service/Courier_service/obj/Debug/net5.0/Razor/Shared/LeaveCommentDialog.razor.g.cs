#pragma checksum "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\LeaveCommentDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9780de1790bff154cdc3f0aed1bf7faae48c3480"
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
#line 1 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\LeaveCommentDialog.razor"
using Courier_service.Models;

#line default
#line hidden
#nullable disable
    public partial class LeaveCommentDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudDialog>(0);
            __builder.AddAttribute(1, "TitleContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudText>(2);
                __builder2.AddAttribute(3, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 7 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\LeaveCommentDialog.razor"
                       Typo.h4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(5, "\r\n\t\t\tКомментарий\r\n\t\t");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(6, "DialogContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __Blazor.Courier_service.Shared.LeaveCommentDialog.TypeInference.CreateMudTextField_0(__builder2, 7, 8, 
#nullable restore
#line 12 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\LeaveCommentDialog.razor"
                             10

#line default
#line hidden
#nullable disable
                , 9, "Ваш комментарий", 10, 
#nullable restore
#line 12 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\LeaveCommentDialog.razor"
                                                                         true

#line default
#line hidden
#nullable disable
                , 11, 
#nullable restore
#line 12 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\LeaveCommentDialog.razor"
                                                                                             comment

#line default
#line hidden
#nullable disable
                , 12, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => comment = __value, comment)));
            }
            ));
            __builder.AddAttribute(13, "DialogActions", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudButton>(14);
                __builder2.AddAttribute(15, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\LeaveCommentDialog.razor"
                            Cancel

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(17, "Отмена");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n\t\t");
                __builder2.OpenComponent<MudBlazor.MudButton>(19);
                __builder2.AddAttribute(20, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 16 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\LeaveCommentDialog.razor"
                          Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\LeaveCommentDialog.razor"
                                                  Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(23, "Сохранить");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "D:\Курьерская служба\Courier_service\Courier_service\Courier_service\Shared\LeaveCommentDialog.razor"
       
	[CascadingParameter] MudDialogInstance MudDialog { get; set; }

	[Parameter] public int orderId { get; set; }
	[Parameter] public DatabaseService databaseService { get; set; }

	string comment { get; set; } = "";

	void Submit()
	{
		if (comment != "")
		{
			try
			{
				databaseService.AddComment(comment, orderId);
				Snackbar.Add("Комментарий сохранен!", Severity.Success);
				MudDialog.Close(DialogResult.Ok(true));
			}
			catch
			{
				Snackbar.Add("Что-то пошло не так!", Severity.Error);
				Cancel();
			}
		}
		else Snackbar.Add("Комментарий пустой!", Severity.Warning);
	}

	void Cancel() => MudDialog.Cancel();

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
    }
}
namespace __Blazor.Courier_service.Shared.LeaveCommentDialog
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Int32 __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Lines", __arg0);
        __builder.AddAttribute(__seq1, "Placeholder", __arg1);
        __builder.AddAttribute(__seq2, "Required", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
