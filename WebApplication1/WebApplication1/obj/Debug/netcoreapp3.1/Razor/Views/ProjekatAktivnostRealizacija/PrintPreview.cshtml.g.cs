#pragma checksum "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65e6a3353635c5a389cd26d4641cee1c1e992f47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProjekatAktivnostRealizacija_PrintPreview), @"mvc.1.0.view", @"/Views/ProjekatAktivnostRealizacija/PrintPreview.cshtml")]
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
#line 1 "D:\New Project\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New Project\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65e6a3353635c5a389cd26d4641cee1c1e992f47", @"/Views/ProjekatAktivnostRealizacija/PrintPreview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_ProjekatAktivnostRealizacija_PrintPreview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.VM.lista_DetaljiRealizacijaVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div id=""print_pdf""><a class=""btn btn-info"" id=""etpdf"">Export to PDF</a></div>
<script>
            $(""#etpdf"").click(function () {
                //var sHtml = $(""#forPrint"").html();
                //sHtml = sHtml.replace(/</g, ""StrTag"").replace(/>/g, ""EndTag"");
                //window.open(""../ProjekatAktivnostRealizacija/Pdf?html="" + sHtml, ""blank"");

                var t3 = document.getElementById(""forPrint"").innerHTML;

                var test = { ""html"": t3 };


                $.ajax({
                    url: ""/ProjekatAktivnostRealizacija/Pdf"",
                    type: ""POST"",
                    data: test,
                    success: function (response) {
                        window.open(""/ProjekatAktivnostRealizacija/Pdf?html="" + test.t3.innerHTML());
                    }
                });
            });
</script>

<div id=""forPrint"">
    <table class=""table"">
        <thead>
        <th>
            Realizacija ID
        </th>
");
            WriteLiteral("        <th>Aktivnost</th>\r\n        <th>Korisnik</th>\r\n        <th>Datum</th>\r\n        <th>Količnia</th>\r\n        <th>Opis</th>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 44 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
             foreach (var x in Model.lista)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 47 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
                   Write(x.idRealizacija);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                    <td>");
#nullable restore
#line 49 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
                   Write(x.NazivAktivnosti);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 50 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
                   Write(x.korisnik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 51 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
                   Write(x.datum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 52 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
                   Write(x.kolicina);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 53 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
                   Write(x.opis);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 55 "D:\New Project\WebApplication1\WebApplication1\Views\ProjekatAktivnostRealizacija\PrintPreview.cshtml"
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
