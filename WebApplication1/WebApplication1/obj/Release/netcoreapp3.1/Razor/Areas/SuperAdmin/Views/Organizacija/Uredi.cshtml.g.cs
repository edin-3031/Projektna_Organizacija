#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38e49a6ff533280fcf481ede52d7ab31fe635576"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_Organizacija_Uredi), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/Organizacija/Uredi.cshtml")]
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
#line 1 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38e49a6ff533280fcf481ede52d7ab31fe635576", @"/Areas/SuperAdmin/Views/Organizacija/Uredi.cshtml")]
    public class Areas_SuperAdmin_Views_Organizacija_Uredi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.Organizacija>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
  
    Layout = "~/Views/Shared/_Layout_admin.cshtml";

    uor id = (uor)ViewData["id"];

    Organizacija org = (Organizacija)ViewData["organizacija_uredi"];

    List<PTT> lista_ptt = (List<PTT>)ViewData["ptt"];
    List<Drzava> lista_drzava = (List<Drzava>)ViewData["drzava"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
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
        font");
            WriteLiteral("-size: 1vw;\r\n        border-radius: 0px 25px 25px 0px;\r\n    }\r\n</style>\r\n<div id=\"kutijaZaMeni\">\r\n    <div id=\"menu\">\r\n        <br />\r\n        <a style=\"color:white; text-decoration-line:none; font-size:120%;\"");
            BeginWriteAttribute("href", " href=\"", 1637, "\"", 1719, 6);
            WriteAttributeValue("", 1644, "/SuperAdmin/SuperAdmin/Index?u=", 1644, 31, true);
#nullable restore
#line 75 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 1675, id.userId, 1675, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1685, "&o=", 1685, 3, true);
#nullable restore
#line 75 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 1688, id.organisationId, 1688, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1706, "&r=", 1706, 3, true);
#nullable restore
#line 75 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 1709, id.roleId, 1709, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"sifarnik\">Opšti šifarnik</li>\r\n            <ul id=\"o_s\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1875, "\"", 1954, 6);
            WriteAttributeValue("", 1882, "/SuperAdmin/Drzava/Prikaz?u=", 1882, 28, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 1910, id.userId, 1910, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1920, "&o=", 1920, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 1923, id.organisationId, 1923, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1941, "&r=", 1941, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 1944, id.roleId, 1944, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Država</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1995, "\"", 2071, 6);
            WriteAttributeValue("", 2002, "/SuperAdmin/PTT/Prikaz?u=", 2002, 25, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 2027, id.userId, 2027, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2037, "&o=", 2037, 3, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 2040, id.organisationId, 2040, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2058, "&r=", 2058, 3, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 2061, id.roleId, 2061, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">PTT</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2109, "\"", 2194, 6);
            WriteAttributeValue("", 2116, "/SuperAdmin/Organizacija/Prikaz?u=", 2116, 34, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 2150, id.userId, 2150, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2160, "&o=", 2160, 3, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 2163, id.organisationId, 2163, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2181, "&r=", 2181, 3, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 2184, id.roleId, 2184, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizacija</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2241, "\"", 2335, 6);
            WriteAttributeValue("", 2248, "/SuperAdmin/OrganizacionaJedinica/Prikaz?u=", 2248, 43, true);
#nullable restore
#line 82 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 2291, id.userId, 2291, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2301, "&o=", 2301, 3, true);
#nullable restore
#line 82 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 2304, id.organisationId, 2304, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2322, "&r=", 2322, 3, true);
#nullable restore
#line 82 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 2325, id.roleId, 2325, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizaciona jedinica</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2392, "\"", 2476, 6);
            WriteAttributeValue("", 2399, "/SuperAdmin/KorisnikOrg/Prikaz?u=", 2399, 33, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 2432, id.userId, 2432, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2442, "&o=", 2442, 3, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 2445, id.organisationId, 2445, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2463, "&r=", 2463, 3, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 2466, id.roleId, 2466, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnik-Organizaciona jedinica</a></li>\r\n            </ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2639, "\"", 2724, 6);
            WriteAttributeValue("", 2646, "/SuperAdmin/ProjekatPlan/Prikaz?u=", 2646, 34, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 2680, id.userId, 2680, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2690, "&o=", 2690, 3, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 2693, id.organisationId, 2693, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2711, "&r=", 2711, 3, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 2714, id.roleId, 2714, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2763, "\"", 2857, 6);
            WriteAttributeValue("", 2770, "/SuperAdmin/ProjekatAktivnostPlan/Prikaz?u=", 2770, 43, true);
#nullable restore
#line 88 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 2813, id.userId, 2813, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2823, "&o=", 2823, 3, true);
#nullable restore
#line 88 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 2826, id.organisationId, 2826, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2844, "&r=", 2844, 3, true);
#nullable restore
#line 88 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 2847, id.roleId, 2847, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2997, "\"", 3098, 6);
            WriteAttributeValue("", 3004, "/SuperAdmin/ProjekatAktivnostRealizacija/Prikaz?u=", 3004, 50, true);
#nullable restore
#line 92 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 3054, id.userId, 3054, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3064, "&o=", 3064, 3, true);
#nullable restore
#line 92 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 3067, id.organisationId, 3067, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3085, "&r=", 3085, 3, true);
#nullable restore
#line 92 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 3088, id.roleId, 3088, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3229, "\"", 3310, 6);
            WriteAttributeValue("", 3236, "/SuperAdmin/Korisnik/Prikaz?u=", 3236, 30, true);
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 3266, id.userId, 3266, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3276, "&o=", 3276, 3, true);
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 3279, id.organisationId, 3279, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3297, "&r=", 3297, 3, true);
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 3300, id.roleId, 3300, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnici</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3354, "\"", 3432, 6);
            WriteAttributeValue("", 3361, "/SuperAdmin/Uloge/Prikaz?u=", 3361, 27, true);
#nullable restore
#line 97 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 3388, id.userId, 3388, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3398, "&o=", 3398, 3, true);
#nullable restore
#line 97 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 3401, id.organisationId, 3401, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3419, "&r=", 3419, 3, true);
#nullable restore
#line 97 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 3422, id.roleId, 3422, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uloge</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3472, "\"", 3551, 6);
            WriteAttributeValue("", 3479, "/SuperAdmin/Status/Prikaz?u=", 3479, 28, true);
#nullable restore
#line 98 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 3507, id.userId, 3507, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3517, "&o=", 3517, 3, true);
#nullable restore
#line 98 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 3520, id.organisationId, 3520, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3538, "&r=", 3538, 3, true);
#nullable restore
#line 98 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 3541, id.roleId, 3541, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Statusi</a></li>\r\n            </ul>\r\n        </ul>\r\n    </div>\r\n</div>\r\n");
            WriteLiteral("<center>\r\n    <h1>Uredi Organizaciju</h1>\r\n    <form action=\"/SuperAdmin/Organizacija/UrediSnimi\" enctype=\"multipart/form-data\" method=\"post\">\r\n        <input hidden=\"hidden\" name=\"u\"");
            BeginWriteAttribute("value", " value=\"", 4617, "\"", 4635, 1);
#nullable restore
#line 126 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 4625, id.userId, 4625, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"o\"");
            BeginWriteAttribute("value", " value=\"", 4680, "\"", 4706, 1);
#nullable restore
#line 127 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 4688, id.organisationId, 4688, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"r\"");
            BeginWriteAttribute("value", " value=\"", 4751, "\"", 4769, 1);
#nullable restore
#line 128 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 4759, id.roleId, 4759, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"org_id\"");
            BeginWriteAttribute("value", " value=\"", 4819, "\"", 4847, 1);
#nullable restore
#line 129 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 4827, org.Organizacija_ID, 4827, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n        <table>\r\n            <tr>\r\n                <td><label>PTT</label></td>\r\n                <td>\r\n                    <select name=\"ptt\">\r\n                        <option");
            BeginWriteAttribute("value", " value=\"", 5026, "\"", 5045, 1);
#nullable restore
#line 135 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 5034, org.PTT_FK, 5034, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled=\"disabled\">");
#nullable restore
#line 135 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
                                                                   Write(org.ptt.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 136 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
                         foreach (var x in lista_ptt)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 5209, "\"", 5226, 1);
#nullable restore
#line 138 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 5217, x.PTT_ID, 5217, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 138 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
                                                 Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 139 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </select>\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td><label>Država</label></td>\r\n                <td>\r\n                    <select name=\"drzava\">\r\n                        <option");
            BeginWriteAttribute("value", " value=\"", 5510, "\"", 5532, 1);
#nullable restore
#line 147 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 5518, org.Drzava_FK, 5518, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled=\"disabled\">");
#nullable restore
#line 147 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
                                                                      Write(org.drzava.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 148 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
                         foreach (var x in lista_drzava)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 5702, "\"", 5722, 1);
#nullable restore
#line 150 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 5710, x.Drzava_ID, 5710, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 150 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
                                                    Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 151 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </select>\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td><label>Šifra</label></td>\r\n                <td><input name=\"sifra\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 5959, "\"", 5977, 1);
#nullable restore
#line 157 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 5967, org.Sifra, 5967, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n            </tr>\r\n            <tr>\r\n                <td><label>Naziv</label></td>\r\n                <td><input name=\"naziv\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 6122, "\"", 6140, 1);
#nullable restore
#line 161 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 6130, org.Naziv, 6130, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n            </tr>\r\n            <tr>\r\n                <td><label>Adresa</label></td>\r\n                <td><input name=\"adresa\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 6287, "\"", 6306, 1);
#nullable restore
#line 165 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Uredi.cshtml"
WriteAttributeValue("", 6295, org.Adresa, 6295, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n            </tr>\r\n            <tr>\r\n                <td><label>Slika</label></td>\r\n                <td>\r\n");
            WriteLiteral("                    <input style=\"border:0px;\" class=\"form-control file-input\" name=\"slika\" type=\"file\" />\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td><label>Logo</label></td>\r\n                <td>\r\n");
            WriteLiteral(@"                    <input style=""border:0px;"" class=""form-control file-input"" name=""logo"" type=""file"" />
                </td>
            </tr>
        </table>
        <button type=""submit"" class=""btn btn-primary"">Spremi</button>
    </form>
</center>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.Organizacija> Html { get; private set; }
    }
}
#pragma warning restore 1591
