#pragma checksum "C:\Users\hamid.mammadov\Desktop\P129Allup\P129Allup\Views\Shared\_BasketPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbda2f92daf1b0b2df5565f034926c07224261c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BasketPartial), @"mvc.1.0.view", @"/Views/Shared/_BasketPartial.cshtml")]
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
#line 2 "C:\Users\hamid.mammadov\Desktop\P129Allup\P129Allup\Views\_ViewImports.cshtml"
using P129Allup.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hamid.mammadov\Desktop\P129Allup\P129Allup\Views\_ViewImports.cshtml"
using P129Allup.ViewModels.BasketViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hamid.mammadov\Desktop\P129Allup\P129Allup\Views\_ViewImports.cshtml"
using P129Allup.ViewModels.HeaderViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hamid.mammadov\Desktop\P129Allup\P129Allup\Views\_ViewImports.cshtml"
using P129Allup.ViewModels.HomeViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hamid.mammadov\Desktop\P129Allup\P129Allup\Views\_ViewImports.cshtml"
using P129Allup.ViewModels.AccountViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hamid.mammadov\Desktop\P129Allup\P129Allup\Views\_ViewImports.cshtml"
using P129Allup.ViewModels.OrderViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbda2f92daf1b0b2df5565f034926c07224261c6", @"/Views/Shared/_BasketPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae26bde490afefc34a24f1d6b8a2da2a6305e8e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__BasketPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BasketVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "basket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "deletefrombasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-close deletefrombasket"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n<div class=\"cart-btn webelement\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbda2f92daf1b0b2df5565f034926c07224261c65897", async() => {
                WriteLiteral("\r\n        <i class=\"icon ion-bag\"></i>\r\n        <span class=\"text\">Cart :</span>\r\n        <span class=\"total\">$");
#nullable restore
#line 8 "C:\Users\hamid.mammadov\Desktop\P129Allup\P129Allup\Views\Shared\_BasketPartial.cshtml"
                         Write(Model.Sum(b=>b.Count * b.Price)+Model.Sum(b=>b.ExTax * b.Count));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n        <span class=\"count\">");
#nullable restore
#line 9 "C:\Users\hamid.mammadov\Desktop\P129Allup\P129Allup\Views\Shared\_BasketPartial.cshtml"
                       Write(Model.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<a href=\"#\" class=\"mobileelement\">\r\n    <i class=\"fal fa-shopping-cart\"></i>\r\n    <span>");
#nullable restore
#line 14 "C:\Users\hamid.mammadov\Desktop\P129Allup\P129Allup\Views\Shared\_BasketPartial.cshtml"
     Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</a>\r\n<div class=\"mini-cart\">\r\n    <ul class=\"cart-items\">\r\n");
#nullable restore
#line 18 "C:\Users\hamid.mammadov\Desktop\P129Allup\P129Allup\Views\Shared\_BasketPartial.cshtml"
         foreach (BasketVM basketVM in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <div class=\"single-cart-item d-flex\">\r\n                    <div class=\"cart-item-thumb\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbda2f92daf1b0b2df5565f034926c07224261c68806", async() => {
                WriteLiteral("<img");
                BeginWriteAttribute("src", " src=\"", 827, "\"", 871, 2);
                WriteAttributeValue("", 833, "/assets/images/product/", 833, 23, true);
#nullable restore
#line 23 "C:\Users\hamid.mammadov\Desktop\P129Allup\P129Allup\Views\Shared\_BasketPartial.cshtml"
WriteAttributeValue("", 856, basketVM.Image, 856, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"product\">");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\Users\hamid.mammadov\Desktop\P129Allup\P129Allup\Views\Shared\_BasketPartial.cshtml"
                                                                          WriteLiteral(basketVM.ProductId);

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
            WriteLiteral("\r\n                        <span class=\"product-quantity\">");
#nullable restore
#line 24 "C:\Users\hamid.mammadov\Desktop\P129Allup\P129Allup\Views\Shared\_BasketPartial.cshtml"
                                                   Write(basketVM.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("x</span>\r\n                    </div>\r\n                    <div class=\"cart-item-content media-body\">\r\n                        <h5 class=\"product-name\"><a href=\"single-product.html\">");
#nullable restore
#line 27 "C:\Users\hamid.mammadov\Desktop\P129Allup\P129Allup\Views\Shared\_BasketPartial.cshtml"
                                                                          Write(basketVM.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                        <span class=\"product-price\">€");
#nullable restore
#line 28 "C:\Users\hamid.mammadov\Desktop\P129Allup\P129Allup\Views\Shared\_BasketPartial.cshtml"
                                                Write(basketVM.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbda2f92daf1b0b2df5565f034926c07224261c612891", async() => {
                WriteLiteral("<i class=\"fal fa-times\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\hamid.mammadov\Desktop\P129Allup\P129Allup\Views\Shared\_BasketPartial.cshtml"
                                                                                   WriteLiteral(basketVM.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </li>\r\n");
#nullable restore
#line 33 "C:\Users\hamid.mammadov\Desktop\P129Allup\P129Allup\Views\Shared\_BasketPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n    <div class=\"price_content\">\r\n        <div class=\"cart-subtotals\">\r\n            <div class=\"products price_inline\">\r\n                <span class=\"label\">Subtotal</span>\r\n                <span class=\"value\">€");
#nullable restore
#line 39 "C:\Users\hamid.mammadov\Desktop\P129Allup\P129Allup\Views\Shared\_BasketPartial.cshtml"
                                 Write(Model.Sum(b=>b.Price * b.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n            <div class=\"tax price_inline\">\r\n                <span class=\"label\">Taxes</span>\r\n                <span class=\"value\">€");
#nullable restore
#line 43 "C:\Users\hamid.mammadov\Desktop\P129Allup\P129Allup\Views\Shared\_BasketPartial.cshtml"
                                 Write(Model.Sum(b=>b.ExTax * b.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n        </div>\r\n        <div class=\"cart-total price_inline\">\r\n            <span class=\"label\">Total</span>\r\n            <span class=\"value\">€");
#nullable restore
#line 48 "C:\Users\hamid.mammadov\Desktop\P129Allup\P129Allup\Views\Shared\_BasketPartial.cshtml"
                             Write(Model.Sum(b => b.ExTax * b.Count) + Model.Sum(b => b.Price * b.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n    </div> <!-- price content -->\r\n    <div class=\"checkout text-center\">\r\n        <a href=\"checkout.html\" class=\"main-btn\">Checkout</a>\r\n    </div>\r\n</div> <!-- mini cart -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BasketVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
