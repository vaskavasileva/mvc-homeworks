#pragma checksum "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Home\PizzaDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a80d9b6b73f89c0f87e08506a1847c37b8514fe3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PizzaDetails), @"mvc.1.0.view", @"/Views/Home/PizzaDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/PizzaDetails.cshtml", typeof(AspNetCore.Views_Home_PizzaDetails))]
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
#line 1 "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\_ViewImports.cshtml"
using SEDC.WebApp.ModelDemo;

#line default
#line hidden
#line 2 "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\_ViewImports.cshtml"
using SEDC.WebApp.ModelDemo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a80d9b6b73f89c0f87e08506a1847c37b8514fe3", @"/Views/Home/PizzaDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb0552483ffb209745e80e9b5011d9dbfa85a6f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PizzaDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SEDC.WebApp.ModelDemo.Models.ViewModels.PizzaVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Home\PizzaDetails.cshtml"
  
    ViewData["Title"] = "PizzaDetails";
    ViewData["Ingredients"] = "Pizza Ingredients";

#line default
#line hidden
            BeginContext(158, 126, true);
            WriteLiteral("\r\n<h2>PizzaDetails</h2>\r\n\r\n<div>\r\n    <h4>PizzaVM</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(285, 40, false);
#line 15 "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Home\PizzaDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(325, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(369, 36, false);
#line 18 "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Home\PizzaDetails.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(405, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(449, 23, false);
#line 21 "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Home\PizzaDetails.cshtml"
       Write(ViewData["Ingredients"]);

#line default
#line hidden
            EndContext();
            BeginContext(472, 33, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");
            EndContext();
#line 25 "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Home\PizzaDetails.cshtml"
             for (int i = 0; i < Model.Ingredients.Count - 1; i++)
            {

#line default
#line hidden
            BeginContext(588, 22, true);
            WriteLiteral("                <span>");
            EndContext();
            BeginContext(611, 20, false);
#line 27 "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Home\PizzaDetails.cshtml"
                 Write(Model.Ingredients[i]);

#line default
#line hidden
            EndContext();
            BeginContext(631, 11, true);
            WriteLiteral(" ,</span>\r\n");
            EndContext();
#line 28 "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Home\PizzaDetails.cshtml"
            }

#line default
#line hidden
            BeginContext(657, 14, true);
            WriteLiteral("        <span>");
            EndContext();
            BeginContext(672, 46, false);
#line 29 "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Home\PizzaDetails.cshtml"
         Write(Model.Ingredients[Model.Ingredients.Count - 1]);

#line default
#line hidden
            EndContext();
            BeginContext(718, 50, true);
            WriteLiteral("</span>\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(769, 40, false);
#line 32 "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Home\PizzaDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Size));

#line default
#line hidden
            EndContext();
            BeginContext(809, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(853, 36, false);
#line 35 "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Home\PizzaDetails.cshtml"
       Write(Html.DisplayFor(model => model.Size));

#line default
#line hidden
            EndContext();
            BeginContext(889, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(933, 41, false);
#line 38 "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Home\PizzaDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(974, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1018, 37, false);
#line 41 "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Home\PizzaDetails.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1055, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1103, 68, false);
#line 46 "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Home\PizzaDetails.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1171, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1179, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6512785d46541828f3647163da03671", async() => {
                BeginContext(1201, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1217, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SEDC.WebApp.ModelDemo.Models.ViewModels.PizzaVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
