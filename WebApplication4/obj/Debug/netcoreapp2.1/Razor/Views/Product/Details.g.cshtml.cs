#pragma checksum "C:\Users\OmniViscious\source\repos\MvcProject\WebApplication4\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "306e63b66140f10def8a4af7fda010aff2a271ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Details.cshtml", typeof(AspNetCore.Views_Product_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"306e63b66140f10def8a4af7fda010aff2a271ba", @"/Views/Product/Details.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcProject.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Styles/Details.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\OmniViscious\source\repos\MvcProject\WebApplication4\Views\Product\Details.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(61, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(90, 168, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64d109817c3e4d9ea0d076e6b34f23e1", async() => {
                BeginContext(96, 98, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Product Page</title>\r\n    ");
                EndContext();
                BeginContext(194, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "270af7f71bc34d0d9d3bc13fa1dad8c7", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(247, 4, true);
                WriteLiteral("\r\n\r\n");
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
            BeginContext(258, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(260, 659, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37d0d41e3cf34d20b28ef8384c362fd5", async() => {
                BeginContext(266, 26, true);
                WriteLiteral("\r\n    <h1>Cars Detail for ");
                EndContext();
                BeginContext(293, 11, false);
#line 16 "C:\Users\OmniViscious\source\repos\MvcProject\WebApplication4\Views\Product\Details.cshtml"
                   Write(Model.Title);

#line default
#line hidden
                EndContext();
                BeginContext(304, 42, true);
                WriteLiteral("</h1>\r\n    <div>\r\n        <p>Title: <span>");
                EndContext();
                BeginContext(347, 11, false);
#line 18 "C:\Users\OmniViscious\source\repos\MvcProject\WebApplication4\Views\Product\Details.cshtml"
                   Write(Model.Title);

#line default
#line hidden
                EndContext();
                BeginContext(358, 28, true);
                WriteLiteral("</span></p>\r\n        <p><img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 386, "\"", 404, 1);
#line 19 "C:\Users\OmniViscious\source\repos\MvcProject\WebApplication4\Views\Product\Details.cshtml"
WriteAttributeValue("", 392, Model.Image, 392, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(405, 101, true);
                WriteLiteral(" alt=\"Mclaren 570 Spyder\" style=\" height: 200px; width:340px;\"/></p>\r\n        <p>Manufacturer: <span>");
                EndContext();
                BeginContext(507, 18, false);
#line 20 "C:\Users\OmniViscious\source\repos\MvcProject\WebApplication4\Views\Product\Details.cshtml"
                          Write(Model.Manufacturer);

#line default
#line hidden
                EndContext();
                BeginContext(525, 36, true);
                WriteLiteral("</span></p>\r\n        <p>Make: <span>");
                EndContext();
                BeginContext(562, 10, false);
#line 21 "C:\Users\OmniViscious\source\repos\MvcProject\WebApplication4\Views\Product\Details.cshtml"
                  Write(Model.Make);

#line default
#line hidden
                EndContext();
                BeginContext(572, 37, true);
                WriteLiteral("</span></p>\r\n        <p>Model: <span>");
                EndContext();
                BeginContext(610, 11, false);
#line 22 "C:\Users\OmniViscious\source\repos\MvcProject\WebApplication4\Views\Product\Details.cshtml"
                   Write(Model.Model);

#line default
#line hidden
                EndContext();
                BeginContext(621, 40, true);
                WriteLiteral("</span></p>\r\n        <p>Category: <span>");
                EndContext();
                BeginContext(662, 14, false);
#line 23 "C:\Users\OmniViscious\source\repos\MvcProject\WebApplication4\Views\Product\Details.cshtml"
                      Write(Model.Category);

#line default
#line hidden
                EndContext();
                BeginContext(676, 36, true);
                WriteLiteral("</span></p>\r\n        <p>Year: <span>");
                EndContext();
                BeginContext(713, 10, false);
#line 24 "C:\Users\OmniViscious\source\repos\MvcProject\WebApplication4\Views\Product\Details.cshtml"
                  Write(Model.Year);

#line default
#line hidden
                EndContext();
                BeginContext(723, 39, true);
                WriteLiteral("</span></p>\r\n        <p>Content: <span>");
                EndContext();
                BeginContext(763, 13, false);
#line 25 "C:\Users\OmniViscious\source\repos\MvcProject\WebApplication4\Views\Product\Details.cshtml"
                     Write(Model.Content);

#line default
#line hidden
                EndContext();
                BeginContext(776, 136, true);
                WriteLiteral("</span></p>\r\n        <hr/>\r\n    </div>\r\n    <a href=\"/Product/Index\">Go Back</a>\r\n    <footer><h6>&copy;Car Reviews 2019</h6></footer>\r\n");
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
            BeginContext(919, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcProject.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
