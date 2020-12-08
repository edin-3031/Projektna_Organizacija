#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "686ecc767d51691736e42b6cc052782d77999c08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_ProjekatPlan_Prikaz), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/ProjekatPlan/Prikaz.cshtml")]
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
#line 1 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"686ecc767d51691736e42b6cc052782d77999c08", @"/Areas/SuperAdmin/Views/ProjekatPlan/Prikaz.cshtml")]
    public class Areas_SuperAdmin_Views_ProjekatPlan_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
  
    List<ProjekatPlanVM> lista = (List<ProjekatPlanVM>)ViewData["proj_plan"];

    Layout = "~/Views/Shared/_Layout_admin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<center>
    <h1>Prikaz Projetnih Planova</h1>
    <div id=""dugmad"">
        <div id=""dodaj"">
            <a class=""btn btn-success"" href=""/SuperAdmin/ProjekatPlan/Unos"">Dodaj novi</a>
        </div>
        <div id=""print_excel"">
            <a href=""/SuperAdmin/ProjekatPlan/Excel"" class=""btn btn-info"">Export to Excel</a>
        </div>
    </div>
    <table class=""table"">
        <thead>
        <th>Naziv</th>
        <th>Šifra</th>
        <th>Organizaciona jedinica</th>
        <th>Datum od</th>
        <th>Datum do</th>
        <th>Status</th>
        <th>Akcija</th>
        </thead>
        <tbody>
");
#nullable restore
#line 29 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
             foreach (var x in lista)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 32 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
                   Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
                   Write(x.Sifra);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
                   Write(x.OrganizacionaJedinica_naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
                    Write(x.DatumOd.Date.Day+"."+ x.DatumOd.Date.Month + "." + x.DatumOd.Date.Year + ".");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
                    Write(x.DatumDo.Date.Day+"."+ x.DatumDo.Date.Month + "." + x.DatumDo.Date.Year + ".");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td");
            BeginWriteAttribute("id", " id=\"", 1303, "\"", 1333, 2);
            WriteAttributeValue("", 1308, "status_", 1308, 7, true);
#nullable restore
#line 37 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 1315, x.ProjekatPlan_ID, 1315, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 37 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
                                                  Write(x.Status_naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <script>\r\n                        var element = document.getElementById(\"status_");
#nullable restore
#line 39 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
                                                                 Write(x.ProjekatPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""");

                        if (element.innerText == ""Aktivan"") {
                            element.classList.add(""aktiv"");
                        }
                        else if (element.innerText == ""Prekinut"") {
                            element.classList.add(""prek"");
                        }
                        else if (element.innerText == ""Završen"") {
                            element.classList.add(""zavrs"");
                        }
                    </script>
                    <td>
                        <a class=""btn btn-primary""");
            BeginWriteAttribute("href", " href=\"", 2052, "\"", 2111, 2);
            WriteAttributeValue("", 2059, "/SuperAdmin/ProjekatPlan/Uredi?id=", 2059, 34, true);
#nullable restore
#line 52 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 2093, x.ProjekatPlan_ID, 2093, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uredi</a>\r\n                        <a");
            BeginWriteAttribute("id", " id=\"", 2150, "\"", 2180, 2);
            WriteAttributeValue("", 2155, "ukloni_", 2155, 7, true);
#nullable restore
#line 53 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 2162, x.ProjekatPlan_ID, 2162, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\" style=\"color:white\">Ukloni</a>\r\n\r\n                        <span style=\"color:black; position:absolute;float:right;margin-left:1%;\"");
            BeginWriteAttribute("id", " id=\"", 2335, "\"", 2365, 2);
            WriteAttributeValue("", 2340, "poruka_", 2340, 7, true);
#nullable restore
#line 55 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 2347, x.ProjekatPlan_ID, 2347, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sigurni? <a");
            BeginWriteAttribute("href", " href=\"", 2378, "\"", 2438, 2);
            WriteAttributeValue("", 2385, "/SuperAdmin/ProjekatPlan/Ukloni?id=", 2385, 35, true);
#nullable restore
#line 55 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 2420, x.ProjekatPlan_ID, 2420, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:black; font-weight:bold;\">Da</a> <a");
            BeginWriteAttribute("id", " id=\"", 2488, "\"", 2514, 2);
            WriteAttributeValue("", 2493, "no_", 2493, 3, true);
#nullable restore
#line 55 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
WriteAttributeValue("", 2496, x.ProjekatPlan_ID, 2496, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:black;cursor:pointer; font-weight:bold;\">Ne</a></span>\r\n                        <script>\r\n                            $(\"#poruka_");
#nullable restore
#line 57 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
                                  Write(x.ProjekatPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").hide();\r\n\r\n                            $(\"#ukloni_");
#nullable restore
#line 59 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
                                  Write(x.ProjekatPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").click(function () {\r\n\r\n                                $(\"#poruka_");
#nullable restore
#line 61 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
                                      Write(x.ProjekatPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").slideDown();\r\n                            });\r\n\r\n                            $(\"#no_");
#nullable restore
#line 64 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
                              Write(x.ProjekatPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").click(function () {\r\n                                $(\"#poruka_");
#nullable restore
#line 65 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
                                      Write(x.ProjekatPlan_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").slideUp();\r\n                            });\r\n                        </script>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 70 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatPlan\Prikaz.cshtml"
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
