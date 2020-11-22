#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9500e03bee61cfb915967e26a1cf562d01c4a0e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_OrganizacionaJedinica_Unos), @"mvc.1.0.view", @"/Areas/Admin/Views/OrganizacionaJedinica/Unos.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9500e03bee61cfb915967e26a1cf562d01c4a0e7", @"/Areas/Admin/Views/OrganizacionaJedinica/Unos.cshtml")]
    public class Areas_Admin_Views_OrganizacionaJedinica_Unos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
  
    List<Organizacija> lista_organicija = (List<Organizacija>)ViewData["organizacije"];
    List<PTT> lista_ptt = (List<PTT>)ViewData["ptt"];
    List<Drzava> lista_drzava = (List<Drzava>)ViewData["drzava"];
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
            BeginWriteAttribute("href", " href=\"", 1729, "\"", 1801, 6);
            WriteAttributeValue("", 1736, "/Admin/Admin/Index?u=", 1736, 21, true);
#nullable restore
#line 74 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 1757, id.userId, 1757, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1767, "&o=", 1767, 3, true);
#nullable restore
#line 74 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 1770, id.organisationId, 1770, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1788, "&r=", 1788, 3, true);
#nullable restore
#line 74 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 1791, id.roleId, 1791, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"sifarnik\">Opšti šifarnik</li>\r\n            <ul id=\"o_s\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1957, "\"", 2031, 6);
            WriteAttributeValue("", 1964, "/Admin/Drzava/Prikaz?u=", 1964, 23, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 1987, id.userId, 1987, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1997, "&o=", 1997, 3, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2000, id.organisationId, 2000, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2018, "&r=", 2018, 3, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2021, id.roleId, 2021, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Država</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2072, "\"", 2143, 6);
            WriteAttributeValue("", 2079, "/Admin/PTT/Prikaz?u=", 2079, 20, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2099, id.userId, 2099, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2109, "&o=", 2109, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2112, id.organisationId, 2112, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2130, "&r=", 2130, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2133, id.roleId, 2133, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">PTT</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2181, "\"", 2261, 6);
            WriteAttributeValue("", 2188, "/Admin/Organizacija/Prikaz?u=", 2188, 29, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2217, id.userId, 2217, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2227, "&o=", 2227, 3, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2230, id.organisationId, 2230, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2248, "&r=", 2248, 3, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2251, id.roleId, 2251, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizacija</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2308, "\"", 2397, 6);
            WriteAttributeValue("", 2315, "/Admin/OrganizacionaJedinica/Prikaz?u=", 2315, 38, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2353, id.userId, 2353, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2363, "&o=", 2363, 3, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2366, id.organisationId, 2366, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2384, "&r=", 2384, 3, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2387, id.roleId, 2387, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizaciona jedinica</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2454, "\"", 2533, 6);
            WriteAttributeValue("", 2461, "/Admin/KorisnikOrg/Prikaz?u=", 2461, 28, true);
#nullable restore
#line 82 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2489, id.userId, 2489, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2499, "&o=", 2499, 3, true);
#nullable restore
#line 82 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2502, id.organisationId, 2502, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2520, "&r=", 2520, 3, true);
#nullable restore
#line 82 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2523, id.roleId, 2523, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnik-Organizaciona jedinica</a></li>\r\n            </ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2696, "\"", 2776, 6);
            WriteAttributeValue("", 2703, "/Admin/ProjekatPlan/Prikaz?u=", 2703, 29, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2732, id.userId, 2732, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2742, "&o=", 2742, 3, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2745, id.organisationId, 2745, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2763, "&r=", 2763, 3, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2766, id.roleId, 2766, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2815, "\"", 2904, 6);
            WriteAttributeValue("", 2822, "/Admin/ProjekatAktivnostPlan/Prikaz?u=", 2822, 38, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2860, id.userId, 2860, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2870, "&o=", 2870, 3, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2873, id.organisationId, 2873, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2891, "&r=", 2891, 3, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2894, id.roleId, 2894, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3044, "\"", 3140, 6);
            WriteAttributeValue("", 3051, "/Admin/ProjekatAktivnostRealizacija/Prikaz?u=", 3051, 45, true);
#nullable restore
#line 91 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 3096, id.userId, 3096, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3106, "&o=", 3106, 3, true);
#nullable restore
#line 91 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 3109, id.organisationId, 3109, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3127, "&r=", 3127, 3, true);
#nullable restore
#line 91 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 3130, id.roleId, 3130, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3271, "\"", 3347, 6);
            WriteAttributeValue("", 3278, "/Admin/Korisnik/Prikaz?u=", 3278, 25, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 3303, id.userId, 3303, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3313, "&o=", 3313, 3, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 3316, id.organisationId, 3316, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3334, "&r=", 3334, 3, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 3337, id.roleId, 3337, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnici</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3391, "\"", 3464, 6);
            WriteAttributeValue("", 3398, "/Admin/Uloge/Prikaz?u=", 3398, 22, true);
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 3420, id.userId, 3420, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3430, "&o=", 3430, 3, true);
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 3433, id.organisationId, 3433, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3451, "&r=", 3451, 3, true);
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 3454, id.roleId, 3454, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uloge</a></li>\r\n            </ul>\r\n        </ul>\r\n    </div>\r\n</div>\r\n");
            WriteLiteral("<center>\r\n    <h1>Unos Organizacione jedinice</h1>\r\n    <form method=\"post\" action=\"/Admin/OrganizacionaJedinica/UnosSnimi\">\r\n\r\n        <input hidden=\"hidden\" name=\"u\"");
            BeginWriteAttribute("value", " value=\"", 4444, "\"", 4462, 1);
#nullable restore
#line 125 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 4452, id.userId, 4452, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"o\"");
            BeginWriteAttribute("value", " value=\"", 4507, "\"", 4533, 1);
#nullable restore
#line 126 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 4515, id.organisationId, 4515, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"r\"");
            BeginWriteAttribute("value", " value=\"", 4578, "\"", 4596, 1);
#nullable restore
#line 127 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 4586, id.roleId, 4586, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />

        <table>
            <tr>
                <td>
                    <label>
                        Organizacija
                    </label>
                </td>
                <td>
                    <select name=""organizacija"">
                        <option>---Odaberi---</option>
");
#nullable restore
#line 139 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
                         foreach (var x in lista_organicija)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 5033, "\"", 5059, 1);
#nullable restore
#line 141 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 5041, x.Organizacija_ID, 5041, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 141 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
                                                          Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 142 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </select>
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        PTT
                    </label>
                </td>
                <td>
                    <select name=""ptt"">
                        <option>---Odaberi---</option>
");
#nullable restore
#line 155 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
                         foreach (var x in lista_ptt)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 5567, "\"", 5584, 1);
#nullable restore
#line 157 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 5575, x.PTT_ID, 5575, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 157 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
                                                 Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 158 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </select>
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Država
                    </label>
                </td>
                <td>
                    <select name=""drzava"">
                        <option>---Odaberi---</option>
");
#nullable restore
#line 171 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
                         foreach (var x in lista_drzava)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 6101, "\"", 6122, 1);
#nullable restore
#line 173 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 6109, x.Drazava_ID, 6109, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 173 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
                                                     Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 174 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\OrganizacionaJedinica\Unos.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </select>
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Naziv
                    </label>
                </td>
                <td>
                    <input type=""text"" name=""naziv"" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Adresa
                    </label>
                </td>
                <td>
                    <input type=""text"" name=""adresa"" />
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591