#pragma checksum "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38b2ece153d25b597c7064779d721e93099a7ebc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_JobOffer_Details), @"mvc.1.0.view", @"/Views/JobOffer/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\_ViewImports.cshtml"
using HRWebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\_ViewImports.cshtml"
using HRWebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38b2ece153d25b597c7064779d721e93099a7ebc", @"/Views/JobOffer/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc13186f923734eef5f30550bd02d7d070938538", @"/Views/_ViewImports.cshtml")]
    public class Views_JobOffer_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JobOffer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row page-box\">\r\n    <div class=\"col-sm-12\">\r\n        <h3>");
#nullable restore
#line 8 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <h5>Overview</h5>\r\n        <p>");
#nullable restore
#line 10 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
      Write(Model.Overview);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <h5>Salary</h5>\r\n        <p>");
#nullable restore
#line 12 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
      Write(Model.SalaryFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 12 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
                          Write(Model.SalaryTo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 12 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
                                          Write(Model.Currency);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <h5>Specialization</h5>\r\n        <p>");
#nullable restore
#line 14 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
      Write(Model.Specialization);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <h5>Location</h5>\r\n        <p>");
#nullable restore
#line 16 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
      Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <h5>Added on</h5>\r\n        <p>");
#nullable restore
#line 18 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
      Write(Model.AddedOn.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <h5>Description</h5>\r\n        <p>");
#nullable restore
#line 20 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
      Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
    </div>
    <div class=""col-sm-12"">
        <table class=""table table-striped table-hover"">
            <thead class=""thead-dark"">
                <tr>
                    <th scope=""col"">Full Name</th>
                    <th scope=""col"">E-mail</th>
                    <th scope=""col"">Phone</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 32 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
                 if (Model.JobApplications.Count == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>There are no applications in database for this offer.</td>\r\n                        <td></td>\r\n                        <td></td>\r\n                    </tr>\r\n");
#nullable restore
#line 39 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
                 foreach (JobApplication jobApplication in Model.JobApplications)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 43 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
                       Write(Html.ActionLink(jobApplication.FirstName + " " + jobApplication.LastName, "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 44 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
                       Write(jobApplication.EmailAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 45 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
                       Write(jobApplication.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 47 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <div class=\"col-sm-12 d-inline-block\">\r\n        ");
#nullable restore
#line 52 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
   Write(Html.ActionLink("Apply", "Create", "JobApplication", new { Model.Id }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 1903, "\"", 1959, 1);
#nullable restore
#line 53 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
WriteAttributeValue("", 1910, Url.Action("Edit", "JobOffer", new { Model.Id }), 1910, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
           class=""btn rounded btn-primary"">
            <i class=""fas fa-edit""
               title=""Edit""></i>
            Edit
        </a>
        <button class=""btn btn-rounded btn-danger""
                data-toggle=""modal""
                data-target=""#confirm-delete"">
            <i class=""fas fa-trash-alt""></i>
            Delete
        </button>
        ");
#nullable restore
#line 65 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
   Write(Html.ActionLink("Go back to Job Offers", "Index", "JobOffer", null, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
</div>

<div class=""modal fade"" id=""confirm-delete"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">

            <div class=""modal-header"">
                <h5 class=""modal-title"">Delete Employee</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>

            <div class=""modal-body"">
                <p class=""font-weight-bold mb-0"">Are you sure you want to delete this?</p>
                <p class=""text-danger mb-0""><small>This action cannot be undone.</small></p>
            </div>

            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">
                    <i class=""far fa-window-close""></i>
                    Cancel
                </button>
");
#nullable restore
#line 90 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
                 using (Html.BeginForm("Delete", "JobOffer", new { Model.Id }, FormMethod.Post, null, new { style = "display:inline;" }))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button type=\"submit\" class=\"btn btn-rounded btn-danger\">\r\n                        <i class=\"fas fa-trash-alt\"></i>\r\n                        Delete\r\n                    </button>\r\n");
#nullable restore
#line 97 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JobOffer> Html { get; private set; }
    }
}
#pragma warning restore 1591
