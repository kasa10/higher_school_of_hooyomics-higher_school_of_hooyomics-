#pragma checksum "C:\Users\agehao\higher_school_of_hooyomics-higher_school_of_hooyomics-\higher_school_of_hooyomics\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68605ddba6dcd9202e4055ef272017eced9dcaae"
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
#line 1 "C:\Users\agehao\higher_school_of_hooyomics-higher_school_of_hooyomics-\higher_school_of_hooyomics\Views\_ViewImports.cshtml"
using higher_school_of_hooyomics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\agehao\higher_school_of_hooyomics-higher_school_of_hooyomics-\higher_school_of_hooyomics\Views\_ViewImports.cshtml"
using higher_school_of_hooyomics.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68605ddba6dcd9202e4055ef272017eced9dcaae", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28646174ec0c6e0d7eb6726603905fede6bd0b08", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68605ddba6dcd9202e4055ef272017eced9dcaae3398", async() => {
                WriteLiteral(@"
    <script src='http://code.jquery.com/jquery-2.1.1.min.js'></script>

    <title>Издательство ""Профессиональная литература""</title>
    <link rel=""stylesheet"" type=""text/css"" href=""site.css"">
    <link href=""https://fonts.googleapis.com/css?family=Roboto:300"" rel=""stylesheet"">
    <script src=""https://kit.fontawesome.com/92990b2768.js"" crossorigin=""anonymous""></script>
    <script src=""main.js""></script>
    <script src=""jquery-mousewheel-3.1.12/jquery.mousewheel.js""></script>
    <script src=""http://code.jquery.com/jquery-1.11.1.min.js""></script>



");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68605ddba6dcd9202e4055ef272017eced9dcaae4956", async() => {
                WriteLiteral(@"
    <div class=""top"">

        <div class=""logo"">
            <img src=""logo.png"">
        </div>

        <div class=""reg"">
            <button href type=""button"" class=""btn"">Войти</button>
            <button type=""button"" class=""btn"">Зарегистрироваться</button>
        </div>



        <div class=""menu"">
            <ul>
                <li><i class=""fas fa-home""></i><a href=""#"">Главная</a></li>
                <li><i class=""fas fa-book""></i><a href=""#"">Книги</a></li>
                <li><i class=""fas fa-paragraph""></i><a href=""#"">Об издательстве</a></li>
                <li><i class=""fas fa-map-signs""></i><a href=""#"">Контакты</a></li>
            </ul>
        </div>
    </div>
    <div class=""main"">
        <div class=""cont"">
            <section class=""page section1"">
                <h1>first</h1>
            </section>

            <section class=""page section2"">
                <h1>first2</h1>
            </section>

            <section class=""page section3"">
    ");
                WriteLiteral("            <h1>first3</h1>\r\n            </section>\r\n\r\n            <section class=\"page section4\">\r\n                <h1>firs5t</h1>\r\n            </section>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
