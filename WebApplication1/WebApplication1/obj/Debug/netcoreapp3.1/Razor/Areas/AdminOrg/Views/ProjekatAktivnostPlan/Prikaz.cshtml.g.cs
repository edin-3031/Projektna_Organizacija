#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aebbe8a7d2f08163f320639cd56a69924d9a8fc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminOrg_Views_ProjekatAktivnostPlan_Prikaz), @"mvc.1.0.view", @"/Areas/AdminOrg/Views/ProjekatAktivnostPlan/Prikaz.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aebbe8a7d2f08163f320639cd56a69924d9a8fc9", @"/Areas/AdminOrg/Views/ProjekatAktivnostPlan/Prikaz.cshtml")]
    public class Areas_AdminOrg_Views_ProjekatAktivnostPlan_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
  
    List<ProjekatAktivnostPlan> lista = (List<ProjekatAktivnostPlan>)ViewData["pro_aktiv_plan"];

    uor id = (uor)ViewData["id"]; Layout = "~/Views/Shared/_Layout_admin_org.cshtml";

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
            BeginWriteAttribute("href", " href=\"", 1753, "\"", 1831, 6);
            WriteAttributeValue("", 1760, "/AdminOrg/AdminOrg/Index?u=", 1760, 27, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 1787, id.userId, 1787, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1797, "&o=", 1797, 3, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 1800, id.organisationId, 1800, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1818, "&r=", 1818, 3, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 1821, id.roleId, 1821, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"sifarnik\">Opšti šifarnik</li>\r\n            <ul id=\"o_s\">\r\n\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1989, "\"", 2081, 6);
            WriteAttributeValue("", 1996, "/AdminOrg/OrganizacionaJedinica/Prikaz?u=", 1996, 41, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2037, id.userId, 2037, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2047, "&o=", 2047, 3, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2050, id.organisationId, 2050, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2068, "&r=", 2068, 3, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2071, id.roleId, 2071, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizaciona jedinica</a></li>\r\n            </ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2237, "\"", 2329, 6);
            WriteAttributeValue("", 2244, "/AdminOrg/ProjekatAktivnostPlan/Prikaz?u=", 2244, 41, true);
#nullable restore
#line 88 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2285, id.userId, 2285, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2295, "&o=", 2295, 3, true);
#nullable restore
#line 88 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2298, id.organisationId, 2298, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2316, "&r=", 2316, 3, true);
#nullable restore
#line 88 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2319, id.roleId, 2319, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n\r\n        </ul>\r\n    </div>\r\n</div>\r\n<center>\r\n    <h1>Prikaz Projektnih aktivnosti</h1>\r\n    <div id=\"dugmad\">\r\n        <div id=\"dodaj\">\r\n            <a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 2548, "\"", 2638, 6);
            WriteAttributeValue("", 2555, "/AdminOrg/ProjekatAktivnostPlan/Unos?u=", 2555, 39, true);
#nullable restore
#line 98 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2594, id.userId, 2594, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2604, "&o=", 2604, 3, true);
#nullable restore
#line 98 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2607, id.organisationId, 2607, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2625, "&r=", 2625, 3, true);
#nullable restore
#line 98 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2628, id.roleId, 2628, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Dodaj novi</a>\r\n        </div>\r\n        <div id=\"print_excel\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 2718, "\"", 2776, 2);
            WriteAttributeValue("", 2725, "/Report/IndexAdminOrgAktivnost?o=", 2725, 33, true);
#nullable restore
#line 101 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2758, id.organisationId, 2758, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-info"">Export to Excel</a>
        </div>
    </div>
    <table class=""table"">
        <thead>
        <th>ID</th>
        <th>Projekat plan</th>
        <th>Šifra</th>
        <th>Naziv</th>
        <th>Datum od</th>
        <th>Datum do</th>
        <th>Jedinica mjere</th>
        <th>Količina</th>
        <th>Akcija</th>
        </thead>
        <tbody>
");
#nullable restore
#line 117 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
             foreach (var x in lista)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 120 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                   Write(x.ProjekatAktivnostPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 121 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                    Write(x.projekatPlan.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 122 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                   Write(x.Sifra);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 123 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                   Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 124 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                    Write(x.DatumOd.Date.Day+"."+ x.DatumOd.Date.Month + "." + x.DatumOd.Date.Year + ".");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 125 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                    Write(x.DatumDo.Date.Day+"."+ x.DatumDo.Date.Month + "." + x.DatumDo.Date.Year + ".");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 126 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                   Write(x.JedinicaMjere);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 127 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                   Write(x.Kolicina);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 3795, "\"", 3918, 8);
            WriteAttributeValue("", 3802, "/AdminOrg/ProjekatAktivnostPlan/Ukloni?id=", 3802, 42, true);
#nullable restore
#line 128 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 3844, x.ProjekatAktivnostPlan_ID, 3844, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3871, "&u=", 3871, 3, true);
#nullable restore
#line 128 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 3874, id.userId, 3874, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3884, "&o=", 3884, 3, true);
#nullable restore
#line 128 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 3887, id.organisationId, 3887, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3905, "&r=", 3905, 3, true);
#nullable restore
#line 128 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 3908, id.roleId, 3908, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Ukloni</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 130 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
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
