#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c86550ac80bb7434470d9609b37c7d460f5b24f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_ProjekatPlan_Uredi), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/ProjekatPlan/Uredi.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c86550ac80bb7434470d9609b37c7d460f5b24f8", @"/Areas/SuperAdmin/Views/ProjekatPlan/Uredi.cshtml")]
    public class Areas_SuperAdmin_Views_ProjekatPlan_Uredi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
  
    List<OrganizacionaJedinica> lista_org_jed = (List<OrganizacionaJedinica>)ViewData["org_jed"];
    ProjekatPlan p = (ProjekatPlan)ViewData["projekat"];
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
            WriteLiteral("ize: 1vw;\r\n        border-radius: 0px 25px 25px 0px;\r\n    }\r\n</style>\r\n\r\n<div id=\"kutijaZaMeni\">\r\n    <div id=\"menu\">\r\n        <br />\r\n        <a style=\"color:white; text-decoration-line:none; font-size:120%;\"");
            BeginWriteAttribute("href", " href=\"", 1677, "\"", 1759, 6);
            WriteAttributeValue("", 1684, "/SuperAdmin/SuperAdmin/Index?u=", 1684, 31, true);
#nullable restore
#line 74 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 1715, id.userId, 1715, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1725, "&o=", 1725, 3, true);
#nullable restore
#line 74 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 1728, id.organisationId, 1728, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1746, "&r=", 1746, 3, true);
#nullable restore
#line 74 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 1749, id.roleId, 1749, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"sifarnik\">Opšti šifarnik</li>\r\n            <ul id=\"o_s\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1915, "\"", 1994, 6);
            WriteAttributeValue("", 1922, "/SuperAdmin/Drzava/Prikaz?u=", 1922, 28, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 1950, id.userId, 1950, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1960, "&o=", 1960, 3, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 1963, id.organisationId, 1963, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1981, "&r=", 1981, 3, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 1984, id.roleId, 1984, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Država</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2035, "\"", 2111, 6);
            WriteAttributeValue("", 2042, "/SuperAdmin/PTT/Prikaz?u=", 2042, 25, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 2067, id.userId, 2067, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2077, "&o=", 2077, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 2080, id.organisationId, 2080, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2098, "&r=", 2098, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 2101, id.roleId, 2101, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">PTT</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2149, "\"", 2234, 6);
            WriteAttributeValue("", 2156, "/SuperAdmin/Organizacija/Prikaz?u=", 2156, 34, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 2190, id.userId, 2190, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2200, "&o=", 2200, 3, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 2203, id.organisationId, 2203, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2221, "&r=", 2221, 3, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 2224, id.roleId, 2224, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizacija</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2281, "\"", 2375, 6);
            WriteAttributeValue("", 2288, "/SuperAdmin/OrganizacionaJedinica/Prikaz?u=", 2288, 43, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 2331, id.userId, 2331, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2341, "&o=", 2341, 3, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 2344, id.organisationId, 2344, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2362, "&r=", 2362, 3, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 2365, id.roleId, 2365, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizaciona jedinica</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2432, "\"", 2516, 6);
            WriteAttributeValue("", 2439, "/SuperAdmin/KorisnikOrg/Prikaz?u=", 2439, 33, true);
#nullable restore
#line 82 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 2472, id.userId, 2472, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2482, "&o=", 2482, 3, true);
#nullable restore
#line 82 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 2485, id.organisationId, 2485, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2503, "&r=", 2503, 3, true);
#nullable restore
#line 82 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 2506, id.roleId, 2506, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnik-Organizaciona jedinica</a></li>\r\n            </ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2679, "\"", 2764, 6);
            WriteAttributeValue("", 2686, "/SuperAdmin/ProjekatPlan/Prikaz?u=", 2686, 34, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 2720, id.userId, 2720, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2730, "&o=", 2730, 3, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 2733, id.organisationId, 2733, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2751, "&r=", 2751, 3, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 2754, id.roleId, 2754, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2803, "\"", 2897, 6);
            WriteAttributeValue("", 2810, "/SuperAdmin/ProjekatAktivnostPlan/Prikaz?u=", 2810, 43, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 2853, id.userId, 2853, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2863, "&o=", 2863, 3, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 2866, id.organisationId, 2866, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2884, "&r=", 2884, 3, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 2887, id.roleId, 2887, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3037, "\"", 3138, 6);
            WriteAttributeValue("", 3044, "/SuperAdmin/ProjekatAktivnostRealizacija/Prikaz?u=", 3044, 50, true);
#nullable restore
#line 91 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 3094, id.userId, 3094, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3104, "&o=", 3104, 3, true);
#nullable restore
#line 91 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 3107, id.organisationId, 3107, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3125, "&r=", 3125, 3, true);
#nullable restore
#line 91 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 3128, id.roleId, 3128, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3269, "\"", 3350, 6);
            WriteAttributeValue("", 3276, "/SuperAdmin/Korisnik/Prikaz?u=", 3276, 30, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 3306, id.userId, 3306, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3316, "&o=", 3316, 3, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 3319, id.organisationId, 3319, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3337, "&r=", 3337, 3, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 3340, id.roleId, 3340, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnici</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3394, "\"", 3472, 6);
            WriteAttributeValue("", 3401, "/SuperAdmin/Uloge/Prikaz?u=", 3401, 27, true);
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 3428, id.userId, 3428, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3438, "&o=", 3438, 3, true);
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 3441, id.organisationId, 3441, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3459, "&r=", 3459, 3, true);
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 3462, id.roleId, 3462, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uloge</a></li>\r\n            </ul>\r\n        </ul>\r\n    </div>\r\n</div>\r\n<center>\r\n    <h1>Uređivanje plana projekta</h1>\r\n    <form method=\"post\" action=\"/SuperAdmin/ProjekatPlan/UrediSnimi\">\r\n\r\n        <input hidden=\"hidden\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 3707, "\"", 3733, 1);
#nullable restore
#line 105 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 3715, p.ProjekatPlan_ID, 3715, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"u\"");
            BeginWriteAttribute("value", " value=\"", 3778, "\"", 3796, 1);
#nullable restore
#line 106 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 3786, id.userId, 3786, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"o\"");
            BeginWriteAttribute("value", " value=\"", 3841, "\"", 3867, 1);
#nullable restore
#line 107 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 3849, id.organisationId, 3849, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"r\"");
            BeginWriteAttribute("value", " value=\"", 3912, "\"", 3930, 1);
#nullable restore
#line 108 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 3920, id.roleId, 3920, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n        <table>\r\n            <tr>\r\n                <td>\r\n                    <label>\r\n                        Naziv\r\n                    </label>\r\n                </td>\r\n                <td>\r\n                    <input name=\"naziv\"");
            BeginWriteAttribute("value", " value=\"", 4169, "\"", 4185, 1);
#nullable restore
#line 118 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 4177, p.Naziv, 4177, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Šifra
                    </label>
                </td>
                <td>
                    <input name=""sifra""");
            BeginWriteAttribute("value", " value=\"", 4447, "\"", 4463, 1);
#nullable restore
#line 128 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 4455, p.Sifra, 4455, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Organizaciona jedinica
                    </label>
                </td>
                <td>
                    <select name=""org_jed"">
                        <option");
            BeginWriteAttribute("value", " value=\"", 4779, "\"", 4814, 1);
#nullable restore
#line 139 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 4787, p.OrganizacionaJedinica_FK, 4787, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 139 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
                                                               Write(p.organizacionaJedinica.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 140 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
                         foreach (var x in lista_org_jed)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 4978, "\"", 5013, 1);
#nullable restore
#line 142 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 4986, x.OrganizacionaJedinica_ID, 4986, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 142 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
                                                                   Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 143 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
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
                        Datum od
                    </label>
                </td>
                <td>
                    <input type=""datetime"" name=""OD""");
            BeginWriteAttribute("value", " value=\"", 5364, "\"", 5382, 1);
#nullable restore
#line 154 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 5372, p.DatumOd, 5372, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Datum do
                    </label>
                </td>
                <td>
                    <input type=""datetime"" name=""DO""");
            BeginWriteAttribute("value", " value=\"", 5658, "\"", 5676, 1);
#nullable restore
#line 164 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 5666, p.DatumDo, 5666, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                </td>\r\n            </tr>\r\n        </table>\r\n\r\n        <button class=\"btn btn-primary\">Snimi</button>\r\n    </form>\r\n</center>");
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