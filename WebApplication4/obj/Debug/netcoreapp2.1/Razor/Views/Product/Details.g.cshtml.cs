#pragma checksum "C:\Users\drago\source\repos\MvcProject\WebApplication4\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a01f813cafe1c0ae55565d85ce6e31385e0272ef"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a01f813cafe1c0ae55565d85ce6e31385e0272ef", @"/Views/Product/Details.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcProject.Models.Product>
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
#line 2 "C:\Users\drago\source\repos\MvcProject\WebApplication4\Views\Product\Details.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(61, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(90, 107, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc547a81b6604c3b8865f266d4a9991f", async() => {
                BeginContext(96, 94, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Product Page</title>\r\n");
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
            BeginContext(197, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(199, 584, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39fca67c057e4a56a9540671df27506a", async() => {
                BeginContext(205, 26, true);
                WriteLiteral("\r\n    <h1>Cars Detail for ");
                EndContext();
                BeginContext(232, 11, false);
#line 14 "C:\Users\drago\source\repos\MvcProject\WebApplication4\Views\Product\Details.cshtml"
                   Write(Model.Title);

#line default
#line hidden
                EndContext();
                BeginContext(243, 80, true);
                WriteLiteral("</h1>\r\n    <a href=\"/Home/Index\">Go Back</a>\r\n    <div>\r\n        <p>Title <span>");
                EndContext();
                BeginContext(324, 11, false);
#line 17 "C:\Users\drago\source\repos\MvcProject\WebApplication4\Views\Product\Details.cshtml"
                  Write(Model.Title);

#line default
#line hidden
                EndContext();
                BeginContext(335, 36, true);
                WriteLiteral("</span></p>\r\n        <p>Image <span>");
                EndContext();
                BeginContext(372, 11, false);
#line 18 "C:\Users\drago\source\repos\MvcProject\WebApplication4\Views\Product\Details.cshtml"
                  Write(Model.Image);

#line default
#line hidden
                EndContext();
                BeginContext(383, 43, true);
                WriteLiteral("</span></p>\r\n        <p>Manufacturer <span>");
                EndContext();
                BeginContext(427, 18, false);
#line 19 "C:\Users\drago\source\repos\MvcProject\WebApplication4\Views\Product\Details.cshtml"
                         Write(Model.Manufacturer);

#line default
#line hidden
                EndContext();
                BeginContext(445, 35, true);
                WriteLiteral("</span></p>\r\n        <p>Make <span>");
                EndContext();
                BeginContext(481, 10, false);
#line 20 "C:\Users\drago\source\repos\MvcProject\WebApplication4\Views\Product\Details.cshtml"
                 Write(Model.Make);

#line default
#line hidden
                EndContext();
                BeginContext(491, 36, true);
                WriteLiteral("</span></p>\r\n        <p>Model <span>");
                EndContext();
                BeginContext(528, 11, false);
#line 21 "C:\Users\drago\source\repos\MvcProject\WebApplication4\Views\Product\Details.cshtml"
                  Write(Model.Model);

#line default
#line hidden
                EndContext();
                BeginContext(539, 39, true);
                WriteLiteral("</span></p>\r\n        <p>Category <span>");
                EndContext();
                BeginContext(579, 14, false);
#line 22 "C:\Users\drago\source\repos\MvcProject\WebApplication4\Views\Product\Details.cshtml"
                     Write(Model.Category);

#line default
#line hidden
                EndContext();
                BeginContext(593, 35, true);
                WriteLiteral("</span></p>\r\n        <p>Year <span>");
                EndContext();
                BeginContext(629, 10, false);
#line 23 "C:\Users\drago\source\repos\MvcProject\WebApplication4\Views\Product\Details.cshtml"
                 Write(Model.Year);

#line default
#line hidden
                EndContext();
                BeginContext(639, 38, true);
                WriteLiteral("</span></p>\r\n        <p>Content <span>");
                EndContext();
                BeginContext(678, 13, false);
#line 24 "C:\Users\drago\source\repos\MvcProject\WebApplication4\Views\Product\Details.cshtml"
                    Write(Model.Content);

#line default
#line hidden
                EndContext();
                BeginContext(691, 85, true);
                WriteLiteral("</span></p>\r\n        <hr/>\r\n    </div>\r\n    <footer>&copy;Car Reviews 2019</footer>\r\n");
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
            BeginContext(783, 11, true);
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
