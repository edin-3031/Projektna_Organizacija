#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Unos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dafd5167e38838dc155154c7bc9020725b11408"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_ProjekatAktivnostRealizacija_Unos), @"mvc.1.0.view", @"/Areas/User/Views/ProjekatAktivnostRealizacija/Unos.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dafd5167e38838dc155154c7bc9020725b11408", @"/Areas/User/Views/ProjekatAktivnostRealizacija/Unos.cshtml")]
    public class Areas_User_Views_ProjekatAktivnostRealizacija_Unos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
  
    List<ProjekatAktivnostPlan> lista_proj_aktiv_plan = (List<ProjekatAktivnostPlan>)ViewData["lista_proj_aktiv_plan"];

    List<Korisnici> lista_korisnici = (List<Korisnici>)ViewData["lista_korisnici"];
    Layout = "~/Views/Shared/_Layout_user.cshtml";
    uor id = (uor)ViewData["id"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<center>\r\n    <h1>Unos Realizacije</h1>\r\n    <form method=\"post\" action=\"/User/ProjekatAktivnostRealizacija/UnosSnimi\">\r\n\r\n        <input hidden=\"hidden\" name=\"u\"");
            BeginWriteAttribute("value", " value=\"", 654, "\"", 672, 1);
#nullable restore
#line 17 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 662, id.userId, 662, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n        <input hidden=\"hidden\" name=\"o\"");
            BeginWriteAttribute("value", " value=\"", 716, "\"", 742, 1);
#nullable restore
#line 18 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 724, id.organisationId, 724, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n        <input hidden=\"hidden\" name=\"r\"");
            BeginWriteAttribute("value", " value=\"", 786, "\"", 804, 1);
#nullable restore
#line 19 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 794, id.roleId, 794, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n        <table>\r\n            <tr>\r\n                <td><label>Projektna aktivnost</label></td>\r\n                <td>\r\n                    <select name=\"projekatAktivnostPlan\">\r\n                        <option>---Odaberi---</option>\r\n");
#nullable restore
#line 26 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
                         foreach (var x in lista_proj_aktiv_plan)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 1171, "\"", 1206, 1);
#nullable restore
#line 28 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 1179, x.ProjekatAktivnostPlan_ID, 1179, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
                                                                   Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 29 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
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
#line 38 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
                         foreach (var x in lista_korisnici)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 1642, "\"", 1665, 1);
#nullable restore
#line 40 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 1650, x.Korisnici_ID, 1650, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 40 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
                                                        Write(x.Ime+" "+x.Prezime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 41 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
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
