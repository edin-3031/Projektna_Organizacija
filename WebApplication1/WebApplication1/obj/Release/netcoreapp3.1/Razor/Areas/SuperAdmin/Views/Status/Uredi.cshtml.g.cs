#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36001fde017a034863795c1bb617875a12e6c57b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_Status_Uredi), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/Status/Uredi.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36001fde017a034863795c1bb617875a12e6c57b", @"/Areas/SuperAdmin/Views/Status/Uredi.cshtml")]
    public class Areas_SuperAdmin_Views_Status_Uredi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
  
    Layout = "~/Views/Shared/_Layout_admin.cshtml";
    uor id = (uor)ViewData["id"];

    Status stat = (Status)ViewData["status"];

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
            BeginWriteAttribute("href", " href=\"", 1567, "\"", 1649, 6);
            WriteAttributeValue("", 1574, "/SuperAdmin/SuperAdmin/Index?u=", 1574, 31, true);
#nullable restore
#line 73 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 1605, id.userId, 1605, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1615, "&o=", 1615, 3, true);
#nullable restore
#line 73 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 1618, id.organisationId, 1618, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1636, "&r=", 1636, 3, true);
#nullable restore
#line 73 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 1639, id.roleId, 1639, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"sifarnik\">Opšti šifarnik</li>\r\n            <ul id=\"o_s\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1805, "\"", 1884, 6);
            WriteAttributeValue("", 1812, "/SuperAdmin/Drzava/Prikaz?u=", 1812, 28, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 1840, id.userId, 1840, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1850, "&o=", 1850, 3, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 1853, id.organisationId, 1853, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1871, "&r=", 1871, 3, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 1874, id.roleId, 1874, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Država</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1925, "\"", 2001, 6);
            WriteAttributeValue("", 1932, "/SuperAdmin/PTT/Prikaz?u=", 1932, 25, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 1957, id.userId, 1957, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1967, "&o=", 1967, 3, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 1970, id.organisationId, 1970, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1988, "&r=", 1988, 3, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 1991, id.roleId, 1991, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">PTT</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2039, "\"", 2124, 6);
            WriteAttributeValue("", 2046, "/SuperAdmin/Organizacija/Prikaz?u=", 2046, 34, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 2080, id.userId, 2080, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2090, "&o=", 2090, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 2093, id.organisationId, 2093, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2111, "&r=", 2111, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 2114, id.roleId, 2114, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizacija</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2171, "\"", 2265, 6);
            WriteAttributeValue("", 2178, "/SuperAdmin/OrganizacionaJedinica/Prikaz?u=", 2178, 43, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 2221, id.userId, 2221, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2231, "&o=", 2231, 3, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 2234, id.organisationId, 2234, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2252, "&r=", 2252, 3, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 2255, id.roleId, 2255, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizaciona jedinica</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2322, "\"", 2406, 6);
            WriteAttributeValue("", 2329, "/SuperAdmin/KorisnikOrg/Prikaz?u=", 2329, 33, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 2362, id.userId, 2362, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2372, "&o=", 2372, 3, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 2375, id.organisationId, 2375, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2393, "&r=", 2393, 3, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 2396, id.roleId, 2396, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnik-Organizaciona jedinica</a></li>\r\n            </ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2569, "\"", 2654, 6);
            WriteAttributeValue("", 2576, "/SuperAdmin/ProjekatPlan/Prikaz?u=", 2576, 34, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 2610, id.userId, 2610, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2620, "&o=", 2620, 3, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 2623, id.organisationId, 2623, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2641, "&r=", 2641, 3, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 2644, id.roleId, 2644, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2693, "\"", 2787, 6);
            WriteAttributeValue("", 2700, "/SuperAdmin/ProjekatAktivnostPlan/Prikaz?u=", 2700, 43, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 2743, id.userId, 2743, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2753, "&o=", 2753, 3, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 2756, id.organisationId, 2756, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2774, "&r=", 2774, 3, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 2777, id.roleId, 2777, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2927, "\"", 3028, 6);
            WriteAttributeValue("", 2934, "/SuperAdmin/ProjekatAktivnostRealizacija/Prikaz?u=", 2934, 50, true);
#nullable restore
#line 90 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 2984, id.userId, 2984, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2994, "&o=", 2994, 3, true);
#nullable restore
#line 90 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 2997, id.organisationId, 2997, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3015, "&r=", 3015, 3, true);
#nullable restore
#line 90 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 3018, id.roleId, 3018, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3159, "\"", 3240, 6);
            WriteAttributeValue("", 3166, "/SuperAdmin/Korisnik/Prikaz?u=", 3166, 30, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 3196, id.userId, 3196, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3206, "&o=", 3206, 3, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 3209, id.organisationId, 3209, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3227, "&r=", 3227, 3, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 3230, id.roleId, 3230, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnici</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3284, "\"", 3362, 6);
            WriteAttributeValue("", 3291, "/SuperAdmin/Uloge/Prikaz?u=", 3291, 27, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 3318, id.userId, 3318, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3328, "&o=", 3328, 3, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 3331, id.organisationId, 3331, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3349, "&r=", 3349, 3, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 3352, id.roleId, 3352, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uloge</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3402, "\"", 3481, 6);
            WriteAttributeValue("", 3409, "/SuperAdmin/Status/Prikaz?u=", 3409, 28, true);
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 3437, id.userId, 3437, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3447, "&o=", 3447, 3, true);
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 3450, id.organisationId, 3450, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3468, "&r=", 3468, 3, true);
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 3471, id.roleId, 3471, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Statusi</a></li>\r\n            </ul>\r\n        </ul>\r\n    </div>\r\n</div>\r\n<center>\r\n    <h1>Uređivanje statusa</h1><br /><br />\r\n    <form method=\"post\" action=\"/SuperAdmin/Status/UrediSnimi\">\r\n        <input hidden=\"hidden\" name=\"u\"");
            BeginWriteAttribute("value", " value=\"", 3714, "\"", 3732, 1);
#nullable restore
#line 104 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 3722, id.userId, 3722, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"o\"");
            BeginWriteAttribute("value", " value=\"", 3777, "\"", 3803, 1);
#nullable restore
#line 105 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 3785, id.organisationId, 3785, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"r\"");
            BeginWriteAttribute("value", " value=\"", 3848, "\"", 3866, 1);
#nullable restore
#line 106 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 3856, id.userId, 3856, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 3912, "\"", 3934, 1);
#nullable restore
#line 107 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 3920, stat.StatusID, 3920, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <table>\r\n            <tr>\r\n                <td>\r\n                    <label>Naziv</label>\r\n                </td>\r\n                <td>\r\n                    <input name=\"naziv\"");
            BeginWriteAttribute("value", " value=\"", 4123, "\"", 4142, 1);
#nullable restore
#line 114 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 4131, stat.Naziv, 4131, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    <label>Šifra</label>\r\n                </td>\r\n                <td>\r\n                    <input name=\"sifra\"");
            BeginWriteAttribute("value", " value=\"", 4356, "\"", 4375, 1);
#nullable restore
#line 122 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\Status\Uredi.cshtml"
WriteAttributeValue("", 4364, stat.Sifra, 4364, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </td>\r\n            </tr>\r\n        </table>\r\n        <button class=\"btn btn-primary\">Snimi</button>\r\n    </form>\r\n</center>");
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
