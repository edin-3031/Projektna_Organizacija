#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b679c73734623a31fd0ac68416dda6d464df6a27"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b679c73734623a31fd0ac68416dda6d464df6a27", @"/Areas/AdminOrg/Views/OrganizacionaJedinica/Unos.cshtml")]
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
            BeginWriteAttribute("href", " href=\"", 2109, "\"", 2187, 6);
            WriteAttributeValue("", 2116, "/AdminOrg/AdminOrg/Index?u=", 2116, 27, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2143, id.userId, 2143, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2153, "&o=", 2153, 3, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2156, id.organisationId, 2156, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2174, "&r=", 2174, 3, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2177, id.roleId, 2177, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"sifarnik\">Opšti šifarnik</li>\r\n            <ul id=\"o_s\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2343, "\"", 2435, 6);
            WriteAttributeValue("", 2350, "/AdminOrg/OrganizacionaJedinica/Prikaz?u=", 2350, 41, true);
#nullable restore
#line 91 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2391, id.userId, 2391, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2401, "&o=", 2401, 3, true);
#nullable restore
#line 91 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2404, id.organisationId, 2404, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2422, "&r=", 2422, 3, true);
#nullable restore
#line 91 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2425, id.roleId, 2425, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizaciona jedinica</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2492, "\"", 2574, 6);
            WriteAttributeValue("", 2499, "/AdminOrg/KorisnikOrg/Prikaz?u=", 2499, 31, true);
#nullable restore
#line 92 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2530, id.userId, 2530, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2540, "&o=", 2540, 3, true);
#nullable restore
#line 92 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2543, id.organisationId, 2543, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2561, "&r=", 2561, 3, true);
#nullable restore
#line 92 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2564, id.roleId, 2564, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnik-Organizaciona jedinica</a></li>\r\n            </ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2737, "\"", 2820, 6);
            WriteAttributeValue("", 2744, "/AdminOrg/ProjekatPlan/Prikaz?u=", 2744, 32, true);
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2776, id.userId, 2776, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2786, "&o=", 2786, 3, true);
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2789, id.organisationId, 2789, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2807, "&r=", 2807, 3, true);
#nullable restore
#line 96 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2810, id.roleId, 2810, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2859, "\"", 2951, 6);
            WriteAttributeValue("", 2866, "/AdminOrg/ProjekatAktivnostPlan/Prikaz?u=", 2866, 41, true);
#nullable restore
#line 97 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2907, id.userId, 2907, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2917, "&o=", 2917, 3, true);
#nullable restore
#line 97 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2920, id.organisationId, 2920, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2938, "&r=", 2938, 3, true);
#nullable restore
#line 97 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 2941, id.roleId, 2941, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3091, "\"", 3190, 6);
            WriteAttributeValue("", 3098, "/AdminOrg/ProjekatAktivnostRealizacija/Prikaz?u=", 3098, 48, true);
#nullable restore
#line 101 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 3146, id.userId, 3146, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3156, "&o=", 3156, 3, true);
#nullable restore
#line 101 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 3159, id.organisationId, 3159, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3177, "&r=", 3177, 3, true);
#nullable restore
#line 101 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 3180, id.roleId, 3180, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3321, "\"", 3400, 6);
            WriteAttributeValue("", 3328, "/AdminOrg/Korisnik/Prikaz?u=", 3328, 28, true);
#nullable restore
#line 105 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 3356, id.userId, 3356, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3366, "&o=", 3366, 3, true);
#nullable restore
#line 105 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 3369, id.organisationId, 3369, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3387, "&r=", 3387, 3, true);
#nullable restore
#line 105 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 3390, id.roleId, 3390, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Korisnici</a></li>
            </ul>
        </ul>
    </div>
</div>

<center>
    <div id=""zaglavlje"" style=""width:100%"">
        <h1 style=""position:relative; display:inline;"">Unos Organizacione Jedinice</h1>
        <img style=""height:7vw; width:7vw; position:relative; float:right; display:inline;""");
            BeginWriteAttribute("src", " src=\"", 3713, "\"", 3726, 1);
#nullable restore
#line 114 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 3719, imgsrc, 3719, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div><br /><br />\r\n    <form method=\"post\" action=\"/AdminOrg/OrganizacionaJedinica/UnosSnimi?\">\r\n\r\n        <input hidden=\"hidden\" name=\"u\"");
            BeginWriteAttribute("value", " value=\"", 3875, "\"", 3893, 1);
#nullable restore
#line 118 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 3883, id.userId, 3883, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"o\"");
            BeginWriteAttribute("value", " value=\"", 3938, "\"", 3964, 1);
#nullable restore
#line 119 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 3946, id.organisationId, 3946, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"r\"");
            BeginWriteAttribute("value", " value=\"", 4009, "\"", 4027, 1);
#nullable restore
#line 120 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 4017, id.roleId, 4017, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n        <table>\r\n            <tr>\r\n                <td>\r\n                    <label>\r\n                        Organizacija\r\n                    </label>\r\n                </td>\r\n                <td>\r\n                    <input readonly=\"readonly\"");
            BeginWriteAttribute("value", " value=\"", 4280, "\"", 4305, 1);
#nullable restore
#line 130 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 4288, organicija.Naziv, 4288, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <input hidden=\"hidden\" name=\"organizacija\"");
            BeginWriteAttribute("value", " value=\"", 4373, "\"", 4408, 1);
#nullable restore
#line 131 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 4381, organicija.Organizacija_ID, 4381, 27, false);

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
#line 150 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
                         foreach (var x in lista_ptt)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 5206, "\"", 5223, 1);
#nullable restore
#line 152 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 5214, x.PTT_ID, 5214, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 152 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
                                                 Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 153 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
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
#line 166 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
                         foreach (var x in lista_drzava)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 5740, "\"", 5760, 1);
#nullable restore
#line 168 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
WriteAttributeValue("", 5748, x.Drzava_ID, 5748, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 168 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
                                                    Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 169 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Unos.cshtml"
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
