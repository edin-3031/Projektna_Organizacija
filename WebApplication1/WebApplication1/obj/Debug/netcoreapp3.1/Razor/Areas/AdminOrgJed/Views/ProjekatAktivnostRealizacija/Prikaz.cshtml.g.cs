#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6edb1ea05f86d6932cf7e6c38aecc0208940aa49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminOrgJed_Views_ProjekatAktivnostRealizacija_Prikaz), @"mvc.1.0.view", @"/Areas/AdminOrgJed/Views/ProjekatAktivnostRealizacija/Prikaz.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6edb1ea05f86d6932cf7e6c38aecc0208940aa49", @"/Areas/AdminOrgJed/Views/ProjekatAktivnostRealizacija/Prikaz.cshtml")]
    public class Areas_AdminOrgJed_Views_ProjekatAktivnostRealizacija_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
  
    List<par_final_VM> lista = (List<par_final_VM>)ViewData["lista_relizacija"];

    uor id = (uor)ViewData["id"];
    Layout = "~/Views/Shared/_Layout_admin_org.cshtml";

    byte[] pic = (byte[])ViewData["logo"];
    var base64 = Convert.ToBase64String(pic);
    var imgsrc = string.Format("data:image/gif;base64,{0}", base64);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>


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

    #dodaj, #detalji, #print_preview, #print_excel, #print_pdf {
        display: inline-block;
        margin: 2%;
    }

    #print_preview, #print_excel, #print_pdf {
        color: white;
    }

    #dugmad {
        margin-bottom: 2%;
        margin-top: 2%;
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
        width");
            WriteLiteral(@": 15%;
        margin-left: 0px;
        background-color: rgba(0, 0, 0, 0.8);
        color: white;
        top: 20%;
        font-size: 1vw;
        border-radius: 0px 25px 25px 0px;
    }
</style>
<div id=""kutijaZaMeni"">
    <div id=""menu"">
        <br />
        <a style=""color:white; text-decoration-line:none; font-size:120%;""");
            BeginWriteAttribute("href", " href=\"", 1905, "\"", 1989, 6);
            WriteAttributeValue("", 1912, "/AdminOrgJed/AdminOrgJed/Index?u=", 1912, 33, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 1945, id.userId, 1945, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1955, "&o=", 1955, 3, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 1958, id.organisationId, 1958, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1976, "&r=", 1976, 3, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 1979, id.roleId, 1979, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2147, "\"", 2233, 6);
            WriteAttributeValue("", 2154, "/AdminOrgJed/ProjekatPlan/Prikaz?u=", 2154, 35, true);
#nullable restore
#line 88 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 2189, id.userId, 2189, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2199, "&o=", 2199, 3, true);
#nullable restore
#line 88 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 2202, id.organisationId, 2202, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2220, "&r=", 2220, 3, true);
#nullable restore
#line 88 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 2223, id.roleId, 2223, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2272, "\"", 2367, 6);
            WriteAttributeValue("", 2279, "/AdminOrgJed/ProjekatAktivnostPlan/Prikaz?u=", 2279, 44, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 2323, id.userId, 2323, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2333, "&o=", 2333, 3, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 2336, id.organisationId, 2336, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2354, "&r=", 2354, 3, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 2357, id.roleId, 2357, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2507, "\"", 2609, 6);
            WriteAttributeValue("", 2514, "/AdminOrgJed/ProjekatAktivnostRealizacija/Prikaz?u=", 2514, 51, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 2565, id.userId, 2565, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2575, "&o=", 2575, 3, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 2578, id.organisationId, 2578, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2596, "&r=", 2596, 3, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 2599, id.roleId, 2599, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2740, "\"", 2822, 6);
            WriteAttributeValue("", 2747, "/AdminOrgJed/Korisnik/Prikaz?u=", 2747, 31, true);
#nullable restore
#line 97 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 2778, id.userId, 2778, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2788, "&o=", 2788, 3, true);
#nullable restore
#line 97 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 2791, id.organisationId, 2791, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2809, "&r=", 2809, 3, true);
#nullable restore
#line 97 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 2812, id.roleId, 2812, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnici</a></li>\r\n            </ul>\r\n        </ul>\r\n    </div>\r\n</div>\r\n");
            WriteLiteral("<center>\r\n    <div id=\"zaglavlje\" style=\"width:100%\">\r\n        <h1 style=\"position:relative; display:inline;\">Prikaz Realizacija</h1>\r\n        <img style=\"height:7vw; width:7vw; position:relative; float:right; display:inline;\"");
            BeginWriteAttribute("src", " src=\"", 3933, "\"", 3946, 1);
#nullable restore
#line 125 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 3939, imgsrc, 3939, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n\r\n    <div id=\"dugmad\">\r\n        <div id=\"dodaj\">\r\n            <a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 4053, "\"", 4153, 6);
            WriteAttributeValue("", 4060, "/AdminOrgJed/ProjekatAktivnostRealizacija/Unos?u=", 4060, 49, true);
#nullable restore
#line 130 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 4109, id.userId, 4109, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4119, "&o=", 4119, 3, true);
#nullable restore
#line 130 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 4122, id.organisationId, 4122, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4140, "&r=", 4140, 3, true);
#nullable restore
#line 130 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 4143, id.roleId, 4143, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Unesi novu</a>\r\n        </div>\r\n        <div id=\"detalji\">\r\n            <a class=\"btn btn-warning\"");
            BeginWriteAttribute("href", " href=\"", 4253, "\"", 4356, 6);
            WriteAttributeValue("", 4260, "/AdminOrgJed/ProjekatAktivnostRealizacija/Detalji?u=", 4260, 52, true);
#nullable restore
#line 133 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 4312, id.userId, 4312, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4322, "&o=", 4322, 3, true);
#nullable restore
#line 133 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 4325, id.organisationId, 4325, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4343, "&r=", 4343, 3, true);
#nullable restore
#line 133 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 4346, id.roleId, 4346, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Detalji</a>\r\n        </div>\r\n");
            WriteLiteral("        <div id=\"print_excel\"><a");
            BeginWriteAttribute("href", " href=\"", 4689, "\"", 4756, 2);
            WriteAttributeValue("", 4696, "/AdminOrgJed/ProjekatAktivnostRealizacija/Excel?u=", 4696, 50, true);
#nullable restore
#line 137 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 4746, id.userId, 4746, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-info"">Export to Excel</a></div>
        <div></div>
        <div></div>
    </div>
    <table class=""table"">
        <thead>
        <th>Projekat plan</th>
        <th>Projekat aktivnost plan</th>
        <th>Korisnik</th>
        <th>Datum</th>
        <th>Količina</th>
        <th>Opis</th>
        <th>Akcija</th>
        </thead>
        <tbody>
");
#nullable restore
#line 152 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
             foreach (var x in lista)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 155 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                   Write(x.proj_plan.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 156 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                   Write(x.ProjekatAktivnostPlan_all.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 157 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                    Write(x.Korisnici.Ime+" "+x.Korisnici.Prezime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 158 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                    Write(x.Datum.Date.Day+"."+ x.Datum.Date.Month + "." + x.Datum.Date.Year + ".");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 159 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                   Write(x.Kolicina);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 160 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                   Write(x.Opis);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 5664, "\"", 5803, 8);
            WriteAttributeValue("", 5671, "/AdminOrgJed/ProjekatAktivnostRealizacija/Uredi?id=", 5671, 51, true);
#nullable restore
#line 162 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 5722, x.ProjekatAktivnostRealizacija_ID, 5722, 34, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5756, "&u=", 5756, 3, true);
#nullable restore
#line 162 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 5759, id.userId, 5759, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5769, "&o=", 5769, 3, true);
#nullable restore
#line 162 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 5772, id.organisationId, 5772, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5790, "&r=", 5790, 3, true);
#nullable restore
#line 162 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 5793, id.roleId, 5793, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uredi</a>\r\n                        <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 5865, "\"", 6005, 8);
            WriteAttributeValue("", 5872, "/AdminOrgJed/ProjekatAktivnostRealizacija/Ukloni?id=", 5872, 52, true);
#nullable restore
#line 163 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 5924, x.ProjekatAktivnostRealizacija_ID, 5924, 34, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5958, "&u=", 5958, 3, true);
#nullable restore
#line 163 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 5961, id.userId, 5961, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5971, "&o=", 5971, 3, true);
#nullable restore
#line 163 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 5974, id.organisationId, 5974, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5992, "&r=", 5992, 3, true);
#nullable restore
#line 163 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 5995, id.roleId, 5995, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Ukloni</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 166 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
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
