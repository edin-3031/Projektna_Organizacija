#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Unos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29c9e0ccf973e4ff22077ade71b21993b6395e15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminOrg_Views_ProjekatAktivnostPlan_Unos), @"mvc.1.0.view", @"/Areas/AdminOrg/Views/ProjekatAktivnostPlan/Unos.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Unos.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Unos.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29c9e0ccf973e4ff22077ade71b21993b6395e15", @"/Areas/AdminOrg/Views/ProjekatAktivnostPlan/Unos.cshtml")]
    public class Areas_AdminOrg_Views_ProjekatAktivnostPlan_Unos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Unos.cshtml"
  
    List<ProjekatPlan> lista_proj_plan = (List<ProjekatPlan>)ViewData["lista_proj_plan"];
    Layout = "~/Views/Shared/_Layout_admin_org.cshtml";
    uor id = (uor)ViewData["id"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<center>\r\n    <h1>Unos Projektnog Plana</h1>\r\n    <form method=\"post\" action=\"/AdminOrg/ProjekatAktivnostPlan/UnosSnimi\">\r\n        <input name=\"u\"");
            BeginWriteAttribute("value", " value=\"", 528, "\"", 546, 1);
#nullable restore
#line 15 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 536, id.userId, 536, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden=\"hidden\"/>\r\n        <input name=\"o\"");
            BeginWriteAttribute("value", " value=\"", 590, "\"", 616, 1);
#nullable restore
#line 16 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 598, id.organisationId, 598, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden=\"hidden\"/>\r\n        <input name=\"r\"");
            BeginWriteAttribute("value", " value=\"", 660, "\"", 678, 1);
#nullable restore
#line 17 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 668, id.roleId, 668, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" hidden=""hidden""/>
        <table>
            <tr>
                <td>
                    <label>
                        Projekat plan
                    </label>
                </td>
                <td>
                    <select name=""projekatPlan"">
                        <option>---Odaberi---</option>
");
#nullable restore
#line 28 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Unos.cshtml"
                         foreach (var x in lista_proj_plan)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 1128, "\"", 1154, 1);
#nullable restore
#line 30 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 1136, x.ProjekatPlan_ID, 1136, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 30 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Unos.cshtml"
                                                          Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 31 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostPlan\Unos.cshtml"
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
                        Šifra
                    </label>
                </td>
                <td>
                    <input type=""text"" name=""sifra"" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Naziv
                    </label>
                </td>
                <td>
                    <input type=""text"" name=""naziv"" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Datum od
                    </label>
                </td>
                <td>
                    <input type=""datetime-local"" name=""Od"" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Datum do
                   ");
            WriteLiteral(@" </label>
                </td>
                <td>
                    <input type=""datetime-local"" name=""Do"" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Jedinica mjere
                    </label>
                </td>
                <td>
                    <input type=""text"" name=""jedinicaMjere"" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Količina
                    </label>
                </td>
                <td>
                    <input type=""text"" name=""kolicina"" />
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
