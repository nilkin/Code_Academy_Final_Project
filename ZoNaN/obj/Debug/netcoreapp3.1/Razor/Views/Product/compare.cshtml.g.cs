#pragma checksum "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Product\compare.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f12613f4fbb9d5c44fe0181aa4536e4bd2173d1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_compare), @"mvc.1.0.view", @"/Views/Product/compare.cshtml")]
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
#line 1 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\_ViewImports.cshtml"
using ZoNaN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\_ViewImports.cshtml"
using ZoNaN.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\_ViewImports.cshtml"
using ZoNaN.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\_ViewImports.cshtml"
using ZoNaN.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f12613f4fbb9d5c44fe0181aa4536e4bd2173d1b", @"/Views/Product/compare.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e085038e2ec48b5d8f282d62ad12166ffa96046", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_compare : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CompareViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_breadcrumbs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddFromCompareToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn third-btn btn-theme2 text-uppercase"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn d-none third-btn btn-theme2 text-uppercase"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveFromCompare", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn third-btn btn-theme2 text-uppercase remove-compare"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_newsletters", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<main>\r\n");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f12613f4fbb9d5c44fe0181aa4536e4bd2173d1b6385", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 4 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Product\compare.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Breadcrumb;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral(@"    <section class=""compare-section shop-order top-margin"">
        <div class=""container grid-wraper"">
            <div class=""row"">
                <div class=""col-12"">
                    <h3 class=""title text-center text-md-left text-capitalize"">compare</h3>
                    <div class=""table-responsive"">
                        <table class=""table"">
                            <thead class=""thead-light"">
                                <tr>
                                    <th class=""text-dark"" scope=""col"">product info</th>
");
#nullable restore
#line 17 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Product\compare.cshtml"
                                     foreach (var item in Model.CompareItems)
                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <th scope=\"col\" class=\"text-center\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 968, "\"", 997, 2);
            WriteAttributeValue("", 974, "/Assets/img/", 974, 12, true);
#nullable restore
#line 21 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Product\compare.cshtml"
WriteAttributeValue("", 986, item.Photo, 986, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"img\">\r\n\r\n                                    <span class=\"sub-title d-block\">");
#nullable restore
#line 23 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Product\compare.cshtml"
                                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 24 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Product\compare.cshtml"
                                     if (@item.Quantity > 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f12613f4fbb9d5c44fe0181aa4536e4bd2173d1b10207", async() => {
                WriteLiteral(" add to cart");
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
#line 26 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Product\compare.cshtml"
                                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 27 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Product\compare.cshtml"
                                    }
                                    else 
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f12613f4fbb9d5c44fe0181aa4536e4bd2173d1b12869", async() => {
                WriteLiteral(" add to cart");
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
#line 30 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Product\compare.cshtml"
                                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 31 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Product\compare.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f12613f4fbb9d5c44fe0181aa4536e4bd2173d1b15449", async() => {
                WriteLiteral(" Remove");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Product\compare.cshtml"
                                                                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 33 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Product\compare.cshtml"
AddHtmlAttributeValue("", 1827, item.Id, 1827, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </th>\r\n");
#nullable restore
#line 35 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Product\compare.cshtml"
                                        
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <th scope=""row"">
                                        Price
                                    </th>

");
#nullable restore
#line 46 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Product\compare.cshtml"
                                     foreach (var item in Model.CompareItems)
                                    {

                       

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td class=\"text-center\">\r\n                                                <span class=\"whish-list-price\">\r\n                                                    ");
#nullable restore
#line 52 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Product\compare.cshtml"
                                               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $\r\n                                                </span>\r\n                                            </td>\r\n");
#nullable restore
#line 55 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Product\compare.cshtml"
                                        

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                </tr>\r\n                                <tr>\r\n                                    <th scope=\"row\">\r\n                                        Description\r\n                                    </th>\r\n\r\n");
#nullable restore
#line 66 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Product\compare.cshtml"
                                     foreach (var item in Model.CompareItems)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td class=\"text-center\">\r\n                                            <p>");
#nullable restore
#line 69 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Product\compare.cshtml"
                                          Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </td>\r\n");
#nullable restore
#line 71 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Product\compare.cshtml"

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                </tr>\r\n                                <tr>\r\n                                    <th scope=\"row\">\r\n                                        Availability\r\n                                    </th>\r\n\r\n");
#nullable restore
#line 81 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Product\compare.cshtml"
                                     foreach (var item in Model.CompareItems)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td class=\"text-center\">\r\n");
#nullable restore
#line 84 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Product\compare.cshtml"
                                             if (@item.Quantity > 0)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"badge  position-static my-badge\">In Stock</span>\r\n");
#nullable restore
#line 87 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Product\compare.cshtml"

                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"badge badge-danger position-static my-badge\">Out Stock</span>\r\n");
#nullable restore
#line 92 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Product\compare.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </td>\r\n");
#nullable restore
#line 94 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Product\compare.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                </tr>\r\n                                <tr>\r\n                                    <th scope=\"row\">\r\n                                        weight\r\n                                    </th>\r\n\r\n");
#nullable restore
#line 103 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Product\compare.cshtml"
                                     foreach (var item in Model.CompareItems)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td class=\"text-center\">\r\n                                            ");
#nullable restore
#line 106 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Product\compare.cshtml"
                                       Write(item.Dimention);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n");
#nullable restore
#line 108 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Product\compare.cshtml"
          
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </tr>\r\n                                <tr>\r\n                                    <th scope=\"row\">\r\n                                        colors\r\n                                    </th>\r\n\r\n");
#nullable restore
#line 117 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Product\compare.cshtml"
                                     foreach (var item in Model.CompareItems)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td class=\"text-center\">\r\n                                            ");
#nullable restore
#line 120 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Product\compare.cshtml"
                                       Write(item.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n");
#nullable restore
#line 122 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Product\compare.cshtml"

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </tr>\r\n                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f12613f4fbb9d5c44fe0181aa4536e4bd2173d1b26486", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#nullable restore
#line 135 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Product\compare.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Subscriber;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CompareViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
