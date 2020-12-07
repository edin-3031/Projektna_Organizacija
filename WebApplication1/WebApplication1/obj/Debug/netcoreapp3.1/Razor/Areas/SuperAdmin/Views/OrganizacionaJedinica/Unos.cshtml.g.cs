#pragma checksum "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Unos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2764089f220b647dae3fa1ae7f1b7a5cec565c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_OrganizacionaJedinica_Unos), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/OrganizacionaJedinica/Unos.cshtml")]
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
#line 1 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Unos.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Unos.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2764089f220b647dae3fa1ae7f1b7a5cec565c9", @"/Areas/SuperAdmin/Views/OrganizacionaJedinica/Unos.cshtml")]
    public class Areas_SuperAdmin_Views_OrganizacionaJedinica_Unos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Unos.cshtml"
  
    List<Organizacija> lista_organicija = (List<Organizacija>)ViewData["organizacije"];
    List<PTT> lista_ptt = (List<PTT>)ViewData["ptt"];
    List<Drzava> lista_drzava = (List<Drzava>)ViewData["drzava"];

    Layout = "~/Views/Shared/_Layout_admin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<center>
    <h1>Unos Organizacione jedinice</h1>
    <form method=""post"" action=""/SuperAdmin/OrganizacionaJedinica/UnosSnimi"">
        <table>
            <tr>
                <td>
                    <label>
                        Organizacija
                    </label>
                </td>
                <td>
                    <select name=""organizacija"">
                        <option>---Odaberi---</option>
");
#nullable restore
#line 23 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Unos.cshtml"
                         foreach (var x in lista_organicija)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 900, "\"", 926, 1);
#nullable restore
#line 25 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 908, x.Organizacija_ID, 908, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 25 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Unos.cshtml"
                                                          Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 26 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Unos.cshtml"
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
                        PTT
                    </label>
                </td>
                <td>
                    <select name=""ptt"">
                        <option>---Odaberi---</option>
");
#nullable restore
#line 39 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Unos.cshtml"
                         foreach (var x in lista_ptt)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 1434, "\"", 1451, 1);
#nullable restore
#line 41 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 1442, x.PTT_ID, 1442, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 41 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Unos.cshtml"
                                                 Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 42 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Unos.cshtml"
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
                        Država
                    </label>
                </td>
                <td>
                    <select name=""drzava"">
                        <option>---Odaberi---</option>
");
#nullable restore
#line 55 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Unos.cshtml"
                         foreach (var x in lista_drzava)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 1968, "\"", 1988, 1);
#nullable restore
#line 57 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 1976, x.Drzava_ID, 1976, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 57 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Unos.cshtml"
                                                    Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 58 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Unos.cshtml"
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
                        Adresa
                    </label>
                </td>
                <td>
                    <input type=""text"" name=""adresa"" />
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
