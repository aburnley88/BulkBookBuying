#pragma checksum "C:\Users\wwstudent\Desktop\BulkBookBuying\BulkBookBuying\BulkBookBuying\Areas\Customer\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b76b98c7d5b05c4b79903c399f010f3317d3fe81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Cart_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/Cart/Index.cshtml")]
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
#line 1 "C:\Users\wwstudent\Desktop\BulkBookBuying\BulkBookBuying\BulkBookBuying\Areas\Customer\Views\_ViewImports.cshtml"
using BulkBookBuying;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wwstudent\Desktop\BulkBookBuying\BulkBookBuying\BulkBookBuying\Areas\Customer\Views\_ViewImports.cshtml"
using BulkBookBuying.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b76b98c7d5b05c4b79903c399f010f3317d3fe81", @"/Areas/Customer/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"990a70a8db43f6b5fc3417e4a857dd6166fa9d59", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BulkBookBuying.Models.ViewModels.ShoppingCartViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b76b98c7d5b05c4b79903c399f010f3317d3fe813700", async() => {
                WriteLiteral("\r\n    <br />\r\n");
#nullable restore
#line 4 "C:\Users\wwstudent\Desktop\BulkBookBuying\BulkBookBuying\BulkBookBuying\Areas\Customer\Views\Cart\Index.cshtml"
     if(Model.ListCart.Count()> 0)
    { 

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <div class=""backgroundWhiteBorder"">
        <div class=""container"">
            <div class=""card"">
                <div class=""card-header bg-dark text-light ml-0 row container"">
                    <div class=""col-6"">
                        <i class=""fa fa-shopping-cart""></i> &nbsp;
                        Shopping Cart
                    </div>
                    <div class=""col-6 text-right"">
                        <a class=""btn btn-outline-info btn-sm"">Continue Shopping</a>
                    </div>
                </div>
               

                <div class=""card-body"">
");
#nullable restore
#line 21 "C:\Users\wwstudent\Desktop\BulkBookBuying\BulkBookBuying\BulkBookBuying\Areas\Customer\Views\Cart\Index.cshtml"
                     foreach (var item in Model.ListCart)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <div class=""row"">
                            <div class=""d-none d-lg-block col-lg-1 text-center py-2"">
                                <img src=""https://via.placeholder.com/150"" class=""rounded"" width=""100%"" />
                            </div>
                            <div class=""col-12 text-sm-center col-lg-6 text-lg-left"">
                                <h5><strong>--TITLE--</strong></h5>
                                <p><small>--DESCRIPTION--</small></p>
                            </div>
                            <div class=""col-12 text-sm-center col-lg-5 text-lg-right row"">
                                <div class=""col-4 text-md-right"" style=""padding-top:5px;"">
                                    <h6><strong>--Price --<span class=""text-muted"">x</span> --Count-- </strong></h6>
                                </div>
                                <div class=""col-6 col-sm-4 col-lg-6"">
                                    <div class=""float-right mx-1"">
      ");
                WriteLiteral(@"                                  <button type=""submit"" class=""btn btn-primary"">
                                            <i class=""fas fa-plus""></i>
                                        </button>
                                    </div>
                                    <div class=""float-right mx-1"">
                                        <button type=""submit"" class=""btn btn-danger"">
                                            <i class=""fas fa-minus""></i>
                                        </button>
                                    </div>
                                </div>
                                <div class=""col-2 col-sm-4 col-lg-2 text-right"">
                                    <button type=""submit"" class=""btn btn-outline-danger"">
                                        <i class=""fas fa-trash""></i>
                                    </button>
                                </div>
                            </div>
                        </div>
            ");
                WriteLiteral("            <hr />\r\n");
#nullable restore
#line 55 "C:\Users\wwstudent\Desktop\BulkBookBuying\BulkBookBuying\BulkBookBuying\Areas\Customer\Views\Cart\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <div class=""row"">
                        <div class=""col-12 col-md-6 offset-md-6 col-lg-4 offset-lg-8 pr-4"">
                            <ul class=""list-group"">
                                <li class=""list-group-item d-flex justify-content-between bg-light"">
                                    <span class=""text-info""> Total (USD)</span>
                                    <strong class=""text-info"">$ <span id=""txtOrderTotal"">--TOTAL--</span></strong>
                                </li>
                            </ul>
                        </div>
                    </div>

                </div>
              
                <div class=""card-footer"">
                    <div class=""card-footer row"">

                        <div class=""col-sm-12 col-lg-4 col-md-6 offset-lg-8 offset-md-6 "">

                            <a class=""btn btn-success form-control"">Summary</a>
                        </div>
                    </div>
                </div>
       ");
                WriteLiteral("     </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 82 "C:\Users\wwstudent\Desktop\BulkBookBuying\BulkBookBuying\BulkBookBuying\Areas\Customer\Views\Cart\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div>There are no items in cart.</div>\r\n");
#nullable restore
#line 86 "C:\Users\wwstudent\Desktop\BulkBookBuying\BulkBookBuying\BulkBookBuying\Areas\Customer\Views\Cart\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BulkBookBuying.Models.ViewModels.ShoppingCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
