#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7248124f2099d63848854fda767486c3bb46d5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_ProjekatAktivnostPlan_Prikaz), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/ProjekatAktivnostPlan/Prikaz.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7248124f2099d63848854fda767486c3bb46d5d", @"/Areas/SuperAdmin/Views/ProjekatAktivnostPlan/Prikaz.cshtml")]
    public class Areas_SuperAdmin_Views_ProjekatAktivnostPlan_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
  
    List<ProjekatAktivnostPlan> lista = (List<ProjekatAktivnostPlan>)ViewData["pro_aktiv_plan"];
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
            BeginWriteAttribute("href", " href=\"", 1616, "\"", 1698, 6);
            WriteAttributeValue("", 1623, "/SuperAdmin/SuperAdmin/Index?u=", 1623, 31, true);
#nullable restore
#line 72 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 1654, id.userId, 1654, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1664, "&o=", 1664, 3, true);
#nullable restore
#line 72 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 1667, id.organisationId, 1667, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1685, "&r=", 1685, 3, true);
#nullable restore
#line 72 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 1688, id.roleId, 1688, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"sifarnik\">Opšti šifarnik</li>\r\n            <ul id=\"o_s\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1854, "\"", 1933, 6);
            WriteAttributeValue("", 1861, "/SuperAdmin/Drzava/Prikaz?u=", 1861, 28, true);
#nullable restore
#line 76 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 1889, id.userId, 1889, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1899, "&o=", 1899, 3, true);
#nullable restore
#line 76 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 1902, id.organisationId, 1902, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1920, "&r=", 1920, 3, true);
#nullable restore
#line 76 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 1923, id.roleId, 1923, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Država</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1974, "\"", 2050, 6);
            WriteAttributeValue("", 1981, "/SuperAdmin/PTT/Prikaz?u=", 1981, 25, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2006, id.userId, 2006, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2016, "&o=", 2016, 3, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2019, id.organisationId, 2019, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2037, "&r=", 2037, 3, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2040, id.roleId, 2040, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">PTT</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2088, "\"", 2173, 6);
            WriteAttributeValue("", 2095, "/SuperAdmin/Organizacija/Prikaz?u=", 2095, 34, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2129, id.userId, 2129, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2139, "&o=", 2139, 3, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2142, id.organisationId, 2142, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2160, "&r=", 2160, 3, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2163, id.roleId, 2163, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizacija</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2220, "\"", 2314, 6);
            WriteAttributeValue("", 2227, "/SuperAdmin/OrganizacionaJedinica/Prikaz?u=", 2227, 43, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2270, id.userId, 2270, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2280, "&o=", 2280, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2283, id.organisationId, 2283, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2301, "&r=", 2301, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2304, id.roleId, 2304, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizaciona jedinica</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2371, "\"", 2455, 6);
            WriteAttributeValue("", 2378, "/SuperAdmin/KorisnikOrg/Prikaz?u=", 2378, 33, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2411, id.userId, 2411, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2421, "&o=", 2421, 3, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2424, id.organisationId, 2424, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2442, "&r=", 2442, 3, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2445, id.roleId, 2445, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnik-Organizaciona jedinica</a></li>\r\n            </ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2618, "\"", 2703, 6);
            WriteAttributeValue("", 2625, "/SuperAdmin/ProjekatPlan/Prikaz?u=", 2625, 34, true);
#nullable restore
#line 84 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2659, id.userId, 2659, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2669, "&o=", 2669, 3, true);
#nullable restore
#line 84 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2672, id.organisationId, 2672, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2690, "&r=", 2690, 3, true);
#nullable restore
#line 84 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2693, id.roleId, 2693, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2742, "\"", 2836, 6);
            WriteAttributeValue("", 2749, "/SuperAdmin/ProjekatAktivnostPlan/Prikaz?u=", 2749, 43, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2792, id.userId, 2792, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2802, "&o=", 2802, 3, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2805, id.organisationId, 2805, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2823, "&r=", 2823, 3, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2826, id.roleId, 2826, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2976, "\"", 3077, 6);
            WriteAttributeValue("", 2983, "/SuperAdmin/ProjekatAktivnostRealizacija/Prikaz?u=", 2983, 50, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 3033, id.userId, 3033, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3043, "&o=", 3043, 3, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 3046, id.organisationId, 3046, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3064, "&r=", 3064, 3, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 3067, id.roleId, 3067, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3208, "\"", 3289, 6);
            WriteAttributeValue("", 3215, "/SuperAdmin/Korisnik/Prikaz?u=", 3215, 30, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 3245, id.userId, 3245, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3255, "&o=", 3255, 3, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 3258, id.organisationId, 3258, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3276, "&r=", 3276, 3, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 3279, id.roleId, 3279, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnici</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3333, "\"", 3411, 6);
            WriteAttributeValue("", 3340, "/SuperAdmin/Uloge/Prikaz?u=", 3340, 27, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 3367, id.userId, 3367, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3377, "&o=", 3377, 3, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 3380, id.organisationId, 3380, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3398, "&r=", 3398, 3, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 3401, id.roleId, 3401, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uloge</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3451, "\"", 3530, 6);
            WriteAttributeValue("", 3458, "/SuperAdmin/Status/Prikaz?u=", 3458, 28, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 3486, id.userId, 3486, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3496, "&o=", 3496, 3, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 3499, id.organisationId, 3499, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3517, "&r=", 3517, 3, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 3520, id.roleId, 3520, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Statusi</a></li>\r\n            </ul>\r\n        </ul>\r\n    </div>\r\n</div>\r\n\r\n<center>\r\n    <h1>Prikaz Projektnih aktivnosti</h1>\r\n    <div id=\"dugmad\">\r\n        <div id=\"dodaj\">\r\n            <a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 3746, "\"", 3838, 6);
            WriteAttributeValue("", 3753, "/SuperAdmin/ProjekatAktivnostPlan/Unos?u=", 3753, 41, true);
#nullable restore
#line 105 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 3794, id.userId, 3794, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3804, "&o=", 3804, 3, true);
#nullable restore
#line 105 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 3807, id.organisationId, 3807, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3825, "&r=", 3825, 3, true);
#nullable restore
#line 105 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 3828, id.roleId, 3828, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Dodaj novi</a>
        </div>
        <div id=""print_excel"">
            <a href=""/SuperAdmin/ProjekatAktivnostPlan/Excel"" class=""btn btn-info"">Export to Excel</a>
        </div>
    </div>
    <table class=""table"">
        <thead>
        <th>Naziv</th>
        <th>Šifra</th>
        <th>Projekat plan</th>
        <th>Datum od</th>
        <th>Datum do</th>
        <th>Jedinica mjere</th>
        <th>Količina</th>
        <th>Akcija</th>
        </thead>
        <tbody>
");
#nullable restore
#line 123 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
             foreach (var x in lista)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 126 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                   Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 127 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                   Write(x.Sifra);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 128 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                   Write(x.projekatPlan.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 129 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                    Write(x.DatumOd.Date.Day+"."+ x.DatumOd.Date.Month + "." + x.DatumOd.Date.Year + ".");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 130 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                    Write(x.DatumDo.Date.Day+"."+ x.DatumDo.Date.Month + "." + x.DatumDo.Date.Year + ".");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 131 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                   Write(x.JedinicaMjere);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 132 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                   Write(x.Kolicina);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 4929, "\"", 5053, 8);
            WriteAttributeValue("", 4936, "/SuperAdmin/ProjekatAktivnostPlan/Uredi?id=", 4936, 43, true);
#nullable restore
#line 134 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 4979, x.ProjekatAktivnostPlan_ID, 4979, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5006, "&u=", 5006, 3, true);
#nullable restore
#line 134 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 5009, id.userId, 5009, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5019, "&o=", 5019, 3, true);
#nullable restore
#line 134 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 5022, id.organisationId, 5022, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5040, "&r=", 5040, 3, true);
#nullable restore
#line 134 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 5043, id.roleId, 5043, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uredi</a>\r\n                        <a");
            BeginWriteAttribute("id", " id=\"", 5092, "\"", 5131, 2);
            WriteAttributeValue("", 5097, "ukloni_", 5097, 7, true);
#nullable restore
#line 135 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 5104, x.ProjekatAktivnostPlan_ID, 5104, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\" style=\"color:white\">Ukloni</a>\r\n\r\n                        <span style=\"color:black; position:absolute;float:right;margin-left:1%;\"");
            BeginWriteAttribute("id", " id=\"", 5286, "\"", 5325, 2);
            WriteAttributeValue("", 5291, "poruka_", 5291, 7, true);
#nullable restore
#line 137 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 5298, x.ProjekatAktivnostPlan_ID, 5298, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sigurni? <a");
            BeginWriteAttribute("href", " href=\"", 5338, "\"", 5463, 8);
            WriteAttributeValue("", 5345, "/SuperAdmin/ProjekatAktivnostPlan/Ukloni?id=", 5345, 44, true);
#nullable restore
#line 137 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 5389, x.ProjekatAktivnostPlan_ID, 5389, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5416, "&u=", 5416, 3, true);
#nullable restore
#line 137 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 5419, id.userId, 5419, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5429, "&o=", 5429, 3, true);
#nullable restore
#line 137 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 5432, id.organisationId, 5432, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5450, "&r=", 5450, 3, true);
#nullable restore
#line 137 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 5453, id.roleId, 5453, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:black; font-weight:bold;\">Da</a> <a");
            BeginWriteAttribute("id", " id=\"", 5513, "\"", 5548, 2);
            WriteAttributeValue("", 5518, "no_", 5518, 3, true);
#nullable restore
#line 137 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 5521, x.ProjekatAktivnostPlan_ID, 5521, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:black;cursor:pointer; font-weight:bold;\">Ne</a></span>\r\n                        <script>\r\n                            $(\"#poruka_");
#nullable restore
#line 139 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                                  Write(x.ProjekatAktivnostPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").hide();\r\n\r\n                            $(\"#ukloni_");
#nullable restore
#line 141 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                                  Write(x.ProjekatAktivnostPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").click(function () {\r\n\r\n                                $(\"#poruka_");
#nullable restore
#line 143 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                                      Write(x.ProjekatAktivnostPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").slideDown();\r\n                            });\r\n\r\n                            $(\"#no_");
#nullable restore
#line 146 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                              Write(x.ProjekatAktivnostPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").click(function () {\r\n                                $(\"#poruka_");
#nullable restore
#line 147 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                                      Write(x.ProjekatAktivnostPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").slideUp();\r\n                            });\r\n                        </script>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 152 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</center>\r\n\r\n\r\n");
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