#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3e7bb27b1f196a83ec457f02d0d561dcf5503bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_KorisnikOrg_Prikaz), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/KorisnikOrg/Prikaz.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3e7bb27b1f196a83ec457f02d0d561dcf5503bd", @"/Areas/SuperAdmin/Views/KorisnikOrg/Prikaz.cshtml")]
    public class Areas_SuperAdmin_Views_KorisnikOrg_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
  
    List<adminOrg_kor_orgJed_VM> lista = (List<adminOrg_kor_orgJed_VM>)ViewData["kor_org_jed"];
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
            BeginWriteAttribute("href", " href=\"", 1613, "\"", 1695, 6);
            WriteAttributeValue("", 1620, "/SuperAdmin/SuperAdmin/Index?u=", 1620, 31, true);
#nullable restore
#line 71 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 1651, id.userId, 1651, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1661, "&o=", 1661, 3, true);
#nullable restore
#line 71 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 1664, id.organisationId, 1664, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1682, "&r=", 1682, 3, true);
#nullable restore
#line 71 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 1685, id.roleId, 1685, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"sifarnik\">Opšti šifarnik</li>\r\n            <ul id=\"o_s\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1851, "\"", 1930, 6);
            WriteAttributeValue("", 1858, "/SuperAdmin/Drzava/Prikaz?u=", 1858, 28, true);
#nullable restore
#line 75 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 1886, id.userId, 1886, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1896, "&o=", 1896, 3, true);
#nullable restore
#line 75 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 1899, id.organisationId, 1899, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1917, "&r=", 1917, 3, true);
#nullable restore
#line 75 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 1920, id.roleId, 1920, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Država</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1971, "\"", 2047, 6);
            WriteAttributeValue("", 1978, "/SuperAdmin/PTT/Prikaz?u=", 1978, 25, true);
#nullable restore
#line 76 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 2003, id.userId, 2003, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2013, "&o=", 2013, 3, true);
#nullable restore
#line 76 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 2016, id.organisationId, 2016, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2034, "&r=", 2034, 3, true);
#nullable restore
#line 76 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 2037, id.roleId, 2037, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">PTT</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2085, "\"", 2170, 6);
            WriteAttributeValue("", 2092, "/SuperAdmin/Organizacija/Prikaz?u=", 2092, 34, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 2126, id.userId, 2126, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2136, "&o=", 2136, 3, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 2139, id.organisationId, 2139, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2157, "&r=", 2157, 3, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 2160, id.roleId, 2160, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizacija</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2217, "\"", 2311, 6);
            WriteAttributeValue("", 2224, "/SuperAdmin/OrganizacionaJedinica/Prikaz?u=", 2224, 43, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 2267, id.userId, 2267, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2277, "&o=", 2277, 3, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 2280, id.organisationId, 2280, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2298, "&r=", 2298, 3, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 2301, id.roleId, 2301, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizaciona jedinica</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2368, "\"", 2452, 6);
            WriteAttributeValue("", 2375, "/SuperAdmin/KorisnikOrg/Prikaz?u=", 2375, 33, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 2408, id.userId, 2408, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2418, "&o=", 2418, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 2421, id.organisationId, 2421, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2439, "&r=", 2439, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 2442, id.roleId, 2442, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnik-Organizaciona jedinica</a></li>\r\n            </ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2615, "\"", 2700, 6);
            WriteAttributeValue("", 2622, "/SuperAdmin/ProjekatPlan/Prikaz?u=", 2622, 34, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 2656, id.userId, 2656, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2666, "&o=", 2666, 3, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 2669, id.organisationId, 2669, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2687, "&r=", 2687, 3, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 2690, id.roleId, 2690, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2739, "\"", 2833, 6);
            WriteAttributeValue("", 2746, "/SuperAdmin/ProjekatAktivnostPlan/Prikaz?u=", 2746, 43, true);
#nullable restore
#line 84 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 2789, id.userId, 2789, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2799, "&o=", 2799, 3, true);
#nullable restore
#line 84 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 2802, id.organisationId, 2802, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2820, "&r=", 2820, 3, true);
#nullable restore
#line 84 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 2823, id.roleId, 2823, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2973, "\"", 3074, 6);
            WriteAttributeValue("", 2980, "/SuperAdmin/ProjekatAktivnostRealizacija/Prikaz?u=", 2980, 50, true);
#nullable restore
#line 88 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 3030, id.userId, 3030, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3040, "&o=", 3040, 3, true);
#nullable restore
#line 88 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 3043, id.organisationId, 3043, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3061, "&r=", 3061, 3, true);
#nullable restore
#line 88 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 3064, id.roleId, 3064, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3205, "\"", 3286, 6);
            WriteAttributeValue("", 3212, "/SuperAdmin/Korisnik/Prikaz?u=", 3212, 30, true);
#nullable restore
#line 92 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 3242, id.userId, 3242, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3252, "&o=", 3252, 3, true);
#nullable restore
#line 92 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 3255, id.organisationId, 3255, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3273, "&r=", 3273, 3, true);
#nullable restore
#line 92 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 3276, id.roleId, 3276, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnici</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3330, "\"", 3408, 6);
            WriteAttributeValue("", 3337, "/SuperAdmin/Uloge/Prikaz?u=", 3337, 27, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 3364, id.userId, 3364, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3374, "&o=", 3374, 3, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 3377, id.organisationId, 3377, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3395, "&r=", 3395, 3, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 3398, id.roleId, 3398, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uloge</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3448, "\"", 3527, 6);
            WriteAttributeValue("", 3455, "/SuperAdmin/Status/Prikaz?u=", 3455, 28, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 3483, id.userId, 3483, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3493, "&o=", 3493, 3, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 3496, id.organisationId, 3496, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3514, "&r=", 3514, 3, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 3517, id.roleId, 3517, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Statusi</a></li>\r\n            </ul>\r\n        </ul>\r\n    </div>\r\n</div>\r\n<center>\r\n    <h1>Prikaz Korisnika - Organizacione Jedinice</h1>\r\n    <div id=\"dugmad\">\r\n        <div id=\"dodaj\">\r\n            <a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 3754, "\"", 3836, 6);
            WriteAttributeValue("", 3761, "/SuperAdmin/KorisnikOrg/Unos?u=", 3761, 31, true);
#nullable restore
#line 103 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 3792, id.userId, 3792, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3802, "&o=", 3802, 3, true);
#nullable restore
#line 103 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 3805, id.organisationId, 3805, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3823, "&r=", 3823, 3, true);
#nullable restore
#line 103 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 3826, id.roleId, 3826, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Unesi novo</a>
        </div>
        <div id=""print_excel"">
            <a href=""/SuperAdmin/KorisnikOrg/Excel"" class=""btn btn-info"">Export to Excel</a>
        </div>
    </div>
    <table class=""table"">
        <thead>
        <th>Korisnik</th>
        <th>Organizaciona jedinica</th>
        <th>Akcija</th>
        </thead>
");
#nullable restore
#line 115 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
         foreach (var x in lista)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 118 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
               Write(x.korisnik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 119 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
               Write(x.o_j);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 4382, "\"", 4478, 8);
            WriteAttributeValue("", 4389, "/SuperAdmin/KorisnikOrg/Uredi?id=", 4389, 33, true);
#nullable restore
#line 121 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 4422, x.K_O_ID, 4422, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4431, "&u=", 4431, 3, true);
#nullable restore
#line 121 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 4434, id.userId, 4434, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4444, "&o=", 4444, 3, true);
#nullable restore
#line 121 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 4447, id.organisationId, 4447, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4465, "&r=", 4465, 3, true);
#nullable restore
#line 121 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 4468, id.roleId, 4468, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uredi</a>\r\n                    <a");
            BeginWriteAttribute("id", " id=\"", 4513, "\"", 4534, 2);
            WriteAttributeValue("", 4518, "ukloni_", 4518, 7, true);
#nullable restore
#line 122 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 4525, x.K_O_ID, 4525, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\" style=\"color:white\">Ukloni</a>\r\n\r\n                    <span style=\"color:black; position:absolute;float:right;margin-left:1%;\"");
            BeginWriteAttribute("id", " id=\"", 4685, "\"", 4706, 2);
            WriteAttributeValue("", 4690, "poruka_", 4690, 7, true);
#nullable restore
#line 124 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 4697, x.K_O_ID, 4697, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sigurni? <a");
            BeginWriteAttribute("href", " href=\"", 4719, "\"", 4816, 8);
            WriteAttributeValue("", 4726, "/SuperAdmin/KorisnikOrg/Ukloni?id=", 4726, 34, true);
#nullable restore
#line 124 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 4760, x.K_O_ID, 4760, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4769, "&u=", 4769, 3, true);
#nullable restore
#line 124 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 4772, id.userId, 4772, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4782, "&o=", 4782, 3, true);
#nullable restore
#line 124 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 4785, id.organisationId, 4785, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4803, "&r=", 4803, 3, true);
#nullable restore
#line 124 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 4806, id.roleId, 4806, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:black; font-weight:bold;\">Da</a> <a");
            BeginWriteAttribute("id", " id=\"", 4866, "\"", 4883, 2);
            WriteAttributeValue("", 4871, "no_", 4871, 3, true);
#nullable restore
#line 124 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
WriteAttributeValue("", 4874, x.K_O_ID, 4874, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:black;cursor:pointer; font-weight:bold;\">Ne</a></span>\r\n                    <script>\r\n                            $(\"#poruka_");
#nullable restore
#line 126 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
                                  Write(x.K_O_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").hide();\r\n\r\n                            $(\"#ukloni_");
#nullable restore
#line 128 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
                                  Write(x.K_O_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").click(function () {\r\n\r\n                                $(\"#poruka_");
#nullable restore
#line 130 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
                                      Write(x.K_O_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").slideDown();\r\n                            });\r\n\r\n                            $(\"#no_");
#nullable restore
#line 133 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
                              Write(x.K_O_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").click(function () {\r\n                                $(\"#poruka_");
#nullable restore
#line 134 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
                                      Write(x.K_O_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").slideUp();\r\n                            });\r\n                    </script>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 139 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\KorisnikOrg\Prikaz.cshtml"
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