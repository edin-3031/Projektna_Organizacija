#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac2e3a42fd8c50cfcf40603299bbbdd9cc7f4f39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_ProjekatPlan_Unos), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/ProjekatPlan/Unos.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac2e3a42fd8c50cfcf40603299bbbdd9cc7f4f39", @"/Areas/SuperAdmin/Views/ProjekatPlan/Unos.cshtml")]
    public class Areas_SuperAdmin_Views_ProjekatPlan_Unos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
  
    Layout = "~/Views/Shared/_Layout_admin.cshtml";
    uor id = (uor)ViewData["id"];

    List<OrganizacionaJedinica> lista_org_jed = (List<OrganizacionaJedinica>)ViewData["lista_org_jed"];
    List<Status> stat_lista = (List<Status>)ViewData["statusi"];

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
            BeginWriteAttribute("href", " href=\"", 1689, "\"", 1771, 6);
            WriteAttributeValue("", 1696, "/SuperAdmin/SuperAdmin/Index?u=", 1696, 31, true);
#nullable restore
#line 73 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 1727, id.userId, 1727, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1737, "&o=", 1737, 3, true);
#nullable restore
#line 73 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 1740, id.organisationId, 1740, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1758, "&r=", 1758, 3, true);
#nullable restore
#line 73 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 1761, id.roleId, 1761, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"sifarnik\">Opšti šifarnik</li>\r\n            <ul id=\"o_s\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1927, "\"", 2006, 6);
            WriteAttributeValue("", 1934, "/SuperAdmin/Drzava/Prikaz?u=", 1934, 28, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 1962, id.userId, 1962, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1972, "&o=", 1972, 3, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 1975, id.organisationId, 1975, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1993, "&r=", 1993, 3, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 1996, id.roleId, 1996, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Država</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2047, "\"", 2123, 6);
            WriteAttributeValue("", 2054, "/SuperAdmin/PTT/Prikaz?u=", 2054, 25, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2079, id.userId, 2079, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2089, "&o=", 2089, 3, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2092, id.organisationId, 2092, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2110, "&r=", 2110, 3, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2113, id.roleId, 2113, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">PTT</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2161, "\"", 2246, 6);
            WriteAttributeValue("", 2168, "/SuperAdmin/Organizacija/Prikaz?u=", 2168, 34, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2202, id.userId, 2202, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2212, "&o=", 2212, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2215, id.organisationId, 2215, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2233, "&r=", 2233, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2236, id.roleId, 2236, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizacija</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2293, "\"", 2387, 6);
            WriteAttributeValue("", 2300, "/SuperAdmin/OrganizacionaJedinica/Prikaz?u=", 2300, 43, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2343, id.userId, 2343, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2353, "&o=", 2353, 3, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2356, id.organisationId, 2356, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2374, "&r=", 2374, 3, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2377, id.roleId, 2377, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizaciona jedinica</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2444, "\"", 2528, 6);
            WriteAttributeValue("", 2451, "/SuperAdmin/KorisnikOrg/Prikaz?u=", 2451, 33, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2484, id.userId, 2484, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2494, "&o=", 2494, 3, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2497, id.organisationId, 2497, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2515, "&r=", 2515, 3, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2518, id.roleId, 2518, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnik-Organizaciona jedinica</a></li>\r\n            </ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2691, "\"", 2776, 6);
            WriteAttributeValue("", 2698, "/SuperAdmin/ProjekatPlan/Prikaz?u=", 2698, 34, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2732, id.userId, 2732, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2742, "&o=", 2742, 3, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2745, id.organisationId, 2745, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2763, "&r=", 2763, 3, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2766, id.roleId, 2766, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2815, "\"", 2909, 6);
            WriteAttributeValue("", 2822, "/SuperAdmin/ProjekatAktivnostPlan/Prikaz?u=", 2822, 43, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2865, id.userId, 2865, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2875, "&o=", 2875, 3, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2878, id.organisationId, 2878, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2896, "&r=", 2896, 3, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2899, id.roleId, 2899, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3049, "\"", 3150, 6);
            WriteAttributeValue("", 3056, "/SuperAdmin/ProjekatAktivnostRealizacija/Prikaz?u=", 3056, 50, true);
#nullable restore
#line 90 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3106, id.userId, 3106, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3116, "&o=", 3116, 3, true);
#nullable restore
#line 90 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3119, id.organisationId, 3119, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3137, "&r=", 3137, 3, true);
#nullable restore
#line 90 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3140, id.roleId, 3140, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3281, "\"", 3362, 6);
            WriteAttributeValue("", 3288, "/SuperAdmin/Korisnik/Prikaz?u=", 3288, 30, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3318, id.userId, 3318, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3328, "&o=", 3328, 3, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3331, id.organisationId, 3331, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3349, "&r=", 3349, 3, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3352, id.roleId, 3352, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnici</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3406, "\"", 3484, 6);
            WriteAttributeValue("", 3413, "/SuperAdmin/Uloge/Prikaz?u=", 3413, 27, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3440, id.userId, 3440, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3450, "&o=", 3450, 3, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3453, id.organisationId, 3453, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3471, "&r=", 3471, 3, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3474, id.roleId, 3474, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uloge</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3524, "\"", 3603, 6);
            WriteAttributeValue("", 3531, "/SuperAdmin/Status/Prikaz?u=", 3531, 28, true);
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3559, id.userId, 3559, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3569, "&o=", 3569, 3, true);
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3572, id.organisationId, 3572, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3590, "&r=", 3590, 3, true);
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3593, id.roleId, 3593, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Statusi</a></li>\r\n            </ul>\r\n        </ul>\r\n    </div>\r\n</div>\r\n<center>\r\n    <h1>Unos Projektnog Plana</h1>\r\n    <form method=\"post\" action=\"/SuperAdmin/ProjekatPlan/UnosSnimi\">\r\n        <input hidden=\"hidden\" name=\"u\"");
            BeginWriteAttribute("value", " value=\"", 3832, "\"", 3850, 1);
#nullable restore
#line 104 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3840, id.userId, 3840, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"o\"");
            BeginWriteAttribute("value", " value=\"", 3895, "\"", 3921, 1);
#nullable restore
#line 105 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3903, id.organisationId, 3903, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"r\"");
            BeginWriteAttribute("value", " value=\"", 3966, "\"", 3984, 1);
#nullable restore
#line 106 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3974, id.roleId, 3974, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />

        <table>
            <tr>
                <td>
                    <label>
                        Organizaciona jedinica
                    </label>
                </td>
                <td>
                    <select name=""organizacionaJedinica"">
                        <option>---Odaberi---</option>
");
#nullable restore
#line 118 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
                         foreach (var x in lista_org_jed)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 4437, "\"", 4472, 1);
#nullable restore
#line 120 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 4445, x.OrganizacionaJedinica_ID, 4445, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 120 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
                                                                   Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 121 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
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
                        Šifra
                    </label>
                </td>
                <td>
                    <input type=""text"" name=""sifra"" />
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
                        Datum od
                    </label>
                </td>
                <td>
                    <input type=""datetime-local"" name=""Od"" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Datum do
                   ");
            WriteLiteral(@" </label>
                </td>
                <td>
                    <input type=""datetime-local"" name=""Do"" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Status
                    </label>
                </td>
                <td>
                    <select name=""status_id"">
                        <option>---Odaberi---</option>
");
#nullable restore
#line 174 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
                         foreach (var x in stat_lista)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 6102, "\"", 6121, 1);
#nullable restore
#line 176 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 6110, x.StatusID, 6110, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 176 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
                                                   Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 177 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </select>\r\n                </td>\r\n            </tr>\r\n        </table>\r\n        <button type=\"submit\" class=\"btn btn-primary\">Unesi</button>\r\n    </form>\r\n</center>");
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