#pragma checksum "C:\Users\Melusi Mgwenya\source\repos\BuhleProject\recatcha test\BuhleProject\Views\Admin\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dd4ab77534f5895145a90952f934b2de7880792"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Delete), @"mvc.1.0.view", @"/Views/Admin/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Delete.cshtml", typeof(AspNetCore.Views_Admin_Delete))]
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
#line 1 "C:\Users\Melusi Mgwenya\source\repos\BuhleProject\recatcha test\BuhleProject\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Melusi Mgwenya\source\repos\BuhleProject\recatcha test\BuhleProject\Views\_ViewImports.cshtml"
using BuhleProject.Models.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\Melusi Mgwenya\source\repos\BuhleProject\recatcha test\BuhleProject\Views\_ViewImports.cshtml"
using BuhleProject.Models.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dd4ab77534f5895145a90952f934b2de7880792", @"/Views/Admin/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95ee3756e4d05d7f396e1e3bd0e59650b890ca02", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BuhleProject.Models.Entities.LoanApplication>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "View", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Melusi Mgwenya\source\repos\BuhleProject\recatcha test\BuhleProject\Views\Admin\Delete.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
            BeginContext(95, 183, true);
            WriteLiteral("\r\n<h1>View</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>LoanApplication</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(279, 51, false);
#line 15 "C:\Users\Melusi Mgwenya\source\repos\BuhleProject\recatcha test\BuhleProject\Views\Admin\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.applicationDate));

#line default
#line hidden
            EndContext();
            BeginContext(330, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(394, 47, false);
#line 18 "C:\Users\Melusi Mgwenya\source\repos\BuhleProject\recatcha test\BuhleProject\Views\Admin\Delete.cshtml"
       Write(Html.DisplayFor(model => model.applicationDate));

#line default
#line hidden
            EndContext();
            BeginContext(441, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(504, 45, false);
#line 21 "C:\Users\Melusi Mgwenya\source\repos\BuhleProject\recatcha test\BuhleProject\Views\Admin\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.applicant));

#line default
#line hidden
            EndContext();
            BeginContext(549, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(613, 41, false);
#line 24 "C:\Users\Melusi Mgwenya\source\repos\BuhleProject\recatcha test\BuhleProject\Views\Admin\Delete.cshtml"
       Write(Html.DisplayFor(model => model.applicant));

#line default
#line hidden
            EndContext();
            BeginContext(654, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(717, 42, false);
#line 27 "C:\Users\Melusi Mgwenya\source\repos\BuhleProject\recatcha test\BuhleProject\Views\Admin\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.amount));

#line default
#line hidden
            EndContext();
            BeginContext(759, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(823, 38, false);
#line 30 "C:\Users\Melusi Mgwenya\source\repos\BuhleProject\recatcha test\BuhleProject\Views\Admin\Delete.cshtml"
       Write(Html.DisplayFor(model => model.amount));

#line default
#line hidden
            EndContext();
            BeginContext(861, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(924, 44, false);
#line 33 "C:\Users\Melusi Mgwenya\source\repos\BuhleProject\recatcha test\BuhleProject\Views\Admin\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.approved));

#line default
#line hidden
            EndContext();
            BeginContext(968, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1032, 40, false);
#line 36 "C:\Users\Melusi Mgwenya\source\repos\BuhleProject\recatcha test\BuhleProject\Views\Admin\Delete.cshtml"
       Write(Html.DisplayFor(model => model.approved));

#line default
#line hidden
            EndContext();
            BeginContext(1072, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1135, 44, false);
#line 39 "C:\Users\Melusi Mgwenya\source\repos\BuhleProject\recatcha test\BuhleProject\Views\Admin\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.rejected));

#line default
#line hidden
            EndContext();
            BeginContext(1179, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1243, 40, false);
#line 42 "C:\Users\Melusi Mgwenya\source\repos\BuhleProject\recatcha test\BuhleProject\Views\Admin\Delete.cshtml"
       Write(Html.DisplayFor(model => model.rejected));

#line default
#line hidden
            EndContext();
            BeginContext(1283, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1346, 42, false);
#line 45 "C:\Users\Melusi Mgwenya\source\repos\BuhleProject\recatcha test\BuhleProject\Views\Admin\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.reason));

#line default
#line hidden
            EndContext();
            BeginContext(1388, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1452, 38, false);
#line 48 "C:\Users\Melusi Mgwenya\source\repos\BuhleProject\recatcha test\BuhleProject\Views\Admin\Delete.cshtml"
       Write(Html.DisplayFor(model => model.reason));

#line default
#line hidden
            EndContext();
            BeginContext(1490, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1528, 156, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5dd4ab77534f5895145a90952f934b2de788079210204", async() => {
                BeginContext(1552, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1562, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5dd4ab77534f5895145a90952f934b2de788079210597", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 53 "C:\Users\Melusi Mgwenya\source\repos\BuhleProject\recatcha test\BuhleProject\Views\Admin\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1598, 79, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1684, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BuhleProject.Models.Entities.LoanApplication> Html { get; private set; }
    }
}
#pragma warning restore 1591
