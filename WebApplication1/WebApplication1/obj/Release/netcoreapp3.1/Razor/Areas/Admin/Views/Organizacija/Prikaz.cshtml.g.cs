#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2ee5e96fdef14b0a2659f0a8782619bef3f7c9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Organizacija_Prikaz), @"mvc.1.0.view", @"/Areas/Admin/Views/Organizacija/Prikaz.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2ee5e96fdef14b0a2659f0a8782619bef3f7c9b", @"/Areas/Admin/Views/Organizacija/Prikaz.cshtml")]
    public class Areas_Admin_Views_Organizacija_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
  
    List<Organizacija> lista_organizacija = (List<Organizacija>)ViewData["organizacija"];
    Layout = "~/Views/Shared/_Layout_admin.cshtml";

    uor id = (uor)ViewData["id"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    td {
        padding: 10px;
    }

    a, td {
        /*font-weight: bold;*/
        text-align-last: center;
    }

    li, ul {
        list-style: none;
        margin-top: 5%;
    }

    ul {
        margin: 0px;
        padding: 0px;
        border: 0px;
    }

    #sifarnik, #transakcije, #izvjestaji, #admin {
        font-weight: bold;
    }

    a {
        color: white;
        text-decoration-line: none;
    }

        a:hover {
            color: white;
            text-decoration: none;
            text-decoration-line: none;
        }

    #kutijaZaMeni {
        position: fixed;
        height: 100%;
        width: 17%;
        /*            background-color:green;*/
        display: block;
        margin-left: -17.8%;
    }

    #menu {
        position: fixed;
        /*height: 65%;*/
        width: 15%;
        margin-left: 0px;
        background-color: rgba(0, 0, 0, 0.8);
        color: white;
        top: 20%;
        font-s");
            WriteLiteral("ize: 1vw;\r\n        border-radius: 0px 25px 25px 0px;\r\n    }\r\n</style>\r\n<div id=\"kutijaZaMeni\">\r\n    <div id=\"menu\">\r\n        <br />\r\n        <a style=\"color:white; text-decoration-line:none; font-size:120%;\"");
            BeginWriteAttribute("href", " href=\"", 1609, "\"", 1681, 6);
            WriteAttributeValue("", 1616, "/Admin/Admin/Index?u=", 1616, 21, true);
#nullable restore
#line 72 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 1637, id.userId, 1637, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1647, "&o=", 1647, 3, true);
#nullable restore
#line 72 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 1650, id.organisationId, 1650, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1668, "&r=", 1668, 3, true);
#nullable restore
#line 72 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 1671, id.roleId, 1671, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"sifarnik\">Opšti šifarnik</li>\r\n            <ul id=\"o_s\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1837, "\"", 1911, 6);
            WriteAttributeValue("", 1844, "/Admin/Drzava/Prikaz?u=", 1844, 23, true);
#nullable restore
#line 76 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 1867, id.userId, 1867, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1877, "&o=", 1877, 3, true);
#nullable restore
#line 76 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 1880, id.organisationId, 1880, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1898, "&r=", 1898, 3, true);
#nullable restore
#line 76 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 1901, id.roleId, 1901, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Država</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1952, "\"", 2023, 6);
            WriteAttributeValue("", 1959, "/Admin/PTT/Prikaz?u=", 1959, 20, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 1979, id.userId, 1979, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1989, "&o=", 1989, 3, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 1992, id.organisationId, 1992, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2010, "&r=", 2010, 3, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 2013, id.roleId, 2013, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">PTT</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2061, "\"", 2141, 6);
            WriteAttributeValue("", 2068, "/Admin/Organizacija/Prikaz?u=", 2068, 29, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 2097, id.userId, 2097, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2107, "&o=", 2107, 3, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 2110, id.organisationId, 2110, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2128, "&r=", 2128, 3, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 2131, id.roleId, 2131, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizacija</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2188, "\"", 2277, 6);
            WriteAttributeValue("", 2195, "/Admin/OrganizacionaJedinica/Prikaz?u=", 2195, 38, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 2233, id.userId, 2233, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2243, "&o=", 2243, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 2246, id.organisationId, 2246, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2264, "&r=", 2264, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 2267, id.roleId, 2267, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizaciona jedinica</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2334, "\"", 2413, 6);
            WriteAttributeValue("", 2341, "/Admin/KorisnikOrg/Prikaz?u=", 2341, 28, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 2369, id.userId, 2369, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2379, "&o=", 2379, 3, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 2382, id.organisationId, 2382, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2400, "&r=", 2400, 3, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 2403, id.roleId, 2403, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnik-Organizaciona jedinica</a></li>\r\n            </ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2576, "\"", 2656, 6);
            WriteAttributeValue("", 2583, "/Admin/ProjekatPlan/Prikaz?u=", 2583, 29, true);
#nullable restore
#line 84 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 2612, id.userId, 2612, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2622, "&o=", 2622, 3, true);
#nullable restore
#line 84 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 2625, id.organisationId, 2625, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2643, "&r=", 2643, 3, true);
#nullable restore
#line 84 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 2646, id.roleId, 2646, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2695, "\"", 2784, 6);
            WriteAttributeValue("", 2702, "/Admin/ProjekatAktivnostPlan/Prikaz?u=", 2702, 38, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 2740, id.userId, 2740, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2750, "&o=", 2750, 3, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 2753, id.organisationId, 2753, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2771, "&r=", 2771, 3, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 2774, id.roleId, 2774, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2924, "\"", 3020, 6);
            WriteAttributeValue("", 2931, "/Admin/ProjekatAktivnostRealizacija/Prikaz?u=", 2931, 45, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 2976, id.userId, 2976, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2986, "&o=", 2986, 3, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 2989, id.organisationId, 2989, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3007, "&r=", 3007, 3, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 3010, id.roleId, 3010, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3151, "\"", 3227, 6);
            WriteAttributeValue("", 3158, "/Admin/Korisnik/Prikaz?u=", 3158, 25, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 3183, id.userId, 3183, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3193, "&o=", 3193, 3, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 3196, id.organisationId, 3196, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3214, "&r=", 3214, 3, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 3217, id.roleId, 3217, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnici</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3271, "\"", 3344, 6);
            WriteAttributeValue("", 3278, "/Admin/Uloge/Prikaz?u=", 3278, 22, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 3300, id.userId, 3300, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3310, "&o=", 3310, 3, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 3313, id.organisationId, 3313, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3331, "&r=", 3331, 3, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 3334, id.roleId, 3334, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uloge</a></li>\r\n            </ul>\r\n        </ul>\r\n    </div>\r\n</div>\r\n");
            WriteLiteral("<center>\r\n    <h1>Prikaz Organizacija</h1>\r\n    <div id=\"dugmad\">\r\n        <div id=\"dodaj\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 4264, "\"", 4342, 6);
            WriteAttributeValue("", 4271, "/Admin/Organizacija/Unos?u=", 4271, 27, true);
#nullable restore
#line 123 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 4298, id.userId, 4298, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4308, "&o=", 4308, 3, true);
#nullable restore
#line 123 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 4311, id.organisationId, 4311, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4329, "&r=", 4329, 3, true);
#nullable restore
#line 123 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 4332, id.roleId, 4332, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-success"">Dodaj novu</a>
        </div>
    </div>
    <table class=""table"">
        <thead>
        <th>ID</th>
        <th>PTT</th>
        <th>Država</th>
        <th>Šifra</th>
        <th>Naziv</th>
        <th>Adresa</th>
        <th>Akcija</th>
        </thead>
        <tbody>
");
#nullable restore
#line 137 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
             foreach (var x in lista_organizacija)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 140 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
                   Write(x.Organizacija_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 141 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
                   Write(x.ptt.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 142 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
                   Write(x.drzava.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 143 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
                   Write(x.Sifra);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 144 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
                   Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 145 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
                   Write(x.Adresa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 5028, "\"", 5130, 8);
            WriteAttributeValue("", 5035, "/Admin/Organizacija/Ukloni?id=", 5035, 30, true);
#nullable restore
#line 146 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 5065, x.Organizacija_ID, 5065, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5083, "&u=", 5083, 3, true);
#nullable restore
#line 146 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 5086, id.userId, 5086, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5096, "&o=", 5096, 3, true);
#nullable restore
#line 146 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 5099, id.organisationId, 5099, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5117, "&r=", 5117, 3, true);
#nullable restore
#line 146 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 5120, id.roleId, 5120, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Ukloni</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 148 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Organizacija\Prikaz.cshtml"
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
