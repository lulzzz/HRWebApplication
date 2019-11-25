#pragma checksum "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\User\Views\JobOffer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9899040cca9928eea871846e2672afb918a4b1ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_JobOffer_Index), @"mvc.1.0.view", @"/Areas/User/Views/JobOffer/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9899040cca9928eea871846e2672afb918a4b1ce", @"/Areas/User/Views/JobOffer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3be34088d3a8d7d961323dd0ee2fc4374ac16b9", @"/Areas/User/Views/_ViewImports.cshtml")]
    public class Areas_User_Views_JobOffer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JobOfferViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\User\Views\JobOffer\Index.cshtml"
  
    ViewData["Title"] = "Job Offers";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row mb-2\">\r\n        <div class=\"col-12\">\r\n            <h2 class=\"h3 d-inline-block\">Available job offers</h2>\r\n            <span class=\"badge badge-pill badge-primary align-top\">\r\n                ");
#nullable restore
#line 11 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\User\Views\JobOffer\Index.cshtml"
           Write(Model.JobOffersCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </span>
        </div>

    </div>
    <div class=""row mb-4"">
        <div class=""col-md-6"">
            <div class=""input-group mb-3"" style=""margin-bottom: 14px"">
                <input type=""text"" class=""form-control"" placeholder=""Search""
                       name=""searchString"" id=""Search"" aria-label=""Search by job title"" aria-describedby=""basic-addon2"" />
                <div class=""input-group-append"">
                    <button class=""btn btn-outline-primary"" id=""SearchButton"">
                        <i class=""fas fa-search""></i>
                        Search
                    </button>
                </div>
            </div>
        </div>
        <div class=""col-md-2 mb-4"">
            <div class=""btn-group btn-group-toggle"" data-toggle=""buttons"">
                <label class=""btn btn-outline-primary active"" id=""SortByName""
                       onclick=""sort('name'); return false;"">
                    <input type=""radio"" name=""sorting"" id=""optionNameSort""");
            WriteLiteral(@" autocomplete=""off"" />
                    <i class=""fas fa-sort-alpha-down""></i>
                </label>
                <label class=""btn btn-outline-primary""  id=""SortByNameDesc""
                       onclick=""sort('name_desc'); return false;"">
                    <input type=""radio"" name=""sorting"" id=""optionNameDescSort"" autocomplete=""off"" />
                    <i class=""fas fa-sort-alpha-up""></i>
                </label>
                <label class=""btn btn-outline-primary"" id=""SortByDate""
                       onclick=""sort('date'); return false;"">
                    <input type=""radio"" name=""sorting"" id=""optionDateSort"" autocomplete=""off"" />
                    <i class=""far fa-clock""></i>
                </label>
            </div>
        </div>
    </div>
</div>


<div id=""JobOfferList"">

</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n\r\n    $(document).ready(function () {\r\n        $(\"#JobOfferList\").load(\'");
#nullable restore
#line 61 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\User\Views\JobOffer\Index.cshtml"
                             Write(Url.Action("GetJobOffers", "JobOffer", new { Area = "User" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\r\n        $(\"#SearchButton\").click(search);\r\n    });\r\n\r\n          function search() {\r\n              var searchString = $(\"#Search\").val();\r\n            var sortOrder = $(\'input[name=sorting]:checked\').val();\r\n\r\n              var link = \'");
#nullable restore
#line 69 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\User\Views\JobOffer\Index.cshtml"
                      Write(Url.Action("GetJobOffers",
                                        "JobOffer", new { Area = "User" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"' + '?searchString=' + searchString + '&sortOrder=' + sortOrder;
        $(""#JobOfferList"").load(link);
        }


        function getJobOffersList(url){
        $(""#JobOfferList"").load(url);
        }

          function sort(sortOrder) {
            var searchString = $(""#Search"").val();
            var link = '");
#nullable restore
#line 81 "C:\Users\Lenovo\source\repos\HR App\HR App\HRWebApplication\Areas\User\Views\JobOffer\Index.cshtml"
                    Write(Url.Action("GetJobOffers", "JobOffer", new { Area = "User", page = 1 }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\' + \'?searchString=\' + searchString + \'&sortOrder=\' + sortOrder;\r\n        $(\"#JobOfferList\").load(link);\r\n        }\r\n   \r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JobOfferViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
