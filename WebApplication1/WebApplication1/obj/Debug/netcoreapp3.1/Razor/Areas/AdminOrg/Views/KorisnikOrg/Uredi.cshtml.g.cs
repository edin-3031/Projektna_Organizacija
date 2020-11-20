#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Uredi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcc20c8f6e113c354dab21e40502fffdf886c8c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminOrg_Views_KorisnikOrg_Uredi), @"mvc.1.0.view", @"/Areas/AdminOrg/Views/KorisnikOrg/Uredi.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Uredi.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Uredi.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcc20c8f6e113c354dab21e40502fffdf886c8c7", @"/Areas/AdminOrg/Views/KorisnikOrg/Uredi.cshtml")]
    public class Areas_AdminOrg_Views_KorisnikOrg_Uredi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Uredi.cshtml"
  
    Layout = "~/Views/Shared/_Layout_admin_org.cshtml";

    Korisnici_OrganizacionaJedinica k_o = (Korisnici_OrganizacionaJedinica)ViewData["kor_oj"];

    List<OrganizacionaJedinica> org_jed = (List<OrganizacionaJedinica>)ViewData["OrganizacionaJedinice"];

    uor id = (uor)ViewData["id"];

    byte[] pic = (byte[])ViewData["logo"];
    var base64 = Convert.ToBase64String(pic);
    var imgsrc = string.Format("data:image/gif;base64,{0}", base64);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    td {
        padding: 10px;
    }

    a, td {
        /*font-weight: bold;*/
        text-align-last: center;
    }

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
        width: 15%;
        margin-left: 0px;
        background-color: rgba(0, 0, 0, 0.8);
        color: white;
        top: 20%;
        font");
            WriteLiteral("-size: 1vw;\r\n        border-radius: 0px 25px 25px 0px;\r\n    }\r\n</style>\r\n\r\n<div id=\"kutijaZaMeni\">\r\n    <div id=\"menu\">\r\n        <br />\r\n        <a style=\"color:white; text-decoration-line:none; font-size:120%;\"");
            BeginWriteAttribute("href", " href=\"", 1896, "\"", 1974, 6);
            WriteAttributeValue("", 1903, "/AdminOrg/AdminOrg/Index?u=", 1903, 27, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Uredi.cshtml"
WriteAttributeValue("", 1930, id.userId, 1930, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1940, "&o=", 1940, 3, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Uredi.cshtml"
WriteAttributeValue("", 1943, id.organisationId, 1943, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1961, "&r=", 1961, 3, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Uredi.cshtml"
WriteAttributeValue("", 1964, id.roleId, 1964, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"sifarnik\">Opšti šifarnik</li>\r\n            <ul id=\"o_s\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2130, "\"", 2222, 6);
            WriteAttributeValue("", 2137, "/AdminOrg/OrganizacionaJedinica/Prikaz?u=", 2137, 41, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Uredi.cshtml"
WriteAttributeValue("", 2178, id.userId, 2178, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2188, "&o=", 2188, 3, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Uredi.cshtml"
WriteAttributeValue("", 2191, id.organisationId, 2191, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2209, "&r=", 2209, 3, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Uredi.cshtml"
WriteAttributeValue("", 2212, id.roleId, 2212, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizaciona jedinica</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2279, "\"", 2361, 6);
            WriteAttributeValue("", 2286, "/AdminOrg/KorisnikOrg/Prikaz?u=", 2286, 31, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Uredi.cshtml"
WriteAttributeValue("", 2317, id.userId, 2317, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2327, "&o=", 2327, 3, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Uredi.cshtml"
WriteAttributeValue("", 2330, id.organisationId, 2330, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2348, "&r=", 2348, 3, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Uredi.cshtml"
WriteAttributeValue("", 2351, id.roleId, 2351, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnik-Organizaciona jedinica</a></li>\r\n            </ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2524, "\"", 2607, 6);
            WriteAttributeValue("", 2531, "/AdminOrg/ProjekatPlan/Prikaz?u=", 2531, 32, true);
#nullable restore
#line 90 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Uredi.cshtml"
WriteAttributeValue("", 2563, id.userId, 2563, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2573, "&o=", 2573, 3, true);
#nullable restore
#line 90 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Uredi.cshtml"
WriteAttributeValue("", 2576, id.organisationId, 2576, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2594, "&r=", 2594, 3, true);
#nullable restore
#line 90 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Uredi.cshtml"
WriteAttributeValue("", 2597, id.roleId, 2597, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2646, "\"", 2738, 6);
            WriteAttributeValue("", 2653, "/AdminOrg/ProjekatAktivnostPlan/Prikaz?u=", 2653, 41, true);
#nullable restore
#line 91 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Uredi.cshtml"
WriteAttributeValue("", 2694, id.userId, 2694, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2704, "&o=", 2704, 3, true);
#nullable restore
#line 91 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Uredi.cshtml"
WriteAttributeValue("", 2707, id.organisationId, 2707, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2725, "&r=", 2725, 3, true);
#nullable restore
#line 91 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Uredi.cshtml"
WriteAttributeValue("", 2728, id.roleId, 2728, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2868, "\"", 2947, 6);
            WriteAttributeValue("", 2875, "/AdminOrg/Korisnik/Prikaz?u=", 2875, 28, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Uredi.cshtml"
WriteAttributeValue("", 2903, id.userId, 2903, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2913, "&o=", 2913, 3, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Uredi.cshtml"
WriteAttributeValue("", 2916, id.organisationId, 2916, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2934, "&r=", 2934, 3, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Uredi.cshtml"
WriteAttributeValue("", 2937, id.roleId, 2937, 10, false);

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
        <h1 style=""position:relative; display:inline;"">Uređivanje Korisnika - Organizacione jedinice</h1>
        <img style=""height:7vw; width:7vw; position:relative; float:right; display:inline;""");
            BeginWriteAttribute("src", " src=\"", 3276, "\"", 3289, 1);
#nullable restore
#line 103 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Uredi.cshtml"
WriteAttributeValue("", 3282, imgsrc, 3282, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <form method=\"post\" action=\"/AdminOrg/KorisnikOrg/UrediSnimi\">\r\n        <input hidden=\"hidden\" name=\"u\"");
            BeginWriteAttribute("value", " value=\"", 3414, "\"", 3432, 1);
#nullable restore
#line 106 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Uredi.cshtml"
WriteAttributeValue("", 3422, id.userId, 3422, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"o\"");
            BeginWriteAttribute("value", " value=\"", 3477, "\"", 3503, 1);
#nullable restore
#line 107 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Uredi.cshtml"
WriteAttributeValue("", 3485, id.organisationId, 3485, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"r\"");
            BeginWriteAttribute("value", " value=\"", 3548, "\"", 3566, 1);
#nullable restore
#line 108 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Uredi.cshtml"
WriteAttributeValue("", 3556, id.roleId, 3556, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"k_o_id\"");
            BeginWriteAttribute("value", " value=\"", 3616, "\"", 3663, 1);
#nullable restore
#line 109 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Uredi.cshtml"
WriteAttributeValue("", 3624, k_o.Korisnici_OrganizacionaJedinica_ID, 3624, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <table>\r\n            <tr>\r\n                <td>\r\n                    <label>Korisnik</label>\r\n                </td>\r\n                <td>\r\n                    <input name=\"korisnik\" hidden=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 3874, "\"", 3899, 1);
#nullable restore
#line 116 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Uredi.cshtml"
WriteAttributeValue("", 3882, k_o.Korisnici_FK, 3882, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <input readonly=\"readonly\"");
            BeginWriteAttribute("value", " value=\"", 3951, "\"", 4027, 1);
#nullable restore
#line 117 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Uredi.cshtml"
WriteAttributeValue("", 3959, k_o.korisnici.Ime.ToString()+" "+k_o.korisnici.Prezime.ToString(), 3959, 68, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>Organizaciona jedinica</label>
                </td>
                <td>
                    <select name=""org_jed"">
                        <option");
            BeginWriteAttribute("value", " value=\"", 4295, "\"", 4342, 1);
#nullable restore
#line 126 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Uredi.cshtml"
WriteAttributeValue("", 4303, k_o.Korisnici_OrganizacionaJedinica_ID, 4303, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 126 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Uredi.cshtml"
                                                                           Write(k_o.organizacionaJedinica.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 127 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Uredi.cshtml"
                         foreach (var x in org_jed)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 4502, "\"", 4537, 1);
#nullable restore
#line 129 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Uredi.cshtml"
WriteAttributeValue("", 4510, x.OrganizacionaJedinica_ID, 4510, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 129 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Uredi.cshtml"
                                                                   Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 130 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\KorisnikOrg\Uredi.cshtml"
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
