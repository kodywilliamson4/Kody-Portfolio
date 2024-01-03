// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Pages\ElectionMgmt.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Pages\ElectionMgmt.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Pages\ElectionMgmt.razor"
using Microsoft.VisualBasic.FileIO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/electionmgmt")]
    public partial class ElectionMgmt : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "C:\Users\kodyw\csse4770_sp2021_g01\G01ElectronicVoting\Pages\ElectionMgmt.razor"
       
    public class Voter
    {
        public Voter(string email, string lname, string fname)
        {
            Email = email;
            LastName = lname;
            FirstName = fname;
        }

        public string Email;
        public string LastName;
        public string FirstName;
    }

    public class CandidateListValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var candidateListString = (string)value;
            string[] candidateList = candidateListString.Split(';');

            return ((candidateList.Length > 1) ? ValidationResult.Success : new ValidationResult("Election must have more than one candidate"));
        }
    }

    public class ElectorateCSVFileAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var electorateFile = (IBrowserFile)value;

            if (Path.GetExtension(electorateFile.Name) != ".csv")
            {
                return new ValidationResult("Electorate file must be a csv");
            }

            //using (TextFieldParser parser = new TextFieldParser(electorateFile.OpenReadStream()))
            //{
            //    parser.TextFieldType = FieldType.Delimited;
            //    parser.SetDelimiters(",");

            //    if (parser.ReadLine() != "Email,LastName,FirstName")
            //    {
            //        return new ValidationResult("Electorate file must contain the following columns in order: Email, LastName, FirstName");
            //    }
            //}

            return ValidationResult.Success;
        }
    }

    public class ElectionMgmtFormModel
    {
        [Required(ErrorMessage = "Election needs a title")]
        [StringLength(128, ErrorMessage = "Election title is too long")]
        public string Title { get; set; } = null;

        [Required(ErrorMessage = "Election must have candidates")]
        [CandidateListValidator()]
        public string Candidates { get; set; } = null;

        [Required(ErrorMessage = "Electorate file must be present")]
        [ElectorateCSVFileAttribute()]
        public IBrowserFile Electorate { get; set; }

        [Required(ErrorMessage = "Election must have a start date/time")]
        public DateTime StartDate { get; set; } = DateTime.Today.AddDays(1);

        [Required(ErrorMessage = "Election must have a end date/time")]
        public DateTime EndDate { get; set; } = DateTime.Today.AddDays(8);
    }

    private ElectionMgmtFormModel model = new ElectionMgmtFormModel();
    private List<Voter> electorate = new List<Voter>();
    private Stream electorateFileStream;

    private void ElectorateFileChange(InputFileChangeEventArgs e)
    {
        model.Electorate = e.File;
    }

    private void HandleValidSubmit()
    {
        //using (TextFieldParser parser = new TextFieldParser(model.Electorate.OpenReadStream()))
        //{
        //    parser.TextFieldType = FieldType.Delimited;
        //    parser.SetDelimiters(",");

        //    parser.ReadLine(); //skip column names
        //    while (!parser.EndOfData)
        //    {
        //        string[] fields = parser.ReadFields();
        //        electorate.Add(new Voter(fields[0], fields[1], fields[2]));
        //    }
        //}

        //todo: create election in db
        //todo: send voters to db
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591