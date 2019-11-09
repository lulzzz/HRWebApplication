#pragma checksum "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\Company\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a378028ffb3880b5156015fee18c223ea0e355bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company_Index), @"mvc.1.0.view", @"/Views/Company/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a378028ffb3880b5156015fee18c223ea0e355bb", @"/Views/Company/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc13186f923734eef5f30550bd02d7d070938538", @"/Views/_ViewImports.cshtml")]
    public class Views_Company_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Company>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\Company\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h2 class=\"h3 d-inline-block\">List of all companies</h2>\r\n    <span class=\"badge badge-pill badge-primary align-top\">\r\n        ");
#nullable restore
#line 9 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\Company\Index.cshtml"
   Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </span>
</div>
<div>
    <table class=""table table-striped table-hover"">
        <thead class=""thead-dark"">
            <tr>
                <th scope=""col"">Company Name</th>
                <th style=""width: 20px""></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 21 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\Company\Index.cshtml"
             foreach (Company company in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\Company\Index.cshtml"
                   Write(company.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 686, "\"", 743, 1);
#nullable restore
#line 26 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\Company\Index.cshtml"
WriteAttributeValue("", 693, Url.Action("Edit", "Company", new { company.Id }), 693, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                           class=\"text-primary\">\r\n                            <i class=\"fas fa-edit\"\r\n                               title=\"Edit\"></i>\r\n                        </a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 33 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\Company\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\Company\Index.cshtml"
               Write(Html.ActionLink("Add new company", "Create", "Company", null, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td></td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Company>> Html { get; private set; }
    }
}
#pragma warning restore 1591
