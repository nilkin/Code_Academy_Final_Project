#pragma checksum "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\ContactUs\contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9320a31c4e4796a9d2cbae1436a91af455c22c20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ContactUs_contact), @"mvc.1.0.view", @"/Views/ContactUs/contact.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9320a31c4e4796a9d2cbae1436a91af455c22c20", @"/Views/ContactUs/contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d01911ac31c29fe47c67291227bd1a8216b342d5", @"/Views/_ViewImports.cshtml")]
    public class Views_ContactUs_contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_breadcrumbs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("assets/php/mail.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_newsletters", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<main>\r\n    <!-- breadcrumb-section start -->\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9320a31c4e4796a9d2cbae1436a91af455c22c205260", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <!-- breadcrumb-section end -->
    <!-- map start -->
    <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d97236.62360556707!2d49.784748173306504!3d40.394571267708066!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x40307d6bd6211cf9%3A0x343f6b5e7ae56c6b!2z0JHQsNC60YMsINCQ0LfQtdGA0LHQsNC50LTQttCw0L0!5e0!3m2!1sru!2s!4v1604437597412!5m2!1sru!2s""
            width=""1520"" height=""600"" frameborder=""0"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 529, "\"", 547, 0);
            EndWriteAttribute();
            WriteLiteral(@" aria-hidden=""false"" tabindex=""0""></iframe>
    <!-- map end -->
    <!-- contac us start -->
    <section class=""contact-section head-top"">
        <div class=""container grid-wraper"">
            <div class=""row"">
                <div class=""col-lg-6 col-12 mb-30"">
                    <div class=""contact-page-side-content"">
                        <h3 class=""contact-page-title"">Contact Us</h3>
                        <p class=""contact-page-message mb-30"">Claritas est etiam processus dynamicus, qui sequitur mutationem consuetudium lectorum. Mirum est notare quam littera gothica, quam nunc putamus parum claram anteposuerit litterarum formas human.</p>
                        <div class=""single-contact-block"">
                            <h4><i class=""fa fa-fax""></i> Address</h4>
                            <p>123 Main Street, Anytown, CA 12345 – USA</p>
                        </div>
                        <div class=""single-contact-block"">
                            <h4><i class=""fa fa-phone""");
            WriteLiteral(@"></i> Phone</h4>
                            <p>
                                <a href=""tel:123456789"">Mobile: (08) 123 456 789</a>
                            </p>
                            <p><a href=""tel:1009678456"">Hotline: 1009 678 456</a></p>
                        </div>
                        <div class=""single-contact-block"">
                            <h4><i class=""fas fa-envelope""></i> Email</h4>
                            <p>
                                <a href=""mailto:yourmail@domain.com"">yourmail@domain.com</a>
                            </p>
                            <p> <a href=""mailto:support@hastech.company"">support@hastech.company</a></p>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-6 col-12 mb-30"">
                    <div class=""contact-form-content"">
                        <h3 class=""contact-page-title"">Tell Us Your Message</h3>
                        <div class=""contact-form"">
    ");
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9320a31c4e4796a9d2cbae1436a91af455c22c209172", async() => {
                WriteLiteral("\r\n                                <div class=\"form-group\">\r\n                                    <label>Your Name <span class=\"required\">*</span></label>\r\n                                    <input type=\"text\" name=\"customerName\" id=\"customername\"");
                BeginWriteAttribute("required", " required=\"", 2933, "\"", 2944, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                </div>
                                <div class=""form-group"">
                                    <label>Your Email <span class=""required"">*</span></label>
                                    <input type=""email"" name=""customerEmail"" id=""customerEmail""");
                BeginWriteAttribute("required", " required=\"", 3236, "\"", 3247, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                </div>
                                <div class=""form-group"">
                                    <label>Subject</label>
                                    <input type=""text"" name=""contactSubject"" id=""contactSubject""");
                BeginWriteAttribute("required", " required=\"", 3505, "\"", 3516, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                </div>
                                <div class=""form-group"">
                                    <label>Your Message</label>
                                    <textarea name=""contactMessage"" class=""pb-10"" id=""contactMessage""");
                BeginWriteAttribute("required", " required=\"", 3784, "\"", 3795, 0);
                EndWriteAttribute();
                WriteLiteral(@"></textarea>
                                </div>
                                <div class=""form-group mb-0"">
                                    <button type=""submit"" value=""submit"" id=""submit"" class=""btn third-btn btn-theme2"" name=""submit"">submit</button>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <p class=""form-messegemt-10""></p>
                    </div>
                    <!-- End of contact -->
                </div>
            </div>
        </div>
    </section>
    <!-- contact us end -->
    <!-- common banner news-letter end -->
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9320a31c4e4796a9d2cbae1436a91af455c22c2013176", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <!-- common banner news-letter end -->\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
