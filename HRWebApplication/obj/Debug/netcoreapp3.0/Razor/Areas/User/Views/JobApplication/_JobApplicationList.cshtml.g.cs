#pragma checksum "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\User\Views\JobApplication\_JobApplicationList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4253342bcdb364a8ebd130dba9f6afd8b704c4b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_JobApplication__JobApplicationList), @"mvc.1.0.view", @"/Areas/User/Views/JobApplication/_JobApplicationList.cshtml")]
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
#line 1 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\User\Views\_ViewImports.cshtml"
using HRWebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\User\Views\_ViewImports.cshtml"
using HRWebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\User\Views\_ViewImports.cshtml"
using HRWebApplication.Areas.User;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4253342bcdb364a8ebd130dba9f6afd8b704c4b5", @"/Areas/User/Views/JobApplication/_JobApplicationList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3be34088d3a8d7d961323dd0ee2fc4374ac16b9", @"/Areas/User/Views/_ViewImports.cshtml")]
    public class Areas_User_Views_JobApplication__JobApplicationList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<JobApplication>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""col-sm-12"">
    <table class=""table table-striped table-hover"" id=""JobApplications"">
        <thead class=""thead-dark"">
            <tr>
                <th scope=""col"">Job Title</th>
                <th scope=""col"">Company</th>
                <th scope=""col"">Date of sending</th>
                <th scope=""col"">Application state</th>
                <th scope=""col"">Actions</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 15 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\User\Views\JobApplication\_JobApplicationList.cshtml"
             foreach (JobApplication jobApplication in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"col\">");
#nullable restore
#line 18 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\User\Views\JobApplication\_JobApplicationList.cshtml"
                           Write(Html.ActionLink(jobApplication.JobOffer.Title, "Details", "JobOffer", new { id = jobApplication.JobOfferId, Area = "User" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 19 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\User\Views\JobApplication\_JobApplicationList.cshtml"
                           Write(jobApplication.JobOffer.Company.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 20 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\User\Views\JobApplication\_JobApplicationList.cshtml"
                           Write(jobApplication.CreatedOn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 21 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\User\Views\JobApplication\_JobApplicationList.cshtml"
                           Write(jobApplication.ApplicationState.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">\r\n                    <div class=\"btn-group\" role=\"group\" aria-label=\"Actions\">\r\n                        <div class=\"btn-group\" role=\"group\">\r\n                            <button");
            BeginWriteAttribute("id", " id=\"", 1181, "\"", 1209, 2);
            WriteAttributeValue("", 1186, "drop_", 1186, 5, true);
#nullable restore
#line 25 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\User\Views\JobApplication\_JobApplicationList.cshtml"
WriteAttributeValue("", 1191, jobApplication.Id, 1191, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""button"" class=""btn btn-outline-secondary dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <i class=""fas fa-chevron-circle-down""></i>
                            </button>
                            <div class=""dropdown-menu""");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 1512, "\"", 1553, 2);
            WriteAttributeValue("", 1530, "drop_", 1530, 5, true);
#nullable restore
#line 28 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\User\Views\JobApplication\_JobApplicationList.cshtml"
WriteAttributeValue("", 1535, jobApplication.Id, 1535, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 29 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\User\Views\JobApplication\_JobApplicationList.cshtml"
                                 if (jobApplication.ApplicationState == ApplicationState.Waiting)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 1747, "\"", 1838, 1);
#nullable restore
#line 31 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\User\Views\JobApplication\_JobApplicationList.cshtml"
WriteAttributeValue("", 1754, Url.Action("Edit", "JobApplication", new { Area = "User", id = jobApplication.Id }), 1754, 84, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-edit\"></i> Edit</a>\r\n");
#nullable restore
#line 32 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\User\Views\JobApplication\_JobApplicationList.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"dropdown-divider\"></div>\r\n                                <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 2039, "\"", 2132, 1);
#nullable restore
#line 34 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\User\Views\JobApplication\_JobApplicationList.cshtml"
WriteAttributeValue("", 2046, Url.Action("Delete", "JobApplication", new { Area = "User", id = jobApplication.Id }), 2046, 86, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-trash-alt\"></i> Remove</a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </th>\r\n            </tr>\r\n");
#nullable restore
#line 40 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\User\Views\JobApplication\_JobApplicationList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n<nav aria-label=\"Page navigation\">\r\n    <ul class=\"pagination justify-content-center\">\r\n");
#nullable restore
#line 47 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\User\Views\JobApplication\_JobApplicationList.cshtml"
         for (int i = 1; i <= @ViewBag.PagesCount; i++)
        {
            if (@ViewBag.CurrentPage == i)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item  active\">\r\n                    <a class=\"page-link\">");
#nullable restore
#line 52 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\User\Views\JobApplication\_JobApplicationList.cshtml"
                                    Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </li>\r\n");
#nullable restore
#line 54 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\User\Views\JobApplication\_JobApplicationList.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a class=\"page-link\" href=\"#\"");
            BeginWriteAttribute("onclick", "\r\n                       onclick=\"", 2846, "\"", 3078, 5);
            WriteAttributeValue("", 2880, "getJobApplicationsList(\'", 2880, 24, true);
#nullable restore
#line 59 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\User\Views\JobApplication\_JobApplicationList.cshtml"
WriteAttributeValue("", 2904, Url.Action("GetJobApplications", "JobApplication",new { sortOrder = ViewBag.CurrentSort, currentFilter = ViewBag.CurrentFilter, page = i, Area = "User" }), 2904, 157, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3061, "\');", 3061, 3, true);
            WriteAttributeValue(" ", 3064, "return", 3065, 7, true);
            WriteAttributeValue(" ", 3071, "false;", 3072, 7, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
#nullable restore
#line 60 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\User\Views\JobApplication\_JobApplicationList.cshtml"
                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </a>\r\n                </li>\r\n");
#nullable restore
#line 63 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\User\Views\JobApplication\_JobApplicationList.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<JobApplication>> Html { get; private set; }
    }
}
#pragma warning restore 1591
