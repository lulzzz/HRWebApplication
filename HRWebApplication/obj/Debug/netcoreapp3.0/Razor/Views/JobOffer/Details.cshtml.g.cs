#pragma checksum "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62944d1e7cfed0f5e329de37411d8a64e0257a3c"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62944d1e7cfed0f5e329de37411d8a64e0257a3c", @"/Views/JobOffer/Details.cshtml")]
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
            WriteLiteral("\r\n<div class=\"card text-center\">\r\n    <div class=\"card-header\">\r\n        <div class=\"d-flex align-items-center\">\r\n            <div class=\"pr-3\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 224, "\"", 263, 1);
#nullable restore
#line 10 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
WriteAttributeValue("", 231, Url.Action("Index", "JobOffer"), 231, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <i class=\"fas fa-chevron-circle-left\"></i>\r\n                </a>\r\n            </div>\r\n            <h3 class=\"mb-1\">\r\n                ");
#nullable restore
#line 15 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
           Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h3>\r\n        </div>\r\n    </div>\r\n\r\n    <ul class=\"list-group list-group-flush\">\r\n        <li class=\"list-group-item\">\r\n            <h4 class=\"card-title\">Overview</h4>\r\n            <p class=\"card-text\">");
#nullable restore
#line 23 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
                            Write(Model.Overview);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n            <h4 class=\"card-title\">Salary</h4>\r\n            <p class=\"card-text\">");
#nullable restore
#line 27 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
                            Write(Model.SalaryFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 27 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
                                                Write(Model.SalaryTo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 27 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
                                                                Write(Model.Currency);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n            <h4 class=\"card-title\">Specialization</h4>\r\n            <p class=\"card-text\">");
#nullable restore
#line 31 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
                            Write(Model.Specialization);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n            <h4 class=\"card-title\">Location</h4>\r\n            <p class=\"card-text\">");
#nullable restore
#line 35 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
                            Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n            <h4 class=\"card-title\">Added on</h4>\r\n            <p class=\"card-text\">");
#nullable restore
#line 39 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
                            Write(Model.AddedOn.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n            <h4 class=\"card-title\">Description</h4>\r\n            <p class=\"card-text\">");
#nullable restore
#line 43 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
                            Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </li>\r\n    </ul>\r\n");
#nullable restore
#line 46 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
     if (Model.ValidUntil.HasValue)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card-footer text-muted\">\r\n            ");
#nullable restore
#line 49 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
       Write(Model.ValidUntil.Value.Subtract(DateTime.Now).Days);

#line default
#line hidden
#nullable disable
            WriteLiteral(" days left(");
#nullable restore
#line 49 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
                                                                     Write(Model.ValidUntil.Value.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n        </div>\r\n");
#nullable restore
#line 51 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<div>
    <div class=""col-sm-12"">
        <table class=""table table-striped table-hover"" id=""JobApplications"">
            <thead class=""thead-dark"">
                <tr>
                    <th scope=""col"">Full Name</th>
                    <th scope=""col"">E-mail</th>
                    <th scope=""col"">Phone</th>
                </tr>
            </thead>
            <tbody>

");
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <div class=\"col-sm-12 d-inline-block\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 2752, "\"", 2816, 1);
#nullable restore
#line 78 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
WriteAttributeValue("", 2759, Url.Action("Create", "JobApplication", new { Model.Id }), 2759, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n           class=\"btn rounded btn-primary\">\r\n            <i class=\"fas fa-paper-plane\"\r\n               title=\"Apply\"></i>\r\n            Apply\r\n        </a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 2985, "\"", 3041, 1);
#nullable restore
#line 84 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
WriteAttributeValue("", 2992, Url.Action("Edit", "JobOffer", new { Model.Id }), 2992, 49, false);

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
                <p class=""font-weight-bold mb-0"">Are you sure you want to delete this?</p>");
            WriteLiteral(@"
                <p class=""text-danger mb-0""><small>This action cannot be undone.</small></p>
            </div>

            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">
                    <i class=""far fa-window-close""></i>
                    Cancel
                </button>
");
#nullable restore
#line 121 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
                 using (Html.BeginForm("Delete", "JobOffer", new { Model.Id }, FormMethod.Post, null, new { style = "display:inline;" }))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 123 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button type=\"submit\" class=\"btn btn-rounded btn-danger\">\r\n                        <i class=\"fas fa-trash-alt\"></i>\r\n                        Delete\r\n                    </button>\r\n");
#nullable restore
#line 128 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n    var uri = \'/api/JobApplicationAPI\';\r\n\r\n    // Send an AJAX request when document is ready\r\n    $(document).ready(function () {\r\n        // Get OfferID of current offer\r\n        var id =  ");
#nullable restore
#line 142 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
             Write(Html.Raw(Model.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
        // On success, 'data' contains a list of Job Applications.
        $.getJSON(uri + '/' + id).done(function (data) {
            //No application in database
            if ( isArrayEmpty(data) ) {
                $(""<tr><td>There are no applications in database for this offer.</td><td></td><td></td></tr>"").appendTo('#JobApplications');
                return;
            }
            $.each(data, function (key, jobApplication) {
                    var rows = ""<tr>""
                    + ""<td>"" + jobApplication.firstName +  "" "" + jobApplication.lastName + ""</td>""
                    + ""<td>"" + jobApplication.emailAddress + ""</td>""
                    + ""<td>"" + jobApplication.phoneNumber + ""</td>""
                    + ""</tr>"";
                    // Add a list item for the product.
                    $(rows).appendTo($('#JobApplications'));
                });
            });
    })

        function isArrayEmpty(array) {
    return array.filter(function(el) {
        return");
                WriteLiteral(@" !jQuery.isEmptyObject(el);
    }).length === 0;
}
    function find() {
        var id = $('#prodId').val();
        $.getJSON(uri + '/' + id)
            .done(function (data) {
                $('#product').text(formatItem(data));
            })
            .fail(function (jqXHR, textStatus, err) {
                $('#product').text('Error: ' + err);
            });
    }
    </script>
");
            }
            );
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
