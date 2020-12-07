#pragma checksum "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Unos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2cbb7d713d7d9c37759aa29e9f9d96867acb414"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminOrg_Views_KorisnikOrg_Unos), @"mvc.1.0.view", @"/Areas/AdminOrg/Views/KorisnikOrg/Unos.cshtml")]
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
#line 1 "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Unos.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Unos.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2cbb7d713d7d9c37759aa29e9f9d96867acb414", @"/Areas/AdminOrg/Views/KorisnikOrg/Unos.cshtml")]
    public class Areas_AdminOrg_Views_KorisnikOrg_Unos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Unos.cshtml"
  
    List<Korisnici> lista_korisnici = (List<Korisnici>)ViewData["korisnik"];
    List<OrganizacionaJedinica> lista_org_jed = (List<OrganizacionaJedinica>)ViewData["org_jed"];
   
    Layout = "~/Views/Shared/_Layout_admin_org.cshtml";

    byte[] pic = (byte[])ViewData["logo"];
    var base64 = Convert.ToBase64String(pic);
    var imgsrc = string.Format("data:image/gif;base64,{0}", base64);

#line default
#line hidden
#nullable disable
            WriteLiteral("<center>\r\n    <div id=\"zaglavlje\" style=\"width:100%\">\r\n        <h1 style=\"position:relative; display:inline;\">Unos Korisnika - Organizacione Jedinice</h1>\r\n        <img style=\"height:7vw; width:7vw; position:relative; float:right; display:inline;\"");
            BeginWriteAttribute("src", " src=\"", 723, "\"", 736, 1);
#nullable restore
#line 16 "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Unos.cshtml"
WriteAttributeValue("", 729, imgsrc, 729, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
    </div>
    <form method=""post"" action=""/AdminOrg/KorisnikOrg/UnosSnimi"">
        <table>
            <tr>
                <td>
                    <label>
                        Korisnik
                    </label>
                </td>
                <td>
                    <select name=""korisnik"">
                        <option>---Odaberi---</option>
");
#nullable restore
#line 29 "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Unos.cshtml"
                         foreach (var x in lista_korisnici)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 1241, "\"", 1264, 1);
#nullable restore
#line 31 "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Unos.cshtml"
WriteAttributeValue("", 1249, x.Korisnici_ID, 1249, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 31 "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Unos.cshtml"
                                                        Write(x.Ime + " " + x.Prezime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 32 "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Unos.cshtml"
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
                        Organizaciona jedinica
                    </label>
                </td>
                <td>
                    <select name=""organizacionaJedinica"">
                        <option>---Odaberi---</option>
");
#nullable restore
#line 45 "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Unos.cshtml"
                         foreach (var x in lista_org_jed)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 1831, "\"", 1866, 1);
#nullable restore
#line 47 "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Unos.cshtml"
WriteAttributeValue("", 1839, x.OrganizacionaJedinica_ID, 1839, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 47 "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Unos.cshtml"
                                                                   Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 48 "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Unos.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </select>\r\n                </td>\r\n            </tr>\r\n        </table>\r\n        <button class=\"btn btn-success\" type=\"submit\">Dodaj nove</button>\r\n    </form>\r\n</center>");
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
