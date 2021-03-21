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
#line 2 "D:\Egyetem\Semester3\DNP1\RiderProjects\DNPSessions\HandIn1Family\Pages\FamilyOverview.razor"
using HandIn1Family.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Egyetem\Semester3\DNP1\RiderProjects\DNPSessions\HandIn1Family\Pages\FamilyOverview.razor"
using System.Collections;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Egyetem\Semester3\DNP1\RiderProjects\DNPSessions\HandIn1Family\Pages\FamilyOverview.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/FamilyOverview")]
    public partial class FamilyOverview : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "D:\Egyetem\Semester3\DNP1\RiderProjects\DNPSessions\HandIn1Family\Pages\FamilyOverview.razor"
       
    private IList<Adult> adults;
    private IList<Adult> adultsToShow;
    
    protected override async Task OnInitializedAsync()
    {
        adults = AdultData.GetAdults();
        adultsToShow = adults;
    //Console.WriteLine(adults);
    }

    private void RemoveAdult(int adultId)
    {
        Adult adultToRemove = adults.First(a => a.Id == adultId);
        AdultData.RemoveAdult(adultId);
        adults.Remove(adultToRemove);
        adultsToShow.Remove(adultToRemove);
    }

    
    private void Filter(ChangeEventArgs changeEventArgs)
    {
        int? filterById = null;
        try
        {
            filterById = int.Parse(changeEventArgs.Value.ToString());
        }
        catch (Exception e)
        {
            
        }
        if (filterById != null)
        {
            adultsToShow = adults.Where(a => a.Id == filterById).ToList();
        }
        else
        {
            adultsToShow = adults;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultData AdultData { get; set; }
    }
}
#pragma warning restore 1591