#pragma checksum "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcfd28e9178790971caa679b1150f328ffb40e99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SacramentPlans_Details), @"mvc.1.0.view", @"/Views/SacramentPlans/Details.cshtml")]
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
#line 1 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/_ViewImports.cshtml"
using SacramentMeetingPlanner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/_ViewImports.cshtml"
using SacramentMeetingPlanner.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcfd28e9178790971caa679b1150f328ffb40e99", @"/Views/SacramentPlans/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30016034c65dc4d043069574fe70410c16402d52", @"/Views/_ViewImports.cshtml")]
    public class Views_SacramentPlans_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SacramentMeeting.Models.SacramentPlan>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <dl class=\"program-container\">\r\n            <h2 class=\"program-center mb-5\">\r\n                ");
#nullable restore
#line 9 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
           Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h2>\r\n        <div class=\"program-row\">\r\n            <dt class=\"left\">\r\n                ");
#nullable restore
#line 13 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.ConductingLeader));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"right\">\r\n                ");
#nullable restore
#line 16 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
           Write(Html.DisplayFor(model => model.ConductingLeader));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </div>\r\n\r\n        <div class=\"program-row\">\r\n            <dt class=left\">\r\n                ");
#nullable restore
#line 22 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.OpeningHymn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"right\">\r\n                ");
#nullable restore
#line 25 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
           Write(Html.DisplayFor(model => model.OpeningHymn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </div>\r\n            <p class=\"hymn-name\">hymn name</p>\r\n        <div class=\"program-row\">\r\n            <dt class=\"left\">\r\n                ");
#nullable restore
#line 31 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.OpeningPrayer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"right\">\r\n                ");
#nullable restore
#line 34 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
           Write(Html.DisplayFor(model => model.OpeningPrayer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </div>\r\n        <p class=\"program-center\">Ward and Stake Business</p>\r\n        <div class=\"program-row\">\r\n            <dt class=\"left\">\r\n                ");
#nullable restore
#line 40 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.SacramentHymn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"right\">\r\n                ");
#nullable restore
#line 43 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
           Write(Html.DisplayFor(model => model.SacramentHymn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </div>\r\n        <p class=\"hymn-name\">hymn name</p>\r\n        <p class=\"program-center\">Administration of the Sacrament</p>\r\n        <div class=\"program-row\">\r\n            <dt class=\"left\">Talks</dt>\r\n        </div>\r\n\r\n");
#nullable restore
#line 52 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
         foreach (var item in Model.Speakers)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"program-row\">\r\n            <dt class=\"left topic-name\">\r\n                ");
#nullable restore
#line 56 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.Topic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"right\">\r\n                ");
#nullable restore
#line 59 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </div>\r\n");
#nullable restore
#line 62 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"program-row\">\r\n            <dt class=\"left\">\r\n\r\n                ");
#nullable restore
#line 67 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.MusicNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"right\">\r\n                ");
#nullable restore
#line 70 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
           Write(Html.DisplayFor(model => model.MusicNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </div>\r\n        <p class=\"hymn-name\">hymn name</p>\r\n        <div class=\"program-row\">\r\n            <dt class=\"left\">\r\n                ");
#nullable restore
#line 76 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.ClosingHymn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"right\">\r\n                ");
#nullable restore
#line 79 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
           Write(Html.DisplayFor(model => model.ClosingHymn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <p class=\"hymn-name\">hymn name</p>\r\n        <div class=\"program-row\">\r\n            <dt class=\"left\">\r\n                ");
#nullable restore
#line 84 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.ClosingPrayer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"right\">\r\n                ");
#nullable restore
#line 87 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
           Write(Html.DisplayFor(model => model.ClosingPrayer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </div>\r\n\r\n    </dl>\r\n</div>\r\n<div class=\"program-center mt-6\">\r\n    <a asp-action=\"Edit\" asp-route-id=\"");
#nullable restore
#line 94 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
                                  Write(Model.SacramentPlanId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Edit</a> |\r\n    <a asp-action=\"Delete\" asp-route-id=\"");
#nullable restore
#line 95 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
                                    Write(Model.SacramentPlanId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Delete</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 100 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
  await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SacramentMeeting.Models.SacramentPlan> Html { get; private set; }
    }
}
#pragma warning restore 1591