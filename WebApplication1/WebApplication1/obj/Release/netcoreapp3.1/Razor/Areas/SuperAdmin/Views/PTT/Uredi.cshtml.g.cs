#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb3693a7698fe058f2876ac8865fa82ad14b2ff9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_PTT_Uredi), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/PTT/Uredi.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb3693a7698fe058f2876ac8865fa82ad14b2ff9", @"/Areas/SuperAdmin/Views/PTT/Uredi.cshtml")]
    public class Areas_SuperAdmin_Views_PTT_Uredi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
  
    Layout = "~/Views/Shared/_Layout_admin.cshtml";

    uor id = (uor)ViewData["id"];
    PTT ptt = (PTT)ViewData["uredi_ptt"];

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
            BeginWriteAttribute("href", " href=\"", 1563, "\"", 1645, 6);
            WriteAttributeValue("", 1570, "/SuperAdmin/SuperAdmin/Index?u=", 1570, 31, true);
#nullable restore
#line 73 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 1601, id.userId, 1601, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1611, "&o=", 1611, 3, true);
#nullable restore
#line 73 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 1614, id.organisationId, 1614, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1632, "&r=", 1632, 3, true);
#nullable restore
#line 73 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 1635, id.roleId, 1635, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"sifarnik\">Opšti šifarnik</li>\r\n            <ul id=\"o_s\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1801, "\"", 1880, 6);
            WriteAttributeValue("", 1808, "/SuperAdmin/Drzava/Prikaz?u=", 1808, 28, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 1836, id.userId, 1836, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1846, "&o=", 1846, 3, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 1849, id.organisationId, 1849, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1867, "&r=", 1867, 3, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 1870, id.roleId, 1870, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Država</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1921, "\"", 1997, 6);
            WriteAttributeValue("", 1928, "/SuperAdmin/PTT/Prikaz?u=", 1928, 25, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 1953, id.userId, 1953, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1963, "&o=", 1963, 3, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 1966, id.organisationId, 1966, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1984, "&r=", 1984, 3, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 1987, id.roleId, 1987, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">PTT</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2035, "\"", 2120, 6);
            WriteAttributeValue("", 2042, "/SuperAdmin/Organizacija/Prikaz?u=", 2042, 34, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 2076, id.userId, 2076, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2086, "&o=", 2086, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 2089, id.organisationId, 2089, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2107, "&r=", 2107, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 2110, id.roleId, 2110, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizacija</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2167, "\"", 2261, 6);
            WriteAttributeValue("", 2174, "/SuperAdmin/OrganizacionaJedinica/Prikaz?u=", 2174, 43, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 2217, id.userId, 2217, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2227, "&o=", 2227, 3, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 2230, id.organisationId, 2230, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2248, "&r=", 2248, 3, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 2251, id.roleId, 2251, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizaciona jedinica</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2318, "\"", 2402, 6);
            WriteAttributeValue("", 2325, "/SuperAdmin/KorisnikOrg/Prikaz?u=", 2325, 33, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 2358, id.userId, 2358, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2368, "&o=", 2368, 3, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 2371, id.organisationId, 2371, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2389, "&r=", 2389, 3, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 2392, id.roleId, 2392, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnik-Organizaciona jedinica</a></li>\r\n            </ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2565, "\"", 2650, 6);
            WriteAttributeValue("", 2572, "/SuperAdmin/ProjekatPlan/Prikaz?u=", 2572, 34, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 2606, id.userId, 2606, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2616, "&o=", 2616, 3, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 2619, id.organisationId, 2619, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2637, "&r=", 2637, 3, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 2640, id.roleId, 2640, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2689, "\"", 2783, 6);
            WriteAttributeValue("", 2696, "/SuperAdmin/ProjekatAktivnostPlan/Prikaz?u=", 2696, 43, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 2739, id.userId, 2739, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2749, "&o=", 2749, 3, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 2752, id.organisationId, 2752, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2770, "&r=", 2770, 3, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 2773, id.roleId, 2773, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2923, "\"", 3024, 6);
            WriteAttributeValue("", 2930, "/SuperAdmin/ProjekatAktivnostRealizacija/Prikaz?u=", 2930, 50, true);
#nullable restore
#line 90 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 2980, id.userId, 2980, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2990, "&o=", 2990, 3, true);
#nullable restore
#line 90 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 2993, id.organisationId, 2993, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3011, "&r=", 3011, 3, true);
#nullable restore
#line 90 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 3014, id.roleId, 3014, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3155, "\"", 3236, 6);
            WriteAttributeValue("", 3162, "/SuperAdmin/Korisnik/Prikaz?u=", 3162, 30, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 3192, id.userId, 3192, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3202, "&o=", 3202, 3, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 3205, id.organisationId, 3205, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3223, "&r=", 3223, 3, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 3226, id.roleId, 3226, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnici</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3280, "\"", 3358, 6);
            WriteAttributeValue("", 3287, "/SuperAdmin/Uloge/Prikaz?u=", 3287, 27, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 3314, id.userId, 3314, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3324, "&o=", 3324, 3, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 3327, id.organisationId, 3327, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3345, "&r=", 3345, 3, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 3348, id.roleId, 3348, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uloge</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3398, "\"", 3477, 6);
            WriteAttributeValue("", 3405, "/SuperAdmin/Status/Prikaz?u=", 3405, 28, true);
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 3433, id.userId, 3433, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3443, "&o=", 3443, 3, true);
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 3446, id.organisationId, 3446, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3464, "&r=", 3464, 3, true);
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 3467, id.roleId, 3467, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Statusi</a></li>\r\n            </ul>\r\n        </ul>\r\n    </div>\r\n</div>\r\n<center>\r\n    <h1>Uredi PTT</h1>\r\n    <form method=\"post\" action=\"/SuperAdmin/PTT/UrediSnimi\">\r\n\r\n        <input hidden=\"hidden\" name=\"u\"");
            BeginWriteAttribute("value", " value=\"", 3688, "\"", 3706, 1);
#nullable restore
#line 105 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 3696, id.userId, 3696, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"o\"");
            BeginWriteAttribute("value", " value=\"", 3751, "\"", 3777, 1);
#nullable restore
#line 106 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 3759, id.organisationId, 3759, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"r\"");
            BeginWriteAttribute("value", " value=\"", 3822, "\"", 3840, 1);
#nullable restore
#line 107 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 3830, id.roleId, 3830, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n        <input hidden=\"hidden\" name=\"id_ptt\"");
            BeginWriteAttribute("value", " value=\"", 3892, "\"", 3911, 1);
#nullable restore
#line 109 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 3900, ptt.PTT_ID, 3900, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <table>\r\n            <tr>\r\n                <td><label>Naziv</label></td>\r\n                <td><input type=\"text\" name=\"naziv\"");
            BeginWriteAttribute("value", " value=\"", 4050, "\"", 4068, 1);
#nullable restore
#line 113 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 4058, ptt.Naziv, 4058, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n            </tr>\r\n            <tr>\r\n                <td><label>Šifra</label></td>\r\n                <td><input type=\"text\" name=\"sifra\"");
            BeginWriteAttribute("value", " value=\"", 4214, "\"", 4232, 1);
#nullable restore
#line 117 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\PTT\Uredi.cshtml"
WriteAttributeValue("", 4222, ptt.Sifra, 4222, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n            </tr>\r\n        </table>\r\n        <button type=\"submit\" class=\"btn btn-primary\">Snimi</button>\r\n    </form>\r\n</center>");
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