#pragma checksum "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\CreatedElectionCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54ae17789cec8c184b27520dd8750cba6ddfc843"
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
#line 1 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\CreatedElectionCard.razor"
using G01ElectronicVoting.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\CreatedElectionCard.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    public partial class CreatedElectionCard : Microsoft.AspNetCore.Components.ComponentBase
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
#nullable restore
#line 9 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\CreatedElectionCard.razor"
             if (ThisElection.EndDate < DateTime.Now)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "span");
            __builder.AddAttribute(7, "style", "cursor:pointer");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\CreatedElectionCard.razor"
                                                       HideElection

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(9, "🗙");
            __builder.CloseElement();
#nullable restore
#line 12 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\CreatedElectionCard.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn btn-link");
            __builder.AddAttribute(12, "type", "button");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\CreatedElectionCard.razor"
                                                                 ToggleCollapse

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, 
#nullable restore
#line 14 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\CreatedElectionCard.razor"
                 ThisElection.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 16 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\CreatedElectionCard.razor"
               (string, string) bs = BadgeStatus(ThisElection.StartDate, ThisElection.EndDate); 

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "span");
            __builder.AddAttribute(16, "class", "badge" + " " + (
#nullable restore
#line 17 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\CreatedElectionCard.razor"
                                bs.Item1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, 
#nullable restore
#line 17 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\CreatedElectionCard.razor"
                                           bs.Item2

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "collapse" + " " + (
#nullable restore
#line 20 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\CreatedElectionCard.razor"
                           Collapse ? "" : "show"

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(23);
            __builder.AddAttribute(24, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 22 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\CreatedElectionCard.razor"
                              model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 22 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\CreatedElectionCard.razor"
                                                    HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(27);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n\r\n                ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-group mb-0");
                __builder2.AddMarkupContent(31, "<label for=\"add-voter\"><b>Add New Voter</b></label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(32);
                __builder2.AddAttribute(33, "id", "add-voter");
                __builder2.AddAttribute(34, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\CreatedElectionCard.razor"
                                                           model.Voter

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Voter = __value, model.Voter))));
                __builder2.AddAttribute(36, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Voter));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n\r\n                ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "form-group mb-0");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(40);
                __builder2.AddAttribute(41, "id", "email-new-voter");
                __builder2.AddAttribute(42, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 31 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\CreatedElectionCard.razor"
                                                                     model.EmailNewVoter

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.EmailNewVoter = __value, model.EmailNewVoter))));
                __builder2.AddAttribute(44, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => model.EmailNewVoter));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\r\n                    ");
                __builder2.AddMarkupContent(46, "<label for=\"email-new-voter\">Notify new voter by email</label>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(48);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(49, "\r\n\r\n                ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "form-group mb-0");
                __builder2.OpenElement(52, "button");
                __builder2.AddAttribute(53, "type", "submit");
                __builder2.AddAttribute(54, "class", "btn btn-info");
                __builder2.AddAttribute(55, "disabled", 
#nullable restore
#line 38 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\CreatedElectionCard.razor"
                                                                          loading

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\CreatedElectionCard.razor"
                                                                                             () => SubmitMessage = string.Empty

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(57, "\r\n                        Add\r\n");
#nullable restore
#line 40 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\CreatedElectionCard.razor"
                         if (loading)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(58, "<div class=\"spinner-border spinner-border-sm\"></div>");
#nullable restore
#line 43 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\CreatedElectionCard.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n\r\n                    ");
                __builder2.OpenElement(60, "i");
                __builder2.AddContent(61, 
#nullable restore
#line 46 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\CreatedElectionCard.razor"
                        SubmitMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(62, "\r\n\r\n            <br>");
#nullable restore
#line 52 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\CreatedElectionCard.razor"
             if (ThisElection.StartDate <= DateTime.Now && ThisElection.EndDate > DateTime.Now)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(63, "button");
            __builder.AddAttribute(64, "type", "button");
            __builder.AddAttribute(65, "class", "btn btn-danger");
            __builder.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\CreatedElectionCard.razor"
                                                                       DeleteElection

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(67, "Close Early");
            __builder.CloseElement();
            __builder.AddContent(68, " ");
            __builder.AddMarkupContent(69, "<i>Note: Votes will NOT be counted</i>");
#nullable restore
#line 55 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\CreatedElectionCard.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(70, "<br>\r\n\r\n            ");
            __builder.OpenElement(71, "p");
            __builder.AddAttribute(72, "style", "margin-top:16px;");
            __builder.AddMarkupContent(73, "<b>Election Info</b>\r\n                <br>\r\n                Start: ");
            __builder.AddContent(74, 
#nullable restore
#line 62 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\CreatedElectionCard.razor"
                        ThisElection.StartDate.ToLongDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(75, "\r\n                <br>\r\n                End: ");
            __builder.AddContent(76, 
#nullable restore
#line 64 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\CreatedElectionCard.razor"
                      ThisElection.EndDate.ToLongDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Client\Shared\CreatedElectionCard.razor"
 
    [Parameter]
    public Election ThisElection { get; set; }
    [Parameter]
    public EventCallback RefreshElections { get; set; }

    private string SubmitMessage { get; set; } = "";

    public class VoterAddressValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            try
            {
                return Regex.Match(value.ToString(), @"^\S+@\S+\.\S+$").Success ? ValidationResult.Success : new ValidationResult("Invalid email address");
            }
            catch (RegexMatchTimeoutException _)
            {
                return new ValidationResult("Timeout");
            }
            catch (Exception _)
            {
                throw;
            }
        }
    }

    public class AddVoterFormModel
    {
        [Required]
        [VoterAddressValidator()]
        public string Voter { get; set; }

        public bool EmailNewVoter { get; set; } = false;
    }

    private AddVoterFormModel model = new();

    private bool loading = false;

    private bool Collapse { get; set; } = true;
    private void ToggleCollapse() => Collapse = !Collapse;

    private (string, string) BadgeStatus(DateTime start, DateTime end)
    {
        if (DateTime.Now < start) return ("badge-primary", "Upcoming");
        else if (DateTime.Now > end) return ("badge-secondary", "Concluded");
        else return ("badge-success", "Active");
    }

    private async Task HideElection()
    {
        ThisElection.Hidden = true;
        await http.PutAsJsonAsync("api/Election", ThisElection);
        await RefreshElections.InvokeAsync();
    }

    private async Task DeleteElection()
    {
        Collapse = true;
        await http.DeleteAsync($"api/Election/{ThisElection.Id}");
        await RefreshElections.InvokeAsync();
    }

    private async Task HandleValidSubmit()
    {
        SubmitMessage = "";
        loading = true;

        if (ThisElection.Electorate.Contains(model.Voter))
        {
            SubmitMessage = "Voter with specified address already in electorate";
        }
        else
        {
            ThisElection.Electorate.Add(model.Voter);
            await http.PutAsJsonAsync("api/Election", ThisElection);

            if (model.EmailNewVoter)
                await http.GetFromJsonAsync<bool>($"api/Email/{model.Voter}");

            SubmitMessage = $"Added {model.Voter} to electorate";
        }

        loading = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591