#pragma checksum "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "817d2df0c4db48e8f570646f2fe7b868aa4bda38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminOrg_Views_Korisnik_Unos), @"mvc.1.0.view", @"/Areas/AdminOrg/Views/Korisnik/Unos.cshtml")]
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
#line 1 "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"817d2df0c4db48e8f570646f2fe7b868aa4bda38", @"/Areas/AdminOrg/Views/Korisnik/Unos.cshtml")]
    public class Areas_AdminOrg_Views_Korisnik_Unos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
  
    List<Uloge> lista_uloge = (List<Uloge>)ViewData["uloge"];
    List<OrganizacionaJedinica>org_jed=(List<OrganizacionaJedinica>) ViewData["organizacione_jedinice"];

    Layout = "~/Views/Shared/_Layout_admin_org.cshtml";

    byte[] pic = (byte[])ViewData["logo"];
    var base64 = Convert.ToBase64String(pic);
    var imgsrc = string.Format("data:image/gif;base64,{0}", base64);

#line default
#line hidden
#nullable disable
            WriteLiteral("<center>\r\n    <div id=\"zaglavlje\" style=\"width:100%\">\r\n        <h1 style=\"position:relative; display:inline;\">Unos korisnika</h1>\r\n        <img style=\"height:7vw; width:7vw; position:relative; float:right; display:inline;\"");
            BeginWriteAttribute("src", " src=\"", 687, "\"", 700, 1);
#nullable restore
#line 16 "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 693, imgsrc, 693, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
    </div>
    <form action=""/AdminOrg/Korisnik/UnosSnimi"">
        <table>
            <tr>
                <td><label>Šifra</label></td>
                <td><input type=""text"" name=""sifra"" /></td>
            </tr>
            <tr>
                <td><label>Ime</label></td>
                <td><input type=""text"" name=""ime"" /></td>
            </tr>
            <tr>
                <td><label>Prezime</label></td>
                <td><input type=""text"" name=""prezime"" /></td>
            </tr>
            <tr>
                <td><label>Telefon</label></td>
                <td><input type=""text"" name=""telefon"" /></td>
            </tr>
            <tr>
                <td><label>Mail</label></td>
                <td><input type=""text"" name=""mail"" /></td>
            </tr>
            <tr>
                <td><label>Korisničko ime</label></td>
                <td><input type=""text"" name=""username"" /></td>
            </tr>
            <tr>
                <td><label>Lozinka</la");
            WriteLiteral(@"bel></td>
                <td><input type=""password"" name=""lozinka"" /></td>
            </tr>
            <tr>
                <td>
                    <label>Organizaciona jedinica</label>
                </td>
                <td>
                    <select name=""Org_jed_id"">
                        <option>---Odaberi---</option>
");
#nullable restore
#line 55 "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
                         foreach (var x in org_jed)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 2185, "\"", 2220, 1);
#nullable restore
#line 57 "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 2193, x.OrganizacionaJedinica_ID, 2193, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 57 "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
                                                                   Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 58 "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </select>
                </td>
            </tr>
            <tr>
                <td>
                    <label>Uloga</label>
                </td>
                <td>
                    <select name=""uloga"">
                        <option>---Odaberi---</option>
");
#nullable restore
#line 69 "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
                         foreach (var x in lista_uloge)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 2686, "\"", 2705, 1);
#nullable restore
#line 71 "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 2694, x.Uloge_ID, 2694, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2706, "\"", 2721, 1);
#nullable restore
#line 71 "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 2714, x.Opis, 2714, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 71 "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
                                                                   Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 72 "D:\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </select>\r\n                </td>\r\n            </tr>\r\n        </table>\r\n        <button type=\"submit\" class=\"btn btn-primary\">Snimi</button>\r\n    </form>\r\n</center>");
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
