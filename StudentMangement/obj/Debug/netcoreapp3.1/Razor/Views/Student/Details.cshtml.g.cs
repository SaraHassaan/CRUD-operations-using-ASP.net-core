#pragma checksum "D:\Sara\Practice\C#\Asp.NetCoreProjs\StudentMangement\StudentMangement\Views\Student\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1777b0cd73b66bfaf96194bff2bc727e491fd63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Details), @"mvc.1.0.view", @"/Views/Student/Details.cshtml")]
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
#line 1 "D:\Sara\Practice\C#\Asp.NetCoreProjs\StudentMangement\StudentMangement\Views\_ViewImports.cshtml"
using StudentMangement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Sara\Practice\C#\Asp.NetCoreProjs\StudentMangement\StudentMangement\Views\_ViewImports.cshtml"
using StudentMangement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1777b0cd73b66bfaf96194bff2bc727e491fd63", @"/Views/Student/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"871f4e6eb3eac5cbaf02a10067bf247cb5ddf7fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Student>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1777b0cd73b66bfaf96194bff2bc727e491fd633593", async() => {
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <label class=\"form-label\">Id</label>\r\n        <input type=\"number\"");
                BeginWriteAttribute("value", " value=\"", 143, "\"", 160, 1);
#nullable restore
#line 6 "D:\Sara\Practice\C#\Asp.NetCoreProjs\StudentMangement\StudentMangement\Views\Student\Details.cshtml"
WriteAttributeValue("", 151, Model.Id, 151, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly class=\"form-control\">\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label class=\"form-label\">Name</label>\r\n        <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 310, "\"", 329, 1);
#nullable restore
#line 10 "D:\Sara\Practice\C#\Asp.NetCoreProjs\StudentMangement\StudentMangement\Views\Student\Details.cshtml"
WriteAttributeValue("", 318, Model.Name, 318, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly class=\"form-control\">\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label class=\"form-label\">Grade</label>\r\n        <input type=\"number\"");
                BeginWriteAttribute("value", " value=\"", 482, "\"", 502, 1);
#nullable restore
#line 14 "D:\Sara\Practice\C#\Asp.NetCoreProjs\StudentMangement\StudentMangement\Views\Student\Details.cshtml"
WriteAttributeValue("", 490, Model.Grade, 490, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly class=\"form-control\">\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label class=\"form-label\">Date Of Birth</label>\r\n        <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 661, "\"", 716, 2);
#nullable restore
#line 18 "D:\Sara\Practice\C#\Asp.NetCoreProjs\StudentMangement\StudentMangement\Views\Student\Details.cshtml"
WriteAttributeValue("", 669, Model.BirthDate.ToShortDateString(), 669, 36, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 705, "mm/dd/yyyy", 706, 11, true);
                EndWriteAttribute();
                WriteLiteral(" readonly  class=\"form-control\">\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
