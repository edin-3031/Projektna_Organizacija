#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c7ec3a9b64c75bc9daf597a1ecdaed25a801059"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Korisnik_Prikaz), @"mvc.1.0.view", @"/Areas/Admin/Views/Korisnik/Prikaz.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Prikaz.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Prikaz.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c7ec3a9b64c75bc9daf597a1ecdaed25a801059", @"/Areas/Admin/Views/Korisnik/Prikaz.cshtml")]
    public class Areas_Admin_Views_Korisnik_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Prikaz.cshtml"
  
    List<Korisnici> lista = (List<Korisnici>)ViewData["korisnik"];
    uor id = (uor)ViewData["id"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<center>\r\n    <h1>Prikaz Korisnika</h1>\r\n    <div id=\"dugmad\">\r\n        <div id=\"dodaj\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 406, "\"", 480, 6);
            WriteAttributeValue("", 413, "/Admin/Korisnik/Unos?u=", 413, 23, true);
#nullable restore
#line 15 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 436, id.userId, 436, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 446, "&o=", 446, 3, true);
#nullable restore
#line 15 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 449, id.organisationId, 449, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 467, "&r=", 467, 3, true);
#nullable restore
#line 15 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 470, id.roleId, 470, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-success"">Dodaj novog</a>
        </div>
    </div>
    <table class=""table"">
        <thead>
        <th>ID</th>
        <th>Korisničko ime</th>
        <th>Uloga</th>
        <th>Šifra</th>
        <th>Ime</th>
        <th>Prezime</th>
        <th>Telefon</th>
        <th>Mail</th>
        <th>Lozinka</th>
        <th>Akcija</th>
        </thead>
        <tbody>
");
#nullable restore
#line 32 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Prikaz.cshtml"
             foreach (var x in lista)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 35 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Prikaz.cshtml"
                   Write(x.Korisnici_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Prikaz.cshtml"
                   Write(x.Korisnicko_Ime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 37 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Prikaz.cshtml"
                   Write(x.uloge.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 38 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Prikaz.cshtml"
                   Write(x.Sifra);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 39 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Prikaz.cshtml"
                   Write(x.Ime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 40 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Prikaz.cshtml"
                   Write(x.Prezime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 41 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Prikaz.cshtml"
                   Write(x.Telefon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 42 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Prikaz.cshtml"
                   Write(x.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 43 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Prikaz.cshtml"
                   Write(x.Lozinka);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1381, "\"", 1476, 8);
            WriteAttributeValue("", 1388, "/Admin/Korisnik/Ukloni?id=", 1388, 26, true);
#nullable restore
#line 44 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 1414, x.Korisnici_ID, 1414, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1429, "&u=", 1429, 3, true);
#nullable restore
#line 44 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 1432, id.userId, 1432, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1442, "&o=", 1442, 3, true);
#nullable restore
#line 44 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 1445, id.organisationId, 1445, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1463, "&r=", 1463, 3, true);
#nullable restore
#line 44 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 1466, id.roleId, 1466, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Ukloni</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 46 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Prikaz.cshtml"
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
