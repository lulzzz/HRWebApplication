#pragma checksum "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\_JobOfferList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d2825085a2c7e67868afc6c1b06e13700fc0c26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_JobOffer__JobOfferList), @"mvc.1.0.view", @"/Views/JobOffer/_JobOfferList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d2825085a2c7e67868afc6c1b06e13700fc0c26", @"/Views/JobOffer/_JobOfferList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc13186f923734eef5f30550bd02d7d070938538", @"/Views/_ViewImports.cshtml")]
    public class Views_JobOffer__JobOfferList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<JobOffer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card-deck\">\r\n\r\n");
#nullable restore
#line 5 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\_JobOfferList.cshtml"
     foreach (JobOffer jobOffer in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card bg-light mb-3\" style=\"max-width: 18rem; min-width: 16rem;\">\r\n            <div class=\"card-header\">");
#nullable restore
#line 8 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\_JobOfferList.cshtml"
                                Write(Html.ActionLink(jobOffer.Title, "Details", new { id = jobOffer.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 10 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\_JobOfferList.cshtml"
                                  Write(jobOffer.SalaryFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 10 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\_JobOfferList.cshtml"
                                                         Write(jobOffer.SalaryTo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 10 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\_JobOfferList.cshtml"
                                                                            Write(jobOffer.Currency);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-text h-100\">");
#nullable restore
#line 11 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\_JobOfferList.cshtml"
                                      Write(jobOffer.Overview);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <ul class=\"list-group list-group-flush\">\r\n                <li class=\"list-group-item\">Location: ");
#nullable restore
#line 14 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\_JobOfferList.cshtml"
                                                 Write(jobOffer.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item\">Specialization: ");
#nullable restore
#line 15 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\_JobOfferList.cshtml"
                                                       Write(jobOffer.Specialization);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            </ul>\r\n            <div class=\"card-footer text-center\"><small>Added on ");
#nullable restore
#line 17 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\_JobOfferList.cshtml"
                                                            Write(jobOffer.AddedOn.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></div>\r\n        </div>\r\n");
#nullable restore
#line 19 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\_JobOfferList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<nav aria-label=\"Page navigation\">\r\n    <ul class=\"pagination justify-content-center\">\r\n");
#nullable restore
#line 24 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\_JobOfferList.cshtml"
         for (int i = 1; i <= @ViewBag.PagesCount; i++)
        {
            if (@ViewBag.CurrentPage == i)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item  active\">\r\n                    <a class=\"page-link\">");
#nullable restore
#line 29 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\_JobOfferList.cshtml"
                                    Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </li>\r\n");
#nullable restore
#line 31 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\_JobOfferList.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a class=\"page-link\" href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1398, "\"", 1574, 5);
            WriteAttributeValue("", 1408, "GetJobOffersList(\'", 1408, 18, true);
#nullable restore
#line 35 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\_JobOfferList.cshtml"
WriteAttributeValue("", 1426, Url.Action("GetJobOffers", "JobOffer", new { sortOrder = ViewBag.CurrentSort, currentFilter = ViewBag.CurrentFilter, page = i }), 1426, 131, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1557, "\');", 1557, 3, true);
            WriteAttributeValue(" ", 1560, "return", 1561, 7, true);
            WriteAttributeValue(" ", 1567, "false;", 1568, 7, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 35 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\_JobOfferList.cshtml"
                                                                                                                                                                                                                              Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </li>\r\n");
#nullable restore
#line 37 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Views\JobOffer\_JobOfferList.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<JobOffer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
