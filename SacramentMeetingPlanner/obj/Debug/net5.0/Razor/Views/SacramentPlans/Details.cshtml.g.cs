#pragma checksum "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0a6be57ec453c58ef04498bb298b1c78440af50"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0a6be57ec453c58ef04498bb298b1c78440af50", @"/Views/SacramentPlans/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30016034c65dc4d043069574fe70410c16402d52", @"/Views/_ViewImports.cshtml")]
    public class Views_SacramentPlans_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SacramentMeeting.Models.SacramentPlan>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
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
            WriteLiteral("\r\n<dl class=\"program-container\">\r\n    <h2 class=\"program-center mb-5\">\r\n        ");
#nullable restore
#line 9 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
   Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h2>\r\n");
            WriteLiteral("\r\n    <div class=\"program-row\">\r\n        <dt class=\"left\">\r\n            ");
#nullable restore
#line 22 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OpeningHymn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"right\">\r\n            ");
#nullable restore
#line 25 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
       Write(Html.DisplayFor(model => model.OpeningHymn.HymnNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </div>\r\n    <p class=\"hymn-name\">");
#nullable restore
#line 28 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
                    Write(Html.DisplayFor(model => model.OpeningHymn.HymnName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <div class=\"program-row\">\r\n        <dt class=\"left\">\r\n            ");
#nullable restore
#line 31 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OpeningPrayer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"right\">\r\n            ");
#nullable restore
#line 34 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
       Write(Html.DisplayFor(model => model.OpeningPrayer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </div>\r\n    <p class=\"program-center\">Ward and Stake Business</p>\r\n    <div class=\"program-row\">\r\n        <dt class=\"left\">\r\n            ");
#nullable restore
#line 40 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SacramentHymn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"right\">\r\n            ");
#nullable restore
#line 43 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
       Write(Html.DisplayFor(model => model.SacramentHymn.HymnNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </div>\r\n    <p class=\"hymn-name\">\r\n        ");
#nullable restore
#line 47 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
   Write(Html.DisplayFor(model => model.SacramentHymn.HymnName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <p class=\"program-center\">Administration of the Sacrament</p>\r\n");
#nullable restore
#line 50 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
     if (Model.Speakers.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"program-row\">\r\n            <dt class=\"left\">Talks</dt>\r\n        </div>\r\n");
#nullable restore
#line 55 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
         foreach (var item in Model.Speakers)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"program-row\">\r\n                <dt class=\"left topic-name\">\r\n                    ");
#nullable restore
#line 59 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Topic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"right\">\r\n                    ");
#nullable restore
#line 62 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n            </div>\r\n");
#nullable restore
#line 65 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
         
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
     if (Model.IntermediateHymn != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"program-row\">\r\n            <dt class=\"left\">\r\n\r\n                ");
#nullable restore
#line 72 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.IntermediateHymn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"right\">\r\n                ");
#nullable restore
#line 75 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
           Write(Html.DisplayFor(model => model.IntermediateHymn.HymnNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </div>\r\n        <p class=\"hymn-name\">");
#nullable restore
#line 78 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
                        Write(Html.DisplayFor(model => model.IntermediateHymn.HymnName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 79 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"program-center\">Bearing of Testimonies</p>\r\n");
#nullable restore
#line 83 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"program-row\">\r\n        <dt class=\"left\">\r\n            ");
#nullable restore
#line 87 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ClosingHymn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"right\">\r\n            ");
#nullable restore
#line 90 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
       Write(Html.DisplayFor(model => model.ClosingHymn.HymnNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <p class=\"hymn-name\">");
#nullable restore
#line 92 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
                    Write(Html.DisplayFor(model => model.ClosingHymn.HymnName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <div class=\"program-row\">\r\n        <dt class=\"left\">\r\n            ");
#nullable restore
#line 95 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ClosingPrayer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"right\">\r\n            ");
#nullable restore
#line 98 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
       Write(Html.DisplayFor(model => model.ClosingPrayer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </div>\r\n\r\n</dl>\r\n\r\n<div class=\"program-center mt-6\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0a6be57ec453c58ef04498bb298b1c78440af5014279", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 105 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
                           WriteLiteral(Model.SacramentPlanId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0a6be57ec453c58ef04498bb298b1c78440af5016465", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 106 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
                             WriteLiteral(Model.SacramentPlanId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0a6be57ec453c58ef04498bb298b1c78440af5018655", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 110 "/Users/4cibe/Desktop/School/fall2021/CIT365-.NET/week12/SacramentMeetingPlanner/SacramentMeetingPlanner/Views/SacramentPlans/Details.cshtml"
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
