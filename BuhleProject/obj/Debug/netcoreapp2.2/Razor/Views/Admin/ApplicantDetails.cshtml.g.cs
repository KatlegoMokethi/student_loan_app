#pragma checksum "C:\Users\Melusi Mgwenya\Downloads\StudentLoanProject\BuhleProject\Views\Admin\ApplicantDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98d4f101acb190b3f2e416c428eb6a5ec7dbc840"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ApplicantDetails), @"mvc.1.0.view", @"/Views/Admin/ApplicantDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/ApplicantDetails.cshtml", typeof(AspNetCore.Views_Admin_ApplicantDetails))]
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
#line 1 "C:\Users\Melusi Mgwenya\Downloads\StudentLoanProject\BuhleProject\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Melusi Mgwenya\Downloads\StudentLoanProject\BuhleProject\Views\_ViewImports.cshtml"
using BuhleProject.Models.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\Melusi Mgwenya\Downloads\StudentLoanProject\BuhleProject\Views\_ViewImports.cshtml"
using BuhleProject.Models.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98d4f101acb190b3f2e416c428eb6a5ec7dbc840", @"/Views/Admin/ApplicantDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"389075d264d9893d3b267880bc6f003b3984c695", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ApplicantDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Document>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewDocument", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Melusi Mgwenya\Downloads\StudentLoanProject\BuhleProject\Views\Admin\ApplicantDetails.cshtml"
  
    ViewData["Title"] = "Applicant Details";

#line default
#line hidden
            BeginContext(85, 177, true);
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <h1>Applicant Details</h1>\r\n\r\n    <table class=\"table\">\r\n        <thead class=\"bg-primary text-light\">\r\n            <tr>\r\n                <th>\r\n");
            EndContext();
            BeginContext(337, 80, true);
            WriteLiteral("                    Date Uploaded\r\n                </th>\r\n                <th>\r\n");
            EndContext();
            BeginContext(487, 139, true);
            WriteLiteral("                    Document Type\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 26 "C:\Users\Melusi Mgwenya\Downloads\StudentLoanProject\BuhleProject\Views\Admin\ApplicantDetails.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(683, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(756, 47, false);
#line 30 "C:\Users\Melusi Mgwenya\Downloads\StudentLoanProject\BuhleProject\Views\Admin\ApplicantDetails.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DateUploaded));

#line default
#line hidden
            EndContext();
            BeginContext(803, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(883, 42, false);
#line 33 "C:\Users\Melusi Mgwenya\Downloads\StudentLoanProject\BuhleProject\Views\Admin\ApplicantDetails.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DocType));

#line default
#line hidden
            EndContext();
            BeginContext(925, 55, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
            EndContext();
            BeginContext(1067, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1091, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98d4f101acb190b3f2e416c428eb6a5ec7dbc8406171", async() => {
                BeginContext(1144, 12, true);
                WriteLiteral("View documnt");
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
#line 37 "C:\Users\Melusi Mgwenya\Downloads\StudentLoanProject\BuhleProject\Views\Admin\ApplicantDetails.cshtml"
                                                       WriteLiteral(item.id);

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
            BeginContext(1160, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 40 "C:\Users\Melusi Mgwenya\Downloads\StudentLoanProject\BuhleProject\Views\Admin\ApplicantDetails.cshtml"
            }

#line default
#line hidden
            BeginContext(1227, 40, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Document>> Html { get; private set; }
    }
}
#pragma warning restore 1591
