#pragma checksum "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Shared\Components\ChekoutComponent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4d68568a352400b87bc4c8c668be2998a5946aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ChekoutComponent_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ChekoutComponent/Default.cshtml")]
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
#nullable restore
#line 5 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\_ViewImports.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\_ViewImports.cshtml"
using ZoNaN.ViewComponents;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4d68568a352400b87bc4c8c668be2998a5946aa", @"/Views/Shared/Components/ChekoutComponent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02410344cb48176cbd8230807a2ea5a36b5f03ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ChekoutComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CartViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("proceed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProceedAsync", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn third-btn btn-theme2 d-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Shared\Components\ChekoutComponent\Default.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-lg-3 mb-30\">\r\n        <ul class=\"list-group cart-summary\">\r\n            <li class=\"list-group-item d-flex justify-content-between align-items-center\">\r\n                <ul class=\"items\">\r\n");
#nullable restore
#line 8 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Shared\Components\ChekoutComponent\Default.cshtml"
                     foreach (var item in Model.CartItems)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li");
            BeginWriteAttribute("id", " id=\"", 364, "\"", 377, 1);
#nullable restore
#line 10 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Shared\Components\ChekoutComponent\Default.cshtml"
WriteAttributeValue("", 369, item.Id, 369, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <a class=\"image\"><img class=\"chekout-images\"");
            BeginWriteAttribute("src", " src=\"", 453, "\"", 482, 2);
            WriteAttributeValue("", 459, "/Assets/img/", 459, 12, true);
#nullable restore
#line 11 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Shared\Components\ChekoutComponent\Default.cshtml"
WriteAttributeValue("", 471, item.Photo, 471, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Cart product Image\"></a>\r\n                            <div class=\"content\">\r\n                                <a class=\"title\">");
#nullable restore
#line 13 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Shared\Components\ChekoutComponent\Default.cshtml"
                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                <span class=\"quantity-price\">");
#nullable restore
#line 14 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Shared\Components\ChekoutComponent\Default.cshtml"
                                                        Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" x <span class=\"amount \">");
#nullable restore
#line 14 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Shared\Components\ChekoutComponent\Default.cshtml"
                                                                                               Write(item.Price.ToString("C2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></span>\r\n                            </div>\r\n                        </li>\r\n");
#nullable restore
#line 17 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Shared\Components\ChekoutComponent\Default.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </ul>
            </li>
            <li class=""list-group-item d-flex justify-content-between align-items-center"">
                <ul class=""items"">
                    <li>Total</li>
                </ul>
                <ul class=""amount"">
                    <li class=""amount text-success font-weight-bold"">");
#nullable restore
#line 26 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Shared\Components\ChekoutComponent\Default.cshtml"
                                                                Write(Model.GrandTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n                </ul>\r\n            </li>\r\n            <li  class=\"list-group-item text-center\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4d68568a352400b87bc4c8c668be2998a5946aa9476", async() => {
                WriteLiteral("Proceed to checkout");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </li>
        </ul>

        <div class=""delivery-info"">
            <ul>
                <li>
                    <i class=""fas fa-shield-alt""></i> Security policy (edit with Customer reassurance module)
                </li>
                <li>
                    <i class=""fas fa-truck""></i> Delivery policy (edit with Customer reassurance module)
                </li>
                <li class=""mb-0"">
                    <i class=""fas fa-exchange-alt""></i> Return policy (edit with Customer reassurance module)
                </li>
            </ul>
        </div>
    </div>
");
#nullable restore
#line 48 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Shared\Components\ChekoutComponent\Default.cshtml"
}

else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""col-lg-3 mb-30"">
    <ul class=""list-group cart-summary"">
    </ul>

    <div class=""delivery-info"">
        <ul>
            <li>
                <i class=""fas fa-shield-alt""></i> Security policy (edit with Customer reassurance module)
            </li>
            <li>
                <i class=""fas fa-truck""></i> Delivery policy (edit with Customer reassurance module)
            </li>
            <li class=""mb-0"">
                <i class=""fas fa-exchange-alt""></i> Return policy (edit with Customer reassurance module)
            </li>
        </ul>
    </div>
</div>
");
#nullable restore
#line 70 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Shared\Components\ChekoutComponent\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591