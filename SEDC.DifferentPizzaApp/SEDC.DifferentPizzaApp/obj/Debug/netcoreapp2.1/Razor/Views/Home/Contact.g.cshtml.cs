#pragma checksum "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.DifferentPizzaApp\SEDC.DifferentPizzaApp\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b93df4061ff384cf01ca37cf92dff41c251f235f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b93df4061ff384cf01ca37cf92dff41c251f235f", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"077120a3aa676d026ec126f57554b77e1f1e6f29", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.DifferentPizzaApp\SEDC.DifferentPizzaApp\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
            BeginContext(43, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(48, 17, false);
#line 4 "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.DifferentPizzaApp\SEDC.DifferentPizzaApp\Views\Home\Contact.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(65, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(77, 19, false);
#line 5 "C:\Users\code\Desktop\mvc-homeworks\mvc-homeworks\SEDC.DifferentPizzaApp\SEDC.DifferentPizzaApp\Views\Home\Contact.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(96, 369, true);
            WriteLiteral(@"</h3>

<address>
    One Microsoft Way<br />
    Redmond, WA 98052-6399<br />
    <abbr title=""Phone"">P:</abbr>
    425.555.0100
</address>

<address>
    <strong>Support:</strong> <a href=""mailto:Support@example.com"">Support@example.com</a><br />
    <strong>Marketing:</strong> <a href=""mailto:Marketing@example.com"">Marketing@example.com</a>
</address>
");
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
