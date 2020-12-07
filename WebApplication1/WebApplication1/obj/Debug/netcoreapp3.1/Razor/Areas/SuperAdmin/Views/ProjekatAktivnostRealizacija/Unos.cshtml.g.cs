#pragma checksum "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostRealizacija\Unos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11864b5ccc9e73d769bbde319e69ddda1c29b33a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_ProjekatAktivnostRealizacija_Unos), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/ProjekatAktivnostRealizacija/Unos.cshtml")]
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
#line 1 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11864b5ccc9e73d769bbde319e69ddda1c29b33a", @"/Areas/SuperAdmin/Views/ProjekatAktivnostRealizacija/Unos.cshtml")]
    public class Areas_SuperAdmin_Views_ProjekatAktivnostRealizacija_Unos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
  
    List<ProjekatAktivnostPlanVM> lista_proj_aktiv_plan = (List<ProjekatAktivnostPlanVM>)ViewData["lista_proj_aktiv_plan"];
    Layout = "~/Views/Shared/_Layout_admin.cshtml";

    List<Korisnici> lista_korisnici = (List<Korisnici>)ViewData["lista_korisnici"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<center>
    <h1>Unos Realizacije</h1>
    <form method=""post"" action=""/SuperAdmin/ProjekatAktivnostRealizacija/UnosSnimi"">
        <table>
            <tr>
                <td><label>Projektna aktivnost</label></td>
                <td>
                    <select name=""projekatAktivnostPlan"">
                        <option>---Odaberi---</option>
");
#nullable restore
#line 18 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
                         foreach (var x in lista_proj_aktiv_plan)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 828, "\"", 863, 1);
#nullable restore
#line 20 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 836, x.ProjekatAktivnostPlan_ID, 836, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 20 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
                                                                   Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 20 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
                                                                             Write(x.ProjekatPlan_naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</option>\r\n");
#nullable restore
#line 21 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </select>
                </td>
            </tr>
            <tr>
                <td><label>Korisnik</label></td>
                <td>
                    <select name=""korisnik"">
                        <option>---Odaberi---</option>
");
#nullable restore
#line 30 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
                         foreach (var x in lista_korisnici)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 1323, "\"", 1346, 1);
#nullable restore
#line 32 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 1331, x.Korisnici_ID, 1331, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 32 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
                                                        Write(x.Ime+" "+x.Prezime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 33 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </select>
                </td>
            </tr>
            <tr>
                <td><label>Datum</label></td>
                <td>
                    <input name=""datum"" type=""datetime-local"" />
                </td>
            </tr>
            <tr>
                <td><label>Količina</label></td>
                <td>
                    <input name=""kolicina"" type=""text"" />
                </td>
            </tr>
            <tr>
                <td><label>Opis</label></td>
                <td>
                    <input name=""opis"" type=""text"" />
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
