#pragma checksum "C:\Users\A\source\repos\ClothesStore\ClothesStore\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08301d961cfbc8b05a45f5f28ccb8174bc7a7be5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/Index.cshtml", typeof(AspNetCore.Views_Cart_Index))]
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
#line 1 "C:\Users\A\source\repos\ClothesStore\ClothesStore\Views\_ViewImports.cshtml"
using ClothesStore.Models;

#line default
#line hidden
#line 3 "C:\Users\A\source\repos\ClothesStore\ClothesStore\Views\_ViewImports.cshtml"
using ClothesStore.Models.ViewModels;

#line default
#line hidden
#line 5 "C:\Users\A\source\repos\ClothesStore\ClothesStore\Views\_ViewImports.cshtml"
using ClothesStore.Infrastructure;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08301d961cfbc8b05a45f5f28ccb8174bc7a7be5", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"668eb67f2dbc42a154d366d92b34e6e3782bca8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CartIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveFromCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 276, true);
            WriteLiteral(@"    <h2>Your cart</h2>
<table class=""table table-bordered table-striped"">
    <thead>
    <tr>
        <th>Quantity</th>
        <th>Item</th>
        <th class=""text-right"">Price</th>
        <th class=""text-right"">Subtotal</th>
    </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 13 "C:\Users\A\source\repos\ClothesStore\ClothesStore\Views\Cart\Index.cshtml"
         foreach (var line in Model.Cart.Lines)
        {

#line default
#line hidden
            BeginContext(363, 50, true);
            WriteLiteral("        <tr>\r\n            <td class=\"text-center\">");
            EndContext();
            BeginContext(414, 13, false);
#line 16 "C:\Users\A\source\repos\ClothesStore\ClothesStore\Views\Cart\Index.cshtml"
                               Write(line.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(427, 41, true);
            WriteLiteral("</td>\r\n            <td class=\"text-left\">");
            EndContext();
            BeginContext(469, 17, false);
#line 17 "C:\Users\A\source\repos\ClothesStore\ClothesStore\Views\Cart\Index.cshtml"
                             Write(line.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(486, 42, true);
            WriteLiteral("</td>\r\n            <td class=\"text-right\">");
            EndContext();
            BeginContext(529, 32, false);
#line 18 "C:\Users\A\source\repos\ClothesStore\ClothesStore\Views\Cart\Index.cshtml"
                              Write(line.Product.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(561, 42, true);
            WriteLiteral("</td>\r\n            <td class=\"text-right\">");
            EndContext();
            BeginContext(605, 50, false);
#line 19 "C:\Users\A\source\repos\ClothesStore\ClothesStore\Views\Cart\Index.cshtml"
                               Write((line.Quantity * line.Product.Price).ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(656, 41, true);
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(697, 343, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2513b9630754ad3932d310cfed934a9", async() => {
                BeginContext(745, 59, true);
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"ProductID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 804, "\"", 835, 1);
#line 22 "C:\Users\A\source\repos\ClothesStore\ClothesStore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 812, line.Product.ProductID, 812, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(836, 62, true);
                WriteLiteral(" />\r\n                    <input type=\"hidden\" name=\"returnUrl\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 898, "\"", 922, 1);
#line 23 "C:\Users\A\source\repos\ClothesStore\ClothesStore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 906, Model.ReturnUrl, 906, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(923, 110, true);
                WriteLiteral(" />\r\n                    <button type=\"submit\" class=\"btn btn-sm btn-danger\">Remove</button>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1040, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 28 "C:\Users\A\source\repos\ClothesStore\ClothesStore\Views\Cart\Index.cshtml"
         }

#line default
#line hidden
            BeginContext(1088, 124, true);
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n    <tr>\r\n        <td colspan=\"3\" class=\"text-right\">Total:</td>\r\n        <td class=\"text-right\">");
            EndContext();
            BeginContext(1213, 44, false);
#line 33 "C:\Users\A\source\repos\ClothesStore\ClothesStore\Views\Cart\Index.cshtml"
                          Write(Model.Cart.ComputeTotalValue().ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(1257, 99, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    </tfoot>\r\n</table>\r\n<div class=\"text-center\">\r\n    <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1356, "\"", 1379, 1);
#line 38 "C:\Users\A\source\repos\ClothesStore\ClothesStore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1363, Model.ReturnUrl, 1363, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1380, 28, true);
            WriteLiteral(">Continue shopping</a>\r\n    ");
            EndContext();
            BeginContext(1408, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4ab924126db4adf8210e23f235ed836", async() => {
                BeginContext(1480, 8, true);
                WriteLiteral("Checkout");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1492, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CartIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
