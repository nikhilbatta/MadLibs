#pragma checksum "/Users/Guest/Desktop/MadLibs.Solution/MadLibs/Views/Home/DogTheme.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a13dfdf311b8dc5e3a35e21fac7b664d2c19adbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DogTheme), @"mvc.1.0.view", @"/Views/Home/DogTheme.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/DogTheme.cshtml", typeof(AspNetCore.Views_Home_DogTheme))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a13dfdf311b8dc5e3a35e21fac7b664d2c19adbd", @"/Views/Home/DogTheme.cshtml")]
    public class Views_Home_DogTheme : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(25, 180, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a13dfdf311b8dc5e3a35e21fac7b664d2c19adbd2853", async() => {
                BeginContext(31, 167, true);
                WriteLiteral("\n    <meta charset=\'utf-8\'>\n    <title>!PlayMadLibs</title>\n    <link rel=\'stylesheet\' href=\'https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css\'>\n  ");
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
            BeginContext(205, 3, true);
            WriteLiteral("\n  ");
            EndContext();
            BeginContext(208, 230, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a13dfdf311b8dc5e3a35e21fac7b664d2c19adbd4188", async() => {
                BeginContext(214, 9, true);
                WriteLiteral("\n    <p> ");
                EndContext();
                BeginContext(224, 10, false);
#line 9 "/Users/Guest/Desktop/MadLibs.Solution/MadLibs/Views/Home/DogTheme.cshtml"
   Write(Model.noun);

#line default
#line hidden
                EndContext();
                BeginContext(234, 12, true);
                WriteLiteral(" ate a cat, ");
                EndContext();
                BeginContext(247, 10, false);
#line 9 "/Users/Guest/Desktop/MadLibs.Solution/MadLibs/Views/Home/DogTheme.cshtml"
                          Write(Model.Verb);

#line default
#line hidden
                EndContext();
                BeginContext(257, 63, true);
                WriteLiteral(" to the store and got some dog food then went to the bathroom. ");
                EndContext();
                BeginContext(321, 15, false);
#line 9 "/Users/Guest/Desktop/MadLibs.Solution/MadLibs/Views/Home/DogTheme.cshtml"
                                                                                                    Write(Model.Adjective);

#line default
#line hidden
                EndContext();
                BeginContext(336, 40, true);
                WriteLiteral(" cats then went ran out and went crazy. ");
                EndContext();
                BeginContext(377, 13, false);
#line 9 "/Users/Guest/Desktop/MadLibs.Solution/MadLibs/Views/Home/DogTheme.cshtml"
                                                                                                                                                            Write(Model.Nountwo);

#line default
#line hidden
                EndContext();
                BeginContext(390, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(392, 11, false);
#line 9 "/Users/Guest/Desktop/MadLibs.Solution/MadLibs/Views/Home/DogTheme.cshtml"
                                                                                                                                                                           Write(Model.Verb3);

#line default
#line hidden
                EndContext();
                BeginContext(403, 28, true);
                WriteLiteral(" to the other store. </p>\n  ");
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
            BeginContext(438, 108, true);
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
