#pragma checksum "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4785027698261ab5d8beb281fbae2f72c5380b64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4785027698261ab5d8beb281fbae2f72c5380b64", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb0552483ffb209745e80e9b5011d9dbfa85a6f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SEDC.WebApp.ModelDemo.Models.Domain.Pizza>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(62, 6, true);
            WriteLiteral("\n\n<h1>");
            EndContext();
            BeginContext(69, 13, false);
#line 4 "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Home\Index.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(82, 11, true);
            WriteLiteral(" </h1>\n<h2>");
            EndContext();
            BeginContext(94, 19, false);
#line 5 "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Home\Index.cshtml"
Write(ViewData["Heading"]);

#line default
#line hidden
            EndContext();
            BeginContext(113, 87, true);
            WriteLiteral(" </h2>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
            EndContext();
            BeginContext(201, 40, false);
#line 10 "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(241, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(294, 40, false);
#line 13 "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Size));

#line default
#line hidden
            EndContext();
            BeginContext(334, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(387, 41, false);
#line 16 "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(428, 80, true);
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 22 "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Home\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(539, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(586, 39, false);
#line 25 "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(625, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(678, 39, false);
#line 28 "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Size));

#line default
#line hidden
            EndContext();
            BeginContext(717, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(770, 40, false);
#line 31 "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(810, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(863, 64, false);
#line 34 "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Home\Index.cshtml"
           Write(Html.ActionLink("Details", "PizzaDetails", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(927, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(947, 62, false);
#line 35 "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Home\Index.cshtml"
           Write(Html.ActionLink("Put in order", "Order", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1009, 33, true);
            WriteLiteral("\n            </td>\n        </tr>\n");
            EndContext();
#line 38 "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1044, 22, true);
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SEDC.WebApp.ModelDemo.Models.Domain.Pizza>> Html { get; private set; }
    }
}
#pragma warning restore 1591
