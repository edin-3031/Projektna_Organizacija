#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39515b4ecdcdcbf941a49e73b431f9e03b39a1d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminOrg_Views_ProjekatAktivnostRealizacija_PrintPreview), @"mvc.1.0.view", @"/Areas/AdminOrg/Views/ProjekatAktivnostRealizacija/PrintPreview.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39515b4ecdcdcbf941a49e73b431f9e03b39a1d1", @"/Areas/AdminOrg/Views/ProjekatAktivnostRealizacija/PrintPreview.cshtml")]
    public class Areas_AdminOrg_Views_ProjekatAktivnostRealizacija_PrintPreview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.VM.lista_DetaljiRealizacijaVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 8 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"

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
            BeginWriteAttribute("href", " href=\"", 1888, "\"", 1966, 6);
            WriteAttributeValue("", 1895, "/AdminOrg/AdminOrg/Index?u=", 1895, 27, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 1922, id.userId, 1922, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1932, "&o=", 1932, 3, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 1935, id.organisationId, 1935, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1953, "&r=", 1953, 3, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 1956, id.roleId, 1956, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n            <li id=\"sifarnik\">Opšti šifarnik</li>\r\n            <ul id=\"o_s\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2122, "\"", 2214, 6);
            WriteAttributeValue("", 2129, "/AdminOrg/OrganizacionaJedinica/Prikaz?u=", 2129, 41, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 2170, id.userId, 2170, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2180, "&o=", 2180, 3, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 2183, id.organisationId, 2183, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2201, "&r=", 2201, 3, true);
#nullable restore
#line 87 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 2204, id.roleId, 2204, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Organizaciona jedinica</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2271, "\"", 2353, 6);
            WriteAttributeValue("", 2278, "/AdminOrg/KorisnikOrg/Prikaz?u=", 2278, 31, true);
#nullable restore
#line 88 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 2309, id.userId, 2309, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2319, "&o=", 2319, 3, true);
#nullable restore
#line 88 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 2322, id.organisationId, 2322, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2340, "&r=", 2340, 3, true);
#nullable restore
#line 88 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 2343, id.roleId, 2343, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Korisnik-Organizaciona jedinica</a></li>\r\n            </ul>\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2516, "\"", 2599, 6);
            WriteAttributeValue("", 2523, "/AdminOrg/ProjekatPlan/Prikaz?u=", 2523, 32, true);
#nullable restore
#line 92 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 2555, id.userId, 2555, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2565, "&o=", 2565, 3, true);
#nullable restore
#line 92 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 2568, id.organisationId, 2568, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2586, "&r=", 2586, 3, true);
#nullable restore
#line 92 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 2589, id.roleId, 2589, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2638, "\"", 2730, 6);
            WriteAttributeValue("", 2645, "/AdminOrg/ProjekatAktivnostPlan/Prikaz?u=", 2645, 41, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 2686, id.userId, 2686, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2696, "&o=", 2696, 3, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 2699, id.organisationId, 2699, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2717, "&r=", 2717, 3, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 2720, id.roleId, 2720, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2870, "\"", 2969, 6);
            WriteAttributeValue("", 2877, "/AdminOrg/ProjekatAktivnostRealizacija/Prikaz?u=", 2877, 48, true);
#nullable restore
#line 97 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 2925, id.userId, 2925, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2935, "&o=", 2935, 3, true);
#nullable restore
#line 97 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 2938, id.organisationId, 2938, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2956, "&r=", 2956, 3, true);
#nullable restore
#line 97 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 2959, id.roleId, 2959, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3100, "\"", 3179, 6);
            WriteAttributeValue("", 3107, "/AdminOrg/Korisnik/Prikaz?u=", 3107, 28, true);
#nullable restore
#line 101 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 3135, id.userId, 3135, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3145, "&o=", 3145, 3, true);
#nullable restore
#line 101 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 3148, id.organisationId, 3148, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3166, "&r=", 3166, 3, true);
#nullable restore
#line 101 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 3169, id.roleId, 3169, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Korisnici</a></li>
            </ul>
        </ul>
    </div>
</div>

<div id=""zaglavlje"" style=""width:100%"">
    <h1 style=""position:relative; display:inline;"">Print Preview</h1>
    <img style=""height:7vw; width:7vw; position:relative; float:right; display:inline;""");
            BeginWriteAttribute("src", " src=\"", 3456, "\"", 3469, 1);
#nullable restore
#line 109 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 3462, imgsrc, 3462, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
</div>

<div id=""print_pdf""><a class=""btn btn-info"" id=""etpdf"">Export to PDF</a></div>
<script>
    $(""#etpdf"").click(function () {
        var sHtml = $(""#forPrint"").html();
        sHtml = sHtml.replace(/</g, ""StrTag"").replace(/>/g, ""EndTag"");

        var t3 = sHtml;

        var test = { ""html"": t3 };

        $.ajax({
            url: ""/SuperAdmin/ProjekatAktivnostRealizacija/Pdf"",
            type: ""POST"",
            data: test,
            success: function (response) {
                window.open(""../SuperAdmin/ProjekatAktivnostRealizacija/Pdf?html="" + test.t3, ""blank"");
            },
            fail: function (response) {
                alert(""Fail!"");
            }
        });
    });
</script>

<div id=""forPrint"">
    <table class=""table"">
        <thead>
        <th>Realizacija ID</th>
");
            WriteLiteral("        <th>Aktivnost</th>\r\n        <th>Korisnik</th>\r\n        <th>Datum</th>\r\n        <th>Količnia</th>\r\n        <th>Opis</th>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 148 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
             foreach (var x in Model.lista)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 151 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
                   Write(x.idRealizacija);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                    <td>");
#nullable restore
#line 153 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
                   Write(x.NazivAktivnosti);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 154 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
                   Write(x.korisnik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 155 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
                   Write(x.datum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 156 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
                   Write(x.kolicina);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 157 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
                   Write(x.opis);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 159 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrg\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.VM.lista_DetaljiRealizacijaVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
