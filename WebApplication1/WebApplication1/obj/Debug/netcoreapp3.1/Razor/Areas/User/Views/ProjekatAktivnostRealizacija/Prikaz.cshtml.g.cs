#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8f7bd08a88df87574229a7df17ce2d604957cd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_ProjekatAktivnostRealizacija_Prikaz), @"mvc.1.0.view", @"/Areas/User/Views/ProjekatAktivnostRealizacija/Prikaz.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8f7bd08a88df87574229a7df17ce2d604957cd0", @"/Areas/User/Views/ProjekatAktivnostRealizacija/Prikaz.cshtml")]
    public class Areas_User_Views_ProjekatAktivnostRealizacija_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
  
    List<par_final_VM> lista = (List<par_final_VM>)ViewData["lista_relizacija"];

    uor id = (uor)ViewData["id"];
    Layout = "~/Views/Shared/_Layout_user.cshtml";

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
            BeginWriteAttribute("href", " href=\"", 1900, "\"", 1970, 6);
            WriteAttributeValue("", 1907, "/User/User/Index?u=", 1907, 19, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 1926, id.userId, 1926, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1936, "&o=", 1936, 3, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 1939, id.organisationId, 1939, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1957, "&r=", 1957, 3, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 1960, id.roleId, 1960, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2126, "\"", 2205, 6);
            WriteAttributeValue("", 2133, "/User/ProjekatPlan/Prikaz?u=", 2133, 28, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 2161, id.userId, 2161, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2171, "&o=", 2171, 3, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 2174, id.organisationId, 2174, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2192, "&r=", 2192, 3, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 2195, id.roleId, 2195, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2244, "\"", 2332, 6);
            WriteAttributeValue("", 2251, "/User/ProjekatAktivnostPlan/Prikaz?u=", 2251, 37, true);
#nullable restore
#line 88 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 2288, id.userId, 2288, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2298, "&o=", 2298, 3, true);
#nullable restore
#line 88 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 2301, id.organisationId, 2301, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2319, "&r=", 2319, 3, true);
#nullable restore
#line 88 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 2322, id.roleId, 2322, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2472, "\"", 2567, 6);
            WriteAttributeValue("", 2479, "/User/ProjekatAktivnostRealizacija/Prikaz?u=", 2479, 44, true);
#nullable restore
#line 92 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 2523, id.userId, 2523, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2533, "&o=", 2533, 3, true);
#nullable restore
#line 92 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 2536, id.organisationId, 2536, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2554, "&r=", 2554, 3, true);
#nullable restore
#line 92 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 2557, id.roleId, 2557, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Realizacija</a></li>
            </ul>

        </ul>
    </div>
</div>

<center>
    <div id=""zaglavlje"" style=""width:100%"">
        <h1 style=""position:relative; display:inline;"">Prikaz Realizacija</h1>
        <img style=""height:7vw; width:7vw; position:relative; float:right; display:inline;""");
            BeginWriteAttribute("src", " src=\"", 2875, "\"", 2888, 1);
#nullable restore
#line 102 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 2881, imgsrc, 2881, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <br />\r\n    <div id=\"dugmad\">\r\n        <div id=\"dodaj\">\r\n            <a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 3005, "\"", 3098, 6);
            WriteAttributeValue("", 3012, "/User/ProjekatAktivnostRealizacija/Unos?u=", 3012, 42, true);
#nullable restore
#line 107 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 3054, id.userId, 3054, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3064, "&o=", 3064, 3, true);
#nullable restore
#line 107 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 3067, id.organisationId, 3067, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3085, "&r=", 3085, 3, true);
#nullable restore
#line 107 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 3088, id.roleId, 3088, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Unesi novu</a>\r\n        </div>\r\n        <div id=\"detalji\">\r\n            <a class=\"btn btn-warning\"");
            BeginWriteAttribute("href", " href=\"", 3198, "\"", 3294, 6);
            WriteAttributeValue("", 3205, "/User/ProjekatAktivnostRealizacija/Detalji?u=", 3205, 45, true);
#nullable restore
#line 110 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 3250, id.userId, 3250, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3260, "&o=", 3260, 3, true);
#nullable restore
#line 110 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 3263, id.organisationId, 3263, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3281, "&r=", 3281, 3, true);
#nullable restore
#line 110 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 3284, id.roleId, 3284, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Detalji</a>\r\n        </div>\r\n\r\n        <div id=\"print_excel\"><a");
            BeginWriteAttribute("href", " href=\"", 3359, "\"", 3419, 2);
            WriteAttributeValue("", 3366, "/User/ProjekatAktivnostRealizacija/Excel?u=", 3366, 43, true);
#nullable restore
#line 113 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 3409, id.userId, 3409, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-info"">Export to Excel</a></div>
        <div></div>
        <div></div>
    </div>
    <table class=""table"">
        <thead>
        <th>Projekat plan</th>
        <th>Projekat aktivnost plan</th>
        <th>Korisnik</th>
        <th>Datum</th>
        <th>Količina</th>
        <th>Opis</th>
        <th>Akcija</th>
        </thead>
        <tbody>
");
#nullable restore
#line 128 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
             foreach (var x in lista)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 131 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                   Write(x.proj_plan.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 132 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                   Write(x.ProjekatAktivnostPlan_all.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 133 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                    Write(x.Korisnici.Ime+" "+x.Korisnici.Prezime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 134 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                    Write(x.Datum.Date.Day+"."+ x.Datum.Date.Month + "." + x.Datum.Date.Year + ".");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 135 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                   Write(x.Kolicina);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 136 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                   Write(x.Opis);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 4327, "\"", 4459, 8);
            WriteAttributeValue("", 4334, "/User/ProjekatAktivnostRealizacija/Uredi?id=", 4334, 44, true);
#nullable restore
#line 138 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 4378, x.ProjekatAktivnostRealizacija_ID, 4378, 34, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4412, "&u=", 4412, 3, true);
#nullable restore
#line 138 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 4415, id.userId, 4415, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4425, "&o=", 4425, 3, true);
#nullable restore
#line 138 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 4428, id.organisationId, 4428, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4446, "&r=", 4446, 3, true);
#nullable restore
#line 138 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 4449, id.roleId, 4449, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uredi</a>\r\n                        <a");
            BeginWriteAttribute("id", " id=\"", 4498, "\"", 4544, 2);
            WriteAttributeValue("", 4503, "ukloni_", 4503, 7, true);
#nullable restore
#line 139 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
WriteAttributeValue("", 4510, x.ProjekatAktivnostRealizacija_ID, 4510, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\" style=\"color:white\">Ukloni</a>\r\n                        <script>\r\n                            $(\"#ukloni_");
#nullable restore
#line 141 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                                  Write(x.ProjekatAktivnostRealizacija_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""").click(function () {
                                var t = confirm(""Da li ste sigurni da želite obrisati odabrani podatak?"");

                                if (t===true)
                                    window.location.href = ""/User/ProjekatAktivnostRealizacija/Ukloni?id=");
#nullable restore
#line 145 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                                                                                                    Write(x.ProjekatAktivnostRealizacija_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("&u=");
#nullable restore
#line 145 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                                                                                                                                         Write(id.userId);

#line default
#line hidden
#nullable disable
            WriteLiteral("&o=");
#nullable restore
#line 145 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                                                                                                                                                      Write(id.organisationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("&r=");
#nullable restore
#line 145 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
                                                                                                                                                                           Write(id.roleId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n                            });\r\n                        </script>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 150 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\User\Views\ProjekatAktivnostRealizacija\Prikaz.cshtml"
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
