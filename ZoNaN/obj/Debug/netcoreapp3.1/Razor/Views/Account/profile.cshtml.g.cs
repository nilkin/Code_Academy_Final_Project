#pragma checksum "C:\Users\n_ilkin\Desktop\my Code\Code_Academy_Final_Project\ZoNaN\Views\Account\profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08db5b9c8098dc04f87e96635c8c9fbfa32de729"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_profile), @"mvc.1.0.view", @"/Views/Account/profile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08db5b9c8098dc04f87e96635c8c9fbfa32de729", @"/Views/Account/profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5e18367f17d3dd6ad5c416cc9255c599fd92365", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_breadcrumbs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "08db5b9c8098dc04f87e96635c8c9fbfa32de7294198", async() => {
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
    <!-- account section start -->
    <div class=""my-account wrapper-top"">
        <div class=""container grid-wraper"">
            <div class=""row"">
                <div class=""col-12"">
                    <h3 class=""title text-capitalize"">my account</h3>
                </div>
                <!-- My Account Tab Menu Start -->
                <div class=""col-lg-3 col-12 mb-30"">
                    <div class=""myaccount-tab-menu nav"" role=""tablist"">
                        <a href=""#dashboad"" data-toggle=""tab"" class=""active"">
                            <i class=""fas fa-tachometer-alt""></i>
                            Dashboard
                        </a>

                        <a href=""#orders"" data-toggle=""tab"">
                            <i class=""fa fa-cart-arrow-down""></i>
                            Orders
                        </a>

                        <a href=""#download"" data-toggle=""tab"">
                            <i class=""fas ");
            WriteLiteral(@"fa-cloud-download-alt""></i>
                            Download
                        </a>

                        <a href=""#payment-method"" data-toggle=""tab"">
                            <i class=""fa fa-credit-card""></i>
                            Payment
                            Method
                        </a>

                        <a href=""#address-edit"" data-toggle=""tab"">
                            <i class=""fa fa-map-marker""></i>
                            address
                        </a>

                        <a href=""#account-info"" data-toggle=""tab"">
                            <i class=""fa fa-user""></i> Account
                            Details
                        </a>

                        <a href=""login.html""> <i class=""fas fa-sign-out-alt""></i>Logout</a>
                    </div>
                </div>
                <!-- My Account Tab Menu End -->
                <!-- My Account Tab Content Start -->
                <div class=""col-lg-9 ");
            WriteLiteral(@"col-12 mb-30"">
                    <div class=""tab-content"" id=""myaccountContent"">
                        <!-- Single Tab Content Start -->
                        <div class=""tab-pane fade"" id=""dashboad"" role=""tabpanel"">
                            <div class=""myaccount-content"">
                                <h3>Dashboard</h3>

                                <div class=""welcome mb-20"">
                                    <p>Hello, <strong>Alex Tuntuni</strong> (If Not <strong>Tuntuni !</strong><a href=""login-register.html"" class=""logout""> Logout</a>)</p>
                                </div>

                                <p class=""mb-0"">From your account dashboard. you can easily check &amp; view your recent orders, manage your shipping and billing addresses and edit your password and account details.</p>
                            </div>
                        </div>
                        <!-- Single Tab Content End -->
                        <!-- Single Tab Content Start -->
 ");
            WriteLiteral(@"                       <div class=""tab-pane fade"" id=""orders"" role=""tabpanel"">
                            <div class=""myaccount-content"">
                                <h3>Orders</h3>

                                <div class=""myaccount-table table-responsive text-center"">
                                    <table class=""table table-bordered"">
                                        <thead class=""bg-success text-white"">
                                            <tr>
                                                <th>No</th>
                                                <th>Name</th>
                                                <th>Date</th>
                                                <th>Status</th>
                                                <th>Total</th>
                                                <th>Action</th>
                                            </tr>
                                        </thead>

                                        <tbody>
    ");
            WriteLiteral(@"                                        <tr>
                                                <td>1</td>
                                                <td>Mostarizing Oil</td>
                                                <td>Aug 22, 2018</td>
                                                <td>Pending</td>
                                                <td>$45</td>
                                                <td>
                                                    <a href=""shopping-cart.html"" class=""ht-btn black-btn"">View</a>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>2</td>
                                                <td>Katopeno Altuni</td>
                                                <td>July 22, 2018</td>
                                                <td>Approved</td>
                                              ");
            WriteLiteral(@"  <td>$100</td>
                                                <td>
                                                    <a href=""shopping-cart.html"" class=""ht-btn black-btn"">View</a>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>3</td>
                                                <td>Murikhete Paris</td>
                                                <td>June 12, 2017</td>
                                                <td>On Hold</td>
                                                <td>$99</td>
                                                <td>
                                                    <a href=""shopping-cart.html"" class=""ht-btn black-btn"">View</a>
                                                </td>
                                            </tr>
                                        </tbody>
                     ");
            WriteLiteral(@"               </table>
                                </div>
                            </div>
                        </div>
                        <!-- Single Tab Content End -->
                        <!-- Single Tab Content Start -->
                        <div class=""tab-pane fade"" id=""download"" role=""tabpanel"">
                            <div class=""myaccount-content"">
                                <h3>Downloads</h3>

                                <div class=""myaccount-table table-responsive text-center"">
                                    <table class=""table table-bordered"">
                                        <thead class=""bg-success text-white"">
                                            <tr>
                                                <th>Product</th>
                                                <th>Date</th>
                                                <th>Expire</th>
                                                <th>Download</th>
                     ");
            WriteLiteral(@"                       </tr>
                                        </thead>

                                        <tbody>
                                            <tr>
                                                <td>Mostarizing Oil</td>
                                                <td>Aug 22, 2018</td>
                                                <td>Yes</td>
                                                <td><a href=""#"" class=""ht-btn black-btn"">Download File</a></td>
                                            </tr>
                                            <tr>
                                                <td>Katopeno Altuni</td>
                                                <td>Sep 12, 2018</td>
                                                <td>Never</td>
                                                <td><a href=""#"" class=""ht-btn black-btn"">Download File</a></td>
                                            </tr>
                                        </tbody>");
            WriteLiteral(@"
                                    </table>
                                </div>
                            </div>
                        </div>
                        <!-- Single Tab Content End -->
                        <!-- Single Tab Content Start -->
                        <div class=""tab-pane fade"" id=""payment-method"" role=""tabpanel"">
                            <div class=""myaccount-content"">
                                <h3>Payment Method</h3>

                                <p class=""saved-message"">You Can't Saved Your Payment Method yet.</p>
                            </div>
                        </div>
                        <!-- Single Tab Content End -->
                        <!-- Single Tab Content Start -->
                        <div class=""tab-pane fade"" id=""address-edit"" role=""tabpanel"">
                            <div class=""myaccount-content"">
                                <h3>Billing Address</h3>

                                <address>
      ");
            WriteLiteral(@"                              <p><strong>Alex Tuntuni</strong></p>
                                    <p>
                                        1355 Market St, Suite 900 <br>
                                        San Francisco, CA 94103
                                    </p>
                                    <p>Mobile: (123) 456-7890</p>
                                </address>

                                <a href=""#"" class=""btn third-btn btn-theme2 "">
                                    <i class=""fa fa-edit""></i>Edit
                                    Address
                                </a>
                            </div>
                        </div>
                        <!-- Single Tab Content End -->
                        <!-- Single Tab Content Start -->
                        <div class=""tab-pane fade active show"" id=""account-info"" role=""tabpanel"">
                            <div class=""myaccount-content"">
                                <h3>Account Deta");
            WriteLiteral("ils</h3>\r\n\r\n                                <div class=\"account-details-form\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08db5b9c8098dc04f87e96635c8c9fbfa32de72916154", async() => {
                WriteLiteral(@"
                                        <div class=""row"">
                                            <div class=""col-lg-6 col-12 mb-30"">
                                                <input id=""first-name"" placeholder=""First Name"" type=""text"">
                                            </div>

                                            <div class=""col-lg-6 col-12 mb-30"">
                                                <input id=""last-name"" placeholder=""Last Name"" type=""text"">
                                            </div>

                                            <div class=""col-12 mb-30"">
                                                <input id=""display-name"" placeholder=""Display Name"" type=""text"">
                                            </div>

                                            <div class=""col-12 mb-30"">
                                                <input id=""email"" placeholder=""Email Address"" type=""email"">
                                            </div>

");
                WriteLiteral(@"                                            <div class=""col-12 mb-30"">
                                                <h4>Password change</h4>
                                            </div>

                                            <div class=""col-12 mb-30"">
                                                <input id=""current-pwd"" placeholder=""Current Password"" type=""password"">
                                            </div>

                                            <div class=""col-lg-6 col-12 mb-30"">
                                                <input id=""new-pwd"" placeholder=""New Password"" type=""password"">
                                            </div>

                                            <div class=""col-lg-6 col-12 mb-30"">
                                                <input id=""confirm-pwd"" placeholder=""Confirm Password"" type=""password"">
                                            </div>

                                            <div class=""col-12"">
       ");
                WriteLiteral(@"                                         <button class=""btn third-btn btn-theme2"">
                                                    Save
                                                    Changes
                                                </button>
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
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                        <!-- Single Tab Content End -->
                    </div>
                </div>
                <!-- My Account Tab Content End -->
            </div>
        </div>
    </div>
    <!-- account section end -->
    <!-- common banner news-letter end -->
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "08db5b9c8098dc04f87e96635c8c9fbfa32de72920449", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
