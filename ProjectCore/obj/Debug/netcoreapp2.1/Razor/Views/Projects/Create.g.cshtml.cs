#pragma checksum "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Projects\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99c4fb9e572e47887ff47bd19cc34284e7066b1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Create), @"mvc.1.0.view", @"/Views/Projects/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Projects/Create.cshtml", typeof(AspNetCore.Views_Projects_Create))]
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
#line 1 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\_ViewImports.cshtml"
using ProjectCore;

#line default
#line hidden
#line 2 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\_ViewImports.cshtml"
using ProjectCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99c4fb9e572e47887ff47bd19cc34284e7066b1e", @"/Views/Projects/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e98a3973da45496466a4ed5bb498f29b8a1f80c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectCore.Logica.Models.BindingModel.ProjectsCreateBindingModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Projects/Create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(74, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Projects\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
            BeginContext(118, 21, true);
            WriteLiteral("\r\n<h2>Create</h2>\r\n\r\n");
            EndContext();
            BeginContext(139, 1762, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f05dd5dbf5bd4a95ae403c60162b2df1", async() => {
                BeginContext(185, 77, true);
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-12\">\r\n            ");
                EndContext();
                BeginContext(263, 27, false);
#line 12 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Projects\Create.cshtml"
       Write(Html.LabelFor(x => x.Title));

#line default
#line hidden
                EndContext();
                BeginContext(290, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(305, 86, false);
#line 13 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Projects\Create.cshtml"
       Write(Html.EditorFor(x => x.Title, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(391, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(406, 75, false);
#line 14 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Projects\Create.cshtml"
       Write(Html.ValidationMessageFor(x => x.Title, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(481, 107, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-12\">\r\n            ");
                EndContext();
                BeginContext(589, 29, false);
#line 20 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Projects\Create.cshtml"
       Write(Html.LabelFor(x => x.Details));

#line default
#line hidden
                EndContext();
                BeginContext(618, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(633, 88, false);
#line 21 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Projects\Create.cshtml"
       Write(Html.EditorFor(x => x.Details, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(721, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(736, 77, false);
#line 22 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Projects\Create.cshtml"
       Write(Html.ValidationMessageFor(x => x.Details, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(813, 107, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-12\">\r\n            ");
                EndContext();
                BeginContext(921, 44, false);
#line 28 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Projects\Create.cshtml"
       Write(Html.LabelFor(x => x.ExpectedCompletionDate));

#line default
#line hidden
                EndContext();
                BeginContext(965, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(980, 103, false);
#line 29 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Projects\Create.cshtml"
       Write(Html.EditorFor(x => x.ExpectedCompletionDate, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(1083, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1098, 92, false);
#line 30 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Projects\Create.cshtml"
       Write(Html.ValidationMessageFor(x => x.ExpectedCompletionDate, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(1190, 225, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-12\">\r\n            <button type=\"submit\" class=\"btn btn-primary\">\r\n                <i class=\"fas fa-save\"></i>\r\n            </button>\r\n\r\n");
                EndContext();
                BeginContext(1607, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1622, 240, false);
#line 47 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Projects\Create.cshtml"
       Write(Html.ActionLink(" ", //name
                 "Index", //action
                 "Projects", //controller
                 null,
                 new { @class = "btn btn-primary fas fa-arrow-circle-left" }//atributtes
                 ));

#line default
#line hidden
                EndContext();
                BeginContext(1862, 32, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1901, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectCore.Logica.Models.BindingModel.ProjectsCreateBindingModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
