#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9e593a749192872da1399d1f150710e755c6ace"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Drzava_Unos), @"mvc.1.0.view", @"/Areas/Admin/Views/Drzava/Unos.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9e593a749192872da1399d1f150710e755c6ace", @"/Areas/Admin/Views/Drzava/Unos.cshtml")]
    public class Areas_Admin_Views_Drzava_Unos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
  
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
            BeginWriteAttribute("href", " href=\"", 1516, "\"", 1588, 6);
            WriteAttributeValue("", 1523, "/Admin/Admin/Index?u=", 1523, 21, true);
#nullable restore
#line 70 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 1544, id.userId, 1544, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1554, "&o=", 1554, 3, true);
#nullable restore
#line 70 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 1557, id.organisationId, 1557, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1575, "&r=", 1575, 3, true);
#nullable restore
#line 70 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 1578, id.roleId, 1578, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"sifarnik\">Opšti šifarnik</li>\r\n            <ul id=\"o_s\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1744, "\"", 1818, 6);
            WriteAttributeValue("", 1751, "/Admin/Drzava/Prikaz?u=", 1751, 23, true);
#nullable restore
#line 74 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 1774, id.userId, 1774, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1784, "&o=", 1784, 3, true);
#nullable restore
#line 74 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 1787, id.organisationId, 1787, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1805, "&r=", 1805, 3, true);
#nullable restore
#line 74 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 1808, id.roleId, 1808, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Država</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1859, "\"", 1930, 6);
            WriteAttributeValue("", 1866, "/Admin/PTT/Prikaz?u=", 1866, 20, true);
#nullable restore
#line 75 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 1886, id.userId, 1886, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1896, "&o=", 1896, 3, true);
#nullable restore
#line 75 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 1899, id.organisationId, 1899, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1917, "&r=", 1917, 3, true);
#nullable restore
#line 75 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 1920, id.roleId, 1920, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">PTT</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1968, "\"", 2048, 6);
            WriteAttributeValue("", 1975, "/Admin/Organizacija/Prikaz?u=", 1975, 29, true);
#nullable restore
#line 76 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 2004, id.userId, 2004, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2014, "&o=", 2014, 3, true);
#nullable restore
#line 76 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 2017, id.organisationId, 2017, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2035, "&r=", 2035, 3, true);
#nullable restore
#line 76 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 2038, id.roleId, 2038, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizacija</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2095, "\"", 2184, 6);
            WriteAttributeValue("", 2102, "/Admin/OrganizacionaJedinica/Prikaz?u=", 2102, 38, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 2140, id.userId, 2140, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2150, "&o=", 2150, 3, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 2153, id.organisationId, 2153, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2171, "&r=", 2171, 3, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 2174, id.roleId, 2174, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizaciona jedinica</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2241, "\"", 2320, 6);
            WriteAttributeValue("", 2248, "/Admin/KorisnikOrg/Prikaz?u=", 2248, 28, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 2276, id.userId, 2276, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2286, "&o=", 2286, 3, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 2289, id.organisationId, 2289, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2307, "&r=", 2307, 3, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 2310, id.roleId, 2310, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnik-Organizaciona jedinica</a></li>\r\n            </ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2483, "\"", 2563, 6);
            WriteAttributeValue("", 2490, "/Admin/ProjekatPlan/Prikaz?u=", 2490, 29, true);
#nullable restore
#line 82 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 2519, id.userId, 2519, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2529, "&o=", 2529, 3, true);
#nullable restore
#line 82 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 2532, id.organisationId, 2532, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2550, "&r=", 2550, 3, true);
#nullable restore
#line 82 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 2553, id.roleId, 2553, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2602, "\"", 2691, 6);
            WriteAttributeValue("", 2609, "/Admin/ProjekatAktivnostPlan/Prikaz?u=", 2609, 38, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 2647, id.userId, 2647, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2657, "&o=", 2657, 3, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 2660, id.organisationId, 2660, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2678, "&r=", 2678, 3, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 2681, id.roleId, 2681, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2831, "\"", 2927, 6);
            WriteAttributeValue("", 2838, "/Admin/ProjekatAktivnostRealizacija/Prikaz?u=", 2838, 45, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 2883, id.userId, 2883, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2893, "&o=", 2893, 3, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 2896, id.organisationId, 2896, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2914, "&r=", 2914, 3, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 2917, id.roleId, 2917, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3058, "\"", 3134, 6);
            WriteAttributeValue("", 3065, "/Admin/Korisnik/Prikaz?u=", 3065, 25, true);
#nullable restore
#line 91 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 3090, id.userId, 3090, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3100, "&o=", 3100, 3, true);
#nullable restore
#line 91 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 3103, id.organisationId, 3103, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3121, "&r=", 3121, 3, true);
#nullable restore
#line 91 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 3124, id.roleId, 3124, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnici</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3178, "\"", 3251, 6);
            WriteAttributeValue("", 3185, "/Admin/Uloge/Prikaz?u=", 3185, 22, true);
#nullable restore
#line 92 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 3207, id.userId, 3207, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3217, "&o=", 3217, 3, true);
#nullable restore
#line 92 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 3220, id.organisationId, 3220, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3238, "&r=", 3238, 3, true);
#nullable restore
#line 92 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 3241, id.roleId, 3241, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uloge</a></li>\r\n            </ul>\r\n        </ul>\r\n    </div>\r\n</div>\r\n");
            WriteLiteral(@"<center>
    <h1>Unos države</h1>
    <form action=""/Admin/Drzava/UnosSnimi"">
        <table>
            <tr>
                <td><label>Šifra</label></td>
                <td><input type=""text"" name=""sifra"" /></td>
            </tr>
            <tr>
                <td><label>Naziv</label></td>
                <td><input type=""text"" name=""naziv"" /></td>
            </tr>
            <input hidden=""hidden"" name=""u""");
            BeginWriteAttribute("value", " value=\"", 4495, "\"", 4513, 1);
#nullable restore
#line 129 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 4503, id.userId, 4503, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <input hidden=\"hidden\" name=\"r\"");
            BeginWriteAttribute("value", " value=\"", 4562, "\"", 4580, 1);
#nullable restore
#line 130 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 4570, id.roleId, 4570, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <input hidden=\"hidden\" name=\"o\"");
            BeginWriteAttribute("value", " value=\"", 4629, "\"", 4655, 1);
#nullable restore
#line 131 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Drzava\Unos.cshtml"
WriteAttributeValue("", 4637, id.organisationId, 4637, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </table>\r\n\r\n        <button type=\"submit\" class=\"btn btn-primary\">Snimi</button>\r\n    </form>\r\n</center>");
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