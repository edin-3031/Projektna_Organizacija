#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4fd10c9a3e6bbe4a9f087c94a625cd7f72f5188"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminOrgJed_Views_ProjekatPlan_Prikaz), @"mvc.1.0.view", @"/Areas/AdminOrgJed/Views/ProjekatPlan/Prikaz.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4fd10c9a3e6bbe4a9f087c94a625cd7f72f5188", @"/Areas/AdminOrgJed/Views/ProjekatPlan/Prikaz.cshtml")]
    public class Areas_AdminOrgJed_Views_ProjekatPlan_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
  
    List<ProjekatPlan> lista = (List<ProjekatPlan>)ViewData["proj_plan"];
    Layout = "~/Views/Shared/_Layout_admin_org.cshtml";

    uor id = (uor)ViewData["id"];

    byte[] pic = (byte[])ViewData["logo"];
    var base64 = Convert.ToBase64String(pic);
    var imgsrc = string.Format("data:image/gif;base64,{0}", base64);

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
            BeginWriteAttribute("href", " href=\"", 1760, "\"", 1844, 6);
            WriteAttributeValue("", 1767, "/AdminOrgJed/AdminOrgJed/Index?u=", 1767, 33, true);
#nullable restore
#line 76 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 1800, id.userId, 1800, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1810, "&o=", 1810, 3, true);
#nullable restore
#line 76 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 1813, id.organisationId, 1813, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1831, "&r=", 1831, 3, true);
#nullable restore
#line 76 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 1834, id.roleId, 1834, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2002, "\"", 2088, 6);
            WriteAttributeValue("", 2009, "/AdminOrgJed/ProjekatPlan/Prikaz?u=", 2009, 35, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 2044, id.userId, 2044, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2054, "&o=", 2054, 3, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 2057, id.organisationId, 2057, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2075, "&r=", 2075, 3, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 2078, id.roleId, 2078, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2127, "\"", 2222, 6);
            WriteAttributeValue("", 2134, "/AdminOrgJed/ProjekatAktivnostPlan/Prikaz?u=", 2134, 44, true);
#nullable restore
#line 82 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 2178, id.userId, 2178, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2188, "&o=", 2188, 3, true);
#nullable restore
#line 82 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 2191, id.organisationId, 2191, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2209, "&r=", 2209, 3, true);
#nullable restore
#line 82 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 2212, id.roleId, 2212, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2362, "\"", 2464, 6);
            WriteAttributeValue("", 2369, "/AdminOrgJed/ProjekatAktivnostRealizacija/Prikaz?u=", 2369, 51, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 2420, id.userId, 2420, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2430, "&o=", 2430, 3, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 2433, id.organisationId, 2433, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2451, "&r=", 2451, 3, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 2454, id.roleId, 2454, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2595, "\"", 2677, 6);
            WriteAttributeValue("", 2602, "/AdminOrgJed/Korisnik/Prikaz?u=", 2602, 31, true);
#nullable restore
#line 90 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 2633, id.userId, 2633, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2643, "&o=", 2643, 3, true);
#nullable restore
#line 90 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 2646, id.organisationId, 2646, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2664, "&r=", 2664, 3, true);
#nullable restore
#line 90 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 2667, id.roleId, 2667, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnici</a></li>\r\n            </ul>\r\n        </ul>\r\n    </div>\r\n</div>\r\n");
            WriteLiteral("<center>\r\n    <div id=\"zaglavlje\" style=\"width:100%\">\r\n        <h1 style=\"position:relative; display:inline;\">Prikaz Projektnih Planova</h1>\r\n        <img style=\"height:7vw; width:7vw; position:relative; float:right; display:inline;\"");
            BeginWriteAttribute("src", " src=\"", 3727, "\"", 3740, 1);
#nullable restore
#line 118 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 3733, imgsrc, 3733, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <div id=\"dugmad\">\r\n        <div id=\"dodaj\">\r\n            <a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 3845, "\"", 3929, 6);
            WriteAttributeValue("", 3852, "/AdminOrgJed/ProjekatPlan/Unos?u=", 3852, 33, true);
#nullable restore
#line 122 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 3885, id.userId, 3885, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3895, "&o=", 3895, 3, true);
#nullable restore
#line 122 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 3898, id.organisationId, 3898, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3916, "&r=", 3916, 3, true);
#nullable restore
#line 122 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 3919, id.roleId, 3919, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Dodaj novi</a>\r\n        </div>\r\n        <div id=\"print_excel\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 4009, "\"", 4060, 2);
            WriteAttributeValue("", 4016, "/AdminOrgJed/ProjekatPlan/Excel?u=", 4016, 34, true);
#nullable restore
#line 125 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 4050, id.userId, 4050, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-info"">Export to Excel</a>
        </div>
    </div>
    <table class=""table"">
        <thead>
        <th>Šifra</th>
        <th>Naziv</th>
        <th>Datum od</th>
        <th>Datum do</th>
        <th>Akcija</th>
        </thead>
        <tbody>
");
#nullable restore
#line 137 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
             foreach (var x in lista)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 140 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
                   Write(x.Sifra);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 141 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
                   Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 142 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
                    Write(x.DatumOd.Date.Day+"."+x.DatumOd.Date.Month + "." + x.DatumOd.Date.Year + ".");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 143 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
                    Write(x.DatumDo.Date.Day+"."+x.DatumDo.Date.Month + "." + x.DatumDo.Date.Year + ".");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 4790, "\"", 4897, 8);
            WriteAttributeValue("", 4797, "/AdminOrgJed/ProjekatPlan/Uredi?id=", 4797, 35, true);
#nullable restore
#line 145 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 4832, x.ProjekatPlan_ID, 4832, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4850, "&u=", 4850, 3, true);
#nullable restore
#line 145 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 4853, id.userId, 4853, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4863, "&o=", 4863, 3, true);
#nullable restore
#line 145 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 4866, id.organisationId, 4866, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4884, "&r=", 4884, 3, true);
#nullable restore
#line 145 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 4887, id.roleId, 4887, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uredi</a>\r\n                        <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 4959, "\"", 5067, 8);
            WriteAttributeValue("", 4966, "/AdminOrgJed/ProjekatPlan/Ukloni?id=", 4966, 36, true);
#nullable restore
#line 146 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 5002, x.ProjekatPlan_ID, 5002, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5020, "&u=", 5020, 3, true);
#nullable restore
#line 146 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 5023, id.userId, 5023, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5033, "&o=", 5033, 3, true);
#nullable restore
#line 146 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 5036, id.organisationId, 5036, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5054, "&r=", 5054, 3, true);
#nullable restore
#line 146 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 5057, id.roleId, 5057, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Ukloni</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 149 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatPlan\Prikaz.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</center>");
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
