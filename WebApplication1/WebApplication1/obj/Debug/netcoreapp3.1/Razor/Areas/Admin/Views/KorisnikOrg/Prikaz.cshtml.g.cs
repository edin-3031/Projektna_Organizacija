#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\KorisnikOrg\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "273db14be310daef4a1721c05527390b58baef33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_KorisnikOrg_Prikaz), @"mvc.1.0.view", @"/Areas/Admin/Views/KorisnikOrg/Prikaz.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\KorisnikOrg\Prikaz.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"273db14be310daef4a1721c05527390b58baef33", @"/Areas/Admin/Views/KorisnikOrg/Prikaz.cshtml")]
    public class Areas_Admin_Views_KorisnikOrg_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\KorisnikOrg\Prikaz.cshtml"
  
    List<Korisnici_OrganizacionaJedinica> lista = (List<Korisnici_OrganizacionaJedinica>)ViewData["kor_org_jed"];
    Layout = "~/Views/Shared/_Layout_admin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<center>
    <h1>Prikaz Korisnika - Organizacione Jedinice</h1>
    <div id=""dugmad"">
        <div id=""dodaj"">
            <a class=""btn btn-success"" href=""/Admin/KorisnikOrg/Unos"">Unesi novo</a>
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
#line 23 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\KorisnikOrg\Prikaz.cshtml"
         foreach (var x in lista)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 26 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\KorisnikOrg\Prikaz.cshtml"
               Write(x.Korisnici_OrganizacionaJedinica_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\KorisnikOrg\Prikaz.cshtml"
                Write(x.korisnici.Ime + " " + x.korisnici.Prezime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\KorisnikOrg\Prikaz.cshtml"
               Write(x.organizacionaJedinica.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1038, "\"", 1111, 2);
            WriteAttributeValue("", 1045, "/Admin/KorisnikOrg/Ukloni?id=", 1045, 29, true);
#nullable restore
#line 29 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 1074, x.Korisnici_OrganizacionaJedinica_ID, 1074, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Ukloni</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 31 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\KorisnikOrg\Prikaz.cshtml"
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
