#pragma checksum "D:\New Project\WebApplication1\WebApplication1\Views\Drzava\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14045fdb0fd9f66e291dfa4df775abf509719588"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Drzava_Prikaz), @"mvc.1.0.view", @"/Views/Drzava/Prikaz.cshtml")]
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
#line 1 "D:\New Project\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New Project\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14045fdb0fd9f66e291dfa4df775abf509719588", @"/Views/Drzava/Prikaz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Drzava_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\New Project\WebApplication1\WebApplication1\Views\Drzava\Prikaz.cshtml"
  

    List<Drzava> lista = (List<Drzava>)ViewData["drzave"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<center>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <th>ID</th>\r\n            <th>Šifra</th>\r\n            <th>Naziv</th>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 16 "D:\New Project\WebApplication1\WebApplication1\Views\Drzava\Prikaz.cshtml"
             foreach (var x in lista)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 19 "D:\New Project\WebApplication1\WebApplication1\Views\Drzava\Prikaz.cshtml"
                   Write(x.Drazava_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 20 "D:\New Project\WebApplication1\WebApplication1\Views\Drzava\Prikaz.cshtml"
                   Write(x.Sifra);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 21 "D:\New Project\WebApplication1\WebApplication1\Views\Drzava\Prikaz.cshtml"
                   Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 609, "\"", 647, 2);
            WriteAttributeValue("", 616, "/Drzava/Ukloni?id=", 616, 18, true);
#nullable restore
#line 22 "D:\New Project\WebApplication1\WebApplication1\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 634, x.Drazava_ID, 634, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Ukloni</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 24 "D:\New Project\WebApplication1\WebApplication1\Views\Drzava\Prikaz.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n        <a href=\"/Drzava/Unos\" class=\"btn btn-success\">Dodaj novu</a>\r\n</center>");
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
