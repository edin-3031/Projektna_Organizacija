#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e44295e04f6bb5e78781906ae7d6b62589078e5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_PTT_Prikaz), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/PTT/Prikaz.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e44295e04f6bb5e78781906ae7d6b62589078e5e", @"/Areas/SuperAdmin/Views/PTT/Prikaz.cshtml")]
    public class Areas_SuperAdmin_Views_PTT_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
  

    Layout = "~/Views/Shared/_Layout_admin.cshtml";
    List<PTT> lista = (List<PTT>)ViewData["ptt"];

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
            BeginWriteAttribute("href", " href=\"", 1571, "\"", 1653, 6);
            WriteAttributeValue("", 1578, "/SuperAdmin/SuperAdmin/Index?u=", 1578, 31, true);
#nullable restore
#line 73 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 1609, id.userId, 1609, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1619, "&o=", 1619, 3, true);
#nullable restore
#line 73 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 1622, id.organisationId, 1622, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1640, "&r=", 1640, 3, true);
#nullable restore
#line 73 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 1643, id.roleId, 1643, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"sifarnik\">Opšti šifarnik</li>\r\n            <ul id=\"o_s\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1809, "\"", 1888, 6);
            WriteAttributeValue("", 1816, "/SuperAdmin/Drzava/Prikaz?u=", 1816, 28, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 1844, id.userId, 1844, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1854, "&o=", 1854, 3, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 1857, id.organisationId, 1857, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1875, "&r=", 1875, 3, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 1878, id.roleId, 1878, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Država</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1929, "\"", 2005, 6);
            WriteAttributeValue("", 1936, "/SuperAdmin/PTT/Prikaz?u=", 1936, 25, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 1961, id.userId, 1961, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1971, "&o=", 1971, 3, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 1974, id.organisationId, 1974, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1992, "&r=", 1992, 3, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 1995, id.roleId, 1995, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">PTT</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2043, "\"", 2128, 6);
            WriteAttributeValue("", 2050, "/SuperAdmin/Organizacija/Prikaz?u=", 2050, 34, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 2084, id.userId, 2084, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2094, "&o=", 2094, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 2097, id.organisationId, 2097, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2115, "&r=", 2115, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 2118, id.roleId, 2118, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizacija</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2175, "\"", 2269, 6);
            WriteAttributeValue("", 2182, "/SuperAdmin/OrganizacionaJedinica/Prikaz?u=", 2182, 43, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 2225, id.userId, 2225, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2235, "&o=", 2235, 3, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 2238, id.organisationId, 2238, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2256, "&r=", 2256, 3, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 2259, id.roleId, 2259, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizaciona jedinica</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2326, "\"", 2410, 6);
            WriteAttributeValue("", 2333, "/SuperAdmin/KorisnikOrg/Prikaz?u=", 2333, 33, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 2366, id.userId, 2366, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2376, "&o=", 2376, 3, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 2379, id.organisationId, 2379, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2397, "&r=", 2397, 3, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 2400, id.roleId, 2400, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnik-Organizaciona jedinica</a></li>\r\n            </ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2573, "\"", 2658, 6);
            WriteAttributeValue("", 2580, "/SuperAdmin/ProjekatPlan/Prikaz?u=", 2580, 34, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 2614, id.userId, 2614, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2624, "&o=", 2624, 3, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 2627, id.organisationId, 2627, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2645, "&r=", 2645, 3, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 2648, id.roleId, 2648, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2697, "\"", 2791, 6);
            WriteAttributeValue("", 2704, "/SuperAdmin/ProjekatAktivnostPlan/Prikaz?u=", 2704, 43, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 2747, id.userId, 2747, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2757, "&o=", 2757, 3, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 2760, id.organisationId, 2760, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2778, "&r=", 2778, 3, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 2781, id.roleId, 2781, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2931, "\"", 3032, 6);
            WriteAttributeValue("", 2938, "/SuperAdmin/ProjekatAktivnostRealizacija/Prikaz?u=", 2938, 50, true);
#nullable restore
#line 90 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 2988, id.userId, 2988, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2998, "&o=", 2998, 3, true);
#nullable restore
#line 90 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 3001, id.organisationId, 3001, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3019, "&r=", 3019, 3, true);
#nullable restore
#line 90 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 3022, id.roleId, 3022, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3163, "\"", 3244, 6);
            WriteAttributeValue("", 3170, "/SuperAdmin/Korisnik/Prikaz?u=", 3170, 30, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 3200, id.userId, 3200, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3210, "&o=", 3210, 3, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 3213, id.organisationId, 3213, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3231, "&r=", 3231, 3, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 3234, id.roleId, 3234, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnici</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3288, "\"", 3366, 6);
            WriteAttributeValue("", 3295, "/SuperAdmin/Uloge/Prikaz?u=", 3295, 27, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 3322, id.userId, 3322, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3332, "&o=", 3332, 3, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 3335, id.organisationId, 3335, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3353, "&r=", 3353, 3, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 3356, id.roleId, 3356, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uloge</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3406, "\"", 3485, 6);
            WriteAttributeValue("", 3413, "/SuperAdmin/Status/Prikaz?u=", 3413, 28, true);
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 3441, id.userId, 3441, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3451, "&o=", 3451, 3, true);
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 3454, id.organisationId, 3454, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3472, "&r=", 3472, 3, true);
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 3475, id.roleId, 3475, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Statusi</a></li>\r\n            </ul>\r\n        </ul>\r\n    </div>\r\n</div>\r\n\r\n<center>\r\n    <h1>Prikaz PTT-ova</h1>\r\n    <div id=\"dugmad\">\r\n        <div id=\"dodaj\">\r\n            <a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 3687, "\"", 3761, 6);
            WriteAttributeValue("", 3694, "/SuperAdmin/PTT/Unos?u=", 3694, 23, true);
#nullable restore
#line 106 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 3717, id.userId, 3717, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3727, "&o=", 3727, 3, true);
#nullable restore
#line 106 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 3730, id.organisationId, 3730, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3748, "&r=", 3748, 3, true);
#nullable restore
#line 106 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 3751, id.roleId, 3751, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Dodaj novi</a>\r\n        </div>\r\n    </div>\r\n    <table class=\"table\">\r\n        <thead>\r\n        <th>Naziv</th>\r\n        <th>Šifra</th>\r\n        <th>Akcija</th>\r\n        </thead>\r\n");
#nullable restore
#line 115 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
         foreach (var x in lista)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 118 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
               Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 119 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
               Write(x.Sifra);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 4120, "\"", 4208, 8);
            WriteAttributeValue("", 4127, "/SuperAdmin/PTT/Uredi?id=", 4127, 25, true);
#nullable restore
#line 121 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 4152, x.PTT_ID, 4152, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4161, "&u=", 4161, 3, true);
#nullable restore
#line 121 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 4164, id.userId, 4164, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4174, "&o=", 4174, 3, true);
#nullable restore
#line 121 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 4177, id.organisationId, 4177, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4195, "&r=", 4195, 3, true);
#nullable restore
#line 121 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 4198, id.roleId, 4198, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Uredi</a>\r\n                    <a");
            BeginWriteAttribute("id", " id=\"", 4267, "\"", 4288, 2);
            WriteAttributeValue("", 4272, "ukloni_", 4272, 7, true);
#nullable restore
#line 122 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 4279, x.PTT_ID, 4279, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\" style=\"color:white\">Ukloni</a>\r\n\r\n                    <span style=\"color:black; position:absolute;float:right;margin-left:1%;\"");
            BeginWriteAttribute("id", " id=\"", 4439, "\"", 4460, 2);
            WriteAttributeValue("", 4444, "poruka_", 4444, 7, true);
#nullable restore
#line 124 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 4451, x.PTT_ID, 4451, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sigurni? <a");
            BeginWriteAttribute("href", " href=\"", 4473, "\"", 4562, 8);
            WriteAttributeValue("", 4480, "/SuperAdmin/PTT/Ukloni?id=", 4480, 26, true);
#nullable restore
#line 124 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 4506, x.PTT_ID, 4506, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4515, "&u=", 4515, 3, true);
#nullable restore
#line 124 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 4518, id.userId, 4518, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4528, "&o=", 4528, 3, true);
#nullable restore
#line 124 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 4531, id.organisationId, 4531, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4549, "&r=", 4549, 3, true);
#nullable restore
#line 124 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 4552, id.roleId, 4552, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:black; font-weight:bold;\">Da</a> <a");
            BeginWriteAttribute("id", " id=\"", 4612, "\"", 4629, 2);
            WriteAttributeValue("", 4617, "no_", 4617, 3, true);
#nullable restore
#line 124 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
WriteAttributeValue("", 4620, x.PTT_ID, 4620, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:black;cursor:pointer; font-weight:bold;\">Ne</a></span>\r\n                    <script>\r\n                            $(\"#poruka_");
#nullable restore
#line 126 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
                                  Write(x.PTT_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").hide();\r\n\r\n                            $(\"#ukloni_");
#nullable restore
#line 128 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
                                  Write(x.PTT_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").click(function () {\r\n\r\n                                $(\"#poruka_");
#nullable restore
#line 130 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
                                      Write(x.PTT_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").slideDown();\r\n                            });\r\n\r\n                            $(\"#no_");
#nullable restore
#line 133 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
                              Write(x.PTT_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").click(function () {\r\n                                $(\"#poruka_");
#nullable restore
#line 134 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
                                      Write(x.PTT_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").slideUp();\r\n                            });\r\n                    </script>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 139 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Prikaz.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n\r\n</center>");
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
