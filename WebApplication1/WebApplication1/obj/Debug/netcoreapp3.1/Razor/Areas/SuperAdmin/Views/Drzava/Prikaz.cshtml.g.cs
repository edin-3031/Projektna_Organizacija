#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8986b3a115fd46130614d52c9cc91b4c017d393"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_Drzava_Prikaz), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/Drzava/Prikaz.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8986b3a115fd46130614d52c9cc91b4c017d393", @"/Areas/SuperAdmin/Views/Drzava/Prikaz.cshtml")]
    public class Areas_SuperAdmin_Views_Drzava_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.VM.uor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
  
    List<Drzava> lista = (List<Drzava>)ViewData["drzave"];
    Layout = "~/Views/Shared/_Layout_admin.cshtml";

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
            BeginWriteAttribute("href", " href=\"", 1544, "\"", 1635, 6);
            WriteAttributeValue("", 1551, "/SuperAdmin/SuperAdmin/Index?u=", 1551, 31, true);
#nullable restore
#line 70 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 1582, Model.userId, 1582, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1595, "&o=", 1595, 3, true);
#nullable restore
#line 70 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 1598, Model.organisationId, 1598, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1619, "&r=", 1619, 3, true);
#nullable restore
#line 70 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 1622, Model.roleId, 1622, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"sifarnik\">Opšti šifarnik</li>\r\n            <ul id=\"o_s\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1791, "\"", 1879, 6);
            WriteAttributeValue("", 1798, "/SuperAdmin/Drzava/Prikaz?u=", 1798, 28, true);
#nullable restore
#line 74 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 1826, Model.userId, 1826, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1839, "&o=", 1839, 3, true);
#nullable restore
#line 74 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 1842, Model.organisationId, 1842, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1863, "&r=", 1863, 3, true);
#nullable restore
#line 74 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 1866, Model.roleId, 1866, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Država</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1920, "\"", 2005, 6);
            WriteAttributeValue("", 1927, "/SuperAdmin/PTT/Prikaz?u=", 1927, 25, true);
#nullable restore
#line 75 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 1952, Model.userId, 1952, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1965, "&o=", 1965, 3, true);
#nullable restore
#line 75 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 1968, Model.organisationId, 1968, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1989, "&r=", 1989, 3, true);
#nullable restore
#line 75 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 1992, Model.roleId, 1992, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">PTT</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2043, "\"", 2137, 6);
            WriteAttributeValue("", 2050, "/SuperAdmin/Organizacija/Prikaz?u=", 2050, 34, true);
#nullable restore
#line 76 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 2084, Model.userId, 2084, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2097, "&o=", 2097, 3, true);
#nullable restore
#line 76 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 2100, Model.organisationId, 2100, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2121, "&r=", 2121, 3, true);
#nullable restore
#line 76 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 2124, Model.roleId, 2124, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizacija</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2184, "\"", 2287, 6);
            WriteAttributeValue("", 2191, "/SuperAdmin/OrganizacionaJedinica/Prikaz?u=", 2191, 43, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 2234, Model.userId, 2234, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2247, "&o=", 2247, 3, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 2250, Model.organisationId, 2250, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2271, "&r=", 2271, 3, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 2274, Model.roleId, 2274, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizaciona jedinica</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2344, "\"", 2437, 6);
            WriteAttributeValue("", 2351, "/SuperAdmin/KorisnikOrg/Prikaz?u=", 2351, 33, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 2384, Model.userId, 2384, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2397, "&o=", 2397, 3, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 2400, Model.organisationId, 2400, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2421, "&r=", 2421, 3, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 2424, Model.roleId, 2424, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnik-Organizaciona jedinica</a></li>\r\n            </ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2600, "\"", 2694, 6);
            WriteAttributeValue("", 2607, "/SuperAdmin/ProjekatPlan/Prikaz?u=", 2607, 34, true);
#nullable restore
#line 82 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 2641, Model.userId, 2641, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2654, "&o=", 2654, 3, true);
#nullable restore
#line 82 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 2657, Model.organisationId, 2657, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2678, "&r=", 2678, 3, true);
#nullable restore
#line 82 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 2681, Model.roleId, 2681, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2733, "\"", 2836, 6);
            WriteAttributeValue("", 2740, "/SuperAdmin/ProjekatAktivnostPlan/Prikaz?u=", 2740, 43, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 2783, Model.userId, 2783, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2796, "&o=", 2796, 3, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 2799, Model.organisationId, 2799, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2820, "&r=", 2820, 3, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 2823, Model.roleId, 2823, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2976, "\"", 3086, 6);
            WriteAttributeValue("", 2983, "/SuperAdmin/ProjekatAktivnostRealizacija/Prikaz?u=", 2983, 50, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 3033, Model.userId, 3033, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3046, "&o=", 3046, 3, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 3049, Model.organisationId, 3049, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3070, "&r=", 3070, 3, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 3073, Model.roleId, 3073, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3217, "\"", 3307, 6);
            WriteAttributeValue("", 3224, "/SuperAdmin/Korisnik/Prikaz?u=", 3224, 30, true);
#nullable restore
#line 91 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 3254, Model.userId, 3254, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3267, "&o=", 3267, 3, true);
#nullable restore
#line 91 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 3270, Model.organisationId, 3270, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3291, "&r=", 3291, 3, true);
#nullable restore
#line 91 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 3294, Model.roleId, 3294, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnici</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3351, "\"", 3438, 6);
            WriteAttributeValue("", 3358, "/SuperAdmin/Uloge/Prikaz?u=", 3358, 27, true);
#nullable restore
#line 92 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 3385, Model.userId, 3385, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3398, "&o=", 3398, 3, true);
#nullable restore
#line 92 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 3401, Model.organisationId, 3401, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3422, "&r=", 3422, 3, true);
#nullable restore
#line 92 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 3425, Model.roleId, 3425, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uloge</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3478, "\"", 3566, 6);
            WriteAttributeValue("", 3485, "/SuperAdmin/Status/Prikaz?u=", 3485, 28, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 3513, Model.userId, 3513, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3526, "&o=", 3526, 3, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 3529, Model.organisationId, 3529, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3550, "&r=", 3550, 3, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 3553, Model.roleId, 3553, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Statusi</a></li>\r\n            </ul>\r\n        </ul>\r\n    </div>\r\n</div>\r\n\r\n<center>\r\n    <h1>Prikaz Država</h1>\r\n    <div id=\"dugmad\">\r\n        <div id=\"dodaj\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 3743, "\"", 3829, 6);
            WriteAttributeValue("", 3750, "/SuperAdmin/Drzava/Unos?u=", 3750, 26, true);
#nullable restore
#line 103 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 3776, Model.userId, 3776, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3789, "&o=", 3789, 3, true);
#nullable restore
#line 103 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 3792, Model.organisationId, 3792, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3813, "&r=", 3813, 3, true);
#nullable restore
#line 103 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 3816, Model.roleId, 3816, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Dodaj novu</a>\r\n        </div>\r\n    </div>\r\n    <table class=\"table\">\r\n        <thead>\r\n        <th>Šifra</th>\r\n        <th>Naziv</th>\r\n        <th>Akcija</th>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 113 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
             foreach (var x in lista)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 116 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
               Write(x.Sifra);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 117 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
               Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 4261, "\"", 4365, 8);
            WriteAttributeValue("", 4268, "/SuperAdmin/Drzava/Uredi?id=", 4268, 28, true);
#nullable restore
#line 119 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 4296, x.Drazava_ID, 4296, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4309, "&u=", 4309, 3, true);
#nullable restore
#line 119 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 4312, Model.userId, 4312, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4325, "&o=", 4325, 3, true);
#nullable restore
#line 119 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 4328, Model.organisationId, 4328, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4349, "&r=", 4349, 3, true);
#nullable restore
#line 119 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 4352, Model.roleId, 4352, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uredi</a>\r\n\r\n                    <a");
            BeginWriteAttribute("id", " id=\"", 4402, "\"", 4427, 2);
            WriteAttributeValue("", 4407, "ukloni_", 4407, 7, true);
#nullable restore
#line 121 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
WriteAttributeValue("", 4414, x.Drazava_ID, 4414, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\" style=\"color:white\">Ukloni</a>\r\n                    <script>\r\n                        $(\"#ukloni_");
#nullable restore
#line 123 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
                              Write(x.Drazava_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""").click(function () {
                            var t = confirm(""Da li ste sigurni da želite obrisati odabrani podatak?"");

                            if (t===true)
                                window.location.href = ""/SuperAdmin/Drzava/Ukloni?id=");
#nullable restore
#line 127 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
                                                                                Write(x.Drazava_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("&u=");
#nullable restore
#line 127 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
                                                                                                Write(Model.userId);

#line default
#line hidden
#nullable disable
            WriteLiteral("&o=");
#nullable restore
#line 127 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
                                                                                                                Write(Model.organisationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("&r=");
#nullable restore
#line 127 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
                                                                                                                                        Write(Model.roleId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n                        });\r\n                    </script>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 132 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Drzava\Prikaz.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.VM.uor> Html { get; private set; }
    }
}
#pragma warning restore 1591
