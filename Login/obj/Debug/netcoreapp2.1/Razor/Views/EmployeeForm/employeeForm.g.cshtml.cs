<<<<<<< HEAD
#pragma checksum "C:\Project\ATSDev\Login\Views\EmployeeForm\employeeForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19bd7a7ffb6e7cb0b05b725f5440c9e96259da0c"
=======
#pragma checksum "D:\G-ABLE\Project\ATSDev\Login\Views\EmployeeForm\employeeForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19bd7a7ffb6e7cb0b05b725f5440c9e96259da0c"
>>>>>>> a94ab672c38a18ee755029b2e1caed40d53f4623
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmployeeForm_employeeForm), @"mvc.1.0.view", @"/Views/EmployeeForm/employeeForm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EmployeeForm/employeeForm.cshtml", typeof(AspNetCore.Views_EmployeeForm_employeeForm))]
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
<<<<<<< HEAD
#line 1 "C:\Project\ATSDev\Login\Views\_ViewImports.cshtml"
=======
#line 1 "D:\G-ABLE\Project\ATSDev\Login\Views\_ViewImports.cshtml"
>>>>>>> a94ab672c38a18ee755029b2e1caed40d53f4623
using Login;

#line default
#line hidden
<<<<<<< HEAD
#line 2 "C:\Project\ATSDev\Login\Views\_ViewImports.cshtml"
=======
#line 2 "D:\G-ABLE\Project\ATSDev\Login\Views\_ViewImports.cshtml"
>>>>>>> a94ab672c38a18ee755029b2e1caed40d53f4623
using Login.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19bd7a7ffb6e7cb0b05b725f5440c9e96259da0c", @"/Views/EmployeeForm/employeeForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9276afe45df5b2f25be23953aa1de474937a8781", @"/Views/_ViewImports.cshtml")]
    public class Views_EmployeeForm_employeeForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/employeeFormController.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 268, true);
            WriteLiteral(@"
<div ng-controller=""EmployeeFormController"">
    <div class=""container"">
        <h3>รายละเอียดเพิ่มเติม</h3>
    <div class=""form-group"">
        <label >Location</label>
       <select class=""form-control"" ng-model=""employeeform.location"" id="""">
            ");
            EndContext();
            BeginContext(268, 18, false);
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30cd70e70a7646a4a3854f298e51acf2", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1437971719a484baa2a0ac924cfeb77", async() => {
>>>>>>> a94ab672c38a18ee755029b2e1caed40d53f4623
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(286, 376, true);
            WriteLiteral(@"
       </select>
    </div>
    <div class=""form-group"">
        <label for="""">Salary</label>
        <input type=""text"" class=""form-control"" ng-model=""employeeform.salary"" placeholder=""Salary"">
    </div>  
    <div class=""form-group"">
        <label for="""">Position</label>
        <select class=""form-control"" ng-model=""employeeform.position"" id="""">
            ");
            EndContext();
            BeginContext(662, 18, false);
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "135e41248035497496b3fd5a5b5c2a61", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9b429ca6eb14aa2a7790e1224cabc01", async() => {
>>>>>>> a94ab672c38a18ee755029b2e1caed40d53f4623
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(680, 145, true);
            WriteLiteral("\r\n       </select>\r\n    </div>  \r\n    <button  class=\"btn btn-default\" ng-click=\"submit(employeeform)\">ส่งข้อมูล</button>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(843, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(849, 54, false);
<<<<<<< HEAD
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cb19d14e53240549a061108c9d06ca8", async() => {
=======
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bd88f7fb3b14f46a6abbf8e16317c38", async() => {
>>>>>>> a94ab672c38a18ee755029b2e1caed40d53f4623
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(903, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
