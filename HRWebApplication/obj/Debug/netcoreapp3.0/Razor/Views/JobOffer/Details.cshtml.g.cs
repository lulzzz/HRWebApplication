#pragma checksum "C:\Users\Lenovo\source\repos\HR App\HRWebApplication\Views\JobOffer\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "297c11105595e7db2aa4a7baba5d9cf890349edd"
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
#line 1 "C:\Users\Lenovo\source\repos\HR App\HRWebApplication\Views\_ViewImports.cshtml"
using HRWebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\HR App\HRWebApplication\Views\_ViewImports.cshtml"
using HRWebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"297c11105595e7db2aa4a7baba5d9cf890349edd", @"/Views/JobOffer/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc13186f923734eef5f30550bd02d7d070938538", @"/Views/_ViewImports.cshtml")]
    public class Views_JobOffer_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JobOffer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>");
#nullable restore
#line 6 "C:\Users\Lenovo\source\repos\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n<h5>Overview</h5>\r\n<p>");
#nullable restore
#line 9 "C:\Users\Lenovo\source\repos\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
Write(Model.Overview);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<h5>Salary</h5>\r\n<p>");
#nullable restore
#line 11 "C:\Users\Lenovo\source\repos\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
Write(Model.SalaryFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 11 "C:\Users\Lenovo\source\repos\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
                  Write(Model.SalaryTo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 11 "C:\Users\Lenovo\source\repos\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
                                  Write(Model.Currency);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<h5>Specialization</h5>\r\n<p>");
#nullable restore
#line 13 "C:\Users\Lenovo\source\repos\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
Write(Model.Specialization);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<h5>Location</h5>\r\n<p>");
#nullable restore
#line 15 "C:\Users\Lenovo\source\repos\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<h5>Added on</h5>\r\n<p>");
#nullable restore
#line 17 "C:\Users\Lenovo\source\repos\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
Write(Model.AddedOn.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<h5>Description</h5>\r\n<p>");
#nullable restore
#line 19 "C:\Users\Lenovo\source\repos\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n</br>\r\n");
#nullable restore
#line 22 "C:\Users\Lenovo\source\repos\HR App\HRWebApplication\Views\JobOffer\Details.cshtml"
Write(Html.ActionLink("Go back to Job Offers", "Index", "JobOffer"));

#line default
#line hidden
#nullable disable
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
