#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Views\Drzava\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0cad1a04b34f2954d10584cf105d7f45b621828"
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
#line 1 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0cad1a04b34f2954d10584cf105d7f45b621828", @"/Views/Drzava/Prikaz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Drzava_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Views\Drzava\Prikaz.cshtml"
  

    List<Drzava> lista = (List<Drzava>)ViewData["drzave"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<center>
    <h1>Prikaz Država</h1>
    <div id=""dugmad"">
        <div id=""dodaj"">
            <a href=""/Drzava/Unos"" class=""btn btn-success"">Dodaj novu</a>
        </div>
    </div>
    <table class=""table"">
        <thead>
        <th>ID</th>
        <th>Šifra</th>
        <th>Naziv</th>
        </thead>
        <tbody>
");
#nullable restore
#line 24 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Views\Drzava\Prikaz.cshtml"
             foreach (var x in lista)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 27 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Views\Drzava\Prikaz.cshtml"
                   Write(x.Drazava_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Views\Drzava\Prikaz.cshtml"
                   Write(x.Sifra);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Views\Drzava\Prikaz.cshtml"
                   Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 781, "\"", 819, 2);
            WriteAttributeValue("", 788, "/Drzava/Ukloni?id=", 788, 18, true);
#nullable restore
#line 30 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 806, x.Drazava_ID, 806, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Ukloni</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 32 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Views\Drzava\Prikaz.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</center>");
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
