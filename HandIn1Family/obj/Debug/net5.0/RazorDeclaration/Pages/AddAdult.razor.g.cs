// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HandIn1Family.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Egyetem\Semester3\DNP1\RiderProjects\DNPSessions\HandIn1Family\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Egyetem\Semester3\DNP1\RiderProjects\DNPSessions\HandIn1Family\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Egyetem\Semester3\DNP1\RiderProjects\DNPSessions\HandIn1Family\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Egyetem\Semester3\DNP1\RiderProjects\DNPSessions\HandIn1Family\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Egyetem\Semester3\DNP1\RiderProjects\DNPSessions\HandIn1Family\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Egyetem\Semester3\DNP1\RiderProjects\DNPSessions\HandIn1Family\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Egyetem\Semester3\DNP1\RiderProjects\DNPSessions\HandIn1Family\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Egyetem\Semester3\DNP1\RiderProjects\DNPSessions\HandIn1Family\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Egyetem\Semester3\DNP1\RiderProjects\DNPSessions\HandIn1Family\_Imports.razor"
using HandIn1Family;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Egyetem\Semester3\DNP1\RiderProjects\DNPSessions\HandIn1Family\_Imports.razor"
using HandIn1Family.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Egyetem\Semester3\DNP1\RiderProjects\DNPSessions\HandIn1Family\Pages\AddAdult.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Egyetem\Semester3\DNP1\RiderProjects\DNPSessions\HandIn1Family\Pages\AddAdult.razor"
using HandIn1Family.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddAdult")]
    public partial class AddAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "D:\Egyetem\Semester3\DNP1\RiderProjects\DNPSessions\HandIn1Family\Pages\AddAdult.razor"
       
    private Adult newAdult = new Adult();

    private void AddNewAdult()
    {
        AdultData.AddAdult(newAdult);
        NavigationManager.NavigateTo("/FamilyOverview");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultData AdultData { get; set; }
    }
}
#pragma warning restore 1591
