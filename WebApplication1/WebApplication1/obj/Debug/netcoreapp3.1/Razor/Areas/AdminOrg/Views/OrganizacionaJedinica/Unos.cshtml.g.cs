#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33347a20e5f864d90c7af2902df1708da0ac1df6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminOrg_Views_OrganizacionaJedinica_Unos), @"mvc.1.0.view", @"/Areas/AdminOrg/Views/OrganizacionaJedinica/Unos.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33347a20e5f864d90c7af2902df1708da0ac1df6", @"/Areas/AdminOrg/Views/OrganizacionaJedinica/Unos.cshtml")]
    public class Areas_AdminOrg_Views_OrganizacionaJedinica_Unos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
  
    //List<Organizacija> lista_organicija = (List<Organizacija>)ViewData["organizacije"];
    Organizacija organicija = (Organizacija)ViewData["organizacija"];
    List<PTT> lista_ptt = (List<PTT>)ViewData["ptt"];
    List<Drzava> lista_drzava = (List<Drzava>)ViewData["drzava"];
    Layout = "~/Views/Shared/_Layout_admin_org.cshtml";

    uor id = (uor)ViewData["id"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>


    li, ul {
        list-style: none;
        margin-top: 5%;
    }

    ul {
        margin: 0px;
        padding: 0px;
        border: 0px;
    }

    #sifarnik, #transakcije, #izvjestaji, #admin {
        font-weight: bold;
    }

    a {
        color: white;
        text-decoration-line: none;
    }

    #dodaj, #detalji, #print_preview, #print_excel, #print_pdf {
        display: inline-block;
        margin: 2%;
    }

    #print_preview, #print_excel, #print_pdf {
        color: white;
    }

    #dugmad {
        margin-bottom: 2%;
        margin-top: 2%;
    }

    a:hover {
        color: white;
        text-decoration: none;
        text-decoration-line: none;
    }

    #kutijaZaMeni {
        position: fixed;
        height: 100%;
        width: 17%;
        /*            background-color:green;*/
        display: block;
        margin-left: -17.8%;
    }

    #menu {
        position: fixed;
        /*height: 65%;*/
        wid");
            WriteLiteral(@"th: 15%;
        margin-left: 0px;
        background-color: rgba(0, 0, 0, 0.8);
        color: white;
        top: 20%;
        font-size: 1vw;
        border-radius: 0px 25px 25px 0px;
    }
</style>
<div id=""kutijaZaMeni"">
    <div id=""menu"">
        <br />
        <a style=""color:white; text-decoration-line:none; font-size:120%;""");
            BeginWriteAttribute("href", " href=\"", 1946, "\"", 2024, 6);
            WriteAttributeValue("", 1953, "/AdminOrg/AdminOrg/Index?u=", 1953, 27, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 1980, id.userId, 1980, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1990, "&o=", 1990, 3, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 1993, id.organisationId, 1993, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2011, "&r=", 2011, 3, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2014, id.roleId, 2014, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"sifarnik\">Opšti šifarnik</li>\r\n            <ul id=\"o_s\">\r\n\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2182, "\"", 2274, 6);
            WriteAttributeValue("", 2189, "/AdminOrg/OrganizacionaJedinica/Prikaz?u=", 2189, 41, true);
#nullable restore
#line 88 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2230, id.userId, 2230, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2240, "&o=", 2240, 3, true);
#nullable restore
#line 88 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2243, id.organisationId, 2243, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2261, "&r=", 2261, 3, true);
#nullable restore
#line 88 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2264, id.roleId, 2264, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizaciona jedinica</a></li>\r\n            </ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2430, "\"", 2522, 6);
            WriteAttributeValue("", 2437, "/AdminOrg/ProjekatAktivnostPlan/Prikaz?u=", 2437, 41, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2478, id.userId, 2478, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2488, "&o=", 2488, 3, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2491, id.organisationId, 2491, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2509, "&r=", 2509, 3, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2512, id.roleId, 2512, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n\r\n        </ul>\r\n    </div>\r\n</div>\r\n\r\n<center>\r\n    <h1>Unos Organizacione jedinice</h1>\r\n    <form method=\"post\" action=\"/AdminOrg/OrganizacionaJedinica/UnosSnimi?\">\r\n\r\n        <input hidden=\"hidden\" name=\"u\"");
            BeginWriteAttribute("value", " value=\"", 2774, "\"", 2792, 1);
#nullable restore
#line 104 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2782, id.userId, 2782, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"o\"");
            BeginWriteAttribute("value", " value=\"", 2837, "\"", 2863, 1);
#nullable restore
#line 105 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2845, id.organisationId, 2845, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"r\"");
            BeginWriteAttribute("value", " value=\"", 2908, "\"", 2926, 1);
#nullable restore
#line 106 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2916, id.roleId, 2916, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n        <table>\r\n            <tr>\r\n                <td>\r\n                    <label>\r\n                        Organizacija\r\n                    </label>\r\n                </td>\r\n                <td>\r\n                    <input readonly=\"readonly\"");
            BeginWriteAttribute("value", " value=\"", 3179, "\"", 3204, 1);
#nullable restore
#line 116 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 3187, organicija.Naziv, 3187, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                    <input hidden=\"hidden\" name=\"organizacija\"");
            BeginWriteAttribute("value", " value=\"", 3271, "\"", 3306, 1);
#nullable restore
#line 117 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 3279, organicija.Organizacija_ID, 3279, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n");
            WriteLiteral(@"                </td>
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
#line 136 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
                         foreach (var x in lista_ptt)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 4079, "\"", 4096, 1);
#nullable restore
#line 138 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 4087, x.PTT_ID, 4087, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 138 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
                                                 Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 139 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
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
#line 152 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
                         foreach (var x in lista_drzava)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 4613, "\"", 4634, 1);
#nullable restore
#line 154 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 4621, x.Drazava_ID, 4621, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 154 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
                                                     Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 155 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
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
                    <input type=""text"" name=""naziv_org_jed"" />
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
