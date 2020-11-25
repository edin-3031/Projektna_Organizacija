#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa0dae84f380744b39096c21f50628984a02bc39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminOrg_Views_Korisnik_Prikaz), @"mvc.1.0.view", @"/Areas/AdminOrg/Views/Korisnik/Prikaz.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0dae84f380744b39096c21f50628984a02bc39", @"/Areas/AdminOrg/Views/Korisnik/Prikaz.cshtml")]
    public class Areas_AdminOrg_Views_Korisnik_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
  
    List<Korisnici> lista = (List<Korisnici>)ViewData["korisnik"];
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
            BeginWriteAttribute("href", " href=\"", 1751, "\"", 1829, 6);
            WriteAttributeValue("", 1758, "/AdminOrg/AdminOrg/Index?u=", 1758, 27, true);
#nullable restore
#line 75 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 1785, id.userId, 1785, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1795, "&o=", 1795, 3, true);
#nullable restore
#line 75 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 1798, id.organisationId, 1798, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1816, "&r=", 1816, 3, true);
#nullable restore
#line 75 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 1819, id.roleId, 1819, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"sifarnik\">Opšti šifarnik</li>\r\n            <ul id=\"o_s\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1985, "\"", 2077, 6);
            WriteAttributeValue("", 1992, "/AdminOrg/OrganizacionaJedinica/Prikaz?u=", 1992, 41, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 2033, id.userId, 2033, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2043, "&o=", 2043, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 2046, id.organisationId, 2046, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2064, "&r=", 2064, 3, true);
#nullable restore
#line 79 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 2067, id.roleId, 2067, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizaciona jedinica</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2134, "\"", 2216, 6);
            WriteAttributeValue("", 2141, "/AdminOrg/KorisnikOrg/Prikaz?u=", 2141, 31, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 2172, id.userId, 2172, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2182, "&o=", 2182, 3, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 2185, id.organisationId, 2185, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2203, "&r=", 2203, 3, true);
#nullable restore
#line 80 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 2206, id.roleId, 2206, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnik-Organizaciona jedinica</a></li>\r\n            </ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2379, "\"", 2462, 6);
            WriteAttributeValue("", 2386, "/AdminOrg/ProjekatPlan/Prikaz?u=", 2386, 32, true);
#nullable restore
#line 84 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 2418, id.userId, 2418, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2428, "&o=", 2428, 3, true);
#nullable restore
#line 84 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 2431, id.organisationId, 2431, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2449, "&r=", 2449, 3, true);
#nullable restore
#line 84 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 2452, id.roleId, 2452, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2501, "\"", 2593, 6);
            WriteAttributeValue("", 2508, "/AdminOrg/ProjekatAktivnostPlan/Prikaz?u=", 2508, 41, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 2549, id.userId, 2549, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2559, "&o=", 2559, 3, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 2562, id.organisationId, 2562, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2580, "&r=", 2580, 3, true);
#nullable restore
#line 85 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 2583, id.roleId, 2583, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2733, "\"", 2832, 6);
            WriteAttributeValue("", 2740, "/AdminOrg/ProjekatAktivnostRealizacija/Prikaz?u=", 2740, 48, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 2788, id.userId, 2788, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2798, "&o=", 2798, 3, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 2801, id.organisationId, 2801, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2819, "&r=", 2819, 3, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 2822, id.roleId, 2822, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2963, "\"", 3042, 6);
            WriteAttributeValue("", 2970, "/AdminOrg/Korisnik/Prikaz?u=", 2970, 28, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 2998, id.userId, 2998, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3008, "&o=", 3008, 3, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 3011, id.organisationId, 3011, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3029, "&r=", 3029, 3, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 3032, id.roleId, 3032, 10, false);

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
        <h1 style=""position:relative; display:inline;"">Prikaz Korisnika</h1>
        <img style=""height:7vw; width:7vw; position:relative; float:right; display:inline;""");
            BeginWriteAttribute("src", " src=\"", 3344, "\"", 3357, 1);
#nullable restore
#line 102 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 3350, imgsrc, 3350, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <div id=\"dugmad\">\r\n        <div id=\"dodaj\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 3438, "\"", 3515, 6);
            WriteAttributeValue("", 3445, "/AdminOrg/Korisnik/Unos?u=", 3445, 26, true);
#nullable restore
#line 106 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 3471, id.userId, 3471, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3481, "&o=", 3481, 3, true);
#nullable restore
#line 106 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 3484, id.organisationId, 3484, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3502, "&r=", 3502, 3, true);
#nullable restore
#line 106 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 3505, id.roleId, 3505, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Dodaj novog</a>\r\n        </div>\r\n        <div id=\"print_excel\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 3620, "\"", 3672, 2);
            WriteAttributeValue("", 3627, "/AdminOrg/Korisnik/Excel?o=", 3627, 27, true);
#nullable restore
#line 109 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 3654, id.organisationId, 3654, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-info"">Export to Excel</a>
        </div>
    </div>
    <table class=""table"">
        <thead>
        <th>Ime i prezime</th>
        <th>Šifra</th>
        <th>Uloga</th>
        <th>Korisničko ime</th>
        <th>Lozinka</th>
        <th>Telefon</th>
        <th>Mail</th>
        <th>Akcija</th>
        </thead>
        <tbody>
");
#nullable restore
#line 124 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
             foreach (var x in lista)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 127 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
                    Write(x.Ime.ToString()+" "+x.Prezime.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 128 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
                   Write(x.Sifra);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 129 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
                   Write(x.uloge.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 130 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
                   Write(x.Korisnicko_Ime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 131 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
                   Write(x.Lozinka);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 132 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
                   Write(x.Telefon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 133 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
                   Write(x.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 4515, "\"", 4612, 8);
            WriteAttributeValue("", 4522, "/AdminOrg/Korisnik/Uredi?id=", 4522, 28, true);
#nullable restore
#line 135 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 4550, x.Korisnici_ID, 4550, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4565, "&u=", 4565, 3, true);
#nullable restore
#line 135 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 4568, id.userId, 4568, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4578, "&o=", 4578, 3, true);
#nullable restore
#line 135 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 4581, id.organisationId, 4581, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4599, "&r=", 4599, 3, true);
#nullable restore
#line 135 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 4602, id.roleId, 4602, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uredi</a>\r\n                        <a");
            BeginWriteAttribute("id", " id=\"", 4651, "\"", 4678, 2);
            WriteAttributeValue("", 4656, "ukloni_", 4656, 7, true);
#nullable restore
#line 136 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
WriteAttributeValue("", 4663, x.Korisnici_ID, 4663, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\" style=\"color:white\">Ukloni</a>\r\n                        <script>\r\n                            $(\"#ukloni_");
#nullable restore
#line 138 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
                                  Write(x.Korisnici_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""").click(function () {
                                var t = confirm(""Da li ste sigurni da želite obrisati odabrani podatak?"");

                                if (t===true)
                                    window.location.href = ""/AdminOrg/Korisnik/Ukloni?id=");
#nullable restore
#line 142 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
                                                                                    Write(x.Korisnici_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("&u=");
#nullable restore
#line 142 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
                                                                                                      Write(id.userId);

#line default
#line hidden
#nullable disable
            WriteLiteral("&o=");
#nullable restore
#line 142 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
                                                                                                                   Write(id.organisationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("&r=");
#nullable restore
#line 142 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
                                                                                                                                        Write(id.roleId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n                            });\r\n                        </script>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 147 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\Korisnik\Prikaz.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</center>");
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
