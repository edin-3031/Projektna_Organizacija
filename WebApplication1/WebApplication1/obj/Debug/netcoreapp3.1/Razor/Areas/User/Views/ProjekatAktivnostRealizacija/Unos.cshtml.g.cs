#pragma checksum "D:\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Unos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e60ca01e63f0f63c4166463d81c8bdbafa33b4d"
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
#line 1 "D:\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e60ca01e63f0f63c4166463d81c8bdbafa33b4d", @"/Areas/User/Views/ProjekatAktivnostRealizacija/Unos.cshtml")]
    public class Areas_User_Views_ProjekatAktivnostRealizacija_Unos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
  
    List<dropdownAdminOrgUnosRealVM> lista_proj_aktiv_plan = (List<dropdownAdminOrgUnosRealVM>)ViewData["lista_proj_aktiv_plan"];
    List<Korisnici> lista_korisnici = (List<Korisnici>)ViewData["lista_korisnici"];

    Layout = "~/Views/Shared/_Layout_user.cshtml";

    byte[] pic = (byte[])ViewData["logo"];
    var base64 = Convert.ToBase64String(pic);
    var imgsrc = string.Format("data:image/gif;base64,{0}", base64);

#line default
#line hidden
#nullable disable
            WriteLiteral("<center>\r\n    <div id=\"zaglavlje\" style=\"width:100%\">\r\n        <h1 style=\"position:relative; display:inline;\">Unos realizacije</h1>\r\n        <img style=\"height:7vw; width:7vw; position:relative; float:right; display:inline;\"");
            BeginWriteAttribute("src", " src=\"", 731, "\"", 744, 1);
#nullable restore
#line 16 "D:\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 737, imgsrc, 737, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
    </div>

    <form method=""post"" action=""/User/ProjekatAktivnostRealizacija/UnosSnimi"">
        <table>
            <tr>
                <td><label>Projektna aktivnost</label></td>
                <td>
                    <select name=""projekatAktivnostPlan"">
                        <option>---Odaberi---</option>
");
#nullable restore
#line 26 "D:\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
                         foreach (var x in lista_proj_aktiv_plan)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 1206, "\"", 1228, 1);
#nullable restore
#line 28 "D:\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 1214, x.aktivnostId, 1214, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "D:\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
                                                      Write(x.aktivnost);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 28 "D:\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
                                                                    Write(x.projekat);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</option>\r\n");
#nullable restore
#line 29 "D:\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
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
#line 38 "D:\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
                         foreach (var x in lista_korisnici)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 1682, "\"", 1705, 1);
#nullable restore
#line 40 "D:\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
WriteAttributeValue("", 1690, x.Korisnici_ID, 1690, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 40 "D:\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
                                                        Write(x.Ime+" "+x.Prezime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 41 "D:\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Unos.cshtml"
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
