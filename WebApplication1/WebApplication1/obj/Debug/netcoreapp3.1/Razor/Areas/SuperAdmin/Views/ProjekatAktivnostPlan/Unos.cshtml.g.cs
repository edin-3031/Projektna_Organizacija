#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f0e252e667f976c406a5ddf9dc619798c4d0f4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_ProjekatAktivnostPlan_Unos), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/ProjekatAktivnostPlan/Unos.cshtml")]
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
#line 1 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f0e252e667f976c406a5ddf9dc619798c4d0f4f", @"/Areas/SuperAdmin/Views/ProjekatAktivnostPlan/Unos.cshtml")]
    public class Areas_SuperAdmin_Views_ProjekatAktivnostPlan_Unos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
  
    List<ProjekatPlanVM> lista_proj_plan = (List<ProjekatPlanVM>)ViewData["lista_proj_plan"];

    Layout = "~/Views/Shared/_Layout_admin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<center>
    <h1>Unos Projektnih aktivnosti</h1>
    <form method=""post"" action=""/SuperAdmin/ProjekatAktivnostPlan/UnosSnimi"">
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
#line 21 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
                         foreach (var x in lista_proj_plan)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 783, "\"", 809, 1);
#nullable restore
#line 23 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
WriteAttributeValue("", 791, x.ProjekatPlan_ID, 791, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 23 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
                                                          Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 23 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
                                                                    Write(x.OrganizacionaJedinica_naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</option>\r\n");
#nullable restore
#line 24 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostPlan\Unos.cshtml"
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
