#pragma checksum "D:\Git_Projects\ASP.Net-MentorShip-\ASP.NetCore Fundamental Beginner\2.1-PieShop(DataBase)\PieShop\PieShop\Views\Pie\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adcd2f62ae939d533fd099be47367078200cb3ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pie_Details), @"mvc.1.0.view", @"/Views/Pie/Details.cshtml")]
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
#line 1 "D:\Git_Projects\ASP.Net-MentorShip-\ASP.NetCore Fundamental Beginner\2.1-PieShop(DataBase)\PieShop\PieShop\Views\_ViewImports.cshtml"
using PieShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Git_Projects\ASP.Net-MentorShip-\ASP.NetCore Fundamental Beginner\2.1-PieShop(DataBase)\PieShop\PieShop\Views\_ViewImports.cshtml"
using PieShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Git_Projects\ASP.Net-MentorShip-\ASP.NetCore Fundamental Beginner\2.1-PieShop(DataBase)\PieShop\PieShop\Views\_ViewImports.cshtml"
using PieShop.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Git_Projects\ASP.Net-MentorShip-\ASP.NetCore Fundamental Beginner\2.1-PieShop(DataBase)\PieShop\PieShop\Views\_ViewImports.cshtml"
using PieShop.Models.Repositories;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adcd2f62ae939d533fd099be47367078200cb3ff", @"/Views/Pie/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c73ebbbc396ab5a1863564bb2897de5fbb5bc4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Pie_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PieShop.Models.Pie>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Git_Projects\ASP.Net-MentorShip-\ASP.NetCore Fundamental Beginner\2.1-PieShop(DataBase)\PieShop\PieShop\Views\Pie\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Pie</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n       \r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "D:\Git_Projects\ASP.Net-MentorShip-\ASP.NetCore Fundamental Beginner\2.1-PieShop(DataBase)\PieShop\PieShop\Views\Pie\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "D:\Git_Projects\ASP.Net-MentorShip-\ASP.NetCore Fundamental Beginner\2.1-PieShop(DataBase)\PieShop\PieShop\Views\Pie\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "D:\Git_Projects\ASP.Net-MentorShip-\ASP.NetCore Fundamental Beginner\2.1-PieShop(DataBase)\PieShop\PieShop\Views\Pie\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ShortDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10 text-secondary\">\r\n            ");
#nullable restore
#line 24 "D:\Git_Projects\ASP.Net-MentorShip-\ASP.NetCore Fundamental Beginner\2.1-PieShop(DataBase)\PieShop\PieShop\Views\Pie\Details.cshtml"
       Write(Html.DisplayFor(model => model.ShortDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "D:\Git_Projects\ASP.Net-MentorShip-\ASP.NetCore Fundamental Beginner\2.1-PieShop(DataBase)\PieShop\PieShop\Views\Pie\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LongDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10 text-info\">\r\n            ");
#nullable restore
#line 30 "D:\Git_Projects\ASP.Net-MentorShip-\ASP.NetCore Fundamental Beginner\2.1-PieShop(DataBase)\PieShop\PieShop\Views\Pie\Details.cshtml"
       Write(Html.DisplayFor(model => model.LongDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "D:\Git_Projects\ASP.Net-MentorShip-\ASP.NetCore Fundamental Beginner\2.1-PieShop(DataBase)\PieShop\PieShop\Views\Pie\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10 text-danger font-weight-bold\">\r\n            ");
#nullable restore
#line 36 "D:\Git_Projects\ASP.Net-MentorShip-\ASP.NetCore Fundamental Beginner\2.1-PieShop(DataBase)\PieShop\PieShop\Views\Pie\Details.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" $\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n           <img");
            BeginWriteAttribute("src", " src=\"", 1126, "\"", 1147, 1);
#nullable restore
#line 39 "D:\Git_Projects\ASP.Net-MentorShip-\ASP.NetCore Fundamental Beginner\2.1-PieShop(DataBase)\PieShop\PieShop\Views\Pie\Details.cshtml"
WriteAttributeValue("", 1132, Model.ImageUrl, 1132, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </dt>\r\n        \r\n    </dl>\r\n</div>\r\n<div class=\"addToCart\">\r\n    <p class=\"button\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adcd2f62ae939d533fd099be47367078200cb3ff9040", async() => {
                WriteLiteral("Add to cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pieId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "D:\Git_Projects\ASP.Net-MentorShip-\ASP.NetCore Fundamental Beginner\2.1-PieShop(DataBase)\PieShop\PieShop\Views\Pie\Details.cshtml"
                WriteLiteral(Model.PieId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pieId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pieId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pieId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </p>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 53 "D:\Git_Projects\ASP.Net-MentorShip-\ASP.NetCore Fundamental Beginner\2.1-PieShop(DataBase)\PieShop\PieShop\Views\Pie\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adcd2f62ae939d533fd099be47367078200cb3ff11895", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PieShop.Models.Pie> Html { get; private set; }
    }
}
#pragma warning restore 1591
