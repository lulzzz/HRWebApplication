#pragma checksum "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\HRUser\Views\JobOffer\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6497d66b70143f112b820cd7a1d1ee0f98a0a90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HRUser_Views_JobOffer_Edit), @"mvc.1.0.view", @"/Areas/HRUser/Views/JobOffer/Edit.cshtml")]
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
#line 1 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\HRUser\Views\_ViewImports.cshtml"
using HRWebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\HRUser\Views\_ViewImports.cshtml"
using HRWebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\HRUser\Views\_ViewImports.cshtml"
using HRWebApplication.Areas.HRUser;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6497d66b70143f112b820cd7a1d1ee0f98a0a90", @"/Areas/HRUser/Views/JobOffer/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d8559be2de8ff119321796a53dc477b99fb99af", @"/Areas/HRUser/Views/_ViewImports.cshtml")]
    public class Areas_HRUser_Views_JobOffer_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JobOffer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\HRUser\Views\JobOffer\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-sm-12\">\r\n        <h2>Edit Job Offer</h2>\r\n");
#nullable restore
#line 9 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\HRUser\Views\JobOffer\Edit.cshtml"
         using (Html.BeginForm("Edit","JobOffer", new { Area = "HRUser" }))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\HRUser\Views\JobOffer\Edit.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\HRUser\Views\JobOffer\Edit.cshtml"
       Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\HRUser\Views\JobOffer\Edit.cshtml"
       Write(Html.HiddenFor(m=> m.CompanyId));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 15 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\HRUser\Views\JobOffer\Edit.cshtml"
           Write(Html.LabelFor(m => m.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 16 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\HRUser\Views\JobOffer\Edit.cshtml"
           Write(Html.EditorFor(m => m.Title, new { htmlAttributes = new { @class = "form-control", placeholder = "Job offer title" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 17 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\HRUser\Views\JobOffer\Edit.cshtml"
           Write(Html.ValidationMessageFor(m => m.Title, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 20 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\HRUser\Views\JobOffer\Edit.cshtml"
           Write(Html.LabelFor(m => m.Specialization));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 21 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\HRUser\Views\JobOffer\Edit.cshtml"
           Write(Html.EditorFor(m => m.Specialization, new { htmlAttributes = new { @class = "form-control", placeholder = "Enter specialization" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 22 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\HRUser\Views\JobOffer\Edit.cshtml"
           Write(Html.ValidationMessageFor(m => m.Specialization, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 25 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\HRUser\Views\JobOffer\Edit.cshtml"
           Write(Html.LabelFor(m => m.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 26 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\HRUser\Views\JobOffer\Edit.cshtml"
           Write(Html.EditorFor(m => m.Location, new { htmlAttributes = new { @class = "form-control", placeholder = "Enter location" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 27 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\HRUser\Views\JobOffer\Edit.cshtml"
           Write(Html.ValidationMessageFor(m => m.Location, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"form-row align-items-center\">\r\n                <div class=\"col-auto\">\r\n                    ");
#nullable restore
#line 32 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\HRUser\Views\JobOffer\Edit.cshtml"
               Write(Html.LabelFor(m => m.SalaryFrom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 33 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\HRUser\Views\JobOffer\Edit.cshtml"
               Write(Html.EditorFor(m => m.SalaryFrom, new { htmlAttributes = new { @class = "form-control", placeholder = "From" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 34 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\HRUser\Views\JobOffer\Edit.cshtml"
               Write(Html.ValidationMessageFor(m => m.SalaryFrom, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n                <div class=\"col-auto\">\r\n                    ");
#nullable restore
#line 38 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\HRUser\Views\JobOffer\Edit.cshtml"
               Write(Html.LabelFor(m => m.SalaryTo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 39 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\HRUser\Views\JobOffer\Edit.cshtml"
               Write(Html.EditorFor(m => m.SalaryTo, new { htmlAttributes = new { @class = "form-control", placeholder = "To" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 40 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\HRUser\Views\JobOffer\Edit.cshtml"
               Write(Html.ValidationMessageFor(m => m.SalaryTo, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-auto\">\r\n                    ");
#nullable restore
#line 43 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\HRUser\Views\JobOffer\Edit.cshtml"
               Write(Html.LabelFor(m => m.Currency));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 44 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\HRUser\Views\JobOffer\Edit.cshtml"
               Write(Html.DropDownListFor(
                        m => m.Currency, Html.GetEnumSelectList(typeof(Currency)), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 46 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\HRUser\Views\JobOffer\Edit.cshtml"
               Write(Html.ValidationMessageFor(m => m.Currency, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 50 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\HRUser\Views\JobOffer\Edit.cshtml"
           Write(Html.LabelFor(m => m.ValidUntil));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"input-group\">\r\n                    ");
#nullable restore
#line 52 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\HRUser\Views\JobOffer\Edit.cshtml"
               Write(Html.EditorFor(m => m.ValidUntil, new { htmlAttributes = new { @class = "form-control", type = "Date" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <span class=\"input-group-addon\">\r\n                        <span class=\"glyphicon glyphicon-calendar\"></span>\r\n                    </span>\r\n                </div>\r\n                ");
#nullable restore
#line 57 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\HRUser\Views\JobOffer\Edit.cshtml"
           Write(Html.ValidationMessageFor(m => m.ValidUntil, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 60 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\HRUser\Views\JobOffer\Edit.cshtml"
           Write(Html.LabelFor(m => m.Overview));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 61 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\HRUser\Views\JobOffer\Edit.cshtml"
           Write(Html.TextAreaFor(m => m.Overview, new { @class = "form-control", placeholder = "Enter short description of your offer" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 62 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\HRUser\Views\JobOffer\Edit.cshtml"
           Write(Html.ValidationMessageFor(m => m.Overview, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 65 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\HRUser\Views\JobOffer\Edit.cshtml"
           Write(Html.LabelFor(m => m.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 66 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\HRUser\Views\JobOffer\Edit.cshtml"
           Write(Html.TextAreaFor(m => m.Description, new { @class = "form-control", placeholder = "Enter full description" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 67 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\HRUser\Views\JobOffer\Edit.cshtml"
           Write(Html.ValidationMessageFor(m => m.Description, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-primary\">Save</button>\r\n");
#nullable restore
#line 70 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\HRUser\Views\JobOffer\Edit.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
