#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67fe0e73d3bd9bf1f27ad4e32908442886109fee"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67fe0e73d3bd9bf1f27ad4e32908442886109fee", @"/Areas/AdminOrg/Views/ProjekatAktivnostPlan/Prikaz.cshtml")]
    public class Areas_AdminOrg_Views_ProjekatAktivnostPlan_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
  
    List<ProjekatAktivnostPlan> lista = (List<ProjekatAktivnostPlan>)ViewData["pro_aktiv_plan"];

    uor id = (uor)ViewData["id"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<center>\r\n    <h1>Prikaz Projektnih aktivnosti</h1>\r\n    <div id=\"dugmad\">\r\n        <div id=\"dodaj\">\r\n            <a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 474, "\"", 564, 6);
            WriteAttributeValue("", 481, "/AdminOrg/ProjekatAktivnostPlan/Unos?u=", 481, 39, true);
#nullable restore
#line 16 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 520, id.userId, 520, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 530, "&o=", 530, 3, true);
#nullable restore
#line 16 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 533, id.organisationId, 533, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 551, "&r=", 551, 3, true);
#nullable restore
#line 16 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 554, id.roleId, 554, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Dodaj novi</a>\r\n        </div>\r\n    </div>\r\n    <table class=\"table\">\r\n        <thead>\r\n        <th>ID</th>\r\n");
            WriteLiteral("        <th>Šifra</th>\r\n        <th>Naziv</th>\r\n        <th>Datum od</th>\r\n        <th>Datum do</th>\r\n        <th>Jedinica mjere</th>\r\n        <th>Količina</th>\r\n        <th>Akcija</th>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 32 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
             foreach (var x in lista)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 35 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                   Write(x.ProjekatAktivnostPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                    <td>");
#nullable restore
#line 37 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                   Write(x.Sifra);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 38 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                   Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 39 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                    Write(x.DatumOd.Date.Day+"."+ x.DatumOd.Date.Month + "." + x.DatumOd.Date.Year + ".");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 40 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                    Write(x.DatumDo.Date.Day+"."+ x.DatumDo.Date.Month + "." + x.DatumDo.Date.Year + ".");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 41 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                   Write(x.JedinicaMjere);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 42 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                   Write(x.Kolicina);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1565, "\"", 1688, 8);
            WriteAttributeValue("", 1572, "/AdminOrg/ProjekatAktivnostPlan/Ukloni?id=", 1572, 42, true);
#nullable restore
#line 43 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 1614, x.ProjekatAktivnostPlan_ID, 1614, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1641, "&u=", 1641, 3, true);
#nullable restore
#line 43 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 1644, id.userId, 1644, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1654, "&o=", 1654, 3, true);
#nullable restore
#line 43 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 1657, id.organisationId, 1657, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1675, "&r=", 1675, 3, true);
#nullable restore
#line 43 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 1678, id.roleId, 1678, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Ukloni</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 45 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
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
