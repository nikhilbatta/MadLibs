#pragma checksum "/Users/Guest/Desktop/MadLibs.Solution/MadLibs/Views/Home/CelebrityTheme.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb4940e7dc62e78cf39a5482637a0a2d9e98206d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CelebrityTheme), @"mvc.1.0.view", @"/Views/Home/CelebrityTheme.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CelebrityTheme.cshtml", typeof(AspNetCore.Views_Home_CelebrityTheme))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb4940e7dc62e78cf39a5482637a0a2d9e98206d", @"/Views/Home/CelebrityTheme.cshtml")]
    public class Views_Home_CelebrityTheme : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\n<html>\n  ");
            EndContext();
            BeginContext(25, 183, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb4940e7dc62e78cf39a5482637a0a2d9e98206d2895", async() => {
                BeginContext(31, 170, true);
                WriteLiteral("\n    <meta charset=\'utf-8\'>\n    <title>Celebrity Theme</title>\n    <link rel=\'stylesheet\' href=\'https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css\'>\n  ");
                EndContext();
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
            EndContext();
            BeginContext(208, 3, true);
            WriteLiteral("\n  ");
            EndContext();
            BeginContext(211, 159, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb4940e7dc62e78cf39a5482637a0a2d9e98206d4233", async() => {
                BeginContext(217, 9, true);
                WriteLiteral("\n    <p> ");
                EndContext();
                BeginContext(227, 10, false);
#line 9 "/Users/Guest/Desktop/MadLibs.Solution/MadLibs/Views/Home/CelebrityTheme.cshtml"
   Write(Model.Verb);

#line default
#line hidden
                EndContext();
                BeginContext(237, 33, true);
                WriteLiteral(", went to the store and got some ");
                EndContext();
                BeginContext(271, 15, false);
#line 9 "/Users/Guest/Desktop/MadLibs.Solution/MadLibs/Views/Home/CelebrityTheme.cshtml"
                                               Write(Model.Adjective);

#line default
#line hidden
                EndContext();
                BeginContext(286, 28, true);
                WriteLiteral(" then went to the bathroom. ");
                EndContext();
                BeginContext(315, 10, false);
#line 9 "/Users/Guest/Desktop/MadLibs.Solution/MadLibs/Views/Home/CelebrityTheme.cshtml"
                                                                                           Write(Model.verb);

#line default
#line hidden
                EndContext();
                BeginContext(325, 19, true);
                WriteLiteral(" then went to feed ");
                EndContext();
                BeginContext(345, 10, false);
#line 9 "/Users/Guest/Desktop/MadLibs.Solution/MadLibs/Views/Home/CelebrityTheme.cshtml"
                                                                                                                         Write(Model.verb);

#line default
#line hidden
                EndContext();
                BeginContext(355, 8, true);
                WriteLiteral(" </p>\n  ");
                EndContext();
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
            EndContext();
            BeginContext(370, 108, true);
            WriteLiteral("\n<form action = \"/form\">\n<button type = \"submit\" value =\"play again\" > Play again </button>\n</form>\n\n</html>");
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
