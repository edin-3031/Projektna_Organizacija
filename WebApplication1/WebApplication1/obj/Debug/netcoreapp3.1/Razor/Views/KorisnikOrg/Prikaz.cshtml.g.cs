#pragma checksum "D:\New Project\WebApplication1\WebApplication1\Views\KorisnikOrg\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f046a817dfa2aea23876780e06e8fea2c6fb2699"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_KorisnikOrg_Prikaz), @"mvc.1.0.view", @"/Views/KorisnikOrg/Prikaz.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f046a817dfa2aea23876780e06e8fea2c6fb2699", @"/Views/KorisnikOrg/Prikaz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_KorisnikOrg_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\New Project\WebApplication1\WebApplication1\Views\KorisnikOrg\Prikaz.cshtml"
  
    List<Korisnici_OrganizacionaJedinica> lista = (List<Korisnici_OrganizacionaJedinica>)ViewData["kor_org_jed"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<center>
    <h1>Prikaz Korisnika - Organizacione Jedinice</h1>
    <div id=""dugmad"">
        <div id=""dodaj"">
            <a class=""btn btn-success"" href=""/KorisnikOrg/Unos"">Unesi novo</a>
        </div>
    </div>
    <table class=""table"">
        <thead>
        <th>ID</th>
        <th>Korisnik</th>
        <th>Organizaciona jedinica</th>
        <th>Akcija</th>
        </thead>
");
#nullable restore
#line 21 "D:\New Project\WebApplication1\WebApplication1\Views\KorisnikOrg\Prikaz.cshtml"
         foreach (var x in lista)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 24 "D:\New Project\WebApplication1\WebApplication1\Views\KorisnikOrg\Prikaz.cshtml"
               Write(x.Korisnici_OrganizacionaJedinica_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "D:\New Project\WebApplication1\WebApplication1\Views\KorisnikOrg\Prikaz.cshtml"
                Write(x.korisnici.Ime + " " + x.korisnici.Prezime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "D:\New Project\WebApplication1\WebApplication1\Views\KorisnikOrg\Prikaz.cshtml"
               Write(x.organizacionaJedinica.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 947, "\"", 1014, 2);
            WriteAttributeValue("", 954, "/KorisnikOrg/Ukloni?id=", 954, 23, true);
#nullable restore
#line 27 "D:\New Project\WebApplication1\WebApplication1\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 977, x.Korisnici_OrganizacionaJedinica_ID, 977, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Ukloni</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 29 "D:\New Project\WebApplication1\WebApplication1\Views\KorisnikOrg\Prikaz.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</center>");
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
