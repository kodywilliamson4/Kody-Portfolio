#pragma checksum "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Pages\Voting.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d5989cf2a78c5622c113e06f076dabfe4f99963"
// <auto-generated/>
#pragma warning disable 1591
namespace G01ElectronicVoting.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\_Imports.razor"
using G01ElectronicVoting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\_Imports.razor"
using G01ElectronicVoting.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Pages\Voting.razor"
using G01ElectronicVoting.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/voting")]
    public partial class Voting : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((auth) => (__builder2) => {
                __builder2.AddMarkupContent(2, "<h3>Voting Dashboard</h3>\r\n\r\n        ");
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "accordion");
                __builder2.AddAttribute(5, "id", "accordionExample");
#nullable restore
#line 10 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Pages\Voting.razor"
             foreach (var e in elections)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<G01ElectronicVoting.Shared.ElectionCard>(6);
                __builder2.AddAttribute(7, "ThisElection", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<G01ElectronicVoting.Data.Election>(
#nullable restore
#line 12 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Pages\Voting.razor"
                                           e

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
#nullable restore
#line 13 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Pages\Voting.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(8, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((auth) => (__builder2) => {
                __builder2.AddMarkupContent(9, "<div class=\"alert alert-warning\">You must be logged in to vote in elections</div>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Pages\Voting.razor"
       
    List<Election> elections;

    protected override void OnInitialized()
    {
        //todo: pull elections user is allowed to vote in from db

        //temporary example elections
        elections = new List<Election>
        {
            new Election("BGSU CS Department Chair", new List<string> {"Candidate1", "Candidate2"} , new DateTime(2021, 2, 8), new DateTime(2021, 2, 24)),
            new Election("Electronic Music Club Vice President", new List<string> {"Candidate3", "Candidate4"} , new DateTime(2021, 2, 8), new DateTime(2021, 2, 12))
        };
    }

    private void HandleSubmit()
    {
        //todo: send vote to database
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
