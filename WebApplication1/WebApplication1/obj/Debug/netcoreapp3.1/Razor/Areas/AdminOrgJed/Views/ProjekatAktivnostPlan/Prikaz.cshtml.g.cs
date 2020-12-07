#pragma checksum "D:\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostPlan\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "156b16defd69e7a4a6bb07f0e632544750b82ac1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminOrgJed_Views_ProjekatAktivnostPlan_Prikaz), @"mvc.1.0.view", @"/Areas/AdminOrgJed/Views/ProjekatAktivnostPlan/Prikaz.cshtml")]
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
#line 1 "D:\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"156b16defd69e7a4a6bb07f0e632544750b82ac1", @"/Areas/AdminOrgJed/Views/ProjekatAktivnostPlan/Prikaz.cshtml")]
    public class Areas_AdminOrgJed_Views_ProjekatAktivnostPlan_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
  
    List<ProjekatAktivnostPlan> lista = (List<ProjekatAktivnostPlan>)ViewData["pro_aktiv_plan"];

    Layout = "~/Views/Shared/_Layout_admin_org_jed.cshtml";

    byte[] pic = (byte[])ViewData["logo"];
    var base64 = Convert.ToBase64String(pic);
    var imgsrc = string.Format("data:image/gif;base64,{0}", base64);

#line default
#line hidden
#nullable disable
            WriteLiteral("<center>\r\n    <div id=\"zaglavlje\" style=\"width:100%\">\r\n        <h1 style=\"position:relative; display:inline;\">Prikaz Projektnih aktivnosti</h1>\r\n        <img style=\"height:7vw; width:7vw; position:relative; float:right; display:inline;\"");
            BeginWriteAttribute("src", " src=\"", 634, "\"", 647, 1);
#nullable restore
#line 15 "D:\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 640, imgsrc, 640, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
    </div>
    <div id=""dugmad"">
        <div id=""dodaj"">
            <a class=""btn btn-success"" href=""/AdminOrgJed/ProjekatAktivnostPlan/Unos"">Dodaj novi</a>
        </div>
        <div id=""print_excel"">
            <a href=""/AdminOrgJed/ProjekatAktivnostPlan/Excel"" class=""btn btn-info"">Export to Excel</a>
        </div>
    </div>
    <table class=""table"">
        <thead>
            <th>Naziv</th>
            <th>Šifra</th>
            <th>Projekat plan</th>
            <th>Datum od</th>
            <th>Datum do</th>
            <th>Količina</th>
            <th>Jedinica mjere</th>
            <th>Akcija</th>
        </thead>
        <tbody>
");
#nullable restore
#line 37 "D:\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
             foreach (var x in lista)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 40 "D:\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                   Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 41 "D:\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                   Write(x.Sifra);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 42 "D:\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                    Write(x.projekatPlan.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 43 "D:\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                    Write(x.DatumOd.Date.Day+"."+ x.DatumOd.Date.Month + "." + x.DatumOd.Date.Year + ".");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 44 "D:\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                    Write(x.DatumDo.Date.Day+"."+ x.DatumDo.Date.Month + "." + x.DatumDo.Date.Year + ".");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 45 "D:\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                   Write(x.Kolicina);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 46 "D:\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                   Write(x.JedinicaMjere);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1924, "\"", 2002, 2);
            WriteAttributeValue("", 1931, "/AdminOrgJed/ProjekatAktivnostPlan/Uredi?id=", 1931, 44, true);
#nullable restore
#line 48 "D:\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 1975, x.ProjekatAktivnostPlan_ID, 1975, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uredi</a>\r\n                        <a");
            BeginWriteAttribute("id", " id=\"", 2041, "\"", 2080, 2);
            WriteAttributeValue("", 2046, "ukloni_", 2046, 7, true);
#nullable restore
#line 49 "D:\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2053, x.ProjekatAktivnostPlan_ID, 2053, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\" style=\"color:white\">Ukloni</a>\r\n\r\n                        <span style=\"color:black; position:absolute;float:right;margin-left:1%;\"");
            BeginWriteAttribute("id", " id=\"", 2235, "\"", 2274, 2);
            WriteAttributeValue("", 2240, "poruka_", 2240, 7, true);
#nullable restore
#line 51 "D:\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2247, x.ProjekatAktivnostPlan_ID, 2247, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sigurni? <a");
            BeginWriteAttribute("href", " href=\"", 2287, "\"", 2366, 2);
            WriteAttributeValue("", 2294, "/AdminOrgJed/ProjekatAktivnostPlan/Ukloni?id=", 2294, 45, true);
#nullable restore
#line 51 "D:\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2339, x.ProjekatAktivnostPlan_ID, 2339, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:black; font-weight:bold;\">Da</a> <a");
            BeginWriteAttribute("id", " id=\"", 2416, "\"", 2451, 2);
            WriteAttributeValue("", 2421, "no_", 2421, 3, true);
#nullable restore
#line 51 "D:\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
WriteAttributeValue("", 2424, x.ProjekatAktivnostPlan_ID, 2424, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:black;cursor:pointer; font-weight:bold;\">Ne</a></span>\r\n                        <script>\r\n                            $(\"#poruka_");
#nullable restore
#line 53 "D:\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                                  Write(x.ProjekatAktivnostPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").hide();\r\n\r\n                            $(\"#ukloni_");
#nullable restore
#line 55 "D:\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                                  Write(x.ProjekatAktivnostPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").click(function () {\r\n\r\n                                $(\"#poruka_");
#nullable restore
#line 57 "D:\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                                      Write(x.ProjekatAktivnostPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").slideDown();\r\n                            });\r\n\r\n                            $(\"#no_");
#nullable restore
#line 60 "D:\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                              Write(x.ProjekatAktivnostPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").click(function () {\r\n                                $(\"#poruka_");
#nullable restore
#line 61 "D:\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
                                      Write(x.ProjekatAktivnostPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").slideUp();\r\n                            });\r\n                        </script>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 66 "D:\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostPlan\Prikaz.cshtml"
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
