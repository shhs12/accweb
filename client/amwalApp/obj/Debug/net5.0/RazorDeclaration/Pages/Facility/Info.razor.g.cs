// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#pragma warning restore 1591