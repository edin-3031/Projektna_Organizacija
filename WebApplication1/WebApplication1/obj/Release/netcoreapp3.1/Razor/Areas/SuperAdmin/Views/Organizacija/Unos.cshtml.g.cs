#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e9e0026e0d0ac7edd78bc646c95ae363c0b87e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_Organizacija_Unos), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/Organizacija/Unos.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e9e0026e0d0ac7edd78bc646c95ae363c0b87e0", @"/Areas/SuperAdmin/Views/Organizacija/Unos.cshtml")]
    public class Areas_SuperAdmin_Views_Organizacija_Unos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
  

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
            BeginWriteAttribute("href", " href=\"", 1642, "\"", 1724, 6);
            WriteAttributeValue("", 1649, "/SuperAdmin/SuperAdmin/Index?u=", 1649, 31, true);
#nullable restore
#line 74 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 1680, id.userId, 1680, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1690, "&o=", 1690, 3, true);
#nullable restore
#line 74 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 1693, id.organisationId, 1693, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1711, "&r=", 1711, 3, true);
#nullable restore
#line 74 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 1714, id.roleId, 1714, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"sifarnik\">Opšti šifarnik</li>\r\n            <ul id=\"o_s\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1880, "\"", 1959, 6);
            WriteAttributeValue("", 1887, "/SuperAdmin/Drzava/Prikaz?u=", 1887, 28, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 1915, id.userId, 1915, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1925, "&o=", 1925, 3, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 1928, id.organisationId, 1928, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1946, "&r=", 1946, 3, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 1949, id.roleId, 1949, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Država</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2000, "\"", 2076, 6);
            WriteAttributeValue("", 2007, "/SuperAdmin/PTT/Prikaz?u=", 2007, 25, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 2032, id.userId, 2032, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2042, "&o=", 2042, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 2045, id.organisationId, 2045, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2063, "&r=", 2063, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 2066, id.roleId, 2066, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">PTT</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2114, "\"", 2199, 6);
            WriteAttributeValue("", 2121, "/SuperAdmin/Organizacija/Prikaz?u=", 2121, 34, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 2155, id.userId, 2155, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2165, "&o=", 2165, 3, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 2168, id.organisationId, 2168, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2186, "&r=", 2186, 3, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 2189, id.roleId, 2189, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizacija</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2246, "\"", 2340, 6);
            WriteAttributeValue("", 2253, "/SuperAdmin/OrganizacionaJedinica/Prikaz?u=", 2253, 43, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 2296, id.userId, 2296, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2306, "&o=", 2306, 3, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 2309, id.organisationId, 2309, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2327, "&r=", 2327, 3, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 2330, id.roleId, 2330, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizaciona jedinica</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2397, "\"", 2481, 6);
            WriteAttributeValue("", 2404, "/SuperAdmin/KorisnikOrg/Prikaz?u=", 2404, 33, true);
#nullable restore
#line 82 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 2437, id.userId, 2437, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2447, "&o=", 2447, 3, true);
#nullable restore
#line 82 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 2450, id.organisationId, 2450, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2468, "&r=", 2468, 3, true);
#nullable restore
#line 82 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 2471, id.roleId, 2471, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnik-Organizaciona jedinica</a></li>\r\n            </ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2644, "\"", 2729, 6);
            WriteAttributeValue("", 2651, "/SuperAdmin/ProjekatPlan/Prikaz?u=", 2651, 34, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 2685, id.userId, 2685, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2695, "&o=", 2695, 3, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 2698, id.organisationId, 2698, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2716, "&r=", 2716, 3, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 2719, id.roleId, 2719, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2768, "\"", 2862, 6);
            WriteAttributeValue("", 2775, "/SuperAdmin/ProjekatAktivnostPlan/Prikaz?u=", 2775, 43, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 2818, id.userId, 2818, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2828, "&o=", 2828, 3, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 2831, id.organisationId, 2831, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2849, "&r=", 2849, 3, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 2852, id.roleId, 2852, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3002, "\"", 3103, 6);
            WriteAttributeValue("", 3009, "/SuperAdmin/ProjekatAktivnostRealizacija/Prikaz?u=", 3009, 50, true);
#nullable restore
#line 91 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 3059, id.userId, 3059, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3069, "&o=", 3069, 3, true);
#nullable restore
#line 91 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 3072, id.organisationId, 3072, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3090, "&r=", 3090, 3, true);
#nullable restore
#line 91 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 3093, id.roleId, 3093, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3234, "\"", 3315, 6);
            WriteAttributeValue("", 3241, "/SuperAdmin/Korisnik/Prikaz?u=", 3241, 30, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 3271, id.userId, 3271, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3281, "&o=", 3281, 3, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 3284, id.organisationId, 3284, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3302, "&r=", 3302, 3, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 3305, id.roleId, 3305, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnici</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3359, "\"", 3437, 6);
            WriteAttributeValue("", 3366, "/SuperAdmin/Uloge/Prikaz?u=", 3366, 27, true);
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 3393, id.userId, 3393, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3403, "&o=", 3403, 3, true);
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 3406, id.organisationId, 3406, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3424, "&r=", 3424, 3, true);
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 3427, id.roleId, 3427, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uloge</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3477, "\"", 3556, 6);
            WriteAttributeValue("", 3484, "/SuperAdmin/Status/Prikaz?u=", 3484, 28, true);
#nullable restore
#line 97 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 3512, id.userId, 3512, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3522, "&o=", 3522, 3, true);
#nullable restore
#line 97 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 3525, id.organisationId, 3525, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3543, "&r=", 3543, 3, true);
#nullable restore
#line 97 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 3546, id.roleId, 3546, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Statusi</a></li>\r\n            </ul>\r\n        </ul>\r\n    </div>\r\n</div>\r\n");
            WriteLiteral("<center>\r\n    <h1>Unos Organizacije</h1>\r\n    <form action=\"/SuperAdmin/Organizacija/UnosSnimi\" enctype=\"multipart/form-data\" method=\"post\">\r\n        <input hidden=\"hidden\" name=\"u\"");
            BeginWriteAttribute("value", " value=\"", 4552, "\"", 4570, 1);
#nullable restore
#line 125 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 4560, id.userId, 4560, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n        <input hidden=\"hidden\" name=\"o\"");
            BeginWriteAttribute("value", " value=\"", 4614, "\"", 4640, 1);
#nullable restore
#line 126 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 4622, id.organisationId, 4622, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n        <input hidden=\"hidden\" name=\"r\"");
            BeginWriteAttribute("value", " value=\"", 4684, "\"", 4702, 1);
#nullable restore
#line 127 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 4692, id.roleId, 4692, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n\r\n        <table>\r\n            <tr>\r\n                <td><label>PTT</label></td>\r\n                <td>\r\n                    <select name=\"ptt\">\r\n                        <option>---Odaberi---</option>\r\n");
#nullable restore
#line 135 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
                         foreach (var x in lista_ptt)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 5025, "\"", 5042, 1);
#nullable restore
#line 137 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 5033, x.PTT_ID, 5033, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 137 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
                                                 Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 138 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </select>
                </td>
            </tr>
            <tr>
                <td><label>Država</label></td>
                <td>
                    <select name=""drzava"">
                        <option>---Odaberi---</option>
");
#nullable restore
#line 147 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
                         foreach (var x in lista_drzava)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 5471, "\"", 5491, 1);
#nullable restore
#line 149 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
WriteAttributeValue("", 5479, x.Drzava_ID, 5479, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 149 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
                                                    Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 150 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Organizacija\Unos.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </select>
                </td>
            </tr>
            <tr>
                <td><label>Šifra</label></td>
                <td><input name=""sifra"" type=""text"" /></td>
            </tr>
            <tr>
                <td><label>Naziv</label></td>
                <td><input name=""naziv"" type=""text"" /></td>
            </tr>
            <tr>
                <td><label>Adresa</label></td>
                <td><input name=""adresa"" type=""text"" /></td>
            </tr>
            <tr>
                <td><label>Slika</label></td>
                <td>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
