#pragma checksum "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Tasks\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dccf249f9a82ac3e19b72b47e3b6f8720e53e9cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tasks_Create), @"mvc.1.0.view", @"/Views/Tasks/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tasks/Create.cshtml", typeof(AspNetCore.Views_Tasks_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dccf249f9a82ac3e19b72b47e3b6f8720e53e9cb", @"/Views/Tasks/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e98a3973da45496466a4ed5bb498f29b8a1f80c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Tasks_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectCore.Logica.Models.BindingModel.TaskCreateBindingModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Tasks/Create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(70, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Tasks\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
            BeginContext(114, 21, true);
            WriteLiteral("\r\n<h2>Create</h2>\r\n\r\n");
            EndContext();
            BeginContext(135, 4042, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfb7fafb5bdb4dd391c1269b6efb0f2a", async() => {
                BeginContext(178, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(185, 32, false);
#line 10 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Tasks\Create.cshtml"
Write(Html.HiddenFor(x => x.ProjectId));

#line default
#line hidden
                EndContext();
                BeginContext(217, 77, true);
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-12\">\r\n            ");
                EndContext();
                BeginContext(295, 27, false);
#line 13 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Tasks\Create.cshtml"
       Write(Html.LabelFor(x => x.Title));

#line default
#line hidden
                EndContext();
                BeginContext(322, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(337, 86, false);
#line 14 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Tasks\Create.cshtml"
       Write(Html.EditorFor(x => x.Title, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(423, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(438, 75, false);
#line 15 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Tasks\Create.cshtml"
       Write(Html.ValidationMessageFor(x => x.Title, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(513, 107, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-12\">\r\n            ");
                EndContext();
                BeginContext(621, 29, false);
#line 21 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Tasks\Create.cshtml"
       Write(Html.LabelFor(x => x.Details));

#line default
#line hidden
                EndContext();
                BeginContext(650, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(665, 88, false);
#line 22 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Tasks\Create.cshtml"
       Write(Html.EditorFor(x => x.Details, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(753, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(768, 77, false);
#line 23 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Tasks\Create.cshtml"
       Write(Html.ValidationMessageFor(x => x.Details, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(845, 107, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-12\">\r\n            ");
                EndContext();
                BeginContext(953, 36, false);
#line 29 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Tasks\Create.cshtml"
       Write(Html.LabelFor(x => x.ExpirationDate));

#line default
#line hidden
                EndContext();
                BeginContext(989, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1004, 95, false);
#line 30 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Tasks\Create.cshtml"
       Write(Html.EditorFor(x => x.ExpirationDate, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(1099, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1114, 84, false);
#line 31 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Tasks\Create.cshtml"
       Write(Html.ValidationMessageFor(x => x.ExpirationDate, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(1198, 107, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-12\">\r\n            ");
                EndContext();
                BeginContext(1306, 33, false);
#line 37 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Tasks\Create.cshtml"
       Write(Html.LabelFor(x => x.IsCompleted));

#line default
#line hidden
                EndContext();
                BeginContext(1339, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1354, 90, false);
#line 38 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Tasks\Create.cshtml"
       Write(Html.EditorFor(x => x.IsCompleted, new { htmlAttributes = new { @class = "form-check" } }));

#line default
#line hidden
                EndContext();
                BeginContext(1444, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1459, 81, false);
#line 39 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Tasks\Create.cshtml"
       Write(Html.ValidationMessageFor(x => x.IsCompleted, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(1540, 107, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-12\">\r\n            ");
                EndContext();
                BeginContext(1648, 28, false);
#line 45 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Tasks\Create.cshtml"
       Write(Html.LabelFor(x => x.Effort));

#line default
#line hidden
                EndContext();
                BeginContext(1676, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1691, 87, false);
#line 46 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Tasks\Create.cshtml"
       Write(Html.EditorFor(x => x.Effort, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(1778, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1793, 76, false);
#line 47 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Tasks\Create.cshtml"
       Write(Html.ValidationMessageFor(x => x.Effort, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(1869, 107, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-12\">\r\n            ");
                EndContext();
                BeginContext(1977, 35, false);
#line 53 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Tasks\Create.cshtml"
       Write(Html.LabelFor(x => x.RemainingWork));

#line default
#line hidden
                EndContext();
                BeginContext(2012, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(2027, 94, false);
#line 54 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Tasks\Create.cshtml"
       Write(Html.EditorFor(x => x.RemainingWork, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(2121, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(2136, 83, false);
#line 55 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Tasks\Create.cshtml"
       Write(Html.ValidationMessageFor(x => x.RemainingWork, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(2219, 109, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-12\">\r\n            ");
                EndContext();
                BeginContext(2329, 29, false);
#line 62 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Tasks\Create.cshtml"
       Write(Html.LabelFor(x => x.StateId));

#line default
#line hidden
                EndContext();
                BeginContext(2358, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(2373, 140, false);
#line 63 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Tasks\Create.cshtml"
       Write(Html.DropDownListFor(x => x.StateId, new SelectList(ViewBag.States, "Id", "Name"), new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(2513, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(2528, 77, false);
#line 64 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Tasks\Create.cshtml"
       Write(Html.ValidationMessageFor(x => x.StateId, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(2605, 107, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-12\">\r\n            ");
                EndContext();
                BeginContext(2713, 32, false);
#line 70 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Tasks\Create.cshtml"
       Write(Html.LabelFor(x => x.ActivityId));

#line default
#line hidden
                EndContext();
                BeginContext(2745, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(2760, 147, false);
#line 71 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Tasks\Create.cshtml"
       Write(Html.DropDownListFor(x => x.ActivityId, new SelectList(ViewBag.Activities, "Id", "Name"), new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(2907, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(2922, 80, false);
#line 72 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Tasks\Create.cshtml"
       Write(Html.ValidationMessageFor(x => x.ActivityId, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(3002, 107, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-12\">\r\n            ");
                EndContext();
                BeginContext(3110, 32, false);
#line 78 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Tasks\Create.cshtml"
       Write(Html.LabelFor(x => x.PriorityId));

#line default
#line hidden
                EndContext();
                BeginContext(3142, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(3157, 147, false);
#line 79 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Tasks\Create.cshtml"
       Write(Html.DropDownListFor(x => x.PriorityId, new SelectList(ViewBag.Priorities, "Id", "Name"), new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(3304, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(3319, 80, false);
#line 80 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Tasks\Create.cshtml"
       Write(Html.ValidationMessageFor(x => x.PriorityId, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(3399, 225, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-12\">\r\n            <button type=\"submit\" class=\"btn btn-primary\">\r\n                <i class=\"fas fa-save\"></i>\r\n            </button>\r\n\r\n");
                EndContext();
                BeginContext(3856, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(3871, 267, false);
#line 97 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Views\Tasks\Create.cshtml"
       Write(Html.ActionLink(" ", //name
                 "Index", //action
                 "Tasks", //controller
                 new { projectId = Model.ProjectId},
                 new { @class = "btn btn-primary fas fa-arrow-circle-left" }//atributtes
                 ));

#line default
#line hidden
                EndContext();
                BeginContext(4138, 32, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectCore.Logica.Models.BindingModel.TaskCreateBindingModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
