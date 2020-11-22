#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef4d0c29c9cbd03b431909b08ad63c9df37fb0cc"
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef4d0c29c9cbd03b431909b08ad63c9df37fb0cc", @"/Areas/AdminOrg/Views/Korisnik/Unos.cshtml")]
    public class Areas_AdminOrg_Views_Korisnik_Unos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
  
    List<Uloge> lista_uloge = (List<Uloge>)ViewData["uloge"];
    List<OrganizacionaJedinica>org_jed=(List<OrganizacionaJedinica>) ViewData["organizacione_jedinice"];
    uor id = (uor)ViewData["id"];
    Layout = "~/Views/Shared/_Layout_admin_org.cshtml";

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
            BeginWriteAttribute("href", " href=\"", 1854, "\"", 1932, 6);
            WriteAttributeValue("", 1861, "/AdminOrg/AdminOrg/Index?u=", 1861, 27, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 1888, id.userId, 1888, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1898, "&o=", 1898, 3, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 1901, id.organisationId, 1901, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1919, "&r=", 1919, 3, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 1922, id.roleId, 1922, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"sifarnik\">Opšti šifarnik</li>\r\n            <ul id=\"o_s\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2088, "\"", 2180, 6);
            WriteAttributeValue("", 2095, "/AdminOrg/OrganizacionaJedinica/Prikaz?u=", 2095, 41, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 2136, id.userId, 2136, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2146, "&o=", 2146, 3, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 2149, id.organisationId, 2149, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2167, "&r=", 2167, 3, true);
#nullable restore
#line 81 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 2170, id.roleId, 2170, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizaciona jedinica</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2237, "\"", 2319, 6);
            WriteAttributeValue("", 2244, "/AdminOrg/KorisnikOrg/Prikaz?u=", 2244, 31, true);
#nullable restore
#line 82 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 2275, id.userId, 2275, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2285, "&o=", 2285, 3, true);
#nullable restore
#line 82 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 2288, id.organisationId, 2288, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2306, "&r=", 2306, 3, true);
#nullable restore
#line 82 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 2309, id.roleId, 2309, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnik-Organizaciona jedinica</a></li>\r\n            </ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2482, "\"", 2565, 6);
            WriteAttributeValue("", 2489, "/AdminOrg/ProjekatPlan/Prikaz?u=", 2489, 32, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 2521, id.userId, 2521, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2531, "&o=", 2531, 3, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 2534, id.organisationId, 2534, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2552, "&r=", 2552, 3, true);
#nullable restore
#line 86 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 2555, id.roleId, 2555, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2604, "\"", 2696, 6);
            WriteAttributeValue("", 2611, "/AdminOrg/ProjekatAktivnostPlan/Prikaz?u=", 2611, 41, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 2652, id.userId, 2652, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2662, "&o=", 2662, 3, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 2665, id.organisationId, 2665, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2683, "&r=", 2683, 3, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 2686, id.roleId, 2686, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2836, "\"", 2935, 6);
            WriteAttributeValue("", 2843, "/AdminOrg/ProjekatAktivnostRealizacija/Prikaz?u=", 2843, 48, true);
#nullable restore
#line 91 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 2891, id.userId, 2891, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2901, "&o=", 2901, 3, true);
#nullable restore
#line 91 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 2904, id.organisationId, 2904, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2922, "&r=", 2922, 3, true);
#nullable restore
#line 91 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 2925, id.roleId, 2925, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3066, "\"", 3145, 6);
            WriteAttributeValue("", 3073, "/AdminOrg/Korisnik/Prikaz?u=", 3073, 28, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 3101, id.userId, 3101, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3111, "&o=", 3111, 3, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 3114, id.organisationId, 3114, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3132, "&r=", 3132, 3, true);
#nullable restore
#line 95 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 3135, id.roleId, 3135, 10, false);

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
        <h1 style=""position:relative; display:inline;"">Unos korisnika</h1>
        <img style=""height:7vw; width:7vw; position:relative; float:right; display:inline;""");
            BeginWriteAttribute("src", " src=\"", 3443, "\"", 3456, 1);
#nullable restore
#line 103 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 3449, imgsrc, 3449, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <form action=\"/AdminOrg/Korisnik/UnosSnimi\">\r\n        <input hidden=\"hidden\" name=\"o\"");
            BeginWriteAttribute("value", " value=\"", 3563, "\"", 3589, 1);
#nullable restore
#line 106 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 3571, id.organisationId, 3571, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"u\"");
            BeginWriteAttribute("value", " value=\"", 3634, "\"", 3652, 1);
#nullable restore
#line 107 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 3642, id.userId, 3642, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"r\"");
            BeginWriteAttribute("value", " value=\"", 3697, "\"", 3715, 1);
#nullable restore
#line 108 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 3705, id.roleId, 3705, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
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
                <td><label>Lozinka</label></td>
                <td><input type=""password"" name=""lo");
            WriteLiteral(@"zinka"" /></td>
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
#line 145 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
                         foreach (var x in org_jed)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 5138, "\"", 5173, 1);
#nullable restore
#line 147 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 5146, x.OrganizacionaJedinica_ID, 5146, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 147 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
                                                                   Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 148 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
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
#line 159 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
                         foreach (var x in lista_uloge)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 5639, "\"", 5658, 1);
#nullable restore
#line 161 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 5647, x.Uloge_ID, 5647, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 5659, "\"", 5674, 1);
#nullable restore
#line 161 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 5667, x.Opis, 5667, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 161 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
                                                                   Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 162 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Unos.cshtml"
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
