#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a35e01ead44825e98733f3382a2e965155b0e43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminOrg_Views_KorisnikOrg_Prikaz), @"mvc.1.0.view", @"/Areas/AdminOrg/Views/KorisnikOrg/Prikaz.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a35e01ead44825e98733f3382a2e965155b0e43", @"/Areas/AdminOrg/Views/KorisnikOrg/Prikaz.cshtml")]
    public class Areas_AdminOrg_Views_KorisnikOrg_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
  
    List<Korisnici_OrganizacionaJedinica> lista = (List<Korisnici_OrganizacionaJedinica>)ViewData["kor_org_jed"];
    Layout = "~/Views/Shared/_Layout_admin_org.cshtml";
    uor id = (uor)ViewData["id"];

    byte[] pic = (byte[])ViewData["logo"];
    var base64 = Convert.ToBase64String(pic);
    var imgsrc = string.Format("data:image/gif;base64,{0}", base64);

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
            BeginWriteAttribute("href", " href=\"", 1798, "\"", 1876, 6);
            WriteAttributeValue("", 1805, "/AdminOrg/AdminOrg/Index?u=", 1805, 27, true);
#nullable restore
#line 75 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 1832, id.userId, 1832, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1842, "&o=", 1842, 3, true);
#nullable restore
#line 75 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 1845, id.organisationId, 1845, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1863, "&r=", 1863, 3, true);
#nullable restore
#line 75 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 1866, id.roleId, 1866, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"sifarnik\">Opšti šifarnik</li>\r\n            <ul id=\"o_s\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2032, "\"", 2124, 6);
            WriteAttributeValue("", 2039, "/AdminOrg/OrganizacionaJedinica/Prikaz?u=", 2039, 41, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 2080, id.userId, 2080, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2090, "&o=", 2090, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 2093, id.organisationId, 2093, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2111, "&r=", 2111, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 2114, id.roleId, 2114, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizaciona jedinica</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2181, "\"", 2263, 6);
            WriteAttributeValue("", 2188, "/AdminOrg/KorisnikOrg/Prikaz?u=", 2188, 31, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 2219, id.userId, 2219, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2229, "&o=", 2229, 3, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 2232, id.organisationId, 2232, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2250, "&r=", 2250, 3, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 2253, id.roleId, 2253, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnik-Organizaciona jedinica</a></li>\r\n            </ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2426, "\"", 2509, 6);
            WriteAttributeValue("", 2433, "/AdminOrg/ProjekatPlan/Prikaz?u=", 2433, 32, true);
#nullable restore
#line 84 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 2465, id.userId, 2465, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2475, "&o=", 2475, 3, true);
#nullable restore
#line 84 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 2478, id.organisationId, 2478, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2496, "&r=", 2496, 3, true);
#nullable restore
#line 84 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 2499, id.roleId, 2499, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2548, "\"", 2640, 6);
            WriteAttributeValue("", 2555, "/AdminOrg/ProjekatAktivnostPlan/Prikaz?u=", 2555, 41, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 2596, id.userId, 2596, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2606, "&o=", 2606, 3, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 2609, id.organisationId, 2609, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2627, "&r=", 2627, 3, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 2630, id.roleId, 2630, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2780, "\"", 2879, 6);
            WriteAttributeValue("", 2787, "/AdminOrg/ProjekatAktivnostRealizacija/Prikaz?u=", 2787, 48, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 2835, id.userId, 2835, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2845, "&o=", 2845, 3, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 2848, id.organisationId, 2848, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2866, "&r=", 2866, 3, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 2869, id.roleId, 2869, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3010, "\"", 3089, 6);
            WriteAttributeValue("", 3017, "/AdminOrg/Korisnik/Prikaz?u=", 3017, 28, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 3045, id.userId, 3045, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3055, "&o=", 3055, 3, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 3058, id.organisationId, 3058, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3076, "&r=", 3076, 3, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 3079, id.roleId, 3079, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Korisnici</a></li>
            </ul>
        </ul>
    </div>
</div>
<center>
    <div id=""zaglavlje"" style=""width:100%"">
        <h1 style=""position:relative; display:inline;"">Prikaz Korisnika - Organizacione jedinice</h1>
        <img style=""height:7vw; width:7vw; position:relative; float:right; display:inline;""");
            BeginWriteAttribute("src", " src=\"", 3414, "\"", 3427, 1);
#nullable restore
#line 101 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 3420, imgsrc, 3420, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <div id=\"dugmad\">\r\n");
            WriteLiteral("        <div id=\"print_excel\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 3704, "\"", 3759, 2);
            WriteAttributeValue("", 3711, "/AdminOrg/KorisnikOrg/Excel?o=", 3711, 30, true);
#nullable restore
#line 108 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 3741, id.organisationId, 3741, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Export to Excel</a>\r\n        </div>\r\n    </div>\r\n    <table class=\"table\">\r\n        <thead>\r\n        <th>ID</th>\r\n        <th>Korisnik</th>\r\n        <th>Organizaciona jedinica</th>\r\n        <th>Akcija</th>\r\n        </thead>\r\n");
#nullable restore
#line 118 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
         foreach (var x in lista)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 121 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
               Write(x.Korisnici_OrganizacionaJedinica_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 122 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
                Write(x.korisnici.Ime + " " + x.korisnici.Prezime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 123 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
               Write(x.organizacionaJedinica.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 4333, "\"", 4455, 8);
            WriteAttributeValue("", 4340, "/AdminOrg/KorisnikOrg/Uredi?id=", 4340, 31, true);
#nullable restore
#line 125 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 4371, x.Korisnici_OrganizacionaJedinica_ID, 4371, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4408, "&u=", 4408, 3, true);
#nullable restore
#line 125 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 4411, id.userId, 4411, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4421, "&o=", 4421, 3, true);
#nullable restore
#line 125 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 4424, id.organisationId, 4424, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4442, "&r=", 4442, 3, true);
#nullable restore
#line 125 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 4445, id.roleId, 4445, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uredi</a>\r\n                    <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 4513, "\"", 4636, 8);
            WriteAttributeValue("", 4520, "/AdminOrg/KorisnikOrg/Ukloni?id=", 4520, 32, true);
#nullable restore
#line 126 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 4552, x.Korisnici_OrganizacionaJedinica_ID, 4552, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4589, "&u=", 4589, 3, true);
#nullable restore
#line 126 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 4592, id.userId, 4592, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4602, "&o=", 4602, 3, true);
#nullable restore
#line 126 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 4605, id.organisationId, 4605, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4623, "&r=", 4623, 3, true);
#nullable restore
#line 126 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 4626, id.roleId, 4626, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Ukloni</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 129 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Prikaz.cshtml"
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
