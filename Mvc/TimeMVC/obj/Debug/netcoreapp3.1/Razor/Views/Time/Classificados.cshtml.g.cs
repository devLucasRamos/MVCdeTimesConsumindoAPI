#pragma checksum "C:\Users\lucas\source\repos\TimeMVC\Views\Time\Classificados.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c93cc3bd4a5c5a61736d018fe55f847270f7a96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Time_Classificados), @"mvc.1.0.view", @"/Views/Time/Classificados.cshtml")]
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
#line 1 "C:\Users\lucas\source\repos\TimeMVC\Views\_ViewImports.cshtml"
using TimeMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lucas\source\repos\TimeMVC\Views\_ViewImports.cshtml"
using TimeMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c93cc3bd4a5c5a61736d018fe55f847270f7a96", @"/Views/Time/Classificados.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f422fd16c617faa471a9a184440c5bebe5abd65", @"/Views/_ViewImports.cshtml")]
    public class Views_Time_Classificados : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TimesMVC.Core.Entities.Classificado>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\lucas\source\repos\TimeMVC\Views\Time\Classificados.cshtml"
  
    ViewData["Title"] = "Times da API";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\lucas\source\repos\TimeMVC\Views\Time\Classificados.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\lucas\source\repos\TimeMVC\Views\Time\Classificados.cshtml"
           Write(Html.DisplayNameFor(model => model.Time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\lucas\source\repos\TimeMVC\Views\Time\Classificados.cshtml"
           Write(Html.DisplayNameFor(model => model.Criacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\lucas\source\repos\TimeMVC\Views\Time\Classificados.cshtml"
           Write(Html.DisplayNameFor(model => model.Premio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 25 "C:\Users\lucas\source\repos\TimeMVC\Views\Time\Classificados.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 29 "C:\Users\lucas\source\repos\TimeMVC\Views\Time\Classificados.cshtml"
               Write(Html.DisplayFor(modelItem => item.Time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "C:\Users\lucas\source\repos\TimeMVC\Views\Time\Classificados.cshtml"
               Write(Html.DisplayFor(modelItem => item.Criacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "C:\Users\lucas\source\repos\TimeMVC\Views\Time\Classificados.cshtml"
               Write(Html.DisplayFor(modelItem => item.Premio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 38 "C:\Users\lucas\source\repos\TimeMVC\Views\Time\Classificados.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TimesMVC.Core.Entities.Classificado>> Html { get; private set; }
    }
}
#pragma warning restore 1591