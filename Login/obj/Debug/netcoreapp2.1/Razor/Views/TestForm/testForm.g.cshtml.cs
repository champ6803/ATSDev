<<<<<<< HEAD
#pragma checksum "C:\Project\ATSDev\Login\Views\TestForm\testForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4603eb3fc27f8d16aed3e8b329b82e7c06dcf8c0"
=======
#pragma checksum "D:\G-ABLE\Project\ATSDev\Login\Views\TestForm\testForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4603eb3fc27f8d16aed3e8b329b82e7c06dcf8c0"
>>>>>>> 7268863780e11879e9af03fc990c8fe70e960ce6
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TestForm_testForm), @"mvc.1.0.view", @"/Views/TestForm/testForm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TestForm/testForm.cshtml", typeof(AspNetCore.Views_TestForm_testForm))]
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
>>>>>>> 7268863780e11879e9af03fc990c8fe70e960ce6
using Login;

#line default
#line hidden
<<<<<<< HEAD
#line 2 "C:\Project\ATSDev\Login\Views\_ViewImports.cshtml"
=======
#line 2 "D:\G-ABLE\Project\ATSDev\Login\Views\_ViewImports.cshtml"
>>>>>>> 7268863780e11879e9af03fc990c8fe70e960ce6
using Login.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4603eb3fc27f8d16aed3e8b329b82e7c06dcf8c0", @"/Views/TestForm/testForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9276afe45df5b2f25be23953aa1de474937a8781", @"/Views/_ViewImports.cshtml")]
    public class Views_TestForm_testForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 406, true);
            WriteLiteral(@"
<div ng-Controller = ""TestController"">
    <div class=""container"">
        <h3>ทดสอบ</h3>
        <div class=""form-group"">
        <label >กรอกชื่อ-สกุล</label>
        <input type=""text"" class=""form-control"" ng-model=""testForm.email"" id="""" placeholder=""ชื่อ-สกุล"">
        <button  class=""btn btn-primary btn-blockt"" ng-click=""sendData(testForm)"">ส่งข้อมูล</button>
    </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
