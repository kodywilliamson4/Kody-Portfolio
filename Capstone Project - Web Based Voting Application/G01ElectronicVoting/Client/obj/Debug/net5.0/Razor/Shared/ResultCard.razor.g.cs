#pragma checksum "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\ResultCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e8d6f386e8ac3b63f29fa7cbc6f7fb38e6d00ff"
// <auto-generated/>
#pragma warning disable 1591
namespace G01ElectronicVoting.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\_Imports.razor"
using G01ElectronicVoting.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\_Imports.razor"
using G01ElectronicVoting.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\_Imports.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\_Imports.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\_Imports.razor"
using Google.Cloud.Firestore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\ResultCard.razor"
using G01ElectronicVoting.Shared;

#line default
#line hidden
#nullable disable
    public partial class ResultCard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card-header");
            __builder.OpenElement(4, "h5");
            __builder.AddAttribute(5, "class", "mb-0");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "class", "btn btn-link");
            __builder.AddAttribute(8, "type", "button");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\ResultCard.razor"
                                                                 ToggleCollapse 

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(10, 
#nullable restore
#line 9 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\ResultCard.razor"
                 ThisResult.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "collapse" + " " + (
#nullable restore
#line 13 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\ResultCard.razor"
                           Collapse ? "" : "show"

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 14 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\ResultCard.razor"
         if (mostVotes > 0)
        {
            if (!Tie)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "alert alert-success");
            __builder.AddContent(16, "Winner: ");
            __builder.AddContent(17, 
#nullable restore
#line 18 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\ResultCard.razor"
                                                          winningCandidate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 19 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\ResultCard.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(18, "<div class=\"alert alert-warning\">This election ended in a tie</div>");
#nullable restore
#line 23 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\ResultCard.razor"
            }
            

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "style", "width:50%;");
            __builder.OpenComponent<G01ElectronicVoting.Client.Shared.ResultChart>(21);
            __builder.AddAttribute(22, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32[]>(
#nullable restore
#line 26 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\ResultCard.razor"
                                  ThisResult.Votes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "Labels", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String[]>(
#nullable restore
#line 26 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\ResultCard.razor"
                                                          ThisResult.Candidates

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 28 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\ResultCard.razor"
                                                                                                       
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(24, "<div class=\"alert alert-danger\">This election ended with no recorded votes</div>");
#nullable restore
#line 33 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\ResultCard.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\ResultCard.razor"
       
    [Parameter]
    public Result ThisResult { get; set; }
    [Parameter]
    public int Index { get; set; }

    private string ChartId { get; set; }
    private bool Collapse { get; set; } = true;
    private bool Tie { get; set; } = false;

    private List<Candidate> chartData = new();
    private int mostVotes = 0;
    private string winningCandidate;

    private void ToggleCollapse() => Collapse = !Collapse;

    protected override async Task OnInitializedAsync()
    {
        ChartId = $"chartdiv_pie{Index}";

        for (int i = 0; i < ThisResult.Votes.Length; i++)
        {
            chartData.Add(new Candidate(ThisResult.Votes[i], ThisResult.Candidates[i]));

            if (ThisResult.Votes[i] > mostVotes)
            {
                mostVotes = ThisResult.Votes[i];
                winningCandidate = ThisResult.Candidates[i];
            }
        }

        if (mostVotes > 0)
        {
            Tie = (ThisResult.Votes.Where(x => x == mostVotes).Count() > 1);

        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
