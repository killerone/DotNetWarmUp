#pragma checksum "C:\Users\HIMANSHU\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27c7aabe990f53515d13729c1ab767b439709a41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\HIMANSHU\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HIMANSHU\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27c7aabe990f53515d13729c1ab767b439709a41", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\HIMANSHU\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Users";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row mt-5 px-3\">\r\n    <div class=\"col-5 mt-5\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27c7aabe990f53515d13729c1ab767b439709a413869", async() => {
                WriteLiteral(@"
            <div class=""form-group"">
                <label for=""name"">Name</label>
                <input type=""text"" class=""form-control"" id=""name"">
            </div>
            <div class=""row"">
                <div class=""col-5"">Date of birth</div>
                <div class=""col"">
                    <div class=""form-group"">
                        <label for=""email"">Email address</label>
                        <input type=""email"" class=""form-control"" id=""email"">
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-5"">
                    <div class=""form-group"">
                        <label for=""phoneNumber"">Phone Number</label>
                        <input type=""text"" class=""form-control"" id=""phoneNumber"">
                    </div>
                </div>
                <div class=""col"">
                    <div class=""form-group"">
                        <label for=""city"">City</label>
       ");
                WriteLiteral(@"                 <input type=""text"" class=""form-control"" id=""city"">
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col"">
                    <button class=""btn btn-primary submit"">ADD</button>
                </div>
                <div class=""col"">
                    <button class=""btn btn-warning submit"">CLEAR</button>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <div class=""col"">
        <button class=""btn btn-info"">Refresh</button>
        <table class=""table mt-2"">
            <thead class=""thead-dark"">
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">Name</th>
                    <th scope=""col"">Email</th>
                    <th scope=""col"">Phone</th>
                    <th scope=""col"">City</th>
                    <th scope=""col"">DoB</th>
                    <th scope=""col""></th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <th scope=""row"">1</th>
                    <td scope=""col"">Himanshu Pednekar</td>
                    <td scope=""col"">himanshupednekar036@email.com</td>
                    <td scope=""col"">1234567890</td>
                    <td scope=""col"">Mumbai</td>
                    <td scope=""col"">5th Jan 2020</td>
                    <td scope=""col"">
                        <div class=""dropdown"">
    ");
            WriteLiteral(@"                        <button type=""button"" class=""btn btn-sm dropdown-toggle dropdown-toggle-split"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <span class=""sr-only"">Toggle Dropdown</span>
                            </button>
                            <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""dropdownMenuButton"">
                                <a class=""dropdown-item"" href=""#"">Update</a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""#"">Delete</a>
                            </div>
                            </div>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</div>
");
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
