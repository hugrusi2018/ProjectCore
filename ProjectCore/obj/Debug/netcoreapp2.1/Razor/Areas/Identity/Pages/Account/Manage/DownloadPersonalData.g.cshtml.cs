#pragma checksum "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Areas\Identity\Pages\Account\Manage\DownloadPersonalData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9085d6915e847da4b83e414df666ec1c6cca62fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProjectCore.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage_DownloadPersonalData), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Manage/DownloadPersonalData.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/Manage/DownloadPersonalData.cshtml", typeof(ProjectCore.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage_DownloadPersonalData), null)]
namespace ProjectCore.Areas.Identity.Pages.Account.Manage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 3 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Areas\Identity\Pages\_ViewImports.cshtml"
using ProjectCore.Areas.Identity;

#line default
#line hidden
#line 1 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using ProjectCore.Areas.Identity.Pages.Account;

#line default
#line hidden
#line 1 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using ProjectCore.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9085d6915e847da4b83e414df666ec1c6cca62fe", @"/Areas/Identity/Pages/Account/Manage/DownloadPersonalData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09d5d7f43ed48f23462262d38cd40b4d804cd994", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8faceaf1039c8523f61b9a107b7d8dc9c2791592", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df1224aef537301f9ff5401e5813a67ea8f470d5", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage_DownloadPersonalData : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Areas\Identity\Pages\Account\Manage\DownloadPersonalData.cshtml"
  
    ViewData["Title"] = "Download Your Data";
    ViewData["ActivePage"] = ManageNavPages.DownloadPersonalData;
    Layout = "/Views/Shared/_LayoutManage.cshtml";

#line default
#line hidden
            BeginContext(214, 6, true);
            WriteLiteral("\r\n<h4>");
            EndContext();
            BeginContext(221, 17, false);
#line 9 "C:\Users\ladasoft\Documents\GitHub\ProjectCore\ProjectCore\ProjectCore\Areas\Identity\Pages\Account\Manage\DownloadPersonalData.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(238, 9, true);
            WriteLiteral("</h4>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(265, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(271, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "936fe021f706409ab1f83eb8e0c4a6d7", async() => {
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
                EndContext();
                BeginContext(315, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DownloadPersonalDataModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DownloadPersonalDataModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DownloadPersonalDataModel>)PageContext?.ViewData;
        public DownloadPersonalDataModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
