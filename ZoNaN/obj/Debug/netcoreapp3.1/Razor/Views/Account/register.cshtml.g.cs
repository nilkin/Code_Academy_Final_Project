#pragma checksum "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Account\register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "367bb9a2845fcdb22a5450596b791edcdca0afda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_register), @"mvc.1.0.view", @"/Views/Account/register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"367bb9a2845fcdb22a5450596b791edcdca0afda", @"/Views/Account/register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b964445f000651e3a7bb63622b62abc7531b3ebc", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_breadcrumbs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("personal-information"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_newsletters", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "367bb9a2845fcdb22a5450596b791edcdca0afda4809", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 3 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Account\register.cshtml"
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
            WriteLiteral(@"
    <!-- breadcrumb-section end -->
    <!-- registr-section start -->
    <div class=""register wrapper-top"">
        <div class=""container grid-wraper"">
            <div class=""row"">
                <div class=""col-12"">
                    <h3 class=""title text-capitalize"">Create an account</h3>
                    <div class=""log-in-form"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "367bb9a2845fcdb22a5450596b791edcdca0afda6789", async() => {
                WriteLiteral(@"
                            <div class=""order-asguest"">
                                <span>Already have an account?</span>
                                <a class=""text-muted hover-color"" href=""login.html"">Log in instead!</a>
                            </div>
                            <div class=""form-group row"">
                                <label class=""col-md-3 col-form-label"">
                                    Social title
                                </label>
                                <div class=""col-md-6"">
                                    <div class=""d-flex flex-wrap"">
                                        <div class=""custom-radio"">
                                            <label for=""opt1"" class=""radio"">
                                                <input type=""radio"" name=""rdo"" id=""opt1"" class=""hidden"" />
                                                <span class=""label""></span>Mr
                                            </label>
                   ");
                WriteLiteral(@"                     </div>
                                        <div class=""custom-radio"">
                                            <label for=""opt2"" class=""radio"">
                                                <input type=""radio"" name=""rdo"" id=""opt2"" class=""hidden"" />
                                                <span class=""label""></span>Mrs
                                            </label>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""form-group row"">
                                <label for=""firstname"" class=""col-md-3 col-form-label"">
                                    First
                                    name
                                </label>
                                <div class=""col-md-6"">
                                    <input type=""text"" id=""firstname"" class=""form-control"">
                ");
                WriteLiteral(@"                </div>
                            </div>
                            <div class=""form-group row"">
                                <label for=""lastname"" class=""col-md-3 col-form-label"">last name</label>
                                <div class=""col-md-6"">
                                    <input type=""text"" id=""lastname"" class=""form-control"">
                                </div>
                            </div>
                            <div class=""form-group row"">
                                <label for=""email"" class=""col-md-3 col-form-label"">Email</label>
                                <div class=""col-md-6"">
                                    <input type=""email"" id=""email"" class=""form-control"">
                                </div>
                            </div>
                            <div class=""form-group row"">
                                <label for=""Password"" class=""col-md-3 col-form-label"">Password</label>
                                <div ");
                WriteLiteral(@"class=""col-md-6"">
                                    <div class=""input-group mb-2 mr-sm-2"">
                                        <input type=""password"" class=""form-control"" id=""Password"">
                                        <div class=""input-group-prepend"">
                                            <button type=""button"" class=""input-group-text third-btn btn-theme2"">show</button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""form-group row"">
                                <label for=""birthdate"" class=""col-md-3 col-form-label"">Birthdate</label>
                                <div class=""col-md-6"">
                                    <input type=""text"" class=""form-control"" id=""birthdate"" placeholder=""MM/DD/YYYY"">
                                </div>
                                <div class=""col-md-3"">
                         ");
                WriteLiteral(@"           <label>
                                        <span class=""optional text-muted"">
                                            Optional
                                        </span>
                                    </label>
                                </div>
                            </div>
                            <div class=""form-group row"">
                                <div class=""col-md-3""></div>
                                <div class=""col-md-6"">
                                    <div class=""check-box-inner"">
                                        <div class=""filter-check-box"">
                                            <input type=""checkbox"" id=""20821"">
                                            <label for=""20821"">Sign up for our newsletter</label>
                                            <p class=""pl-25"">You may unsubscribe at any moment. For that purpose, please find our contact info in the legal notice.</p>
                                        ");
                WriteLiteral(@"</div>
                                    </div>
                                </div>
                                <div class=""col-12"">
                                    <div class=""sign-btn text-right"">
                                        <a href=""#"" class=""btn third-btn btn-theme2"">save</a>
                                    </div>
                                </div>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- registr-section end -->\r\n    <!-- common banner news-letter end -->\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "367bb9a2845fcdb22a5450596b791edcdca0afda14208", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 108 "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Account\register.cshtml"
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
            WriteLiteral("\r\n    <!-- common banner news-letter end -->\r\n</main>");
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
