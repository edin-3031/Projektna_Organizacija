#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "919966514c9cef5e60c393856aaf1240487928b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_ProjekatPlan_Prikaz), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/ProjekatPlan/Prikaz.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"919966514c9cef5e60c393856aaf1240487928b4", @"/Areas/SuperAdmin/Views/ProjekatPlan/Prikaz.cshtml")]
    public class Areas_SuperAdmin_Views_ProjekatPlan_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
  
    List<ProjekatPlan> lista = (List<ProjekatPlan>)ViewData["proj_plan"];
    Layout = "~/Views/Shared/_Layout_admin.cshtml";

    uor id = (uor)ViewData["id"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .aktiv {
        background-color: lawngreen;
        font-weight: bold;
    }

    .prek {
        background-color: dodgerblue;
        color: white;
        font-weight: bold;
    }

    .zavrs {
        background-color: orangered;
        color: white;
        font-weight: bold;
    }

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
        /*      ");
            WriteLiteral(@"      background-color:green;*/
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
        font-size: 1vw;
        border-radius: 0px 25px 25px 0px;
    }
</style>
<div id=""kutijaZaMeni"">
    <div id=""menu"">
        <br />
        <a style=""color:white; text-decoration-line:none; font-size:120%;""");
            BeginWriteAttribute("href", " href=\"", 1906, "\"", 1988, 6);
            WriteAttributeValue("", 1913, "/SuperAdmin/SuperAdmin/Index?u=", 1913, 31, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 1944, id.userId, 1944, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1954, "&o=", 1954, 3, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 1957, id.organisationId, 1957, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1975, "&r=", 1975, 3, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 1978, id.roleId, 1978, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"sifarnik\">Opšti šifarnik</li>\r\n            <ul id=\"o_s\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2144, "\"", 2223, 6);
            WriteAttributeValue("", 2151, "/SuperAdmin/Drzava/Prikaz?u=", 2151, 28, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 2179, id.userId, 2179, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2189, "&o=", 2189, 3, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 2192, id.organisationId, 2192, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2210, "&r=", 2210, 3, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 2213, id.roleId, 2213, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Država</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2264, "\"", 2340, 6);
            WriteAttributeValue("", 2271, "/SuperAdmin/PTT/Prikaz?u=", 2271, 25, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 2296, id.userId, 2296, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2306, "&o=", 2306, 3, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 2309, id.organisationId, 2309, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2327, "&r=", 2327, 3, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 2330, id.roleId, 2330, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">PTT</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2378, "\"", 2463, 6);
            WriteAttributeValue("", 2385, "/SuperAdmin/Organizacija/Prikaz?u=", 2385, 34, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 2419, id.userId, 2419, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2429, "&o=", 2429, 3, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 2432, id.organisationId, 2432, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2450, "&r=", 2450, 3, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 2453, id.roleId, 2453, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizacija</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2510, "\"", 2604, 6);
            WriteAttributeValue("", 2517, "/SuperAdmin/OrganizacionaJedinica/Prikaz?u=", 2517, 43, true);
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 2560, id.userId, 2560, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2570, "&o=", 2570, 3, true);
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 2573, id.organisationId, 2573, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2591, "&r=", 2591, 3, true);
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 2594, id.roleId, 2594, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizaciona jedinica</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2661, "\"", 2745, 6);
            WriteAttributeValue("", 2668, "/SuperAdmin/KorisnikOrg/Prikaz?u=", 2668, 33, true);
#nullable restore
#line 97 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 2701, id.userId, 2701, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2711, "&o=", 2711, 3, true);
#nullable restore
#line 97 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 2714, id.organisationId, 2714, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2732, "&r=", 2732, 3, true);
#nullable restore
#line 97 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 2735, id.roleId, 2735, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnik-Organizaciona jedinica</a></li>\r\n            </ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2908, "\"", 2993, 6);
            WriteAttributeValue("", 2915, "/SuperAdmin/ProjekatPlan/Prikaz?u=", 2915, 34, true);
#nullable restore
#line 101 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 2949, id.userId, 2949, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2959, "&o=", 2959, 3, true);
#nullable restore
#line 101 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 2962, id.organisationId, 2962, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2980, "&r=", 2980, 3, true);
#nullable restore
#line 101 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 2983, id.roleId, 2983, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3032, "\"", 3126, 6);
            WriteAttributeValue("", 3039, "/SuperAdmin/ProjekatAktivnostPlan/Prikaz?u=", 3039, 43, true);
#nullable restore
#line 102 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 3082, id.userId, 3082, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3092, "&o=", 3092, 3, true);
#nullable restore
#line 102 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 3095, id.organisationId, 3095, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3113, "&r=", 3113, 3, true);
#nullable restore
#line 102 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 3116, id.roleId, 3116, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3266, "\"", 3367, 6);
            WriteAttributeValue("", 3273, "/SuperAdmin/ProjekatAktivnostRealizacija/Prikaz?u=", 3273, 50, true);
#nullable restore
#line 106 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 3323, id.userId, 3323, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3333, "&o=", 3333, 3, true);
#nullable restore
#line 106 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 3336, id.organisationId, 3336, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3354, "&r=", 3354, 3, true);
#nullable restore
#line 106 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 3357, id.roleId, 3357, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3498, "\"", 3579, 6);
            WriteAttributeValue("", 3505, "/SuperAdmin/Korisnik/Prikaz?u=", 3505, 30, true);
#nullable restore
#line 110 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 3535, id.userId, 3535, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3545, "&o=", 3545, 3, true);
#nullable restore
#line 110 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 3548, id.organisationId, 3548, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3566, "&r=", 3566, 3, true);
#nullable restore
#line 110 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 3569, id.roleId, 3569, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnici</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3623, "\"", 3701, 6);
            WriteAttributeValue("", 3630, "/SuperAdmin/Uloge/Prikaz?u=", 3630, 27, true);
#nullable restore
#line 111 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 3657, id.userId, 3657, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3667, "&o=", 3667, 3, true);
#nullable restore
#line 111 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 3670, id.organisationId, 3670, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3688, "&r=", 3688, 3, true);
#nullable restore
#line 111 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 3691, id.roleId, 3691, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uloge</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3741, "\"", 3820, 6);
            WriteAttributeValue("", 3748, "/SuperAdmin/Status/Prikaz?u=", 3748, 28, true);
#nullable restore
#line 112 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 3776, id.userId, 3776, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3786, "&o=", 3786, 3, true);
#nullable restore
#line 112 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 3789, id.organisationId, 3789, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3807, "&r=", 3807, 3, true);
#nullable restore
#line 112 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 3810, id.roleId, 3810, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Statusi</a></li>\r\n            </ul>\r\n        </ul>\r\n    </div>\r\n</div>\r\n\r\n<center>\r\n    <h1>Prikaz Projetnih Planova</h1>\r\n    <div id=\"dugmad\">\r\n        <div id=\"dodaj\">\r\n            <a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 4032, "\"", 4115, 6);
            WriteAttributeValue("", 4039, "/SuperAdmin/ProjekatPlan/Unos?u=", 4039, 32, true);
#nullable restore
#line 122 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 4071, id.userId, 4071, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4081, "&o=", 4081, 3, true);
#nullable restore
#line 122 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 4084, id.organisationId, 4084, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4102, "&r=", 4102, 3, true);
#nullable restore
#line 122 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 4105, id.roleId, 4105, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Dodaj novi</a>
        </div>
        <div id=""print_excel"">
            <a href=""/SuperAdmin/ProjekatPlan/Excel"" class=""btn btn-info"">Export to Excel</a>
        </div>
    </div>
    <table class=""table"">
        <thead>
        <th>Naziv</th>
        <th>Šifra</th>
        <th>Organizaciona jedinica</th>
        <th>Datum od</th>
        <th>Datum do</th>
        <th>Status</th>
        <th>Akcija</th>
        </thead>
        <tbody>
");
#nullable restore
#line 139 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
             foreach (var x in lista)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 142 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
                   Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 143 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
                   Write(x.Sifra);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 144 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
                   Write(x.organizacionaJedinica.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 145 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
                    Write(x.DatumOd.Date.Day+"."+ x.DatumOd.Date.Month + "." + x.DatumOd.Date.Year + ".");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 146 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
                    Write(x.DatumDo.Date.Day+"."+ x.DatumDo.Date.Month + "." + x.DatumDo.Date.Year + ".");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td");
            BeginWriteAttribute("id", " id=\"", 5038, "\"", 5068, 2);
            WriteAttributeValue("", 5043, "status_", 5043, 7, true);
#nullable restore
#line 147 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 5050, x.ProjekatPlan_ID, 5050, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 147 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
                                                  Write(x.status.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <script>\r\n                        var element = document.getElementById(\"status_");
#nullable restore
#line 149 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
                                                                 Write(x.ProjekatPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""");

                        if (element.innerText == ""Aktivan"") {
                            element.classList.add(""aktiv"");
                        }
                        else if (element.innerText == ""Prekinut"") {
                            element.classList.add(""prek"");
                        }
                        else if (element.innerText == ""Završen"") {
                            element.classList.add(""zavrs"");
                        }
                    </script>
                    <td>
                        <a class=""btn btn-primary""");
            BeginWriteAttribute("href", " href=\"", 5787, "\"", 5893, 8);
            WriteAttributeValue("", 5794, "/SuperAdmin/ProjekatPlan/Uredi?id=", 5794, 34, true);
#nullable restore
#line 162 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 5828, x.ProjekatPlan_ID, 5828, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5846, "&u=", 5846, 3, true);
#nullable restore
#line 162 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 5849, id.userId, 5849, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5859, "&o=", 5859, 3, true);
#nullable restore
#line 162 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 5862, id.organisationId, 5862, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5880, "&r=", 5880, 3, true);
#nullable restore
#line 162 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 5883, id.roleId, 5883, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uredi</a>\r\n                        <a");
            BeginWriteAttribute("id", " id=\"", 5932, "\"", 5962, 2);
            WriteAttributeValue("", 5937, "ukloni_", 5937, 7, true);
#nullable restore
#line 163 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 5944, x.ProjekatPlan_ID, 5944, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\" style=\"color:white\">Ukloni</a>\r\n\r\n                        <span style=\"color:black; position:absolute;float:right;margin-left:1%;\"");
            BeginWriteAttribute("id", " id=\"", 6117, "\"", 6147, 2);
            WriteAttributeValue("", 6122, "poruka_", 6122, 7, true);
#nullable restore
#line 165 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 6129, x.ProjekatPlan_ID, 6129, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sigurni? <a");
            BeginWriteAttribute("href", " href=\"", 6160, "\"", 6267, 8);
            WriteAttributeValue("", 6167, "/SuperAdmin/ProjekatPlan/Ukloni?id=", 6167, 35, true);
#nullable restore
#line 165 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 6202, x.ProjekatPlan_ID, 6202, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6220, "&u=", 6220, 3, true);
#nullable restore
#line 165 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 6223, id.userId, 6223, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6233, "&o=", 6233, 3, true);
#nullable restore
#line 165 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 6236, id.organisationId, 6236, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6254, "&r=", 6254, 3, true);
#nullable restore
#line 165 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 6257, id.roleId, 6257, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:black; font-weight:bold;\">Da</a> <a");
            BeginWriteAttribute("id", " id=\"", 6317, "\"", 6343, 2);
            WriteAttributeValue("", 6322, "no_", 6322, 3, true);
#nullable restore
#line 165 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 6325, x.ProjekatPlan_ID, 6325, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:black;cursor:pointer; font-weight:bold;\">Ne</a></span>\r\n                        <script>\r\n                            $(\"#poruka_");
#nullable restore
#line 167 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
                                  Write(x.ProjekatPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").hide();\r\n\r\n                            $(\"#ukloni_");
#nullable restore
#line 169 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
                                  Write(x.ProjekatPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").click(function () {\r\n\r\n                                $(\"#poruka_");
#nullable restore
#line 171 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
                                      Write(x.ProjekatPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").slideDown();\r\n                            });\r\n\r\n                            $(\"#no_");
#nullable restore
#line 174 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
                              Write(x.ProjekatPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").click(function () {\r\n                                $(\"#poruka_");
#nullable restore
#line 175 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
                                      Write(x.ProjekatPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").slideUp();\r\n                            });\r\n                        </script>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 180 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
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
