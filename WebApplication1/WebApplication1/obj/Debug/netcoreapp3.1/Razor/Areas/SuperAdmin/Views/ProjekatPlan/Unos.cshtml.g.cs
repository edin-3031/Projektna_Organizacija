#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d590e23e8eef992b07f7847e47d0430294715f8"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d590e23e8eef992b07f7847e47d0430294715f8", @"/Areas/SuperAdmin/Views/ProjekatPlan/Unos.cshtml")]
    public class Areas_SuperAdmin_Views_ProjekatPlan_Unos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
  
    List<OrganizacionaJedinica> lista_org_jed = (List<OrganizacionaJedinica>)ViewData["lista_org_jed"];
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
            BeginWriteAttribute("href", " href=\"", 1623, "\"", 1705, 6);
            WriteAttributeValue("", 1630, "/SuperAdmin/SuperAdmin/Index?u=", 1630, 31, true);
#nullable restore
#line 72 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 1661, id.userId, 1661, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1671, "&o=", 1671, 3, true);
#nullable restore
#line 72 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 1674, id.organisationId, 1674, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1692, "&r=", 1692, 3, true);
#nullable restore
#line 72 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 1695, id.roleId, 1695, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"sifarnik\">Opšti šifarnik</li>\r\n            <ul id=\"o_s\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1861, "\"", 1940, 6);
            WriteAttributeValue("", 1868, "/SuperAdmin/Drzava/Prikaz?u=", 1868, 28, true);
#nullable restore
#line 76 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 1896, id.userId, 1896, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1906, "&o=", 1906, 3, true);
#nullable restore
#line 76 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 1909, id.organisationId, 1909, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1927, "&r=", 1927, 3, true);
#nullable restore
#line 76 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 1930, id.roleId, 1930, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Država</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1981, "\"", 2057, 6);
            WriteAttributeValue("", 1988, "/SuperAdmin/PTT/Prikaz?u=", 1988, 25, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2013, id.userId, 2013, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2023, "&o=", 2023, 3, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2026, id.organisationId, 2026, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2044, "&r=", 2044, 3, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2047, id.roleId, 2047, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">PTT</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2095, "\"", 2180, 6);
            WriteAttributeValue("", 2102, "/SuperAdmin/Organizacija/Prikaz?u=", 2102, 34, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2136, id.userId, 2136, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2146, "&o=", 2146, 3, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2149, id.organisationId, 2149, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2167, "&r=", 2167, 3, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2170, id.roleId, 2170, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizacija</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2227, "\"", 2321, 6);
            WriteAttributeValue("", 2234, "/SuperAdmin/OrganizacionaJedinica/Prikaz?u=", 2234, 43, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2277, id.userId, 2277, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2287, "&o=", 2287, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2290, id.organisationId, 2290, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2308, "&r=", 2308, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2311, id.roleId, 2311, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizaciona jedinica</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2378, "\"", 2462, 6);
            WriteAttributeValue("", 2385, "/SuperAdmin/KorisnikOrg/Prikaz?u=", 2385, 33, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2418, id.userId, 2418, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2428, "&o=", 2428, 3, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2431, id.organisationId, 2431, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2449, "&r=", 2449, 3, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2452, id.roleId, 2452, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnik-Organizaciona jedinica</a></li>\r\n            </ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2625, "\"", 2710, 6);
            WriteAttributeValue("", 2632, "/SuperAdmin/ProjekatPlan/Prikaz?u=", 2632, 34, true);
#nullable restore
#line 84 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2666, id.userId, 2666, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2676, "&o=", 2676, 3, true);
#nullable restore
#line 84 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2679, id.organisationId, 2679, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2697, "&r=", 2697, 3, true);
#nullable restore
#line 84 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2700, id.roleId, 2700, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2749, "\"", 2843, 6);
            WriteAttributeValue("", 2756, "/SuperAdmin/ProjekatAktivnostPlan/Prikaz?u=", 2756, 43, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2799, id.userId, 2799, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2809, "&o=", 2809, 3, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2812, id.organisationId, 2812, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2830, "&r=", 2830, 3, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2833, id.roleId, 2833, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2983, "\"", 3084, 6);
            WriteAttributeValue("", 2990, "/SuperAdmin/ProjekatAktivnostRealizacija/Prikaz?u=", 2990, 50, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3040, id.userId, 3040, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3050, "&o=", 3050, 3, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3053, id.organisationId, 3053, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3071, "&r=", 3071, 3, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3074, id.roleId, 3074, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3215, "\"", 3296, 6);
            WriteAttributeValue("", 3222, "/SuperAdmin/Korisnik/Prikaz?u=", 3222, 30, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3252, id.userId, 3252, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3262, "&o=", 3262, 3, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3265, id.organisationId, 3265, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3283, "&r=", 3283, 3, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3286, id.roleId, 3286, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnici</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3340, "\"", 3418, 6);
            WriteAttributeValue("", 3347, "/SuperAdmin/Uloge/Prikaz?u=", 3347, 27, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3374, id.userId, 3374, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3384, "&o=", 3384, 3, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3387, id.organisationId, 3387, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3405, "&r=", 3405, 3, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3408, id.roleId, 3408, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uloge</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3458, "\"", 3537, 6);
            WriteAttributeValue("", 3465, "/SuperAdmin/Status/Prikaz?u=", 3465, 28, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3493, id.userId, 3493, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3503, "&o=", 3503, 3, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3506, id.organisationId, 3506, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3524, "&r=", 3524, 3, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3527, id.roleId, 3527, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Statusi</a></li>\r\n            </ul>\r\n        </ul>\r\n    </div>\r\n</div>\r\n");
            WriteLiteral("<center>\r\n    <h1>Unos Projektnog Plana</h1>\r\n    <form method=\"post\" action=\"/SuperAdmin/ProjekatPlan/UnosSnimi\">\r\n        <input hidden=\"hidden\" name=\"u\"");
            BeginWriteAttribute("value", " value=\"", 4507, "\"", 4525, 1);
#nullable restore
#line 123 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 4515, id.userId, 4515, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"o\"");
            BeginWriteAttribute("value", " value=\"", 4570, "\"", 4596, 1);
#nullable restore
#line 124 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 4578, id.organisationId, 4578, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"r\"");
            BeginWriteAttribute("value", " value=\"", 4641, "\"", 4659, 1);
#nullable restore
#line 125 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 4649, id.roleId, 4649, 10, false);

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
#line 137 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
                         foreach (var x in lista_org_jed)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 5112, "\"", 5147, 1);
#nullable restore
#line 139 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 5120, x.OrganizacionaJedinica_ID, 5120, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 139 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
                                                                   Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 140 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Unos.cshtml"
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
        </table>
        <button type=""submit"" class=""btn btn-primary"">Unesi</button>
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
