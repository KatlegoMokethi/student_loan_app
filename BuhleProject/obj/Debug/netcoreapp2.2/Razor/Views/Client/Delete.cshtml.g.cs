#pragma checksum "C:\Users\Melusi Mgwenya\Downloads\StudentLoanProject\BuhleProject\Views\Client\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38de6b9567eef7853a738cc238569d4bc7a2298c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_Delete), @"mvc.1.0.view", @"/Views/Client/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Client/Delete.cshtml", typeof(AspNetCore.Views_Client_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38de6b9567eef7853a738cc238569d4bc7a2298c", @"/Views/Client/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"389075d264d9893d3b267880bc6f003b3984c695", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Document>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(17, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Melusi Mgwenya\Downloads\StudentLoanProject\BuhleProject\Views\Client\Delete.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
            BeginContext(59, 268, true);
            WriteLiteral(@"
<div style=""height: 100vh;"">
    <div class=""container"">
        <h1>Document deletion</h1>

        <h3>Are you sure you want to delete this document?</h3>
        <div>
            <hr />
            <dl class=""row"">
                <dt class=""col-sm-2"">
");
            EndContext();
            BeginContext(400, 115, true);
            WriteLiteral("                    UploaderID\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(516, 42, false);
#line 20 "C:\Users\Melusi Mgwenya\Downloads\StudentLoanProject\BuhleProject\Views\Client\Delete.cshtml"
               Write(Html.DisplayFor(model => model.UploaderId));

#line default
#line hidden
            EndContext();
            BeginContext(558, 64, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n");
            EndContext();
            BeginContext(693, 114, true);
            WriteLiteral("                    File name\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(808, 40, false);
#line 27 "C:\Users\Melusi Mgwenya\Downloads\StudentLoanProject\BuhleProject\Views\Client\Delete.cshtml"
               Write(Html.DisplayFor(model => model.filename));

#line default
#line hidden
            EndContext();
            BeginContext(848, 64, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n");
            EndContext();
            BeginContext(987, 118, true);
            WriteLiteral("                    Date uploaded\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(1106, 44, false);
#line 34 "C:\Users\Melusi Mgwenya\Downloads\StudentLoanProject\BuhleProject\Views\Client\Delete.cshtml"
               Write(Html.DisplayFor(model => model.DateUploaded));

#line default
#line hidden
            EndContext();
            BeginContext(1150, 64, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n");
            EndContext();
            BeginContext(1284, 118, true);
            WriteLiteral("                    Document type\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(1403, 39, false);
#line 41 "C:\Users\Melusi Mgwenya\Downloads\StudentLoanProject\BuhleProject\Views\Client\Delete.cshtml"
               Write(Html.DisplayFor(model => model.DocType));

#line default
#line hidden
            EndContext();
            BeginContext(1442, 64, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n");
            EndContext();
            BeginContext(1578, 114, true);
            WriteLiteral("                    Extention\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(1693, 41, false);
#line 48 "C:\Users\Melusi Mgwenya\Downloads\StudentLoanProject\BuhleProject\Views\Client\Delete.cshtml"
               Write(Html.DisplayFor(model => model.extension));

#line default
#line hidden
            EndContext();
            BeginContext(1734, 64, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n");
            EndContext();
            BeginContext(1869, 113, true);
            WriteLiteral("                    Document\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(1983, 40, false);
#line 55 "C:\Users\Melusi Mgwenya\Downloads\StudentLoanProject\BuhleProject\Views\Client\Delete.cshtml"
               Write(Html.DisplayFor(model => model.document));

#line default
#line hidden
            EndContext();
            BeginContext(2023, 64, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n");
            EndContext();
            BeginContext(2154, 109, true);
            WriteLiteral("                    Path\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(2264, 36, false);
#line 62 "C:\Users\Melusi Mgwenya\Downloads\StudentLoanProject\BuhleProject\Views\Client\Delete.cshtml"
               Write(Html.DisplayFor(model => model.path));

#line default
#line hidden
            EndContext();
            BeginContext(2300, 58, true);
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n\r\n            ");
            EndContext();
            BeginContext(2358, 194, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38de6b9567eef7853a738cc238569d4bc7a2298c9825", async() => {
                BeginContext(2398, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(2416, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "38de6b9567eef7853a738cc238569d4bc7a2298c10225", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 67 "C:\Users\Melusi Mgwenya\Downloads\StudentLoanProject\BuhleProject\Views\Client\Delete.cshtml"
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
                BeginContext(2452, 93, true);
                WriteLiteral("\r\n                <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2552, 36, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Document> Html { get; private set; }
    }
}
#pragma warning restore 1591
