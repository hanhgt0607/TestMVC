#pragma checksum "C:\Users\Hanh\source\repos\TestMVC\TestMVC\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5dd29fb32525bbc064ab1b63e7c879b1d762094"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Details.cshtml", typeof(AspNetCore.Views_Products_Details))]
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
#line 1 "C:\Users\Hanh\source\repos\TestMVC\TestMVC\Views\_ViewImports.cshtml"
using TestMVC;

#line default
#line hidden
#line 2 "C:\Users\Hanh\source\repos\TestMVC\TestMVC\Views\_ViewImports.cshtml"
using TestMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5dd29fb32525bbc064ab1b63e7c879b1d762094", @"/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83e9e4bcac7067345e0aba9c65e8c3f54f52ae78", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TestMVC.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Hanh\source\repos\TestMVC\TestMVC\Views\Products\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(76, 121, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Product</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(198, 47, false);
#line 14 "C:\Users\Hanh\source\repos\TestMVC\TestMVC\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(245, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(289, 43, false);
#line 17 "C:\Users\Hanh\source\repos\TestMVC\TestMVC\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(332, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(376, 46, false);
#line 20 "C:\Users\Hanh\source\repos\TestMVC\TestMVC\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SupplierID));

#line default
#line hidden
            EndContext();
            BeginContext(422, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(466, 42, false);
#line 23 "C:\Users\Hanh\source\repos\TestMVC\TestMVC\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.SupplierID));

#line default
#line hidden
            EndContext();
            BeginContext(508, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(552, 46, false);
#line 26 "C:\Users\Hanh\source\repos\TestMVC\TestMVC\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CategoryID));

#line default
#line hidden
            EndContext();
            BeginContext(598, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(642, 42, false);
#line 29 "C:\Users\Hanh\source\repos\TestMVC\TestMVC\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.CategoryID));

#line default
#line hidden
            EndContext();
            BeginContext(684, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(728, 51, false);
#line 32 "C:\Users\Hanh\source\repos\TestMVC\TestMVC\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.QuantityPerUnit));

#line default
#line hidden
            EndContext();
            BeginContext(779, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(823, 47, false);
#line 35 "C:\Users\Hanh\source\repos\TestMVC\TestMVC\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.QuantityPerUnit));

#line default
#line hidden
            EndContext();
            BeginContext(870, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(914, 45, false);
#line 38 "C:\Users\Hanh\source\repos\TestMVC\TestMVC\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UnitPrice));

#line default
#line hidden
            EndContext();
            BeginContext(959, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1003, 41, false);
#line 41 "C:\Users\Hanh\source\repos\TestMVC\TestMVC\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.UnitPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1044, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1088, 49, false);
#line 44 "C:\Users\Hanh\source\repos\TestMVC\TestMVC\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UnitslnStocks));

#line default
#line hidden
            EndContext();
            BeginContext(1137, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1181, 45, false);
#line 47 "C:\Users\Hanh\source\repos\TestMVC\TestMVC\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.UnitslnStocks));

#line default
#line hidden
            EndContext();
            BeginContext(1226, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1270, 48, false);
#line 50 "C:\Users\Hanh\source\repos\TestMVC\TestMVC\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UnitsOnOrder));

#line default
#line hidden
            EndContext();
            BeginContext(1318, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1362, 44, false);
#line 53 "C:\Users\Hanh\source\repos\TestMVC\TestMVC\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.UnitsOnOrder));

#line default
#line hidden
            EndContext();
            BeginContext(1406, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1450, 48, false);
#line 56 "C:\Users\Hanh\source\repos\TestMVC\TestMVC\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ReorderLevel));

#line default
#line hidden
            EndContext();
            BeginContext(1498, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1542, 44, false);
#line 59 "C:\Users\Hanh\source\repos\TestMVC\TestMVC\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.ReorderLevel));

#line default
#line hidden
            EndContext();
            BeginContext(1586, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1630, 48, false);
#line 62 "C:\Users\Hanh\source\repos\TestMVC\TestMVC\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Discontinued));

#line default
#line hidden
            EndContext();
            BeginContext(1678, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1722, 44, false);
#line 65 "C:\Users\Hanh\source\repos\TestMVC\TestMVC\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Discontinued));

#line default
#line hidden
            EndContext();
            BeginContext(1766, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1813, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b83a334f82e4a8da9332fd29b438c5e", async() => {
                BeginContext(1866, 4, true);
                WriteLiteral("Edit");
                EndContext();
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
#line 70 "C:\Users\Hanh\source\repos\TestMVC\TestMVC\Views\Products\Details.cshtml"
                           WriteLiteral(Model.ProductID);

#line default
#line hidden
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
            EndContext();
            BeginContext(1874, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1882, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fee75ce54d4b4ea1a0f5d055273baf84", async() => {
                BeginContext(1904, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1920, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TestMVC.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
