#pragma checksum "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "876e9329fed82b3bbfb8016ca5f0fe94ced1fbd2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_JobOffer_Edit), @"mvc.1.0.view", @"/Views/JobOffer/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"876e9329fed82b3bbfb8016ca5f0fe94ced1fbd2", @"/Views/JobOffer/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc13186f923734eef5f30550bd02d7d070938538", @"/Views/_ViewImports.cshtml")]
    public class Views_JobOffer_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JobOffer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-sm-12\">\r\n        <h2>Edit Job Offer</h2>\r\n");
#nullable restore
#line 9 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Edit.cshtml"
         using (Html.BeginForm("Edit"))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Edit.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Edit.cshtml"
       Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 14 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Edit.cshtml"
           Write(Html.LabelFor(m => m.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 15 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Edit.cshtml"
           Write(Html.EditorFor(m => m.Title, new { htmlAttributes = new { @class = "form-control",placeholder = "Job offer title" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 16 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Edit.cshtml"
           Write(Html.ValidationMessageFor(m => m.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 19 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Edit.cshtml"
           Write(Html.LabelFor(m => m.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 20 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Edit.cshtml"
           Write(Html.TextAreaFor(m => m.Description, new { @class = "form-control", placeholder = "Enter description" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 21 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Edit.cshtml"
           Write(Html.ValidationMessageFor(m => m.Description, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-primary\">Save</button>\r\n");
#nullable restore
#line 24 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Edit.cshtml"
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
