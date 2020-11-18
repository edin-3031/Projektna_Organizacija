#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95600cd139eef5fa0d128b443971ce03e0fc7bc9"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95600cd139eef5fa0d128b443971ce03e0fc7bc9", @"/Areas/AdminOrg/Views/OrganizacionaJedinica/Unos.cshtml")]
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

    byte[] pic = (byte[])ViewData["logo"];


    var base64 = Convert.ToBase64String(pic);
    var imgsrc = string.Format("data:image/gif;base64,{0}", base64);

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
            BeginWriteAttribute("href", " href=\"", 2113, "\"", 2191, 6);
            WriteAttributeValue("", 2120, "/AdminOrg/AdminOrg/Index?u=", 2120, 27, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2147, id.userId, 2147, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2157, "&o=", 2157, 3, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2160, id.organisationId, 2160, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2178, "&r=", 2178, 3, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2181, id.roleId, 2181, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"sifarnik\">Opšti šifarnik</li>\r\n            <ul id=\"o_s\">\r\n\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2349, "\"", 2441, 6);
            WriteAttributeValue("", 2356, "/AdminOrg/OrganizacionaJedinica/Prikaz?u=", 2356, 41, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2397, id.userId, 2397, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2407, "&o=", 2407, 3, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2410, id.organisationId, 2410, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2428, "&r=", 2428, 3, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2431, id.roleId, 2431, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizaciona jedinica</a></li>\r\n            </ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2597, "\"", 2689, 6);
            WriteAttributeValue("", 2604, "/AdminOrg/ProjekatAktivnostPlan/Prikaz?u=", 2604, 41, true);
#nullable restore
#line 99 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2645, id.userId, 2645, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2655, "&o=", 2655, 3, true);
#nullable restore
#line 99 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2658, id.organisationId, 2658, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2676, "&r=", 2676, 3, true);
#nullable restore
#line 99 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2679, id.roleId, 2679, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Aktivnosti</a></li>
            </ul>

        </ul>
    </div>
</div>

<center>
    <div id=""zaglavlje"" style=""width:100%"">
        <h1 style=""position:relative; display:inline;"">Unos Organizacione Jedinice</h1>
        <img style=""height:7vw; width:7vw; position:relative; float:right; display:inline;""");
            BeginWriteAttribute("src", " src=\"", 3005, "\"", 3018, 1);
#nullable restore
#line 109 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 3011, imgsrc, 3011, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <form method=\"post\" action=\"/AdminOrg/OrganizacionaJedinica/UnosSnimi?\">\r\n\r\n        <input hidden=\"hidden\" name=\"u\"");
            BeginWriteAttribute("value", " value=\"", 3155, "\"", 3173, 1);
#nullable restore
#line 113 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 3163, id.userId, 3163, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"o\"");
            BeginWriteAttribute("value", " value=\"", 3218, "\"", 3244, 1);
#nullable restore
#line 114 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 3226, id.organisationId, 3226, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"r\"");
            BeginWriteAttribute("value", " value=\"", 3289, "\"", 3307, 1);
#nullable restore
#line 115 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 3297, id.roleId, 3297, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n        <table>\r\n            <tr>\r\n                <td>\r\n                    <label>\r\n                        Organizacija\r\n                    </label>\r\n                </td>\r\n                <td>\r\n                    <input readonly=\"readonly\"");
            BeginWriteAttribute("value", " value=\"", 3560, "\"", 3585, 1);
#nullable restore
#line 125 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 3568, organicija.Naziv, 3568, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <input hidden=\"hidden\" name=\"organizacija\"");
            BeginWriteAttribute("value", " value=\"", 3653, "\"", 3688, 1);
#nullable restore
#line 126 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 3661, organicija.Organizacija_ID, 3661, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
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
#line 145 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
                         foreach (var x in lista_ptt)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 4486, "\"", 4503, 1);
#nullable restore
#line 147 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 4494, x.PTT_ID, 4494, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 147 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
                                                 Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 148 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
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
#line 161 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
                         foreach (var x in lista_drzava)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 5020, "\"", 5041, 1);
#nullable restore
#line 163 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 5028, x.Drazava_ID, 5028, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 163 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
                                                     Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 164 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
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
