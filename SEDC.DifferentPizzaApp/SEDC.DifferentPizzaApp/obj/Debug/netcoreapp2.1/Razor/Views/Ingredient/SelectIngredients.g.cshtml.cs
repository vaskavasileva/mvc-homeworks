#pragma checksum "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.DifferentPizzaApp\SEDC.DifferentPizzaApp\Views\Ingredient\SelectIngredients.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c6b647a6154f5ba2ef8688e53fd68c97eb27dde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ingredient_SelectIngredients), @"mvc.1.0.view", @"/Views/Ingredient/SelectIngredients.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ingredient/SelectIngredients.cshtml", typeof(AspNetCore.Views_Ingredient_SelectIngredients))]
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
#line 1 "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.DifferentPizzaApp\SEDC.DifferentPizzaApp\Views\_ViewImports.cshtml"
using SEDC.DifferentPizzaApp;

#line default
#line hidden
#line 2 "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.DifferentPizzaApp\SEDC.DifferentPizzaApp\Views\_ViewImports.cshtml"
using SEDC.DifferentPizzaApp.DataAccess.Core.Enums;

#line default
#line hidden
#line 3 "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.DifferentPizzaApp\SEDC.DifferentPizzaApp\Views\_ViewImports.cshtml"
using SEDC.DifferentPizzaApp.DataAccess.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.DifferentPizzaApp\SEDC.DifferentPizzaApp\Views\_ViewImports.cshtml"
using SEDC.DifferentPizzaApp.BusinessLayer.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c6b647a6154f5ba2ef8688e53fd68c97eb27dde", @"/Views/Ingredient/SelectIngredients.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"077120a3aa676d026ec126f57554b77e1f1e6f29", @"/Views/_ViewImports.cshtml")]
    public class Views_Ingredient_SelectIngredients : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<IngredientVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SelectIngredients", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 177, true);
            WriteLiteral("\r\n\r\n\r\n<h2>Select Cheeses</h2>\r\n\r\n<div class=\"form-group\">\r\n    <label for=\"size\">Select the type of dough for your pizza: </label>\r\n    <select class=\"form-control\" id=\"size\">\r\n");
            EndContext();
#line 10 "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.DifferentPizzaApp\SEDC.DifferentPizzaApp\Views\Ingredient\SelectIngredients.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
            BeginContext(255, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(267, 27, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d7f1ea33d4c4f46b2531da3b356958f", async() => {
                BeginContext(276, 9, false);
#line 13 "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.DifferentPizzaApp\SEDC.DifferentPizzaApp\Views\Ingredient\SelectIngredients.cshtml"
               Write(item.Name);

#line default
#line hidden
                EndContext();
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
            BeginContext(294, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 14 "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.DifferentPizzaApp\SEDC.DifferentPizzaApp\Views\Ingredient\SelectIngredients.cshtml"
        }

#line default
#line hidden
            BeginContext(307, 33, true);
            WriteLiteral("\r\n        </select>\r\n\r\n\r\n        ");
            EndContext();
            BeginContext(340, 184, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6afb6a7b716458e829351570c72daa3", async() => {
                BeginContext(377, 92, true);
                WriteLiteral("\r\n            <input type=\"submit\" value=\"Submit\" class=\"btn btn-default\" /> |\r\n            ");
                EndContext();
                BeginContext(469, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6f72688d3944767834d46f46236cddd", async() => {
                    BeginContext(491, 12, true);
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
                BeginContext(507, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(524, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<IngredientVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
