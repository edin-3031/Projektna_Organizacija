#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89298a9e187a06c01d7dbe6a66be697f92b13428"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ProjekatAktivnostRealizacija_Unos), @"mvc.1.0.view", @"/Areas/Admin/Views/ProjekatAktivnostRealizacija/Unos.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89298a9e187a06c01d7dbe6a66be697f92b13428", @"/Areas/Admin/Views/ProjekatAktivnostRealizacija/Unos.cshtml")]
    public class Areas_Admin_Views_ProjekatAktivnostRealizacija_Unos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
  
    List<ProjekatAktivnostPlan> lista_proj_aktiv_plan = (List<ProjekatAktivnostPlan>)ViewData["lista_proj_aktiv_plan"];
    Layout = "~/Views/Shared/_Layout_admin.cshtml";

    List<Korisnici> lista_korisnici = (List<Korisnici>)ViewData["lista_korisnici"];

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
            BeginWriteAttribute("href", " href=\"", 1726, "\"", 1798, 6);
            WriteAttributeValue("", 1733, "/Admin/Admin/Index?u=", 1733, 21, true);
#nullable restore
#line 74 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 1754, id.userId, 1754, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1764, "&o=", 1764, 3, true);
#nullable restore
#line 74 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 1767, id.organisationId, 1767, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1785, "&r=", 1785, 3, true);
#nullable restore
#line 74 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 1788, id.roleId, 1788, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"sifarnik\">Opšti šifarnik</li>\r\n            <ul id=\"o_s\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1954, "\"", 2028, 6);
            WriteAttributeValue("", 1961, "/Admin/Drzava/Prikaz?u=", 1961, 23, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 1984, id.userId, 1984, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1994, "&o=", 1994, 3, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 1997, id.organisationId, 1997, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2015, "&r=", 2015, 3, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 2018, id.roleId, 2018, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Država</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2069, "\"", 2140, 6);
            WriteAttributeValue("", 2076, "/Admin/PTT/Prikaz?u=", 2076, 20, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 2096, id.userId, 2096, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2106, "&o=", 2106, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 2109, id.organisationId, 2109, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2127, "&r=", 2127, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 2130, id.roleId, 2130, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">PTT</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2178, "\"", 2258, 6);
            WriteAttributeValue("", 2185, "/Admin/Organizacija/Prikaz?u=", 2185, 29, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 2214, id.userId, 2214, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2224, "&o=", 2224, 3, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 2227, id.organisationId, 2227, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2245, "&r=", 2245, 3, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 2248, id.roleId, 2248, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizacija</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2305, "\"", 2394, 6);
            WriteAttributeValue("", 2312, "/Admin/OrganizacionaJedinica/Prikaz?u=", 2312, 38, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 2350, id.userId, 2350, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2360, "&o=", 2360, 3, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 2363, id.organisationId, 2363, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2381, "&r=", 2381, 3, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 2384, id.roleId, 2384, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizaciona jedinica</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2451, "\"", 2530, 6);
            WriteAttributeValue("", 2458, "/Admin/KorisnikOrg/Prikaz?u=", 2458, 28, true);
#nullable restore
#line 82 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 2486, id.userId, 2486, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2496, "&o=", 2496, 3, true);
#nullable restore
#line 82 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 2499, id.organisationId, 2499, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2517, "&r=", 2517, 3, true);
#nullable restore
#line 82 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 2520, id.roleId, 2520, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnik-Organizaciona jedinica</a></li>\r\n            </ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2693, "\"", 2773, 6);
            WriteAttributeValue("", 2700, "/Admin/ProjekatPlan/Prikaz?u=", 2700, 29, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 2729, id.userId, 2729, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2739, "&o=", 2739, 3, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 2742, id.organisationId, 2742, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2760, "&r=", 2760, 3, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 2763, id.roleId, 2763, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2812, "\"", 2901, 6);
            WriteAttributeValue("", 2819, "/Admin/ProjekatAktivnostPlan/Prikaz?u=", 2819, 38, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 2857, id.userId, 2857, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2867, "&o=", 2867, 3, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 2870, id.organisationId, 2870, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2888, "&r=", 2888, 3, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 2891, id.roleId, 2891, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3041, "\"", 3137, 6);
            WriteAttributeValue("", 3048, "/Admin/ProjekatAktivnostRealizacija/Prikaz?u=", 3048, 45, true);
#nullable restore
#line 91 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 3093, id.userId, 3093, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3103, "&o=", 3103, 3, true);
#nullable restore
#line 91 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 3106, id.organisationId, 3106, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3124, "&r=", 3124, 3, true);
#nullable restore
#line 91 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 3127, id.roleId, 3127, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3268, "\"", 3344, 6);
            WriteAttributeValue("", 3275, "/Admin/Korisnik/Prikaz?u=", 3275, 25, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 3300, id.userId, 3300, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3310, "&o=", 3310, 3, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 3313, id.organisationId, 3313, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3331, "&r=", 3331, 3, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 3334, id.roleId, 3334, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnici</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3388, "\"", 3461, 6);
            WriteAttributeValue("", 3395, "/Admin/Uloge/Prikaz?u=", 3395, 22, true);
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 3417, id.userId, 3417, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3427, "&o=", 3427, 3, true);
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 3430, id.organisationId, 3430, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3448, "&r=", 3448, 3, true);
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 3451, id.roleId, 3451, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uloge</a></li>\r\n            </ul>\r\n        </ul>\r\n    </div>\r\n</div>\r\n");
            WriteLiteral("<center>\r\n    <h1>Unos Realizacije</h1>\r\n    <form method=\"post\" action=\"/Admin/ProjekatAktivnostRealizacija/UnosSnimi\">\r\n\r\n        <input hidden=\"hidden\" name=\"u\"");
            BeginWriteAttribute("value", " value=\"", 4437, "\"", 4455, 1);
#nullable restore
#line 125 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 4445, id.userId, 4445, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"o\"");
            BeginWriteAttribute("value", " value=\"", 4500, "\"", 4526, 1);
#nullable restore
#line 126 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 4508, id.organisationId, 4508, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"r\"");
            BeginWriteAttribute("value", " value=\"", 4571, "\"", 4589, 1);
#nullable restore
#line 127 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 4579, id.roleId, 4579, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n        <table>\r\n            <tr>\r\n                <td><label>Projektna aktivnost</label></td>\r\n                <td>\r\n                    <select name=\"projekatAktivnostPlan\">\r\n                        <option>---Odaberi---</option>\r\n");
#nullable restore
#line 135 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
                         foreach (var x in lista_proj_aktiv_plan)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 4959, "\"", 4994, 1);
#nullable restore
#line 137 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 4967, x.ProjekatAktivnostPlan_ID, 4967, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 137 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
                                                                   Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 137 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
                                                                             Write(x.projekatPlan.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</option>\r\n");
#nullable restore
#line 138 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </select>
                </td>
            </tr>
            <tr>
                <td><label>Korisnik</label></td>
                <td>
                    <select name=""korisnik"">
                        <option>---Odaberi---</option>
");
#nullable restore
#line 147 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
                         foreach (var x in lista_korisnici)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 5454, "\"", 5477, 1);
#nullable restore
#line 149 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 5462, x.Korisnici_ID, 5462, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 149 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
                                                        Write(x.Ime+" "+x.Prezime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 150 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </select>
                </td>
            </tr>
            <tr>
                <td><label>Datum</label></td>
                <td>
                    <input name=""datum"" type=""datetime-local"" />
                </td>
            </tr>
            <tr>
                <td><label>Količina</label></td>
                <td>
                    <input name=""kolicina"" type=""text"" />
                </td>
            </tr>
            <tr>
                <td><label>Opis</label></td>
                <td>
                    <input name=""opis"" type=""text"" />
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
