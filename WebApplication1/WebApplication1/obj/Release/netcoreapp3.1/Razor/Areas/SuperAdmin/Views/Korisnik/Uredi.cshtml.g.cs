#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "932ca9560e079f9fdc7fde749c2061db5454b7ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_Korisnik_Uredi), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/Korisnik/Uredi.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"932ca9560e079f9fdc7fde749c2061db5454b7ce", @"/Areas/SuperAdmin/Views/Korisnik/Uredi.cshtml")]
    public class Areas_SuperAdmin_Views_Korisnik_Uredi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
  
    Layout = "~/Views/Shared/_Layout_admin.cshtml";

    uor id = (uor)ViewData["id"];

    Korisnici k = (Korisnici)ViewData["korisnik"];

    List<Uloge> uloge = (List<Uloge>)ViewData["uloge"];

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
            BeginWriteAttribute("href", " href=\"", 1631, "\"", 1713, 6);
            WriteAttributeValue("", 1638, "/SuperAdmin/SuperAdmin/Index?u=", 1638, 31, true);
#nullable restore
#line 75 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 1669, id.userId, 1669, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1679, "&o=", 1679, 3, true);
#nullable restore
#line 75 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 1682, id.organisationId, 1682, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1700, "&r=", 1700, 3, true);
#nullable restore
#line 75 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 1703, id.roleId, 1703, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"sifarnik\">Opšti šifarnik</li>\r\n            <ul id=\"o_s\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1869, "\"", 1948, 6);
            WriteAttributeValue("", 1876, "/SuperAdmin/Drzava/Prikaz?u=", 1876, 28, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 1904, id.userId, 1904, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1914, "&o=", 1914, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 1917, id.organisationId, 1917, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1935, "&r=", 1935, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 1938, id.roleId, 1938, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Država</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1989, "\"", 2065, 6);
            WriteAttributeValue("", 1996, "/SuperAdmin/PTT/Prikaz?u=", 1996, 25, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 2021, id.userId, 2021, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2031, "&o=", 2031, 3, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 2034, id.organisationId, 2034, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2052, "&r=", 2052, 3, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 2055, id.roleId, 2055, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">PTT</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2103, "\"", 2188, 6);
            WriteAttributeValue("", 2110, "/SuperAdmin/Organizacija/Prikaz?u=", 2110, 34, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 2144, id.userId, 2144, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2154, "&o=", 2154, 3, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 2157, id.organisationId, 2157, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2175, "&r=", 2175, 3, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 2178, id.roleId, 2178, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizacija</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2235, "\"", 2329, 6);
            WriteAttributeValue("", 2242, "/SuperAdmin/OrganizacionaJedinica/Prikaz?u=", 2242, 43, true);
#nullable restore
#line 82 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 2285, id.userId, 2285, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2295, "&o=", 2295, 3, true);
#nullable restore
#line 82 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 2298, id.organisationId, 2298, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2316, "&r=", 2316, 3, true);
#nullable restore
#line 82 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 2319, id.roleId, 2319, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizaciona jedinica</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2386, "\"", 2470, 6);
            WriteAttributeValue("", 2393, "/SuperAdmin/KorisnikOrg/Prikaz?u=", 2393, 33, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 2426, id.userId, 2426, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2436, "&o=", 2436, 3, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 2439, id.organisationId, 2439, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2457, "&r=", 2457, 3, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 2460, id.roleId, 2460, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnik-Organizaciona jedinica</a></li>\r\n            </ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2633, "\"", 2718, 6);
            WriteAttributeValue("", 2640, "/SuperAdmin/ProjekatPlan/Prikaz?u=", 2640, 34, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 2674, id.userId, 2674, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2684, "&o=", 2684, 3, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 2687, id.organisationId, 2687, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2705, "&r=", 2705, 3, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 2708, id.roleId, 2708, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2757, "\"", 2851, 6);
            WriteAttributeValue("", 2764, "/SuperAdmin/ProjekatAktivnostPlan/Prikaz?u=", 2764, 43, true);
#nullable restore
#line 88 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 2807, id.userId, 2807, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2817, "&o=", 2817, 3, true);
#nullable restore
#line 88 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 2820, id.organisationId, 2820, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2838, "&r=", 2838, 3, true);
#nullable restore
#line 88 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 2841, id.roleId, 2841, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2991, "\"", 3092, 6);
            WriteAttributeValue("", 2998, "/SuperAdmin/ProjekatAktivnostRealizacija/Prikaz?u=", 2998, 50, true);
#nullable restore
#line 92 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 3048, id.userId, 3048, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3058, "&o=", 3058, 3, true);
#nullable restore
#line 92 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 3061, id.organisationId, 3061, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3079, "&r=", 3079, 3, true);
#nullable restore
#line 92 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 3082, id.roleId, 3082, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3223, "\"", 3304, 6);
            WriteAttributeValue("", 3230, "/SuperAdmin/Korisnik/Prikaz?u=", 3230, 30, true);
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 3260, id.userId, 3260, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3270, "&o=", 3270, 3, true);
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 3273, id.organisationId, 3273, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3291, "&r=", 3291, 3, true);
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 3294, id.roleId, 3294, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnici</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3348, "\"", 3426, 6);
            WriteAttributeValue("", 3355, "/SuperAdmin/Uloge/Prikaz?u=", 3355, 27, true);
#nullable restore
#line 97 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 3382, id.userId, 3382, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3392, "&o=", 3392, 3, true);
#nullable restore
#line 97 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 3395, id.organisationId, 3395, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3413, "&r=", 3413, 3, true);
#nullable restore
#line 97 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 3416, id.roleId, 3416, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uloge</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3466, "\"", 3545, 6);
            WriteAttributeValue("", 3473, "/SuperAdmin/Status/Prikaz?u=", 3473, 28, true);
#nullable restore
#line 98 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 3501, id.userId, 3501, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3511, "&o=", 3511, 3, true);
#nullable restore
#line 98 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 3514, id.organisationId, 3514, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3532, "&r=", 3532, 3, true);
#nullable restore
#line 98 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 3535, id.roleId, 3535, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Statusi</a></li>\r\n            </ul>\r\n        </ul>\r\n    </div>\r\n</div>\r\n<center>\r\n    <form method=\"post\" action=\"/SuperAdmin/Korisnik/UrediSnimi\">\r\n\r\n        <input name=\"id\" hidden=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 3738, "\"", 3761, 1);
#nullable restore
#line 106 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 3746, k.Korisnici_ID, 3746, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n        <input name=\"u\" hidden=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 3805, "\"", 3823, 1);
#nullable restore
#line 107 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 3813, id.userId, 3813, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n        <input name=\"o\" hidden=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 3867, "\"", 3893, 1);
#nullable restore
#line 108 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 3875, id.organisationId, 3875, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n        <input name=\"r\" hidden=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 3937, "\"", 3955, 1);
#nullable restore
#line 109 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 3945, id.roleId, 3945, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n\r\n        <table>\r\n            <tr>\r\n                <td>\r\n                    <label>Ime</label>\r\n                </td>\r\n                <td>\r\n                    <input type=\"text\" name=\"ime\"");
            BeginWriteAttribute("value", " value=\"", 4153, "\"", 4167, 1);
#nullable restore
#line 117 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 4161, k.Ime, 4161, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    <label>Prezime</label>\r\n                </td>\r\n                <td>\r\n                    <input type=\"text\" name=\"prezime\"");
            BeginWriteAttribute("value", " value=\"", 4396, "\"", 4414, 1);
#nullable restore
#line 125 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 4404, k.Prezime, 4404, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    <label>Šifra</label>\r\n                </td>\r\n                <td>\r\n                    <input type=\"text\" name=\"sifra\"");
            BeginWriteAttribute("value", " value=\"", 4639, "\"", 4655, 1);
#nullable restore
#line 133 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 4647, k.Sifra, 4647, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    <label>Korisničko ime</label>\r\n                </td>\r\n                <td>\r\n                    <input type=\"text\" name=\"korisnicko_ime\"");
            BeginWriteAttribute("value", " value=\"", 4898, "\"", 4923, 1);
#nullable restore
#line 141 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 4906, k.Korisnicko_Ime, 4906, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    <label>Lozinka</label>\r\n                </td>\r\n                <td>\r\n                    <input type=\"text\" name=\"lozinka\"");
            BeginWriteAttribute("value", " value=\"", 5152, "\"", 5170, 1);
#nullable restore
#line 149 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 5160, k.Lozinka, 5160, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    <label>Mail</label>\r\n                </td>\r\n                <td>\r\n                    <input type=\"text\" name=\"mail\"");
            BeginWriteAttribute("value", " value=\"", 5393, "\"", 5408, 1);
#nullable restore
#line 157 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 5401, k.Mail, 5401, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    <label>Telefon</label>\r\n                </td>\r\n                <td>\r\n                    <input type=\"text\" name=\"telefon\"");
            BeginWriteAttribute("value", " value=\"", 5637, "\"", 5655, 1);
#nullable restore
#line 165 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 5645, k.Telefon, 5645, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    <label>Uloga</label>\r\n                </td>\r\n                <td>\r\n                    <select name=\"uloga\">\r\n                        <option");
            BeginWriteAttribute("value", " value=\"", 5903, "\"", 5922, 1);
#nullable restore
#line 174 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 5911, k.Uloge_FK, 5911, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 174 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
                                               Write(k.uloge.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 175 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
                         foreach (var x in uloge)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 6062, "\"", 6081, 1);
#nullable restore
#line 177 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
WriteAttributeValue("", 6070, x.Uloge_ID, 6070, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 177 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
                                                   Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 178 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Korisnik\Uredi.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </select>\r\n                    \r\n                </td>\r\n            </tr>\r\n        </table>\r\n\r\n        <button class=\"btn btn-primary\">Snimi</button>\r\n    </form>\r\n</center>");
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
