#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc5792f56ca21a8db767404b4d586fd332b5decb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_Organizacija_Prikaz), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/Organizacija/Prikaz.cshtml")]
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
#line 1 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc5792f56ca21a8db767404b4d586fd332b5decb", @"/Areas/SuperAdmin/Views/Organizacija/Prikaz.cshtml")]
    public class Areas_SuperAdmin_Views_Organizacija_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
  
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
            BeginWriteAttribute("href", " href=\"", 1486, "\"", 1568, 6);
            WriteAttributeValue("", 1493, "/SuperAdmin/SuperAdmin/Index?u=", 1493, 31, true);
#nullable restore
#line 69 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 1524, id.userId, 1524, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1534, "&o=", 1534, 3, true);
#nullable restore
#line 69 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 1537, id.organisationId, 1537, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1555, "&r=", 1555, 3, true);
#nullable restore
#line 69 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 1558, id.roleId, 1558, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"sifarnik\">Opšti šifarnik</li>\r\n            <ul id=\"o_s\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1724, "\"", 1803, 6);
            WriteAttributeValue("", 1731, "/SuperAdmin/Drzava/Prikaz?u=", 1731, 28, true);
#nullable restore
#line 73 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 1759, id.userId, 1759, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1769, "&o=", 1769, 3, true);
#nullable restore
#line 73 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 1772, id.organisationId, 1772, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1790, "&r=", 1790, 3, true);
#nullable restore
#line 73 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 1793, id.roleId, 1793, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Država</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1844, "\"", 1920, 6);
            WriteAttributeValue("", 1851, "/SuperAdmin/PTT/Prikaz?u=", 1851, 25, true);
#nullable restore
#line 74 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 1876, id.userId, 1876, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1886, "&o=", 1886, 3, true);
#nullable restore
#line 74 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 1889, id.organisationId, 1889, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1907, "&r=", 1907, 3, true);
#nullable restore
#line 74 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 1910, id.roleId, 1910, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">PTT</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1958, "\"", 2043, 6);
            WriteAttributeValue("", 1965, "/SuperAdmin/Organizacija/Prikaz?u=", 1965, 34, true);
#nullable restore
#line 75 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 1999, id.userId, 1999, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2009, "&o=", 2009, 3, true);
#nullable restore
#line 75 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 2012, id.organisationId, 2012, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2030, "&r=", 2030, 3, true);
#nullable restore
#line 75 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 2033, id.roleId, 2033, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizacija</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2090, "\"", 2184, 6);
            WriteAttributeValue("", 2097, "/SuperAdmin/OrganizacionaJedinica/Prikaz?u=", 2097, 43, true);
#nullable restore
#line 76 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 2140, id.userId, 2140, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2150, "&o=", 2150, 3, true);
#nullable restore
#line 76 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 2153, id.organisationId, 2153, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2171, "&r=", 2171, 3, true);
#nullable restore
#line 76 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 2174, id.roleId, 2174, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizaciona jedinica</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2241, "\"", 2325, 6);
            WriteAttributeValue("", 2248, "/SuperAdmin/KorisnikOrg/Prikaz?u=", 2248, 33, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 2281, id.userId, 2281, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2291, "&o=", 2291, 3, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 2294, id.organisationId, 2294, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2312, "&r=", 2312, 3, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 2315, id.roleId, 2315, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnik-Organizaciona jedinica</a></li>\r\n            </ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2488, "\"", 2573, 6);
            WriteAttributeValue("", 2495, "/SuperAdmin/ProjekatPlan/Prikaz?u=", 2495, 34, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 2529, id.userId, 2529, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2539, "&o=", 2539, 3, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 2542, id.organisationId, 2542, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2560, "&r=", 2560, 3, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 2563, id.roleId, 2563, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2612, "\"", 2706, 6);
            WriteAttributeValue("", 2619, "/SuperAdmin/ProjekatAktivnostPlan/Prikaz?u=", 2619, 43, true);
#nullable restore
#line 82 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 2662, id.userId, 2662, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2672, "&o=", 2672, 3, true);
#nullable restore
#line 82 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 2675, id.organisationId, 2675, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2693, "&r=", 2693, 3, true);
#nullable restore
#line 82 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 2696, id.roleId, 2696, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2846, "\"", 2947, 6);
            WriteAttributeValue("", 2853, "/SuperAdmin/ProjekatAktivnostRealizacija/Prikaz?u=", 2853, 50, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 2903, id.userId, 2903, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2913, "&o=", 2913, 3, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 2916, id.organisationId, 2916, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2934, "&r=", 2934, 3, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 2937, id.roleId, 2937, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3078, "\"", 3159, 6);
            WriteAttributeValue("", 3085, "/SuperAdmin/Korisnik/Prikaz?u=", 3085, 30, true);
#nullable restore
#line 90 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 3115, id.userId, 3115, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3125, "&o=", 3125, 3, true);
#nullable restore
#line 90 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 3128, id.organisationId, 3128, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3146, "&r=", 3146, 3, true);
#nullable restore
#line 90 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 3149, id.roleId, 3149, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnici</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3203, "\"", 3281, 6);
            WriteAttributeValue("", 3210, "/SuperAdmin/Uloge/Prikaz?u=", 3210, 27, true);
#nullable restore
#line 91 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 3237, id.userId, 3237, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3247, "&o=", 3247, 3, true);
#nullable restore
#line 91 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 3250, id.organisationId, 3250, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3268, "&r=", 3268, 3, true);
#nullable restore
#line 91 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 3271, id.roleId, 3271, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uloge</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3321, "\"", 3400, 6);
            WriteAttributeValue("", 3328, "/SuperAdmin/Status/Prikaz?u=", 3328, 28, true);
#nullable restore
#line 92 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 3356, id.userId, 3356, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3366, "&o=", 3366, 3, true);
#nullable restore
#line 92 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 3369, id.organisationId, 3369, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3387, "&r=", 3387, 3, true);
#nullable restore
#line 92 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 3390, id.roleId, 3390, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Statusi</a></li>\r\n            </ul>\r\n        </ul>\r\n    </div>\r\n</div>\r\n");
            WriteLiteral("<center>\r\n    \r\n    <h1>Prikaz Organizacija</h1>\r\n    <div id=\"dugmad\">\r\n        <div id=\"dodaj\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 4328, "\"", 4411, 6);
            WriteAttributeValue("", 4335, "/SuperAdmin/Organizacija/Unos?u=", 4335, 32, true);
#nullable restore
#line 122 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 4367, id.userId, 4367, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4377, "&o=", 4377, 3, true);
#nullable restore
#line 122 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 4380, id.organisationId, 4380, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4398, "&r=", 4398, 3, true);
#nullable restore
#line 122 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 4401, id.roleId, 4401, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-success"">Dodaj novu</a>
        </div>
        <div id=""print_excel"">
            <a href=""/SuperAdmin/Organizacija/Excel"" class=""btn btn-info"">Export to Excel</a>
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
#line 139 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
             foreach (var x in lista_organizacija)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 142 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
                   Write(x.Organizacija_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 143 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
                   Write(x.ptt.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 144 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
                   Write(x.drzava.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 145 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
                   Write(x.Sifra);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 146 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
                   Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 147 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
                   Write(x.Adresa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 5240, "\"", 5346, 8);
            WriteAttributeValue("", 5247, "/SuperAdmin/Organizacija/Uredi?id=", 5247, 34, true);
#nullable restore
#line 148 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 5281, x.Organizacija_ID, 5281, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5299, "&u=", 5299, 3, true);
#nullable restore
#line 148 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 5302, id.userId, 5302, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5312, "&o=", 5312, 3, true);
#nullable restore
#line 148 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 5315, id.organisationId, 5315, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5333, "&r=", 5333, 3, true);
#nullable restore
#line 148 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 5336, id.roleId, 5336, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Uredi</a></td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 5414, "\"", 5521, 8);
            WriteAttributeValue("", 5421, "/SuperAdmin/Organizacija/Ukloni?id=", 5421, 35, true);
#nullable restore
#line 149 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 5456, x.Organizacija_ID, 5456, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5474, "&u=", 5474, 3, true);
#nullable restore
#line 149 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 5477, id.userId, 5477, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5487, "&o=", 5487, 3, true);
#nullable restore
#line 149 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 5490, id.organisationId, 5490, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5508, "&r=", 5508, 3, true);
#nullable restore
#line 149 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
WriteAttributeValue("", 5511, id.roleId, 5511, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Ukloni</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 151 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Prikaz.cshtml"
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
