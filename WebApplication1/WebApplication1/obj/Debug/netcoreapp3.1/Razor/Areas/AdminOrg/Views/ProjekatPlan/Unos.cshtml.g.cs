#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Unos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc9f60d07798964a95cca9587fa23a3654089330"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminOrg_Views_ProjekatPlan_Unos), @"mvc.1.0.view", @"/Areas/AdminOrg/Views/ProjekatPlan/Unos.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Unos.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Unos.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc9f60d07798964a95cca9587fa23a3654089330", @"/Areas/AdminOrg/Views/ProjekatPlan/Unos.cshtml")]
    public class Areas_AdminOrg_Views_ProjekatPlan_Unos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Unos.cshtml"
  
    List<OrganizacionaJedinica> lista_org_jed = (List<OrganizacionaJedinica>)ViewData["lista_org_jed"];
    Layout = "~/Views/Shared/_Layout_admin_org.cshtml";

    uor id = (uor)ViewData["id"];

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
            BeginWriteAttribute("href", " href=\"", 1790, "\"", 1868, 6);
            WriteAttributeValue("", 1797, "/AdminOrg/AdminOrg/Index?u=", 1797, 27, true);
#nullable restore
#line 76 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 1824, id.userId, 1824, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1834, "&o=", 1834, 3, true);
#nullable restore
#line 76 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 1837, id.organisationId, 1837, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1855, "&r=", 1855, 3, true);
#nullable restore
#line 76 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 1858, id.roleId, 1858, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"sifarnik\">Opšti šifarnik</li>\r\n            <ul id=\"o_s\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2024, "\"", 2116, 6);
            WriteAttributeValue("", 2031, "/AdminOrg/OrganizacionaJedinica/Prikaz?u=", 2031, 41, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2072, id.userId, 2072, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2082, "&o=", 2082, 3, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2085, id.organisationId, 2085, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2103, "&r=", 2103, 3, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2106, id.roleId, 2106, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizaciona jedinica</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2173, "\"", 2255, 6);
            WriteAttributeValue("", 2180, "/AdminOrg/KorisnikOrg/Prikaz?u=", 2180, 31, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2211, id.userId, 2211, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2221, "&o=", 2221, 3, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2224, id.organisationId, 2224, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2242, "&r=", 2242, 3, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2245, id.roleId, 2245, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnik-Organizaciona jedinica</a></li>\r\n            </ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2418, "\"", 2501, 6);
            WriteAttributeValue("", 2425, "/AdminOrg/ProjekatPlan/Prikaz?u=", 2425, 32, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2457, id.userId, 2457, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2467, "&o=", 2467, 3, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2470, id.organisationId, 2470, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2488, "&r=", 2488, 3, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2491, id.roleId, 2491, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2540, "\"", 2632, 6);
            WriteAttributeValue("", 2547, "/AdminOrg/ProjekatAktivnostPlan/Prikaz?u=", 2547, 41, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2588, id.userId, 2588, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2598, "&o=", 2598, 3, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2601, id.organisationId, 2601, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2619, "&r=", 2619, 3, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2622, id.roleId, 2622, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2772, "\"", 2871, 6);
            WriteAttributeValue("", 2779, "/AdminOrg/ProjekatAktivnostRealizacija/Prikaz?u=", 2779, 48, true);
#nullable restore
#line 90 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2827, id.userId, 2827, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2837, "&o=", 2837, 3, true);
#nullable restore
#line 90 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2840, id.organisationId, 2840, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2858, "&r=", 2858, 3, true);
#nullable restore
#line 90 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 2861, id.roleId, 2861, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3002, "\"", 3081, 6);
            WriteAttributeValue("", 3009, "/AdminOrg/Korisnik/Prikaz?u=", 3009, 28, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3037, id.userId, 3037, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3047, "&o=", 3047, 3, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3050, id.organisationId, 3050, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3068, "&r=", 3068, 3, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3071, id.roleId, 3071, 10, false);

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
        <h1 style=""position:relative; display:inline;"">Unos Projektnog Plana</h1>
        <img style=""height:7vw; width:7vw; position:relative; float:right; display:inline;""");
            BeginWriteAttribute("src", " src=\"", 3386, "\"", 3399, 1);
#nullable restore
#line 102 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3392, imgsrc, 3392, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <form method=\"post\" action=\"/AdminOrg/ProjekatPlan/UnosSnimi\">\r\n        <input hidden=\"hidden\" name=\"u\"");
            BeginWriteAttribute("value", " value=\"", 3524, "\"", 3542, 1);
#nullable restore
#line 105 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3532, id.userId, 3532, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"o\"");
            BeginWriteAttribute("value", " value=\"", 3587, "\"", 3613, 1);
#nullable restore
#line 106 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3595, id.organisationId, 3595, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"r\"");
            BeginWriteAttribute("value", " value=\"", 3658, "\"", 3676, 1);
#nullable restore
#line 107 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 3666, id.roleId, 3666, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />

        <table>
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
#line 119 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Unos.cshtml"
                         foreach (var x in lista_org_jed)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 4129, "\"", 4164, 1);
#nullable restore
#line 121 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Unos.cshtml"
WriteAttributeValue("", 4137, x.OrganizacionaJedinica_ID, 4137, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 121 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Unos.cshtml"
                                                                   Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 122 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatPlan\Unos.cshtml"
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
                        Šifra
                    </label>
                </td>
                <td>
                    <input type=""text"" name=""sifra"" />
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
                        Datum od
                    </label>
                </td>
                <td>
                    <input type=""datetime-local"" name=""Od"" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Datum do
                   ");
            WriteLiteral(@" </label>
                </td>
                <td>
                    <input type=""datetime-local"" name=""Do"" />
                </td>
            </tr>
        </table>
        <button type=""submit"" class=""btn btn-primary"">Unesi</button>
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