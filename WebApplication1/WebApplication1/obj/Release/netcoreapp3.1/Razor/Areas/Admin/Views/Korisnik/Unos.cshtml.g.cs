#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35d65704c5e394339c0e043e8796b3b93a6b86c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Korisnik_Unos), @"mvc.1.0.view", @"/Areas/Admin/Views/Korisnik/Unos.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35d65704c5e394339c0e043e8796b3b93a6b86c1", @"/Areas/Admin/Views/Korisnik/Unos.cshtml")]
    public class Areas_Admin_Views_Korisnik_Unos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
  
    List<Uloge> lista_uloge = (List<Uloge>)ViewData["uloge"];
    uor id = (uor)ViewData["id"];
    Layout = "~/Views/Shared/_Layout_admin.cshtml";

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
            BeginWriteAttribute("href", " href=\"", 1581, "\"", 1653, 6);
            WriteAttributeValue("", 1588, "/Admin/Admin/Index?u=", 1588, 21, true);
#nullable restore
#line 72 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 1609, id.userId, 1609, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1619, "&o=", 1619, 3, true);
#nullable restore
#line 72 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 1622, id.organisationId, 1622, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1640, "&r=", 1640, 3, true);
#nullable restore
#line 72 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 1643, id.roleId, 1643, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"sifarnik\">Opšti šifarnik</li>\r\n            <ul id=\"o_s\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1809, "\"", 1883, 6);
            WriteAttributeValue("", 1816, "/Admin/Drzava/Prikaz?u=", 1816, 23, true);
#nullable restore
#line 76 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 1839, id.userId, 1839, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1849, "&o=", 1849, 3, true);
#nullable restore
#line 76 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 1852, id.organisationId, 1852, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1870, "&r=", 1870, 3, true);
#nullable restore
#line 76 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 1873, id.roleId, 1873, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Država</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1924, "\"", 1995, 6);
            WriteAttributeValue("", 1931, "/Admin/PTT/Prikaz?u=", 1931, 20, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 1951, id.userId, 1951, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1961, "&o=", 1961, 3, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 1964, id.organisationId, 1964, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1982, "&r=", 1982, 3, true);
#nullable restore
#line 77 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 1985, id.roleId, 1985, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">PTT</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2033, "\"", 2113, 6);
            WriteAttributeValue("", 2040, "/Admin/Organizacija/Prikaz?u=", 2040, 29, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 2069, id.userId, 2069, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2079, "&o=", 2079, 3, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 2082, id.organisationId, 2082, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2100, "&r=", 2100, 3, true);
#nullable restore
#line 78 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 2103, id.roleId, 2103, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizacija</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2160, "\"", 2249, 6);
            WriteAttributeValue("", 2167, "/Admin/OrganizacionaJedinica/Prikaz?u=", 2167, 38, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 2205, id.userId, 2205, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2215, "&o=", 2215, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 2218, id.organisationId, 2218, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2236, "&r=", 2236, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 2239, id.roleId, 2239, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizaciona jedinica</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2306, "\"", 2385, 6);
            WriteAttributeValue("", 2313, "/Admin/KorisnikOrg/Prikaz?u=", 2313, 28, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 2341, id.userId, 2341, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2351, "&o=", 2351, 3, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 2354, id.organisationId, 2354, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2372, "&r=", 2372, 3, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 2375, id.roleId, 2375, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnik-Organizaciona jedinica</a></li>\r\n            </ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2548, "\"", 2628, 6);
            WriteAttributeValue("", 2555, "/Admin/ProjekatPlan/Prikaz?u=", 2555, 29, true);
#nullable restore
#line 84 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 2584, id.userId, 2584, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2594, "&o=", 2594, 3, true);
#nullable restore
#line 84 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 2597, id.organisationId, 2597, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2615, "&r=", 2615, 3, true);
#nullable restore
#line 84 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 2618, id.roleId, 2618, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2667, "\"", 2756, 6);
            WriteAttributeValue("", 2674, "/Admin/ProjekatAktivnostPlan/Prikaz?u=", 2674, 38, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 2712, id.userId, 2712, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2722, "&o=", 2722, 3, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 2725, id.organisationId, 2725, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2743, "&r=", 2743, 3, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 2746, id.roleId, 2746, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2896, "\"", 2992, 6);
            WriteAttributeValue("", 2903, "/Admin/ProjekatAktivnostRealizacija/Prikaz?u=", 2903, 45, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 2948, id.userId, 2948, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2958, "&o=", 2958, 3, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 2961, id.organisationId, 2961, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2979, "&r=", 2979, 3, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 2982, id.roleId, 2982, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3123, "\"", 3199, 6);
            WriteAttributeValue("", 3130, "/Admin/Korisnik/Prikaz?u=", 3130, 25, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 3155, id.userId, 3155, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3165, "&o=", 3165, 3, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 3168, id.organisationId, 3168, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3186, "&r=", 3186, 3, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 3189, id.roleId, 3189, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnici</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3243, "\"", 3316, 6);
            WriteAttributeValue("", 3250, "/Admin/Uloge/Prikaz?u=", 3250, 22, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 3272, id.userId, 3272, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3282, "&o=", 3282, 3, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 3285, id.organisationId, 3285, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3303, "&r=", 3303, 3, true);
#nullable restore
#line 94 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 3306, id.roleId, 3306, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uloge</a></li>\r\n            </ul>\r\n        </ul>\r\n    </div>\r\n</div>\r\n");
            WriteLiteral("<center>\r\n    <h1>Unos Korisnika</h1>\r\n    <form action=\"/Admin/Korisnik/UnosSnimi\">\r\n        <input hidden=\"hidden\" name=\"o\"");
            BeginWriteAttribute("value", " value=\"", 4254, "\"", 4280, 1);
#nullable restore
#line 122 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 4262, id.organisationId, 4262, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"u\"");
            BeginWriteAttribute("value", " value=\"", 4325, "\"", 4343, 1);
#nullable restore
#line 123 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 4333, id.userId, 4333, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden=\"hidden\" name=\"r\"");
            BeginWriteAttribute("value", " value=\"", 4388, "\"", 4406, 1);
#nullable restore
#line 124 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 4396, id.roleId, 4396, 10, false);

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
                    <label>Uloga</label>
                </td>
                <td>
                    <select name=""uloga"">
                        <option>---Odaberi---</option>
");
#nullable restore
#line 161 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
                         foreach (var x in lista_uloge)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 5811, "\"", 5830, 1);
#nullable restore
#line 163 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
WriteAttributeValue("", 5819, x.Uloge_ID, 5819, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 163 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
                                                   Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 164 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\Admin\Views\Korisnik\Unos.cshtml"
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