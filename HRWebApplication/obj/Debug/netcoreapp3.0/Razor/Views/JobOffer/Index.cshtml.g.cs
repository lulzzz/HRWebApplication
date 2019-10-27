#pragma checksum "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a65e3e9904bef4d9536d157249bf7fa7f78a417f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_JobOffer_Index), @"mvc.1.0.view", @"/Views/JobOffer/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a65e3e9904bef4d9536d157249bf7fa7f78a417f", @"/Views/JobOffer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc13186f923734eef5f30550bd02d7d070938538", @"/Views/_ViewImports.cshtml")]
    public class Views_JobOffer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<JobOffer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Index.cshtml"
  
    ViewData["Title"] = "Job Offers";
    var selectedPage = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<h1>Available job offers</h1>\r\n<div class=\"card-deck\">\r\n\r\n");
#nullable restore
#line 12 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Index.cshtml"
     foreach (JobOffer jobOffer in Model.GetRange(selectedPage*3,3))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card bg-light mb-3\" style=\"max-width: 18rem;\">\r\n            <div class=\"card-header\">");
#nullable restore
#line 15 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Index.cshtml"
                                Write(Html.ActionLink(jobOffer.Title, "Details", new { id = jobOffer.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 17 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Index.cshtml"
                                  Write(jobOffer.SalaryFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 17 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Index.cshtml"
                                                         Write(jobOffer.SalaryTo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 17 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Index.cshtml"
                                                                            Write(jobOffer.Currency);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-text\">");
#nullable restore
#line 18 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Index.cshtml"
                                Write(jobOffer.Overview);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <ul class=\"list-group list-group-flush\">\r\n                <li class=\"list-group-item\">Location: ");
#nullable restore
#line 21 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Index.cshtml"
                                                 Write(jobOffer.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item\">Specialization: ");
#nullable restore
#line 22 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Index.cshtml"
                                                       Write(jobOffer.Specialization);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            </ul>\r\n            <div class=\"card-footer text-center\"><small>Added on ");
#nullable restore
#line 24 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Index.cshtml"
                                                            Write(jobOffer.AddedOn.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></div>\r\n        </div>\r\n");
#nullable restore
#line 26 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<nav aria-label=\"Page navigation\">\r\n    <ul class=\"pagination justify-content-center\">\r\n");
#nullable restore
#line 30 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Index.cshtml"
         for (int i = 1; i <= Model.Count/3; i++)
        {
            if (selectedPage + 1 == i)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\"><a class=\"page-link active\" href=\"#\">");
#nullable restore
#line 34 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Index.cshtml"
                                                                      Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 35 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Index.cshtml"

            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\"><a class=\"page-link\" href=\"#\">");
#nullable restore
#line 39 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Index.cshtml"
                                                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 40 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\Index.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</nav>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<JobOffer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
