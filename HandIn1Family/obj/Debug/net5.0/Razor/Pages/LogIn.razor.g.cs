#pragma checksum "D:\Egyetem\Semester3\DNP1\RiderProjects\DNPSessions\HandIn1Family\Pages\LogIn.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae8625341f441b9278bded2134b911bf1d4b02e4"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "D:\Egyetem\Semester3\DNP1\RiderProjects\DNPSessions\HandIn1Family\Pages\LogIn.razor"
using HandIn1Family.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/LogIn")]
    public partial class LogIn : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>LogIn</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "form-group");
                __builder2.AddMarkupContent(5, "<label>User name:</label> ");
                __builder2.OpenElement(6, "input");
                __builder2.AddAttribute(7, "type", "text");
                __builder2.AddAttribute(8, "placeholder", "user name");
                __builder2.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "D:\Egyetem\Semester3\DNP1\RiderProjects\DNPSessions\HandIn1Family\Pages\LogIn.razor"
                                                                                              username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group");
                __builder2.AddMarkupContent(14, "<label>Password</label> ");
                __builder2.OpenElement(15, "input");
                __builder2.AddAttribute(16, "type", "password");
                __builder2.AddAttribute(17, "placeholder", "password");
                __builder2.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "D:\Egyetem\Semester3\DNP1\RiderProjects\DNPSessions\HandIn1Family\Pages\LogIn.razor"
                                                                                               password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "style", "color:red");
                __builder2.AddContent(23, 
#nullable restore
#line 18 "D:\Egyetem\Semester3\DNP1\RiderProjects\DNPSessions\HandIn1Family\Pages\LogIn.razor"
                                errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddContent(24, " ");
                __builder2.OpenElement(25, "a");
                __builder2.AddAttribute(26, "href", "");
                __builder2.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "D:\Egyetem\Semester3\DNP1\RiderProjects\DNPSessions\HandIn1Family\Pages\LogIn.razor"
                                                                        PerformLogin

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(28, " Login ");
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(29, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(30, "a");
                __builder2.AddAttribute(31, "href", "");
                __builder2.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "D:\Egyetem\Semester3\DNP1\RiderProjects\DNPSessions\HandIn1Family\Pages\LogIn.razor"
                             PerformLogout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(33, " Log out ");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "D:\Egyetem\Semester3\DNP1\RiderProjects\DNPSessions\HandIn1Family\Pages\LogIn.razor"
       
    private string username;
    private string password;
    private string errorMessage;

    public async Task PerformLogin()
    {
        errorMessage = "";
        try
        {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).ValidateLogin(username, password);
            username = "";
            password = "";
            NavigationManager.NavigateTo("/");
        }
        catch (Exception e)
        {
            errorMessage = e.Message;
        }
    }

    public async Task PerformLogout()
    {
        errorMessage = "";
        username = "";
        password = "";
        try
        {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();
            NavigationManager.NavigateTo("/");
        }
        catch (Exception e)
        {
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
