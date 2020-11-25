#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "522bb6dfbb3c1669f5d3c667bd4d6f555c5434c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminOrg_Views_ProjekatPlan_Uredi), @"mvc.1.0.view", @"/Areas/AdminOrg/Views/ProjekatPlan/Uredi.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"522bb6dfbb3c1669f5d3c667bd4d6f555c5434c1", @"/Areas/AdminOrg/Views/ProjekatPlan/Uredi.cshtml")]
    public class Areas_AdminOrg_Views_ProjekatPlan_Uredi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
  
    List<OrganizacionaJedinica> lista_org_jed = (List<OrganizacionaJedinica>)ViewData["org_jed"];
    ProjekatPlan p = (ProjekatPlan)ViewData["projekat"];
    Layout = "~/Views/Shared/_Layout_admin_org.cshtml";

    uor id = (uor)ViewData["id"];

    List<Status> stat_lista = (List<Status>)ViewData["statusi"];

    byte[] pic = (byte[])ViewData["logo"];
    var base64 = Convert.ToBase64String(pic);
    var imgsrc = string.Format("data:image/gif;base64,{0}", base64);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
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
        font-s");
            WriteLiteral("ize: 1vw;\r\n        border-radius: 0px 25px 25px 0px;\r\n    }\r\n</style>\r\n<div id=\"kutijaZaMeni\">\r\n    <div id=\"menu\">\r\n        <br />\r\n        <a style=\"color:white; text-decoration-line:none; font-size:120%;\"");
            BeginWriteAttribute("href", " href=\"", 1910, "\"", 1988, 6);
            WriteAttributeValue("", 1917, "/AdminOrg/AdminOrg/Index?u=", 1917, 27, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 1944, id.userId, 1944, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1954, "&o=", 1954, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 1957, id.organisationId, 1957, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1975, "&r=", 1975, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 1978, id.roleId, 1978, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"sifarnik\">Opšti šifarnik</li>\r\n            <ul id=\"o_s\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2144, "\"", 2236, 6);
            WriteAttributeValue("", 2151, "/AdminOrg/OrganizacionaJedinica/Prikaz?u=", 2151, 41, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 2192, id.userId, 2192, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2202, "&o=", 2202, 3, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 2205, id.organisationId, 2205, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2223, "&r=", 2223, 3, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 2226, id.roleId, 2226, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizaciona jedinica</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2293, "\"", 2375, 6);
            WriteAttributeValue("", 2300, "/AdminOrg/KorisnikOrg/Prikaz?u=", 2300, 31, true);
#nullable restore
#line 84 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 2331, id.userId, 2331, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2341, "&o=", 2341, 3, true);
#nullable restore
#line 84 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 2344, id.organisationId, 2344, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2362, "&r=", 2362, 3, true);
#nullable restore
#line 84 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 2365, id.roleId, 2365, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnik-Organizaciona jedinica</a></li>\r\n            </ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2538, "\"", 2621, 6);
            WriteAttributeValue("", 2545, "/AdminOrg/ProjekatPlan/Prikaz?u=", 2545, 32, true);
#nullable restore
#line 88 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 2577, id.userId, 2577, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2587, "&o=", 2587, 3, true);
#nullable restore
#line 88 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 2590, id.organisationId, 2590, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2608, "&r=", 2608, 3, true);
#nullable restore
#line 88 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 2611, id.roleId, 2611, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2660, "\"", 2752, 6);
            WriteAttributeValue("", 2667, "/AdminOrg/ProjekatAktivnostPlan/Prikaz?u=", 2667, 41, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 2708, id.userId, 2708, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2718, "&o=", 2718, 3, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 2721, id.organisationId, 2721, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2739, "&r=", 2739, 3, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 2742, id.roleId, 2742, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2892, "\"", 2991, 6);
            WriteAttributeValue("", 2899, "/AdminOrg/ProjekatAktivnostRealizacija/Prikaz?u=", 2899, 48, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 2947, id.userId, 2947, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2957, "&o=", 2957, 3, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 2960, id.organisationId, 2960, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2978, "&r=", 2978, 3, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 2981, id.roleId, 2981, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3122, "\"", 3201, 6);
            WriteAttributeValue("", 3129, "/AdminOrg/Korisnik/Prikaz?u=", 3129, 28, true);
#nullable restore
#line 97 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 3157, id.userId, 3157, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3167, "&o=", 3167, 3, true);
#nullable restore
#line 97 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 3170, id.organisationId, 3170, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3188, "&r=", 3188, 3, true);
#nullable restore
#line 97 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 3191, id.roleId, 3191, 10, false);

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
        <h1 style=""position:relative; display:inline;"">Uređivanje Plana Projekta</h1>
        <img style=""height:7vw; width:7vw; position:relative; float:right; display:inline;""");
            BeginWriteAttribute("src", " src=\"", 3510, "\"", 3523, 1);
#nullable restore
#line 105 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 3516, imgsrc, 3516, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <form method=\"post\" action=\"/AdminOrg/ProjekatPlan/UrediSnimi\">\r\n\r\n        <input hidden=\"hidden\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 3652, "\"", 3678, 1);
#nullable restore
#line 109 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 3660, p.ProjekatPlan_ID, 3660, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"u\"");
            BeginWriteAttribute("value", " value=\"", 3723, "\"", 3741, 1);
#nullable restore
#line 110 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 3731, id.userId, 3731, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"o\"");
            BeginWriteAttribute("value", " value=\"", 3786, "\"", 3812, 1);
#nullable restore
#line 111 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 3794, id.organisationId, 3794, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"r\"");
            BeginWriteAttribute("value", " value=\"", 3857, "\"", 3875, 1);
#nullable restore
#line 112 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 3865, id.roleId, 3865, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n        <table>\r\n            <tr>\r\n                <td>\r\n                    <label>\r\n                        Naziv\r\n                    </label>\r\n                </td>\r\n                <td>\r\n                    <input name=\"naziv\"");
            BeginWriteAttribute("value", " value=\"", 4114, "\"", 4130, 1);
#nullable restore
#line 122 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 4122, p.Naziv, 4122, 8, false);

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
                        Šifra
                    </label>
                </td>
                <td>
                    <input name=""sifra""");
            BeginWriteAttribute("value", " value=\"", 4392, "\"", 4408, 1);
#nullable restore
#line 132 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 4400, p.Sifra, 4400, 8, false);

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
                        Organizaciona jedinica
                    </label>
                </td>
                <td>
                    <select name=""org_jed"">
                        <option");
            BeginWriteAttribute("value", " value=\"", 4724, "\"", 4759, 1);
#nullable restore
#line 143 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 4732, p.OrganizacionaJedinica_FK, 4732, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 143 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
                                                               Write(p.organizacionaJedinica.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 144 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
                         foreach (var x in lista_org_jed)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 4923, "\"", 4958, 1);
#nullable restore
#line 146 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 4931, x.OrganizacionaJedinica_ID, 4931, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 146 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
                                                                   Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 147 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
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
                        Datum od
                    </label>
                </td>
                <td>
                    <input type=""datetime"" name=""OD""");
            BeginWriteAttribute("value", " value=\"", 5309, "\"", 5327, 1);
#nullable restore
#line 158 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 5317, p.DatumOd, 5317, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Datum do
                    </label>
                </td>
                <td>
                    <input type=""datetime"" name=""DO""");
            BeginWriteAttribute("value", " value=\"", 5603, "\"", 5621, 1);
#nullable restore
#line 168 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 5611, p.DatumDo, 5611, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Status
                    </label>
                </td>
                <td>
                    <select name=""status_id"">
                        <option");
            BeginWriteAttribute("value", " value=\"", 5921, "\"", 5941, 1);
#nullable restore
#line 179 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 5929, p.Status_FK, 5929, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 179 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
                                                Write(p.status.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 180 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
                         foreach (var x in stat_lista)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 6087, "\"", 6106, 1);
#nullable restore
#line 182 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
WriteAttributeValue("", 6095, x.StatusID, 6095, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 182 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
                                                   Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 183 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Uredi.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </select>\r\n                </td>\r\n            </tr>\r\n        </table>\r\n\r\n        <button class=\"btn btn-primary\">Snimi</button>\r\n    </form>\r\n</center>");
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
