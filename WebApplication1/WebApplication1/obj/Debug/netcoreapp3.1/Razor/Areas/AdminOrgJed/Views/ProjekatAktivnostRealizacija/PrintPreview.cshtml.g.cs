#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe4d3611c15748f7f3840f31eaa7d8b5a1f98bde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminOrgJed_Views_ProjekatAktivnostRealizacija_PrintPreview), @"mvc.1.0.view", @"/Areas/AdminOrgJed/Views/ProjekatAktivnostRealizacija/PrintPreview.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe4d3611c15748f7f3840f31eaa7d8b5a1f98bde", @"/Areas/AdminOrgJed/Views/ProjekatAktivnostRealizacija/PrintPreview.cshtml")]
    public class Areas_AdminOrgJed_Views_ProjekatAktivnostRealizacija_PrintPreview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.VM.lista_DetaljiRealizacijaVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 8 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"

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
            BeginWriteAttribute("href", " href=\"", 1888, "\"", 1972, 6);
            WriteAttributeValue("", 1895, "/AdminOrgJed/AdminOrgJed/Index?u=", 1895, 33, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 1928, id.userId, 1928, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1938, "&o=", 1938, 3, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 1941, id.organisationId, 1941, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1959, "&r=", 1959, 3, true);
#nullable restore
#line 83 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 1962, id.roleId, 1962, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projektna Organizacija</a><br /><br />\r\n        <ul>\r\n\r\n            <li id=\"transakcije\">Transakcije</li>\r\n            <ul id=\"tra\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2130, "\"", 2216, 6);
            WriteAttributeValue("", 2137, "/AdminOrgJed/ProjekatPlan/Prikaz?u=", 2137, 35, true);
#nullable restore
#line 88 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 2172, id.userId, 2172, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2182, "&o=", 2182, 3, true);
#nullable restore
#line 88 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 2185, id.organisationId, 2185, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2203, "&r=", 2203, 3, true);
#nullable restore
#line 88 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 2206, id.roleId, 2206, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Plan</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2255, "\"", 2350, 6);
            WriteAttributeValue("", 2262, "/AdminOrgJed/ProjekatAktivnostPlan/Prikaz?u=", 2262, 44, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 2306, id.userId, 2306, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2316, "&o=", 2316, 3, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 2319, id.organisationId, 2319, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2337, "&r=", 2337, 3, true);
#nullable restore
#line 89 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 2340, id.roleId, 2340, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aktivnosti</a></li>\r\n            </ul>\r\n            <li id=\"izvjestaji\">Izvještaji</li>\r\n            <ul id=\"izv\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2490, "\"", 2592, 6);
            WriteAttributeValue("", 2497, "/AdminOrgJed/ProjekatAktivnostRealizacija/Prikaz?u=", 2497, 51, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 2548, id.userId, 2548, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2558, "&o=", 2558, 3, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 2561, id.organisationId, 2561, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2579, "&r=", 2579, 3, true);
#nullable restore
#line 93 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 2582, id.roleId, 2582, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Realizacija</a></li>\r\n            </ul>\r\n            <li id=\"admin\">Admin</li>\r\n            <ul id=\"adm\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2723, "\"", 2805, 6);
            WriteAttributeValue("", 2730, "/AdminOrgJed/Korisnik/Prikaz?u=", 2730, 31, true);
#nullable restore
#line 97 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 2761, id.userId, 2761, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2771, "&o=", 2771, 3, true);
#nullable restore
#line 97 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 2774, id.organisationId, 2774, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2792, "&r=", 2792, 3, true);
#nullable restore
#line 97 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 2795, id.roleId, 2795, 10, false);

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
            BeginWriteAttribute("src", " src=\"", 3082, "\"", 3095, 1);
#nullable restore
#line 105 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
WriteAttributeValue("", 3088, imgsrc, 3088, 7, false);

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
#line 144 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
             foreach (var x in Model.lista)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 147 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
                   Write(x.idRealizacija);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                    <td>");
#nullable restore
#line 149 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
                   Write(x.NazivAktivnosti);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 150 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
                   Write(x.korisnik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 151 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
                   Write(x.datum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 152 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
                   Write(x.kolicina);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 153 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
                   Write(x.opis);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 155 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\AdminOrgJed\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
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
