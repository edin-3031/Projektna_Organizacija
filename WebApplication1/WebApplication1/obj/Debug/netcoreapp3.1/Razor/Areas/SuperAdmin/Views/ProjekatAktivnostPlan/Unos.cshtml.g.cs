#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ddab6ccd641e61626401a2a345f3e5d4b9dc9a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_ProjekatAktivnostPlan_Unos), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/ProjekatAktivnostPlan/Unos.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ddab6ccd641e61626401a2a345f3e5d4b9dc9a1", @"/Areas/SuperAdmin/Views/ProjekatAktivnostPlan/Unos.cshtml")]
    public class Areas_SuperAdmin_Views_ProjekatAktivnostPlan_Unos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
  
    List<ProjekatPlan> lista_proj_plan = (List<ProjekatPlan>)ViewData["lista_proj_plan"];
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
            BeginWriteAttribute("href", " href=\"", 1609, "\"", 1691, 6);
            WriteAttributeValue("", 1616, "/SuperAdmin/SuperAdmin/Index?u=", 1616, 31, true);
#nullable restore
#line 72 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 1647, id.userId, 1647, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1657, "&o=", 1657, 3, true);
#nullable restore
#line 72 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 1660, id.organisationId, 1660, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1678, "&r=", 1678, 3, true);
#nullable restore
#line 72 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 1681, id.roleId, 1681, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"sifarnik\">Opšti šifarnik</li>\r\n            <ul id=\"o_s\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1847, "\"", 1926, 6);
            WriteAttributeValue("", 1854, "/SuperAdmin/Drzava/Prikaz?u=", 1854, 28, true);
#nullable restore
#line 76 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 1882, id.userId, 1882, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1892, "&o=", 1892, 3, true);
#nullable restore
#line 76 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 1895, id.organisationId, 1895, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1913, "&r=", 1913, 3, true);
#nullable restore
#line 76 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 1916, id.roleId, 1916, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Država</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1967, "\"", 2043, 6);
            WriteAttributeValue("", 1974, "/SuperAdmin/PTT/Prikaz?u=", 1974, 25, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 1999, id.userId, 1999, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2009, "&o=", 2009, 3, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 2012, id.organisationId, 2012, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2030, "&r=", 2030, 3, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 2033, id.roleId, 2033, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">PTT</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2081, "\"", 2166, 6);
            WriteAttributeValue("", 2088, "/SuperAdmin/Organizacija/Prikaz?u=", 2088, 34, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 2122, id.userId, 2122, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2132, "&o=", 2132, 3, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 2135, id.organisationId, 2135, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2153, "&r=", 2153, 3, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 2156, id.roleId, 2156, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizacija</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2213, "\"", 2307, 6);
            WriteAttributeValue("", 2220, "/SuperAdmin/OrganizacionaJedinica/Prikaz?u=", 2220, 43, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 2263, id.userId, 2263, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2273, "&o=", 2273, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 2276, id.organisationId, 2276, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2294, "&r=", 2294, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 2297, id.roleId, 2297, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizaciona jedinica</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2364, "\"", 2448, 6);
            WriteAttributeValue("", 2371, "/SuperAdmin/KorisnikOrg/Prikaz?u=", 2371, 33, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 2404, id.userId, 2404, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2414, "&o=", 2414, 3, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 2417, id.organisationId, 2417, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2435, "&r=", 2435, 3, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 2438, id.roleId, 2438, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnik-Organizaciona jedinica</a></li>\r\n            </ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2611, "\"", 2696, 6);
            WriteAttributeValue("", 2618, "/SuperAdmin/ProjekatPlan/Prikaz?u=", 2618, 34, true);
#nullable restore
#line 84 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 2652, id.userId, 2652, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2662, "&o=", 2662, 3, true);
#nullable restore
#line 84 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 2665, id.organisationId, 2665, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2683, "&r=", 2683, 3, true);
#nullable restore
#line 84 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 2686, id.roleId, 2686, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2735, "\"", 2829, 6);
            WriteAttributeValue("", 2742, "/SuperAdmin/ProjekatAktivnostPlan/Prikaz?u=", 2742, 43, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 2785, id.userId, 2785, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2795, "&o=", 2795, 3, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 2798, id.organisationId, 2798, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2816, "&r=", 2816, 3, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 2819, id.roleId, 2819, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2969, "\"", 3070, 6);
            WriteAttributeValue("", 2976, "/SuperAdmin/ProjekatAktivnostRealizacija/Prikaz?u=", 2976, 50, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 3026, id.userId, 3026, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3036, "&o=", 3036, 3, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 3039, id.organisationId, 3039, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3057, "&r=", 3057, 3, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 3060, id.roleId, 3060, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3201, "\"", 3282, 6);
            WriteAttributeValue("", 3208, "/SuperAdmin/Korisnik/Prikaz?u=", 3208, 30, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 3238, id.userId, 3238, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3248, "&o=", 3248, 3, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 3251, id.organisationId, 3251, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3269, "&r=", 3269, 3, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 3272, id.roleId, 3272, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnici</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3326, "\"", 3404, 6);
            WriteAttributeValue("", 3333, "/SuperAdmin/Uloge/Prikaz?u=", 3333, 27, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 3360, id.userId, 3360, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3370, "&o=", 3370, 3, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 3373, id.organisationId, 3373, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3391, "&r=", 3391, 3, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 3394, id.roleId, 3394, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uloge</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3444, "\"", 3523, 6);
            WriteAttributeValue("", 3451, "/SuperAdmin/Status/Prikaz?u=", 3451, 28, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 3479, id.userId, 3479, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3489, "&o=", 3489, 3, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 3492, id.organisationId, 3492, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3510, "&r=", 3510, 3, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 3513, id.roleId, 3513, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Statusi</a></li>\r\n            </ul>\r\n        </ul>\r\n    </div>\r\n</div>\r\n");
            WriteLiteral("<center>\r\n    <h1>Unos Projektnih aktivnosti</h1>\r\n    <form method=\"post\" action=\"/SuperAdmin/ProjekatAktivnostPlan/UnosSnimi\">\r\n\r\n        <input hidden=\"hidden\" name=\"u\"");
            BeginWriteAttribute("value", " value=\"", 4509, "\"", 4527, 1);
#nullable restore
#line 124 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 4517, id.userId, 4517, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"o\"");
            BeginWriteAttribute("value", " value=\"", 4572, "\"", 4598, 1);
#nullable restore
#line 125 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 4580, id.organisationId, 4580, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"r\"");
            BeginWriteAttribute("value", " value=\"", 4643, "\"", 4661, 1);
#nullable restore
#line 126 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 4651, id.roleId, 4651, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
        <table>
            <tr>
                <td>
                    <label>
                        Projekat plan
                    </label>
                </td>
                <td>
                    <select name=""projekatPlan"">
                        <option>---Odaberi---</option>
");
#nullable restore
#line 137 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
                         foreach (var x in lista_proj_plan)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 5096, "\"", 5122, 1);
#nullable restore
#line 139 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 5104, x.ProjekatPlan_ID, 5104, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 139 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
                                                          Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 139 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
                                                                     Write(x.organizacionaJedinica.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 140 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
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
                        Jedinica mjere
                    </label>
                </td>
                <td>
                    <input type=""text"" name=""jedinicaMjere"" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Količina
                    </label>
                </td>
                <td>
                    <input type=""text"" name=""kolicina"" />
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
