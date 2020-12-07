#pragma checksum "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Uredi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9462f4697b215bac65cad43c575cc55645d2d626"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_OrganizacionaJedinica_Uredi), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/OrganizacionaJedinica/Uredi.cshtml")]
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
#line 1 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Uredi.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Uredi.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9462f4697b215bac65cad43c575cc55645d2d626", @"/Areas/SuperAdmin/Views/OrganizacionaJedinica/Uredi.cshtml")]
    public class Areas_SuperAdmin_Views_OrganizacionaJedinica_Uredi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Uredi.cshtml"
  
    Layout = "~/Views/Shared/_Layout_admin.cshtml";

    OrganizacionaJedinica org_jed = (OrganizacionaJedinica)ViewData["org_jed"];
    List<Drzava> drzave = (List<Drzava>)ViewData["drzava"];
    List<Organizacija> organizacije = (List<Organizacija>)ViewData["organizacija"];
    List<PTT> ptt = (List<PTT>)ViewData["ptt"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<center>
    <form method=""post"" action=""/SuperAdmin/OrganizacionaJedinica/UrediSnimi"">
        <h1>Uređivanje Organizacione Jedinice</h1>
        <table>
            <tr>
                <td>
                    <label>
                        Naziv
                    </label>
                </td>
                <td>
                    <input type=""text"" name=""naziv""");
            BeginWriteAttribute("value", " value=\"", 790, "\"", 812, 1);
#nullable restore
#line 22 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 798, org_jed.Naziv, 798, 14, false);

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
                        Organizacija
                    </label>
                </td>
                <td>
                    <select name=""organizacija"">
                        <option");
            BeginWriteAttribute("value", " value=\"", 1123, "\"", 1155, 1);
#nullable restore
#line 33 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 1131, org_jed.Organizacija_FK, 1131, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 33 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Uredi.cshtml"
                                                            Write(org_jed.organizacija.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 34 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Uredi.cshtml"
                         foreach (var x in organizacije)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 1315, "\"", 1341, 1);
#nullable restore
#line 36 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 1323, x.Organizacija_ID, 1323, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 36 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Uredi.cshtml"
                                                          Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 37 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Uredi.cshtml"
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
                        Adresa
                    </label>
                </td>
                <td>
                    <input type=""text"" name=""adresa""");
            BeginWriteAttribute("value", " value=\"", 1690, "\"", 1713, 1);
#nullable restore
#line 48 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 1698, org_jed.Adresa, 1698, 15, false);

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
                        Država
                    </label>
                </td>
                <td>
                    <select name=""drzava"">
                        <option");
            BeginWriteAttribute("value", " value=\"", 2012, "\"", 2038, 1);
#nullable restore
#line 59 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 2020, org_jed.Drzava_FK, 2020, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 59 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Uredi.cshtml"
                                                      Write(org_jed.drzava.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 60 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Uredi.cshtml"
                         foreach (var x in drzave)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 2186, "\"", 2206, 1);
#nullable restore
#line 62 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 2194, x.Drzava_ID, 2194, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 62 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Uredi.cshtml"
                                                    Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 63 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Uredi.cshtml"
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
                        <option");
            BeginWriteAttribute("value", " value=\"", 2572, "\"", 2595, 1);
#nullable restore
#line 75 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 2580, org_jed.PTT_FK, 2580, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 75 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Uredi.cshtml"
                                                   Write(org_jed.ptt.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 76 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Uredi.cshtml"
                         foreach (var x in ptt)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 2737, "\"", 2754, 1);
#nullable restore
#line 78 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 2745, x.PTT_ID, 2745, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 78 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Uredi.cshtml"
                                                 Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 79 "D:\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\OrganizacionaJedinica\Uredi.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </select>\r\n                </td>\r\n            </tr>\r\n        </table>\r\n        <button class=\"btn btn-primary\" type=\"submit\">Snimi</button>\r\n    </form>\r\n</center>");
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
