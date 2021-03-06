#pragma checksum "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3658aa901cab6bcf8611f62272f2c2914c7ead80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_ProjekatAktivnostRealizacija_PrintPreview), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/ProjekatAktivnostRealizacija/PrintPreview.cshtml")]
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
#line 4 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3658aa901cab6bcf8611f62272f2c2914c7ead80", @"/Areas/SuperAdmin/Views/ProjekatAktivnostRealizacija/PrintPreview.cshtml")]
    public class Areas_SuperAdmin_Views_ProjekatAktivnostRealizacija_PrintPreview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.VM.lista_DetaljiRealizacijaVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 8 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
    Layout = "~/Views/Shared/_Layout_admin.cshtml";

    uor id = (uor)ViewData["id"];

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
            WriteLiteral(@"ize: 1vw;
        border-radius: 0px 25px 25px 0px;
    }
</style>
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
#line 105 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
             foreach (var x in Model.lista)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 108 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
                   Write(x.idRealizacija);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                    <td>");
#nullable restore
#line 110 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
                   Write(x.NazivAktivnosti);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 111 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
                   Write(x.korisnik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 112 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
                   Write(x.datum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 113 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
                   Write(x.kolicina);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 114 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
                   Write(x.opis);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 116 "D:\New Project\Projektna_Organizacija\WebApplication1\WebApplication1\Areas\SuperAdmin\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
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
