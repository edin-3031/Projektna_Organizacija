#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Uredi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd4b3eb285c0d8b74cdb866b5463b871cb5299db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_ProjekatAktivnostPlan_Uredi), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/ProjekatAktivnostPlan/Uredi.cshtml")]
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
#line 1 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Uredi.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Uredi.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd4b3eb285c0d8b74cdb866b5463b871cb5299db", @"/Areas/SuperAdmin/Views/ProjekatAktivnostPlan/Uredi.cshtml")]
    public class Areas_SuperAdmin_Views_ProjekatAktivnostPlan_Uredi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Uredi.cshtml"
  
    List<ProjekatPlanVM> lista_proj_plan = (List<ProjekatPlanVM>)ViewData["p_p"];
    ProjekatAktivnostPlan p_a = (ProjekatAktivnostPlan)ViewData["proj_aktiv"];

    Layout = "~/Views/Shared/_Layout_admin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<center>\r\n    <h1>Uređivanje aktivnosti projekta</h1>\r\n    <form method=\"post\" action=\"/SuperAdmin/ProjekatAktivnostPlan/UrediSnimi\">\r\n        <input name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 451, "\"", 488, 1);
#nullable restore
#line 12 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Uredi.cshtml"
WriteAttributeValue("", 459, p_a.ProjekatAktivnostPlan_ID, 459, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" hidden=""hidden""/>
        <table>
            <tr>
                <td>
                    <label>
                        Naziv
                    </label>
                </td>
                <td>
                    <input type=""text"" name=""naziv""");
            BeginWriteAttribute("value", " value=\"", 752, "\"", 770, 1);
#nullable restore
#line 21 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Uredi.cshtml"
WriteAttributeValue("", 760, p_a.Naziv, 760, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Šifra
                    </label>
                </td>
                <td>
                    <input type=""text"" name=""sifra""");
            BeginWriteAttribute("value", " value=\"", 1044, "\"", 1062, 1);
#nullable restore
#line 31 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Uredi.cshtml"
WriteAttributeValue("", 1052, p_a.Sifra, 1052, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Projekat
                    </label>
                </td>
                <td>
                    <select name=""proj_plan_id"">
                        <option");
            BeginWriteAttribute("value", " value=\"", 1369, "\"", 1397, 1);
#nullable restore
#line 42 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Uredi.cshtml"
WriteAttributeValue("", 1377, p_a.ProjekatPlan_FK, 1377, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 42 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Uredi.cshtml"
                                                        Write(p_a.projekatPlan.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 43 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Uredi.cshtml"
                         foreach (var x in lista_proj_plan)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 1556, "\"", 1582, 1);
#nullable restore
#line 45 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Uredi.cshtml"
WriteAttributeValue("", 1564, x.ProjekatPlan_ID, 1564, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 45 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Uredi.cshtml"
                                                          Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 45 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Uredi.cshtml"
                                                                    Write(x.OrganizacionaJedinica_naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</option>\r\n");
#nullable restore
#line 46 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Uredi.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </select>
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Datum od
                    </label>
                </td>
                <td>
                    <input type=""datetime"" name=""OD""");
            BeginWriteAttribute("value", " value=\"", 1966, "\"", 1986, 1);
#nullable restore
#line 57 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Uredi.cshtml"
WriteAttributeValue("", 1974, p_a.DatumOd, 1974, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Naziv
                    </label>
                </td>
                <td>
                    <input type=""datetime"" name=""DO""");
            BeginWriteAttribute("value", " value=\"", 2261, "\"", 2281, 1);
#nullable restore
#line 67 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Uredi.cshtml"
WriteAttributeValue("", 2269, p_a.DatumDo, 2269, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Jedinica mjere
                    </label>
                </td>
                <td>
                    <input type=""text"" name=""jedinicaMjere""");
            BeginWriteAttribute("value", " value=\"", 2572, "\"", 2598, 1);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Uredi.cshtml"
WriteAttributeValue("", 2580, p_a.JedinicaMjere, 2580, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Količina
                    </label>
                </td>
                <td>
                    <input type=""text"" name=""kolicina""");
            BeginWriteAttribute("value", " value=\"", 2878, "\"", 2899, 1);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Uredi.cshtml"
WriteAttributeValue("", 2886, p_a.Kolicina, 2886, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </td>\r\n            </tr>\r\n\r\n        </table>\r\n\r\n        <button class=\"btn btn-primary\" type=\"submit\">Snimi</button>\r\n    </form>\r\n</center>");
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
