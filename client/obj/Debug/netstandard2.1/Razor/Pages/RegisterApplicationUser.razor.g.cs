#pragma checksum "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\RegisterApplicationUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01fc4aaf6d9f6ec4f9475009c4e96f5d8423cf09"
// <auto-generated/>
#pragma warning disable 1591
namespace CaApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\_Imports.razor"
using CaApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\_Imports.razor"
using CaApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\RegisterApplicationUser.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\RegisterApplicationUser.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\RegisterApplicationUser.razor"
using CaApp.Models.ConData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\RegisterApplicationUser.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\RegisterApplicationUser.razor"
using CaApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\RegisterApplicationUser.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/register-application-user")]
    public partial class RegisterApplicationUser : CaApp.Pages.RegisterApplicationUserComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.AddMarkupContent(6, "\n      ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-md-12");
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<ApplicationUser>>(10);
                __builder2.AddAttribute(11, "Method", "post");
                __builder2.AddAttribute(12, "Action", "account/register");
                __builder2.AddAttribute(13, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ApplicationUser>(
#nullable restore
#line 17 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\RegisterApplicationUser.razor"
                                                                            user

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\RegisterApplicationUser.razor"
                                                                                                                      user != null

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ApplicationUser>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ApplicationUser>(this, 
#nullable restore
#line 17 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\RegisterApplicationUser.razor"
                                                                                                                                              Form0Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(17, "\n            ");
                    __builder3.OpenElement(18, "div");
                    __builder3.AddAttribute(19, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(20, "class", "row");
                    __builder3.AddMarkupContent(21, "\n              ");
                    __builder3.OpenElement(22, "div");
                    __builder3.AddAttribute(23, "class", "col-md-3");
                    __builder3.AddMarkupContent(24, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(25);
                    __builder3.AddAttribute(26, "Component", "Email");
                    __builder3.AddAttribute(27, "style", "width: 100%");
                    __builder3.AddAttribute(28, "Text", "Email");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(29, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(30, "\n              ");
                    __builder3.OpenElement(31, "div");
                    __builder3.AddAttribute(32, "class", "col-md-9");
                    __builder3.AddMarkupContent(33, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(34);
                    __builder3.AddAttribute(35, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(36, "Name", "UserName");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(37, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(38);
                    __builder3.AddAttribute(39, "Component", "Email");
                    __builder3.AddAttribute(40, "style", "position: absolute");
                    __builder3.AddAttribute(41, "Text", "Email is required");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(42, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(43, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(44, "\n            ");
                    __builder3.OpenElement(45, "div");
                    __builder3.AddAttribute(46, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(47, "class", "row");
                    __builder3.AddMarkupContent(48, "\n              ");
                    __builder3.OpenElement(49, "div");
                    __builder3.AddAttribute(50, "class", "col-md-3");
                    __builder3.AddMarkupContent(51, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(52);
                    __builder3.AddAttribute(53, "Component", "Password");
                    __builder3.AddAttribute(54, "style", "width: 100%");
                    __builder3.AddAttribute(55, "Text", "Password");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(56, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(57, "\n              ");
                    __builder3.OpenElement(58, "div");
                    __builder3.AddAttribute(59, "class", "col-md-9");
                    __builder3.AddMarkupContent(60, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPassword>(61);
                    __builder3.AddAttribute(62, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(63, "Name", "Password");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(64, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(65);
                    __builder3.AddAttribute(66, "Component", "Password");
                    __builder3.AddAttribute(67, "style", "position: absolute");
                    __builder3.AddAttribute(68, "Text", "Password is required");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(69, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(70, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(71, "\n            ");
                    __builder3.OpenElement(72, "div");
                    __builder3.AddAttribute(73, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(74, "class", "row");
                    __builder3.AddMarkupContent(75, "\n              ");
                    __builder3.OpenElement(76, "div");
                    __builder3.AddAttribute(77, "class", "col-md-3");
                    __builder3.AddMarkupContent(78, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(79);
                    __builder3.AddAttribute(80, "Component", "ConfirmPassword");
                    __builder3.AddAttribute(81, "style", "width: 100%");
                    __builder3.AddAttribute(82, "Text", "Confirm password");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(83, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(84, "\n              ");
                    __builder3.OpenElement(85, "div");
                    __builder3.AddAttribute(86, "class", "col-md-9");
                    __builder3.AddMarkupContent(87, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPassword>(88);
                    __builder3.AddAttribute(89, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(90, "Name", "ConfirmPassword");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(91, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(92);
                    __builder3.AddAttribute(93, "Component", "ConfirmPassword");
                    __builder3.AddAttribute(94, "style", "position: absolute");
                    __builder3.AddAttribute(95, "Text", "ConfirmPassword is required");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(96, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(97, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(98, "\n            ");
                    __builder3.OpenElement(99, "div");
                    __builder3.AddAttribute(100, "class", "row");
                    __builder3.AddMarkupContent(101, "\n              ");
                    __builder3.OpenElement(102, "div");
                    __builder3.AddAttribute(103, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(104, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(105);
                    __builder3.AddAttribute(106, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 57 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\RegisterApplicationUser.razor"
                                           ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(107, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 57 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\RegisterApplicationUser.razor"
                                                                            ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(108, "Icon", "save");
                    __builder3.AddAttribute(109, "Text", "Register");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(110, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(111);
                    __builder3.AddAttribute(112, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 59 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\RegisterApplicationUser.razor"
                                           ButtonStyle.Light

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(113, "Text", "Cancel");
                    __builder3.AddAttribute(114, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\RegisterApplicationUser.razor"
                                                                                    Button2Click

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(115, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(116, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(117, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(118, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(119, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(120, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
