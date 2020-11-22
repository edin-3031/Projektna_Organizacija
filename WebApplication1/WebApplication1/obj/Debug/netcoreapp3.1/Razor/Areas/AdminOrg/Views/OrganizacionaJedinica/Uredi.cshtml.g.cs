#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1d4cc131a9a0e3b93babf57321bc0f6606fa3d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminOrg_Views_OrganizacionaJedinica_Uredi), @"mvc.1.0.view", @"/Areas/AdminOrg/Views/OrganizacionaJedinica/Uredi.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1d4cc131a9a0e3b93babf57321bc0f6606fa3d1", @"/Areas/AdminOrg/Views/OrganizacionaJedinica/Uredi.cshtml")]
    public class Areas_AdminOrg_Views_OrganizacionaJedinica_Uredi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
  
    OrganizacionaJedinica o_j = (OrganizacionaJedinica)ViewData["org_jed"];
    List<PTT> ptt_lista = (List<PTT>)ViewData["ptt"];
    List<Drzava> drzave_lista = (List<Drzava>)ViewData["drzave"];

    uor id = (uor)ViewData["id"];
    Layout = "~/Views/Shared/_Layout_admin_org.cshtml";

    byte[] pic = (byte[])ViewData["logo"];
    var base64 = Convert.ToBase64String(pic);
    var imgsrc = string.Format("data:image/gif;base64,{0}", base64);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>


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
        width");
            WriteLiteral(@": 15%;
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
            BeginWriteAttribute("href", " href=\"", 2022, "\"", 2100, 6);
            WriteAttributeValue("", 2029, "/AdminOrg/AdminOrg/Index?u=", 2029, 27, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 2056, id.userId, 2056, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2066, "&o=", 2066, 3, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 2069, id.organisationId, 2069, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2087, "&r=", 2087, 3, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 2090, id.roleId, 2090, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"sifarnik\">Opšti šifarnik</li>\r\n            <ul id=\"o_s\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2256, "\"", 2348, 6);
            WriteAttributeValue("", 2263, "/AdminOrg/OrganizacionaJedinica/Prikaz?u=", 2263, 41, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 2304, id.userId, 2304, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2314, "&o=", 2314, 3, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 2317, id.organisationId, 2317, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2335, "&r=", 2335, 3, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 2338, id.roleId, 2338, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizaciona jedinica</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2405, "\"", 2487, 6);
            WriteAttributeValue("", 2412, "/AdminOrg/KorisnikOrg/Prikaz?u=", 2412, 31, true);
#nullable restore
#line 90 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 2443, id.userId, 2443, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2453, "&o=", 2453, 3, true);
#nullable restore
#line 90 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 2456, id.organisationId, 2456, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2474, "&r=", 2474, 3, true);
#nullable restore
#line 90 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 2477, id.roleId, 2477, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnik-Organizaciona jedinica</a></li>\r\n            </ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2650, "\"", 2733, 6);
            WriteAttributeValue("", 2657, "/AdminOrg/ProjekatPlan/Prikaz?u=", 2657, 32, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 2689, id.userId, 2689, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2699, "&o=", 2699, 3, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 2702, id.organisationId, 2702, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2720, "&r=", 2720, 3, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 2723, id.roleId, 2723, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2772, "\"", 2864, 6);
            WriteAttributeValue("", 2779, "/AdminOrg/ProjekatAktivnostPlan/Prikaz?u=", 2779, 41, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 2820, id.userId, 2820, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2830, "&o=", 2830, 3, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 2833, id.organisationId, 2833, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2851, "&r=", 2851, 3, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 2854, id.roleId, 2854, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3004, "\"", 3103, 6);
            WriteAttributeValue("", 3011, "/AdminOrg/ProjekatAktivnostRealizacija/Prikaz?u=", 3011, 48, true);
#nullable restore
#line 99 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 3059, id.userId, 3059, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3069, "&o=", 3069, 3, true);
#nullable restore
#line 99 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 3072, id.organisationId, 3072, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3090, "&r=", 3090, 3, true);
#nullable restore
#line 99 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 3093, id.roleId, 3093, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3234, "\"", 3313, 6);
            WriteAttributeValue("", 3241, "/AdminOrg/Korisnik/Prikaz?u=", 3241, 28, true);
#nullable restore
#line 103 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 3269, id.userId, 3269, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3279, "&o=", 3279, 3, true);
#nullable restore
#line 103 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 3282, id.organisationId, 3282, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3300, "&r=", 3300, 3, true);
#nullable restore
#line 103 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 3303, id.roleId, 3303, 10, false);

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
        <h1 style=""position:relative; display:inline;"">Uređivanje Organizacionu jedinicu</h1>
        <img style=""height:7vw; width:7vw; position:relative; float:right; display:inline;""");
            BeginWriteAttribute("src", " src=\"", 3630, "\"", 3643, 1);
#nullable restore
#line 111 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 3636, imgsrc, 3636, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <form method=\"post\" action=\"/AdminOrg/OrganizacionaJedinica/UrediSnimi\">\r\n        <input hidden=\"hidden\" name=\"u\"");
            BeginWriteAttribute("value", " value=\"", 3778, "\"", 3796, 1);
#nullable restore
#line 114 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 3786, id.userId, 3786, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n        <input hidden=\"hidden\" name=\"o\"");
            BeginWriteAttribute("value", " value=\"", 3840, "\"", 3866, 1);
#nullable restore
#line 115 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 3848, id.organisationId, 3848, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n        <input hidden=\"hidden\" name=\"r\"");
            BeginWriteAttribute("value", " value=\"", 3910, "\"", 3928, 1);
#nullable restore
#line 116 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 3918, id.roleId, 3918, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n        <input hidden=\"hidden\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 3973, "\"", 4010, 1);
#nullable restore
#line 117 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 3981, o_j.OrganizacionaJedinica_ID, 3981, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n        <input hidden=\"hidden\" name=\"organizacija\"");
            BeginWriteAttribute("value", " value=\"", 4065, "\"", 4093, 1);
#nullable restore
#line 118 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 4073, o_j.Organizacija_FK, 4073, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n        \r\n        <table>\r\n            <tr>\r\n                <td>\r\n                    <label>\r\n                        Naziv\r\n                    </label>\r\n                </td>\r\n                <td>\r\n                    <input name=\"naziv\"");
            BeginWriteAttribute("value", " value=\"", 4339, "\"", 4357, 1);
#nullable restore
#line 128 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 4347, o_j.Naziv, 4347, 10, false);

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
                    <input readonly=""readonly""");
            BeginWriteAttribute("value", " value=\"", 4633, "\"", 4664, 1);
#nullable restore
#line 138 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 4641, o_j.organizacija.Naziv, 4641, 23, false);

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
                        Adresa
                    </label>
                </td>
                <td>
                    <input name=""adresa""");
            BeginWriteAttribute("value", " value=\"", 4928, "\"", 4947, 1);
#nullable restore
#line 148 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 4936, o_j.Adresa, 4936, 11, false);

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
            BeginWriteAttribute("value", " value=\"", 5246, "\"", 5268, 1);
#nullable restore
#line 159 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 5254, o_j.Drzava_FK, 5254, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 159 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
                                                  Write(o_j.drzava.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 160 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
                         foreach (var x in drzave_lista)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 5418, "\"", 5439, 1);
#nullable restore
#line 162 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 5426, x.Drazava_ID, 5426, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 162 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
                                                     Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 163 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
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
            BeginWriteAttribute("value", " value=\"", 5805, "\"", 5824, 1);
#nullable restore
#line 175 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 5813, o_j.PTT_FK, 5813, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 175 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
                                               Write(o_j.ptt.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 176 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
                         foreach (var x in ptt_lista)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 5968, "\"", 5985, 1);
#nullable restore
#line 178 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
WriteAttributeValue("", 5976, x.PTT_ID, 5976, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 178 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
                                                 Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 179 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\OrganizacionaJedinica\Uredi.cshtml"
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