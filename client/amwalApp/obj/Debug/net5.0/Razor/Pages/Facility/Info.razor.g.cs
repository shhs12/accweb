#pragma checksum "D:\accweb\client\amwalApp\Pages\Facility\Info.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c99e08fbce3afe0d27c2faf7d30460a794de862d"
// <auto-generated/>
#pragma warning disable 1591
namespace AccWeb.Pages.Facility
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\accweb\client\amwalApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\accweb\client\amwalApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\accweb\client\amwalApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\accweb\client\amwalApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\accweb\client\amwalApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\accweb\client\amwalApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\accweb\client\amwalApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\accweb\client\amwalApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\accweb\client\amwalApp\_Imports.razor"
using AccWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\accweb\client\amwalApp\_Imports.razor"
using AccWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\accweb\client\amwalApp\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\accweb\client\amwalApp\_Imports.razor"
using MudBlazor.Dialog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\accweb\client\amwalApp\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\accweb\client\amwalApp\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\accweb\client\amwalApp\_Imports.razor"
using AccWeb.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/info")]
    public partial class Info : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(0);
            __builder.AddAttribute(1, "Theme", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MudTheme>(
#nullable restore
#line 3 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                         MyCustomTheme

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenComponent<MudBlazor.MudDialogProvider>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenComponent<MudBlazor.MudSnackbarProvider>(5);
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "style", "max-width: 100%;");
            __builder.AddAttribute(9, "dir", "rtl");
            __builder.AddAttribute(10, "lang", "ar-sa");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(11);
            __builder.AddAttribute(12, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                      model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                                            OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(15);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudCard>(17);
                __builder2.AddAttribute(18, "Style", "direction:rtl; text-align:justify");
                __builder2.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudCardHeader>(20);
                    __builder3.AddAttribute(21, "Class", "alert alert-primary mt-4 ");
                    __builder3.AddAttribute(22, "CardHeaderActions", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudIconButton>(23);
                        __builder4.AddAttribute(24, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                                          Icons.Material.Save

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(25, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 13 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                                                                      MudBlazor.Color.Success

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.AddAttribute(26, "CardHeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudText>(27);
                        __builder4.AddAttribute(28, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 17 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                                   Typo.h6

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(30, "معلومات المنشأة");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\r\n\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudCardContent>(32);
                    __builder3.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __Blazor.AccWeb.Pages.Facility.Info.TypeInference.CreateMudTextField_0(__builder4, 34, 35, 
#nullable restore
#line 24 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                                       Variant.Outlined

#line default
#line hidden
#nullable disable
                        , 36, "اسم المنشأة", 37, 
#nullable restore
#line 25 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                                                               () => model.name1

#line default
#line hidden
#nullable disable
                        , 38, 
#nullable restore
#line 25 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                                           model.name1

#line default
#line hidden
#nullable disable
                        , 39, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.name1 = __value, model.name1)));
                        __builder4.AddMarkupContent(40, "\r\n\r\n\r\n                ");
                        __Blazor.AccWeb.Pages.Facility.Info.TypeInference.CreateMudTextField_1(__builder4, 41, 42, 
#nullable restore
#line 28 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                                       Variant.Outlined

#line default
#line hidden
#nullable disable
                        , 43, "النشاط", 44, 
#nullable restore
#line 29 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                                                                  () => model.activity

#line default
#line hidden
#nullable disable
                        , 45, 
#nullable restore
#line 29 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                                           model.activity

#line default
#line hidden
#nullable disable
                        , 46, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.activity = __value, model.activity)));
                        __builder4.AddMarkupContent(47, "\r\n\r\n\r\n                ");
                        __Blazor.AccWeb.Pages.Facility.Info.TypeInference.CreateMudTextField_2(__builder4, 48, 49, 
#nullable restore
#line 32 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                                       Variant.Outlined

#line default
#line hidden
#nullable disable
                        , 50, "العنوان", 51, 
#nullable restore
#line 33 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                                                                 () => model.address

#line default
#line hidden
#nullable disable
                        , 52, 
#nullable restore
#line 33 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                                           model.address

#line default
#line hidden
#nullable disable
                        , 53, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.address = __value, model.address)));
                        __builder4.AddMarkupContent(54, "\r\n\r\n                ");
                        __builder4.OpenElement(55, "div");
                        __builder4.AddAttribute(56, "class", "row");
                        __builder4.OpenElement(57, "div");
                        __builder4.AddAttribute(58, "class", "col");
                        __Blazor.AccWeb.Pages.Facility.Info.TypeInference.CreateMudTextField_3(__builder4, 59, 60, 
#nullable restore
#line 37 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                                               Variant.Outlined

#line default
#line hidden
#nullable disable
                        , 61, "التلفون", 62, 
#nullable restore
#line 38 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                                                                       () => model.phone

#line default
#line hidden
#nullable disable
                        , 63, 
#nullable restore
#line 38 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                                                   model.phone

#line default
#line hidden
#nullable disable
                        , 64, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.phone = __value, model.phone)));
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(65, "\r\n                    ");
                        __builder4.OpenElement(66, "div");
                        __builder4.AddAttribute(67, "class", "col");
                        __Blazor.AccWeb.Pages.Facility.Info.TypeInference.CreateMudTextField_4(__builder4, 68, 69, 
#nullable restore
#line 41 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                                               Variant.Outlined

#line default
#line hidden
#nullable disable
                        , 70, "الفاكس", 71, 
#nullable restore
#line 42 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                                                                     () => model.fax

#line default
#line hidden
#nullable disable
                        , 72, 
#nullable restore
#line 42 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                                                   model.fax

#line default
#line hidden
#nullable disable
                        , 73, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.fax = __value, model.fax)));
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(74, "\r\n                    ");
                        __builder4.OpenElement(75, "div");
                        __builder4.AddAttribute(76, "class", "col");
                        __Blazor.AccWeb.Pages.Facility.Info.TypeInference.CreateMudTextField_5(__builder4, 77, 78, 
#nullable restore
#line 45 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                                               Variant.Outlined

#line default
#line hidden
#nullable disable
                        , 79, "الجوال", 80, 
#nullable restore
#line 46 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                                                                        () => model.mobile

#line default
#line hidden
#nullable disable
                        , 81, 
#nullable restore
#line 46 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                                                   model.mobile

#line default
#line hidden
#nullable disable
                        , 82, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.mobile = __value, model.mobile)));
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(83, "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n                ");
                        __Blazor.AccWeb.Pages.Facility.Info.TypeInference.CreateMudTextField_6(__builder4, 84, 85, 
#nullable restore
#line 57 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                                       Variant.Outlined

#line default
#line hidden
#nullable disable
                        , 86, "البريد الالكتروني", 87, 
#nullable restore
#line 58 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                                                               () => model.email

#line default
#line hidden
#nullable disable
                        , 88, 
#nullable restore
#line 58 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                                           model.email

#line default
#line hidden
#nullable disable
                        , 89, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.email = __value, model.email)));
                        __builder4.AddMarkupContent(90, "\r\n\r\n\r\n                ");
                        __builder4.OpenElement(91, "div");
                        __builder4.AddAttribute(92, "class", "row");
                        __builder4.OpenElement(93, "div");
                        __builder4.AddAttribute(94, "class", "col");
                        __Blazor.AccWeb.Pages.Facility.Info.TypeInference.CreateMudTextField_7(__builder4, 95, 96, 
#nullable restore
#line 63 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                                               Variant.Outlined

#line default
#line hidden
#nullable disable
                        , 97, "السجل التجاري", 98, 
#nullable restore
#line 64 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                                                                        () => model.comreg

#line default
#line hidden
#nullable disable
                        , 99, 
#nullable restore
#line 64 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                                                   model.comreg

#line default
#line hidden
#nullable disable
                        , 100, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.comreg = __value, model.comreg)));
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(101, "\r\n                    ");
                        __builder4.OpenElement(102, "div");
                        __builder4.AddAttribute(103, "class", "col");
                        __Blazor.AccWeb.Pages.Facility.Info.TypeInference.CreateMudTextField_8(__builder4, 104, 105, 
#nullable restore
#line 67 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                                               Variant.Outlined

#line default
#line hidden
#nullable disable
                        , 106, "الرقم الضريبي", 107, 
#nullable restore
#line 68 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                                                                        () => model.taxnum

#line default
#line hidden
#nullable disable
                        , 108, 
#nullable restore
#line 68 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                                                   model.taxnum

#line default
#line hidden
#nullable disable
                        , 109, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.taxnum = __value, model.taxnum)));
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(110, "\r\n\r\n                ");
                        __builder4.OpenElement(111, "div");
                        __builder4.AddAttribute(112, "class", "row");
                        __builder4.OpenElement(113, "div");
                        __builder4.AddAttribute(114, "class", "col");
                        __Blazor.AccWeb.Pages.Facility.Info.TypeInference.CreateMudTextField_9(__builder4, 115, 116, 
#nullable restore
#line 76 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                                               Variant.Outlined

#line default
#line hidden
#nullable disable
                        , 117, "صندوق البريد", 118, 
#nullable restore
#line 77 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                                                                         () => model.mailbox

#line default
#line hidden
#nullable disable
                        , 119, 
#nullable restore
#line 77 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                                                   model.mailbox

#line default
#line hidden
#nullable disable
                        , 120, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.mailbox = __value, model.mailbox)));
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(121, "\r\n                    ");
                        __builder4.OpenElement(122, "div");
                        __builder4.AddAttribute(123, "class", "col");
                        __Blazor.AccWeb.Pages.Facility.Info.TypeInference.CreateMudTextField_10(__builder4, 124, 125, 
#nullable restore
#line 81 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                                               Variant.Outlined

#line default
#line hidden
#nullable disable
                        , 126, "الرمز البريدي", 127, 
#nullable restore
#line 82 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                                                                       () => model.Pcode

#line default
#line hidden
#nullable disable
                        , 128, 
#nullable restore
#line 82 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
                                                   model.Pcode

#line default
#line hidden
#nullable disable
                        , 129, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Pcode = __value, model.Pcode)));
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(131, "<style>\r\n    .mud-input-label-inputcontrol {\r\n        top: 0;\r\n        /* left: 0; */\r\n        right: 0;\r\n        position: absolute;\r\n        transform: translate(0,24px) scale(1);\r\n    }\r\n\r\n    .mud-shrink + label.mud-input-label.mud-input-label-inputcontrol {\r\n        color: var(--mud-palette-text-primary);\r\n        transform: translate(0,1.5px) scale(.75);\r\n        transform-origin: top right;\r\n    }\r\n\r\n\r\n    .mud-input-helper-text {\r\n        color: var(--mud-palette-text-secondary);\r\n        margin: 0;\r\n        font-size: .75rem;\r\n        margin-top: 3px;\r\n        text-align: right;\r\n        font-weight: 400;\r\n        line-height: 1.66;\r\n        letter-spacing: .03333em;\r\n    }\r\n\r\n    .mud-input-label-inputcontrol {\r\n        top: 0;\r\n        /* left: 0; */\r\n        right: 0;\r\n        position: absolute;\r\n        transform: translate(0,24px) scale(1);\r\n    }\r\n\r\n\r\n    .mud-input {\r\n        font-family: Arial;\r\n        position: relative;\r\n        color: var(--mud-palette-text-primary);\r\n        cursor: text;\r\n        display: inline-flex;\r\n        font-size: 1rem;\r\n        box-sizing: border-box;\r\n        align-items: center;\r\n        font-weight: bold;\r\n        line-height: 1.1876em;\r\n        letter-spacing: .00938em;\r\n        margin: 3px;\r\n    }\r\n\r\n    .mud-input-control > .mud-input-label-inputcontrol {\r\n        color: var(--mud-palette-text-secondary);\r\n        padding: 0;\r\n        font-size: 1rem;\r\n        font-weight: 400;\r\n        line-height: 1;\r\n        letter-spacing: .00938em;\r\n        z-index: 0;\r\n        pointer-events: none;\r\n        margin-right: 15px;\r\n        font-family: \'Cairo\';\r\n        width: fit-content;\r\n    }\r\n\r\n\r\n    .mud-shrink + label.mud-input-label.mud-input-label-inputcontrol {\r\n        color: blue;\r\n        transform: translate(0,1.5px) scale(.75);\r\n        transform-origin: top right;\r\n        margin-right: 25px;\r\n        font-family: \'Cairo\', sans-serif;\r\n        /* color: blue; */\r\n        width: fit-content;\r\n    }\r\n\r\n    .mud-input-control > .mud-input-label-inputcontrol.mud-input-error {\r\n        color: blue !important;\r\n        font-family: \'Cairo\', sans-serif;\r\n        width: fit-content;\r\n    }\r\n\r\n    .mud-typography-h6 {\r\n        font-size: 1rem;\r\n        font-family: \'Cairo\', sans-serif;\r\n        font-weight: 300;\r\n        line-height: 1;\r\n        letter-spacing: .0075em;\r\n    }\r\n\r\n    .alert-primary {\r\n        color: white;\r\n        background-color: #1565c0;\r\n        border-color: blue;\r\n        height: 60px;\r\n    }\r\n\r\n    .mud-shrink + label.mud-input-label.mud-input-label-inputcontrol.mud-input-label-outlined {\r\n        color: var(--mud-palette-text-primary);\r\n        transform: translate(14px,-6px) scale(.75);\r\n        width: fit-content;\r\n        font-family: \'Cairo\', sans-serif;\r\n        color: blue;\r\n    }\r\n\r\n    .mud-input-control > .mud-input-label-inputcontrol.mud-input-error {\r\n        color: blue !important;\r\n        font-family: \'Cairo\', sans-serif;\r\n        width: fit-content;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 116 "D:\accweb\client\amwalApp\Pages\Facility\Info.razor"
       
    Infotb model = new Infotb();
    bool success;

    
    private void OnValidSubmit(EditContext context)
    {
        
        success = true;
        StateHasChanged();
    }



    MudTheme MyCustomTheme = new MudTheme()
    {
        Palette = new Palette()
        {
            Primary = Colors.Blue.Darken3,
            Secondary = Colors.Green.Accent4,
            AppbarBackground = Colors.Red.Default,
        },

        LayoutProperties = new LayoutProperties()
        {
            DrawerWidth = "260px"
        }
    };


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.AccWeb.Pages.Facility.Info
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::MudBlazor.Variant __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Variant", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "For", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::MudBlazor.Variant __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Variant", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "For", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::MudBlazor.Variant __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Variant", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "For", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_3<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::MudBlazor.Variant __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Variant", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "For", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_4<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::MudBlazor.Variant __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Variant", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "For", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_5<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::MudBlazor.Variant __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Variant", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "For", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_6<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::MudBlazor.Variant __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Variant", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "For", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_7<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::MudBlazor.Variant __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Variant", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "For", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_8<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::MudBlazor.Variant __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Variant", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "For", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_9<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::MudBlazor.Variant __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Variant", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "For", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_10<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::MudBlazor.Variant __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Variant", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "For", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
